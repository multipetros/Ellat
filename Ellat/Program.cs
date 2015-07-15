/*
 * ellat project, Program entry point
 * Copyright (C) 2014, Petros Kyladitis
 * 
 * This program is free software distributed under the FreeBSD License,
 * for license details see at 'license.txt' file, distributed with
 * this project, or see at <http://www.multipetros.gr/freebsd-license/>.
 */
 
using System;
using System.Windows.Forms;

namespace Ellat{
	internal sealed class Program{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args){
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}