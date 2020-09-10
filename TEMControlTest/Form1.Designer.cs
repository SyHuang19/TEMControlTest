namespace TEMControlTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.InitConn = new System.Windows.Forms.Button();
			this.ConnStat = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.GetStage = new System.Windows.Forms.Button();
			this.stagex = new System.Windows.Forms.Label();
			this.stagey = new System.Windows.Forms.Label();
			this.stagez = new System.Windows.Forms.Label();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.SftImg = new System.Windows.Forms.Button();
			this.ImgSftx = new System.Windows.Forms.TextBox();
			this.ImgSfty = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.SetNewMag = new System.Windows.Forms.Button();
			this.NewMag = new System.Windows.Forms.TextBox();
			this.BmBlk = new System.Windows.Forms.CheckBox();
			this.StatSave = new System.Windows.Forms.Button();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.defocus = new System.Windows.Forms.TextBox();
			this.GetDef = new System.Windows.Forms.Button();
			this.SetDef = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.67864F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.32136F));
			this.tableLayoutPanel1.Controls.Add(this.InitConn, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.ConnStat, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 2);
			this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 193F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(529, 373);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// InitConn
			// 
			this.InitConn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.InitConn.Location = new System.Drawing.Point(3, 3);
			this.InitConn.Name = "InitConn";
			this.InitConn.Size = new System.Drawing.Size(150, 22);
			this.InitConn.TabIndex = 0;
			this.InitConn.Text = "Connect TEM";
			this.InitConn.UseVisualStyleBackColor = true;
			this.InitConn.Click += new System.EventHandler(this.InitConn_Click);
			// 
			// ConnStat
			// 
			this.ConnStat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ConnStat.Location = new System.Drawing.Point(160, 3);
			this.ConnStat.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.ConnStat.Name = "ConnStat";
			this.ConnStat.Size = new System.Drawing.Size(366, 21);
			this.ConnStat.TabIndex = 1;
			this.ConnStat.Click += new System.EventHandler(this.ConnStat_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.03278F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.96721F));
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.GetStage, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.stagex, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.stagey, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.stagez, 0, 3);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(160, 63);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 4;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(366, 113);
			this.tableLayoutPanel2.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Margin = new System.Windows.Forms.Padding(3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(242, 22);
			this.label1.TabIndex = 1;
			this.label1.Text = "Position";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// GetStage
			// 
			this.GetStage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GetStage.Location = new System.Drawing.Point(252, 61);
			this.GetStage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
			this.GetStage.Name = "GetStage";
			this.GetStage.Size = new System.Drawing.Size(111, 20);
			this.GetStage.TabIndex = 0;
			this.GetStage.Text = "Get Stage";
			this.GetStage.UseVisualStyleBackColor = true;
			this.GetStage.Click += new System.EventHandler(this.GetStage_Click);
			// 
			// stagex
			// 
			this.stagex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.stagex.Location = new System.Drawing.Point(3, 31);
			this.stagex.Margin = new System.Windows.Forms.Padding(3);
			this.stagex.Name = "stagex";
			this.stagex.Size = new System.Drawing.Size(242, 22);
			this.stagex.TabIndex = 2;
			// 
			// stagey
			// 
			this.stagey.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.stagey.Location = new System.Drawing.Point(3, 59);
			this.stagey.Margin = new System.Windows.Forms.Padding(3);
			this.stagey.Name = "stagey";
			this.stagey.Size = new System.Drawing.Size(242, 22);
			this.stagey.TabIndex = 2;
			// 
			// stagez
			// 
			this.stagez.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.stagez.Location = new System.Drawing.Point(3, 87);
			this.stagez.Margin = new System.Windows.Forms.Padding(3);
			this.stagez.Name = "stagez";
			this.stagez.Size = new System.Drawing.Size(242, 22);
			this.stagez.TabIndex = 2;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.SftImg, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.ImgSftx, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.ImgSfty, 0, 2);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(160, 182);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 3;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(203, 113);
			this.tableLayoutPanel3.TabIndex = 3;
			// 
			// SftImg
			// 
			this.SftImg.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.SftImg.Location = new System.Drawing.Point(3, 9);
			this.SftImg.Name = "SftImg";
			this.SftImg.Size = new System.Drawing.Size(197, 25);
			this.SftImg.TabIndex = 0;
			this.SftImg.Text = "Image Shift (um)";
			this.SftImg.UseVisualStyleBackColor = true;
			this.SftImg.Click += new System.EventHandler(this.SftImg_Click);
			// 
			// ImgSftx
			// 
			this.ImgSftx.Location = new System.Drawing.Point(8, 40);
			this.ImgSftx.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
			this.ImgSftx.Name = "ImgSftx";
			this.ImgSftx.Size = new System.Drawing.Size(187, 22);
			this.ImgSftx.TabIndex = 1;
			// 
			// ImgSfty
			// 
			this.ImgSfty.Location = new System.Drawing.Point(8, 77);
			this.ImgSfty.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
			this.ImgSfty.Name = "ImgSfty";
			this.ImgSfty.Size = new System.Drawing.Size(187, 22);
			this.ImgSfty.TabIndex = 1;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.Controls.Add(this.SetNewMag, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.NewMag, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.BmBlk, 0, 2);
			this.tableLayoutPanel4.Controls.Add(this.StatSave, 0, 3);
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 36);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 4;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(151, 140);
			this.tableLayoutPanel4.TabIndex = 4;
			// 
			// SetNewMag
			// 
			this.SetNewMag.Location = new System.Drawing.Point(3, 3);
			this.SetNewMag.Name = "SetNewMag";
			this.SetNewMag.Size = new System.Drawing.Size(145, 24);
			this.SetNewMag.TabIndex = 0;
			this.SetNewMag.Text = "Set Magnification";
			this.SetNewMag.UseVisualStyleBackColor = true;
			this.SetNewMag.Click += new System.EventHandler(this.SetNewMag_Click);
			// 
			// NewMag
			// 
			this.NewMag.Location = new System.Drawing.Point(3, 34);
			this.NewMag.Name = "NewMag";
			this.NewMag.Size = new System.Drawing.Size(145, 22);
			this.NewMag.TabIndex = 1;
			// 
			// BmBlk
			// 
			this.BmBlk.Appearance = System.Windows.Forms.Appearance.Button;
			this.BmBlk.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.BmBlk.Location = new System.Drawing.Point(3, 74);
			this.BmBlk.Name = "BmBlk";
			this.BmBlk.Size = new System.Drawing.Size(145, 28);
			this.BmBlk.TabIndex = 2;
			this.BmBlk.Text = "Beam Blanked";
			this.BmBlk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.BmBlk.UseVisualStyleBackColor = true;
			this.BmBlk.CheckedChanged += new System.EventHandler(this.BmBlk_CheckedChanged);
			// 
			// StatSave
			// 
			this.StatSave.Location = new System.Drawing.Point(3, 110);
			this.StatSave.Name = "StatSave";
			this.StatSave.Size = new System.Drawing.Size(145, 27);
			this.StatSave.TabIndex = 3;
			this.StatSave.Text = "Save Status";
			this.StatSave.UseVisualStyleBackColor = true;
			this.StatSave.Click += new System.EventHandler(this.StatSave_Click);
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.ColumnCount = 1;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.Controls.Add(this.defocus, 0, 0);
			this.tableLayoutPanel5.Controls.Add(this.GetDef, 0, 1);
			this.tableLayoutPanel5.Controls.Add(this.SetDef, 0, 2);
			this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 182);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 3;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.25F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.75F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(149, 125);
			this.tableLayoutPanel5.TabIndex = 5;
			// 
			// defocus
			// 
			this.defocus.Location = new System.Drawing.Point(3, 3);
			this.defocus.Name = "defocus";
			this.defocus.Size = new System.Drawing.Size(143, 22);
			this.defocus.TabIndex = 0;
			// 
			// GetDef
			// 
			this.GetDef.Location = new System.Drawing.Point(3, 37);
			this.GetDef.Name = "GetDef";
			this.GetDef.Size = new System.Drawing.Size(143, 33);
			this.GetDef.TabIndex = 1;
			this.GetDef.Text = "Get Defocus";
			this.GetDef.UseVisualStyleBackColor = true;
			this.GetDef.Click += new System.EventHandler(this.GetDef_Click);
			// 
			// SetDef
			// 
			this.SetDef.Location = new System.Drawing.Point(3, 76);
			this.SetDef.Name = "SetDef";
			this.SetDef.Size = new System.Drawing.Size(143, 33);
			this.SetDef.TabIndex = 2;
			this.SetDef.Text = "Set Defocus";
			this.SetDef.UseVisualStyleBackColor = true;
			this.SetDef.Click += new System.EventHandler(this.SetDef_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 380);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel5.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button InitConn;
        private System.Windows.Forms.Label ConnStat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button GetStage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label stagex;
        private System.Windows.Forms.Label stagey;
        private System.Windows.Forms.Label stagez;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button SftImg;
        private System.Windows.Forms.TextBox ImgSftx;
        private System.Windows.Forms.TextBox ImgSfty;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button SetNewMag;
        private System.Windows.Forms.TextBox NewMag;
        private System.Windows.Forms.CheckBox BmBlk;
        private System.Windows.Forms.Button StatSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox defocus;
        private System.Windows.Forms.Button GetDef;
        private System.Windows.Forms.Button SetDef;
    }
}

