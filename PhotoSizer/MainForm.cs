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

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace F.PhotoSizer {
	
	public partial class MainForm : Form {
		
		public MainForm() {
			InitializeComponent();
		}
		
		private void ChooseFrom(object sender, EventArgs e) {
			if(FBD.ShowDialog() == DialogResult.OK)
				tbFrom.Text = FBD.SelectedPath;
		}
		
		private void ChooseTo(object sender, EventArgs e) {
			if(FBD.ShowDialog() == DialogResult.OK)
				tbTo.Text = FBD.SelectedPath;
		}
		
		private Thread t = null;
		private int pr = 1;
		private int lg = 1;
		private int ht = 1;
		
		private void Start(object sender, EventArgs e) {
			try {
				if(t == null) {
					// Vérifications
					foreach(char c in Path.GetInvalidPathChars()) {
						if(cbSuf.Checked && tbSuf.Text.Contains(c.ToString())) {
							MessageBox.Show("Le suffixe contient des caracères invalides !");
							return;
						}
						if(cbPref.Checked && tbPref.Text.Contains(c.ToString())) {
							MessageBox.Show("Le préfixe contient des caracères invalides !");
							return;
						}
					}
					if(tbTo.Text.Equals(tbFrom.Text, StringComparison.CurrentCultureIgnoreCase)) {
						MessageBox.Show("Les dossiers source et destination sont identiques.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					if(!Directory.Exists(tbFrom.Text)) {
						MessageBox.Show("Le dossier source est introuvable.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					if(!Directory.Exists(tbTo.Text)) {
						if(MessageBox.Show("Le dossier de destination n'éxiste pas, le créer ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
							return;
						try {
							Directory.CreateDirectory(tbTo.Text);
						} catch {
							MessageBox.Show("Impossible de créer un répertoire à cet emplacement !");
							return;
						}
					}
					if(!cbBmp.Checked && !cbPng.Checked && !cbJpg.Checked && !cbTiff.Checked) {
						MessageBox.Show("Choisissez au moins un type d'image ...");
						return;
					}
					if(rbRatio.Checked) {
						if(!int.TryParse(tbRatio.Text, out pr)) {
							MessageBox.Show("Le % doit être un nombre entier !");
							return;
						}
					} else if(rbL.Checked) {
						if(!int.TryParse(tbL.Text, out lg)) {
							MessageBox.Show("Les dimensions doivent être des nombres entiers !");
							return;
						}
					} else if(rbH.Checked) {
						if(!int.TryParse(tbH.Text, out ht)) {
							MessageBox.Show("Les dimensions doivent être des nombres entiers !");
							return;
						}
					}
					// Lancement
					PB.Value = 0;
					btnWork.Text = "Stop !";
					t = new Thread(new ThreadStart(Work));
					t.IsBackground = true;
					t.Start();
				} else {
					if(t.ThreadState != ThreadState.Running) {
						MessageBox.Show("Déjà terminé !");
						return;
					}
					t.Abort();
					MessageBox.Show("Redimensionnement arrêté !");
					Reset();
				}
			} catch(Exception ex) {
				Program.ReportError(ex);
			}
		}
		
		private void PBinit(int val) {
			PB.Maximum = val;
		}
		
		private void PBinc() {
			PB.Value++;
		}
		
		private void Reset() {
			btnWork.Text = "Go !";
			tssName.Text = "Yamanelow - 2011 - Gnu GPL V2";
			PB.Value = 0;
			t = null;
		}
		
		private void CreateSubdirRecursive(string src, string dest) {
			foreach(string d in Directory.GetDirectories(src)) {
				string nw = d.Replace(src, dest);
				if(Directory.Exists(nw))
					continue;
				Directory.CreateDirectory(nw);
				CreateSubdirRecursive(d, nw);
			}
		}
		
		private void Work() {
			try {
				// Recherche
				List<string> files = new List<string>();
				if(cbJpg.Checked)
					files.AddRange(Directory.GetFiles(tbFrom.Text, "*.jpg", cbSub.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly));
				if(cbBmp.Checked)
					files.AddRange(Directory.GetFiles(tbFrom.Text, "*.bmp", cbSub.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly));
				if(cbPng.Checked)
					files.AddRange(Directory.GetFiles(tbFrom.Text, "*.png", cbSub.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly));
				if(cbTiff.Checked)
					files.AddRange(Directory.GetFiles(tbFrom.Text, "*.tiff", cbSub.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly));
				if(cbTiff.Checked)
					files.AddRange(Directory.GetFiles(tbFrom.Text, "*.tif", cbSub.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly));
				this.Invoke(new Action<int>(PBinit), new object[] {files.Count});
				// Subdir
				if(cbSub.Checked) {
					CreateSubdirRecursive(tbFrom.Text, tbTo.Text);
				}
				
				// Travail
				foreach(string file in files) {
					// Fichier déjà éxistant
					tssName.Text = file;
					string ext;
					if(rbBmp.Checked)
						ext = ".bmp";
					else if(rbJpg.Checked)
						ext = ".jpg";
					else if(rbPng.Checked)
						ext = ".png";
					else if(rbTiff.Checked)
						ext = ".tiff";
					else
						ext = Path.GetExtension(file);
					
					string fout = Path.Combine(tbTo.Text,
					                           (cbPref.Checked ? tbPref.Text : string.Empty) + Path.GetFileNameWithoutExtension(file) +
					                           (cbSuf.Checked ? tbSuf.Text + ext : ext)
					                          );
					// Ajout préfixe/suffixe
//					if(cbPref.Checked)
//						fout = tbPref.Text +
					
					if(File.Exists(fout)) {
						switch(MessageBox.Show("Le fichier de destination éxiste déjà, le remplacer ?", "Alerte", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)) {
							case DialogResult.No:
								continue;
							case DialogResult.Cancel:
								this.Invoke(new Action(Reset));
								return;
						}
					}
					
					// Calcul ratio selon choix
					float ratio = 1F;
					Image img = Image.FromFile(file);
					
					if(rbRatio.Checked) {
						ratio = (float) pr / 100;
					} else if(rbL.Checked) {
						int s = img.Width > img.Height ? img.Width : img.Height;
						ratio = (float) lg / s;
					} else if(rbH.Checked) {
						int s = img.Width > img.Height ? img.Height : img.Width;
						ratio = (float) ht / s;
					}
					
					Bitmap bmp = null;
					Graphics g = null;
					if(ratio == 1) {
						bmp = (Bitmap)Bitmap.FromFile(file);
					} else {
						
						// Redimensionnement
						int sW = img.Width;
						int sH = img.Height;
						int dW = (int)(sW * ratio);
						int dH = (int)(sH * ratio);
						
						bmp = new Bitmap(dW, dH, PixelFormat.Format24bppRgb);
						bmp.SetResolution(img.HorizontalResolution, img.VerticalResolution);
						
						g = Graphics.FromImage(bmp);
						g.InterpolationMode = InterpolationMode.HighQualityBicubic;
						g.DrawImage(img, new Rectangle(0, 0, dW, dH), new Rectangle(0, 0, sW, sH), GraphicsUnit.Pixel);
					}
					
					
					// Sauvegarde
					if(!Directory.Exists(Path.GetDirectoryName(file)))
						Directory.CreateDirectory(Path.GetDirectoryName(file));
					if(rbNo.Checked) {
						if(file.EndsWith(".jpg", StringComparison.CurrentCultureIgnoreCase))
							bmp.Save(fout, ImageFormat.Jpeg);
						if(file.EndsWith(".bmp", StringComparison.CurrentCultureIgnoreCase))
							bmp.Save(fout, ImageFormat.Bmp);
						if(file.EndsWith(".png", StringComparison.CurrentCultureIgnoreCase))
							bmp.Save(fout, ImageFormat.Png);
						if(file.EndsWith(".tiff", StringComparison.CurrentCultureIgnoreCase))
							bmp.Save(fout, ImageFormat.Tiff);
						if(file.EndsWith(".tif", StringComparison.CurrentCultureIgnoreCase))
							bmp.Save(fout, ImageFormat.Tiff);
					} else {
						if(rbBmp.Checked)
							bmp.Save(fout, ImageFormat.Bmp);
						else if(rbJpg.Checked)
							bmp.Save(fout, ImageFormat.Jpeg);
						else if(rbPng.Checked)
							bmp.Save(fout, ImageFormat.Png);
						else if(rbTiff.Checked)
							bmp.Save(fout, ImageFormat.Tiff);
					}
					if(g != null)
						g.Dispose();
					if(bmp != null)
						bmp.Dispose();
					img.Dispose();
					this.Invoke(new Action(PBinc));
				}
			} catch(Exception ex) {
				Program.ReportError(ex);
			}
			
			// Fin du thread
			MessageBox.Show("Opération terminée\r\nNombre de photos redimensionnées : " + PB.Value);
			this.Invoke(new Action(Reset));
		}
		
		private void CbPrefCheckedChanged(object sender, EventArgs e) {
			if(cbPref.Checked)
				tbPref.Enabled = true;
			else
				tbPref.Enabled = false;
		}
		
		private void CbSufCheckedChanged(object sender, EventArgs e) {
			if(cbSuf.Checked)
				tbSuf.Enabled = true;
			else
				tbSuf.Enabled = false;
		}
		
	}
	
}
