// This is the main DLL file.

#include "stdafx.h"

#include "TEMControlWrapper.h"

namespace TEMControlWrapper
{
	//CLI wrapper for controlling TEM microscope

	// Microscope class constructor
	TEMControlWrapper::Microscope::Microscope()
	{
		HRESULT hr0 = CoInitializeEx(NULL, COINIT_APARTMENTTHREADED | COINIT_DISABLE_OLE1DDE);
		if (SUCCEEDED(hr0)){
			MessageBox(NULL, L"TEM connection initialized!", L"Status", MB_OK);
		}
		else
		{
			if (hr0 != RPC_E_CHANGED_MODE)
			{
				_com_error error(hr0);
				MessageBox(NULL, error.ErrorMessage(), L"Error", MB_OK);
			}
		}
		
		ThisInstrumentPtr = new TEMScripting::InstrumentInterfacePtr;
		HRESULT hr = ThisInstrumentPtr->CreateInstance(_T("TEMScripting.Instrument.1"));
		if (FAILED(hr)) {
			_com_error error(hr);
			MessageBox(NULL, error.ErrorMessage(), L"Error", MB_OK);
		}
	}

	TEMControlWrapper::Microscope::~Microscope()
	{
		if (ThisInstrumentPtr != nullptr)
		{
			delete ThisInstrumentPtr;
			ThisInstrumentPtr = nullptr;
		}
	}

	TEMControlWrapper::Microscope::!Microscope()
	{
		if (ThisInstrumentPtr != nullptr)
		{
			delete ThisInstrumentPtr;
			ThisInstrumentPtr = nullptr;
		}
	}

	double TEMControlWrapper::Microscope::GetHT()
	{
		double ThisHT;
		TEMScripting::InstrumentInterfacePtr ThisInstrument = *ThisInstrumentPtr;
		TEMScripting::GunPtr ThisGun;
		ThisGun = ThisInstrument->GetGun();
		ThisHT = ThisGun->GetHTValue();
		return ThisHT;
	}

	double TEMControlWrapper::Microscope::GetX()
	{
		double StageX;
		TEMScripting::InstrumentInterfacePtr ThisInstrument = *ThisInstrumentPtr;
		TEMScripting::StagePtr ThisStage = ThisInstrument->Stage;
		StageX = ThisStage->Position->X;
		return StageX;
	}

	// Read current magnification from the microscope
	double TEMControlWrapper::Microscope::GetMag()
	{
		double ThisMag;
		TEMScripting::InstrumentInterfacePtr ThisInstrument = *ThisInstrumentPtr;
		TEMScripting::IlluminationPtr ThisIllumination;
		ThisIllumination = ThisInstrument->GetIllumination();
		ThisMag = ThisIllumination->GetStemMagnification();
		return ThisMag;
	}

	void TEMControlWrapper::Microscope::SetMag(double nMag)
	{
		TEMScripting::InstrumentInterfacePtr ThisInstrument = *ThisInstrumentPtr;
		TEMScripting::IlluminationPtr ThisIllumination;
		ThisIllumination = ThisInstrument->GetIllumination();
		ThisIllumination->StemMagnification = nMag;
	}

	// Switch the status of beam blank
	void TEMControlWrapper::Microscope::SwitchBeamBlank(bool BlankAction)
	{
		TEMScripting::InstrumentInterfacePtr ThisInstrument = *ThisInstrumentPtr;
		TEMScripting::IlluminationPtr ThisIllumination;
		ThisIllumination = ThisInstrument->GetIllumination();
		bool blanked = ThisIllumination->BeamBlanked;
		if (blanked != BlankAction)
		{
			ThisIllumination->BeamBlanked = !blanked;
		}
	}

	// Perform image shift for sample drift correction
	void TEMControlWrapper::Microscope::DoImgSft(double dx, double dy)
	{
		TEMScripting::InstrumentInterfacePtr ThisInstrument = *ThisInstrumentPtr;
		TEMScripting::ProjectionPtr ThisProjection;
		ThisProjection = ThisInstrument->GetProjection();

		TEMScripting::VectorPtr ImgSft;
		ImgSft = ThisProjection->GetImageBeamShift();
		ImgSft->X += dx;
		ImgSft->Y += dy;
		ThisProjection->ImageBeamShift = ImgSft;
	}

