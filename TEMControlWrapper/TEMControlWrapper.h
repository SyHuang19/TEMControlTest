// TEMControlWrapper.h

#pragma once
#include <msclr/marshal.h>
#include <tchar.h>
#include <iostream>
#include <fstream>
using namespace std;
//using namespace System;
using namespace System::Runtime::InteropServices;

#import "StdScript.dll" named_guids
using namespace TEMScripting;

namespace TEMControlWrapper
{
	public ref class Microscope : System::MarshalByRefObject
	{
		TEMScripting::InstrumentInterfacePtr* ThisInstrumentPtr;

	public:
		Microscope();
		~Microscope();
		!Microscope();

		double GetHT();

		double GetX();
		
		double GetMag();

		double GetDefocus();

		void SetDefocus(double df);

		void SetMag(double nMag);

		void SwitchBeamBlank(bool BlankAction);

		void DoImgSft(double dx, double dy);

		void SaveStatus(System::String^ fp);
	};

	static const char* string_to_char_array(System::String^ string)
	{
		const char* str = (const char*)(Marshal::StringToHGlobalAnsi(string)).ToPointer();
		return str;
	}
}

