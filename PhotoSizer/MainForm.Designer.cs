#region License
//    PhotoSizer - Logiciel de redimensionnement d'images
//    Copyright (C) 2011  Yamanelow
//
//    This program is free software; you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation; either version 2 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License along
//    with this program; if not, write to the Free Software Foundation, Inc.,
//    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
#endregion

namespace F.PhotoSizer
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tbFrom = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbTo = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.cbBmp = new System.Windows.Forms.CheckBox();
			this.cbPng = new System.Windows.Forms.CheckBox();
			this.cbJpg = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.rbRatio = new System.Windows.Forms.RadioButton();
			this.rbL = new System.Windows.Forms.RadioButton();
			this.tbRatio = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbL = new System.Windows.Forms.TextBox();
			this.FBD = new System.Windows.Forms.FolderBrowserDialog();
			this.btnWork = new System.Windows.Forms.Button();
			this.tbH = new System.Windows.Forms.TextBox();
			this.rbH = new System.Windows.Forms.RadioButton();
			this.cbTiff = new System.Windows.Forms.CheckBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tssName = new System.Windows.Forms.ToolStripStatusLabel();
			this.PB = new System.Windows.Forms.ToolStripProgressBar();
			this.cbSub = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cbPref = new System.Windows.Forms.CheckBox();
			this.tbPref = new System.Windows.Forms.TextBox();
			this.tbSuf = new System.Windows.Forms.TextBox();
			this.cbSuf = new System.Windows.Forms.CheckBox();
			this.rbNo = new System.Windows.Forms.RadioButton();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbTiff = new System.Windows.Forms.RadioButton();
			this.rbPng = new System.Windows.Forms.RadioButton();
			this.rbJpg = new System.Windows.Forms.RadioButton();
			this.rbBmp = new System.Windows.Forms.RadioButton();
			this.statusStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbFrom
			// 
			this.tbFrom.Enabled = false;
			this.tbFrom.Location = new System.Drawing.Point(12, 26);
			this.tbFrom.Name = "tbFrom";
			this.tbFrom.Size = new System.Drawing.Size(403, 20);
			this.tbFrom.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(223, 14);
			this.label1.TabIndex = 2;
			this.label1.Text = "Dossier source des photos";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(223, 14);
			this.label2.TabIndex = 4;
			this.label2.Text = "Dossier de destination";
			// 
			// tbTo
			// 
			this.tbTo.Enabled = false;
			this.tbTo.Location = new System.Drawing.Point(12, 66);
			this.tbTo.Name = "tbTo";
			this.tbTo.Size = new System.Drawing.Size(403, 20);
			this.tbTo.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(421, 25);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(38, 21);
			this.button1.TabIndex = 5;
			this.button1.Text = "...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.ChooseFrom);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(421, 66);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(38, 21);
			this.button2.TabIndex = 6;
			this.button2.Text = "...";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.ChooseTo);
			// 
			// cbBmp
			// 
			this.cbBmp.Checked = true;
			this.cbBmp.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbBmp.Location = new System.Drawing.Point(12, 201);
			this.cbBmp.Name = "cbBmp";
			this.cbBmp.Size = new System.Drawing.Size(103, 18);
			this.cbBmp.TabIndex = 7;
			this.cbBmp.Text = "Bitmap (.bmp)";
			this.cbBmp.UseVisualStyleBackColor = true;
			// 
			// cbPng
			// 
			this.cbPng.Location = new System.Drawing.Point(243, 201);
			this.cbPng.Name = "cbPng";
			this.cbPng.Size = new System.Drawing.Size(103, 18);
			this.cbPng.TabIndex = 8;
			this.cbPng.Text = "PNG (.png)";
			this.cbPng.UseVisualStyleBackColor = true;
			// 
			// cbJpg
			// 
			this.cbJpg.Checked = true;
			this.cbJpg.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbJpg.Location = new System.Drawing.Point(134, 201);
			this.cbJpg.Name = "cbJpg";
			this.cbJpg.Size = new System.Drawing.Size(103, 18);
			this.cbJpg.TabIndex = 9;
			this.cbJpg.Text = "JPEG (.jpg)";
			this.cbJpg.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 184);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(223, 14);
			this.label3.TabIndex = 10;
			this.label3.Text = "Type d\'images";
			// 
			// rbRatio
			// 
			this.rbRatio.Checked = true;
			this.rbRatio.Location = new System.Drawing.Point(12, 231);
			this.rbRatio.Name = "rbRatio";
			this.rbRatio.Size = new System.Drawing.Size(100, 17);
			this.rbRatio.TabIndex = 11;
			this.rbRatio.TabStop = true;
			this.rbRatio.Text = "Ratio";
			this.rbRatio.UseVisualStyleBackColor = true;
			// 
			// rbL
			// 
			this.rbL.Location = new System.Drawing.Point(134, 231);
			this.rbL.Name = "rbL";
			this.rbL.Size = new System.Drawing.Size(84, 17);
			this.rbL.TabIndex = 12;
			this.rbL.Text = "Largeur max";
			this.rbL.UseVisualStyleBackColor = true;
			// 
			// tbRatio
			// 
			this.tbRatio.Location = new System.Drawing.Point(12, 250);
			this.tbRatio.Name = "tbRatio";
			this.tbRatio.Size = new System.Drawing.Size(82, 20);
			this.tbRatio.TabIndex = 13;
			this.tbRatio.Text = "100";
			this.tbRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(96, 253);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(12, 14);
			this.label4.TabIndex = 14;
			this.label4.Text = "%";
			// 
			// tbL
			// 
			this.tbL.Location = new System.Drawing.Point(134, 250);
			this.tbL.Name = "tbL";
			this.tbL.Size = new System.Drawing.Size(73, 20);
			this.tbL.TabIndex = 15;
			this.tbL.Text = "800";
			this.tbL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnWork
			// 
			this.btnWork.Location = new System.Drawing.Point(412, 249);
			this.btnWork.Name = "btnWork";
			this.btnWork.Size = new System.Drawing.Size(47, 21);
			this.btnWork.TabIndex = 19;
			this.btnWork.Text = "Go !";
			this.btnWork.UseVisualStyleBackColor = true;
			this.btnWork.Click += new System.EventHandler(this.Start);
			// 
			// tbH
			// 
			this.tbH.Location = new System.Drawing.Point(243, 251);
			this.tbH.Name = "tbH";
			this.tbH.Size = new System.Drawing.Size(73, 20);
			this.tbH.TabIndex = 21;
			this.tbH.Text = "600";
			this.tbH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// rbH
			// 
			this.rbH.Location = new System.Drawing.Point(243, 232);
			this.rbH.Name = "rbH";
			this.rbH.Size = new System.Drawing.Size(85, 17);
			this.rbH.TabIndex = 20;
			this.rbH.Text = "Hauteur max";
			this.rbH.UseVisualStyleBackColor = true;
			// 
			// cbTiff
			// 
			this.cbTiff.Location = new System.Drawing.Point(352, 201);
			this.cbTiff.Name = "cbTiff";
			this.cbTiff.Size = new System.Drawing.Size(103, 18);
			this.cbTiff.TabIndex = 22;
			this.cbTiff.Text = "TIFF (.tif .tiff)";
			this.cbTiff.UseVisualStyleBackColor = true;
			// 
			// statusStrip1
			// 
			this.statusStrip1.AutoSize = false;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tssName,
									this.PB});
			this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.statusStrip1.Location = new System.Drawing.Point(0, 353);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(479, 45);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 24;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// tssName
			// 
			this.tssName.Name = "tssName";
			this.tssName.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
			this.tssName.Size = new System.Drawing.Size(171, 15);
			this.tssName.Text = "Yamanelow - 2011 - Gnu GPL V2   ";
			// 
			// PB
			// 
			this.PB.Name = "PB";
			this.PB.Size = new System.Drawing.Size(465, 16);
			// 
			// cbSub
			// 
			this.cbSub.Location = new System.Drawing.Point(12, 96);
			this.cbSub.Name = "cbSub";
			this.cbSub.Size = new System.Drawing.Size(295, 23);
			this.cbSub.TabIndex = 25;
			this.cbSub.Text = "Rechercher également dans les sous-dossiers ?";
			this.cbSub.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(209, 253);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(21, 14);
			this.label5.TabIndex = 26;
			this.label5.Text = "px";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(320, 253);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(21, 14);
			this.label6.TabIndex = 27;
			this.label6.Text = "px";
			// 
			// cbPref
			// 
			this.cbPref.Location = new System.Drawing.Point(12, 125);
			this.cbPref.Name = "cbPref";
			this.cbPref.Size = new System.Drawing.Size(206, 19);
			this.cbPref.TabIndex = 28;
			this.cbPref.Text = "Ajouter un préfixe au fichier de sortie";
			this.cbPref.UseVisualStyleBackColor = true;
			this.cbPref.CheckedChanged += new System.EventHandler(this.CbPrefCheckedChanged);
			// 
			// tbPref
			// 
			this.tbPref.Enabled = false;
			this.tbPref.Location = new System.Drawing.Point(12, 150);
			this.tbPref.Name = "tbPref";
			this.tbPref.Size = new System.Drawing.Size(193, 20);
			this.tbPref.TabIndex = 29;
			// 
			// tbSuf
			// 
			this.tbSuf.Enabled = false;
			this.tbSuf.Location = new System.Drawing.Point(260, 150);
			this.tbSuf.Name = "tbSuf";
			this.tbSuf.Size = new System.Drawing.Size(195, 20);
			this.tbSuf.TabIndex = 31;
			// 
			// cbSuf
			// 
			this.cbSuf.Location = new System.Drawing.Point(260, 125);
			this.cbSuf.Name = "cbSuf";
			this.cbSuf.Size = new System.Drawing.Size(206, 19);
			this.cbSuf.TabIndex = 30;
			this.cbSuf.Text = "Ajouter un suffixe au fichier de sortie";
			this.cbSuf.UseVisualStyleBackColor = true;
			this.cbSuf.CheckedChanged += new System.EventHandler(this.CbSufCheckedChanged);
			// 
			// rbNo
			// 
			this.rbNo.Checked = true;
			this.rbNo.Location = new System.Drawing.Point(12, 33);
			this.rbNo.Name = "rbNo";
			this.rbNo.Size = new System.Drawing.Size(83, 20);
			this.rbNo.TabIndex = 32;
			this.rbNo.TabStop = true;
			this.rbNo.Text = "Non";
			this.rbNo.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(12, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(223, 14);
			this.label7.TabIndex = 33;
			this.label7.Text = "Forcer la sortie";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbTiff);
			this.groupBox1.Controls.Add(this.rbPng);
			this.groupBox1.Controls.Add(this.rbJpg);
			this.groupBox1.Controls.Add(this.rbBmp);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.rbNo);
			this.groupBox1.Location = new System.Drawing.Point(1, 277);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(478, 64);
			this.groupBox1.TabIndex = 34;
			this.groupBox1.TabStop = false;
			// 
			// rbTiff
			// 
			this.rbTiff.Location = new System.Drawing.Point(368, 33);
			this.rbTiff.Name = "rbTiff";
			this.rbTiff.Size = new System.Drawing.Size(83, 20);
			this.rbTiff.TabIndex = 37;
			this.rbTiff.Text = "TIFF";
			this.rbTiff.UseVisualStyleBackColor = true;
			// 
			// rbPng
			// 
			this.rbPng.Location = new System.Drawing.Point(279, 33);
			this.rbPng.Name = "rbPng";
			this.rbPng.Size = new System.Drawing.Size(83, 20);
			this.rbPng.TabIndex = 36;
			this.rbPng.Text = "PNG";
			this.rbPng.UseVisualStyleBackColor = true;
			// 
			// rbJpg
			// 
			this.rbJpg.Location = new System.Drawing.Point(190, 33);
			this.rbJpg.Name = "rbJpg";
			this.rbJpg.Size = new System.Drawing.Size(83, 20);
			this.rbJpg.TabIndex = 35;
			this.rbJpg.Text = "JPEG";
			this.rbJpg.UseVisualStyleBackColor = true;
			// 
			// rbBmp
			// 
			this.rbBmp.Location = new System.Drawing.Point(101, 33);
			this.rbBmp.Name = "rbBmp";
			this.rbBmp.Size = new System.Drawing.Size(83, 20);
			this.rbBmp.TabIndex = 34;
			this.rbBmp.Text = "Bitmap";
			this.rbBmp.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(479, 398);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.tbSuf);
			this.Controls.Add(this.cbSuf);
			this.Controls.Add(this.tbPref);
			this.Controls.Add(this.cbPref);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cbSub);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.cbTiff);
			this.Controls.Add(this.tbH);
			this.Controls.Add(this.rbH);
			this.Controls.Add(this.btnWork);
			this.Controls.Add(this.tbL);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbRatio);
			this.Controls.Add(this.rbL);
			this.Controls.Add(this.rbRatio);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cbJpg);
			this.Controls.Add(this.cbPng);
			this.Controls.Add(this.cbBmp);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbTo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbFrom);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(487, 308);
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "PhotoSizer";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.RadioButton rbBmp;
		private System.Windows.Forms.RadioButton rbJpg;
		private System.Windows.Forms.RadioButton rbPng;
		private System.Windows.Forms.RadioButton rbTiff;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.RadioButton rbNo;
		private System.Windows.Forms.CheckBox cbSuf;
		private System.Windows.Forms.TextBox tbSuf;
		private System.Windows.Forms.TextBox tbPref;
		private System.Windows.Forms.CheckBox cbPref;
		private System.Windows.Forms.ToolStripStatusLabel tssName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox cbSub;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.CheckBox cbTiff;
		private System.Windows.Forms.RadioButton rbL;
		private System.Windows.Forms.RadioButton rbH;
		private System.Windows.Forms.Button btnWork;
		private System.Windows.Forms.FolderBrowserDialog FBD;
		private System.Windows.Forms.CheckBox cbJpg;
		private System.Windows.Forms.CheckBox cbPng;
		private System.Windows.Forms.CheckBox cbBmp;
		private System.Windows.Forms.ToolStripProgressBar PB;
		private System.Windows.Forms.TextBox tbH;
		private System.Windows.Forms.TextBox tbL;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbRatio;
		private System.Windows.Forms.RadioButton rbRatio;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox tbTo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbFrom;
	}
}