	void TEMControlWrapper::Microscope::SaveStatus(System::String^ fp)
	{
		const char* savepath;
		savepath = TEMControlWrapper::string_to_char_array(fp);

		double HT;
		long SS;
		double Convergence;
		double Mag;
		double CL;
		double DF;
		double CondStig[2];
		double ObjStig[2];
		double DiffStig[2];
		double BeamSft[2];
		double BeamTlt[2];
		double DiffSft[2];
		double ImgSft[2];
		double Rot;
		double ObjLens;
		double Stg[5];


		TEMScripting::InstrumentInterfacePtr ThisInstrument = *ThisInstrumentPtr;
		TEMScripting::GunPtr ThisGun;
		ThisGun = ThisInstrument->GetGun();
		TEMScripting::IlluminationPtr ThisIllumination;
		ThisIllumination = ThisInstrument->GetIllumination();
		TEMScripting::ProjectionPtr ThisProjection;
		ThisProjection = ThisInstrument->GetProjection();
		TEMScripting::StagePtr ThisStage;
		ThisStage = ThisInstrument->GetStage();

		HT = ThisGun->HTValue;
		SS = ThisIllumination->SpotsizeIndex;
		Convergence = ThisIllumination->ConvergenceAngle;
		Mag = ThisIllumination->StemMagnification;
		CL = ThisProjection->CameraLength;
		DF = ThisProjection->Defocus;
		CondStig[0] = ThisIllumination->CondenserStigmator->X;
		CondStig[1] = ThisIllumination->CondenserStigmator->Y;
		ObjStig[0] = ThisProjection->ObjectiveStigmator->X;
		ObjStig[1] = ThisProjection->ObjectiveStigmator->Y;
		DiffStig[0] = ThisProjection->DiffractionStigmator->X;
		DiffStig[1] = ThisProjection->DiffractionStigmator->Y;
		BeamSft[0] = ThisIllumination->Shift->X;
		BeamSft[1] = ThisIllumination->Shift->Y;
		BeamTlt[0] = ThisIllumination->Tilt->X;
		BeamTlt[1] = ThisIllumination->Tilt->Y;
		DiffSft[0] = ThisProjection->DiffractionShift->X;
		DiffSft[1] = ThisProjection->DiffractionShift->Y;
		ImgSft[0] = ThisProjection->ImageShift->X;
		ImgSft[1] = ThisProjection->ImageShift->Y;
		Rot = ThisIllumination->StemRotation;
		ObjLens = ThisProjection->ObjectiveExcitation;
		Stg[0] = ThisStage->Position->X;
		Stg[1] = ThisStage->Position->Y;
		Stg[2] = ThisStage->Position->Z;
		Stg[3] = ThisStage->Position->A;
		Stg[4] = ThisStage->Position->B;


		ofstream statusfile(savepath);
		statusfile << "STEM Parameters" << endl;
		statusfile << "====================" << endl;
		statusfile << "HT Value (V)\t\t" << HT << endl;
		statusfile << "Spot Size\t\t" << SS << endl;
		statusfile << "Convergence Angle (rad)\t" << Convergence << endl;
		statusfile << "Magnification\t\t" << Mag << endl;
		statusfile << "Camera Length (m)\t\t" << CL << endl;
		statusfile << "Defocus (m)\t\t" << DF << endl;
		statusfile << "\n";
		statusfile << "Other Parameters" << endl;
		statusfile << "====================" << endl;
		statusfile << "Condenser Stigmator X \t" << CondStig[0] << endl;
		statusfile << "Condenser Stigmator Y \t" << CondStig[1] << endl;
		statusfile << "Objective Stigmator X \t" << ObjStig[0] << endl;
		statusfile << "Objective Stigmator Y \t" << ObjStig[1] << endl;
		statusfile << "Diffraction Stigmator X \t" << DiffStig[0] << endl;
		statusfile << "Diffraction Stigmator Y \t" << DiffStig[1] << endl;
		statusfile << "Beam Shift X (m)\t\t" << BeamSft[0] << endl;
		statusfile << "Beam Shift Y (m)\t\t" << BeamSft[1] << endl;
		statusfile << "Beam Tilt X (m)\t\t" << BeamTlt[0] << endl;
		statusfile << "Beam Tilt Y (m)\t\t" << BeamTlt[1] << endl;
		statusfile << "Image Shift X (m)\t\t" << ImgSft[0] << endl;
		statusfile << "Image Shift Y (m)\t\t" << ImgSft[1] << endl;
		statusfile << "Diffraction Shift X (m)\t" << DiffSft[0] << endl;
		statusfile << "Diffraction Shift Y (m)\t" << DiffSft[1] << endl;
		statusfile << "STEM Rotation (rad)\t" << Rot << endl;
		statusfile << "Obejective Lens\t\t" << ObjLens << endl;
		statusfile << "Stage X (m)\t\t" << Stg[0] << endl;
		statusfile << "Stage Y (m)\t\t" << Stg[1] << endl;
		statusfile << "Stage Z (m)\t\t" << Stg[2] << endl;
		statusfile << "Stage Alpha (rad)\t\t" << Stg[3] << endl;
		statusfile << "Stage Beta (rad)\t\t" << Stg[4] << endl;
		statusfile.close();
	}

}

