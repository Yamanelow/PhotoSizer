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
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace F.PhotoSizer {
	
	internal sealed class Program {
		
		[STAThread]
		private static void Main(string[] args) {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			try {
				Application.Run(new MainForm());
			} catch(Exception ex) {
				ReportError(ex);
			}
		}
		
		public static void ReportError(Exception ex) {
			if(MessageBox.Show("Une erreur est survenue. Envoyer un rapport d'erreur ?", "Erreur", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes) {
				Process.Start("mailto:yamanelow@pando.fr?subject=Erreur PhotoSizer&body=" + ex.Message + "%0D%0A%0D%0A" + FormatMailToArgument(ex.StackTrace));
			}
		}
		
		private static string FormatMailToArgument(string argument) {
			return argument.
				Replace("%", "%25").
				Replace("&", "%26").
				Replace(":", "%3A").
				Replace("\n", "%0A").
				Replace("\r", "%0D").
				Replace("?", "%3F").
				Replace("\"", "%22").
				Replace(" ", "%20");
		}
		
	}
	
}
