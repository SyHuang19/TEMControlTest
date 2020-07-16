using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using TEMControlWrapper;

namespace TEMControlTest
{
    public partial class Form1 : Form
    {
        private TEMControlWrapper.Microscope TEM;

        public Form1()
        {
            InitializeComponent();
            RemotingConfiguration.Configure(@"..\..\Client.config", false);
            MessageBox.Show("Server connection success");
        }

        private void InitConn_Click(object sender, EventArgs e)
        {
            TEM = new TEMControlWrapper.Microscope();
            double HT;
            double Mag;
            HT = TEM.GetHT();
            Mag = TEM.GetMag();

            ConnStat.Text = "Initializing TEM ... Magnification is " + Mag.ToString() + "x; HT is " + HT.ToString() + " V";
        }

        private void ConnStat_Click(object sender, EventArgs e)
        {

        }

        private void GetStage_Click(object sender, EventArgs e)
        {
            double xPos;
            xPos = TEM.GetX();
            xPos *= 1E6;

            stagex.Text = xPos.ToString();
        }

        private void SftImg_Click(object sender, EventArgs e)
        {
            double sftX = Convert.ToDouble(ImgSftx.Text);
            double sftY = Convert.ToDouble(ImgSfty.Text);
            sftX *= 1E-6;
            sftY *= 1E-6;
            TEM.DoImgSft(sftX, sftY);
        }

        private void SetNewMag_Click(object sender, EventArgs e)
        {
            double n_Mag = Convert.ToDouble(NewMag.Text);
            TEM.SetMag(n_Mag);
        }

        private void BmBlk_CheckedChanged(object sender, EventArgs e)
        {
            bool blanked = BmBlk.Checked;
            TEM.SwitchBeamBlank(blanked);
            switch (blanked)
            {
                case true:
                    ConnStat.Text = "Blanking beam";
                    break;
                case false:
                    ConnStat.Text = "Unblanking beam";
                    break;
            }
        }

        private void StatSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog StatSaveDlg = new SaveFileDialog();
            StatSaveDlg.Filter = "Text File|*.txt";
            StatSaveDlg.Title = "Save status file";
            StatSaveDlg.ShowDialog();

            string sfile = StatSaveDlg.FileName;
            TEM.SaveStatus(sfile);
        }

    }
}
