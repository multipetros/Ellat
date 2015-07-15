/*
 * ellat project, main form class
 * Copyright (C) 2014, Petros Kyladitis
 *
 * This program is free software distributed under the FreeBSD License,
 * for license details see at 'license.txt' file, distributed with
 * this project, or see at <http://www.multipetros.gr/freebsd-license/>.
 */
 
using System ;
using System.Collections.Generic ;
using System.Drawing ;
using System.Windows.Forms ;
using System.IO ;
using Multipetros.Text ;
using Multipetros.Utils ;

namespace Ellat{
	public partial class MainForm : Form{
		public MainForm(){
			InitializeComponent() ;
		}
		
		private ElStr el2lat = new ElStr() ;
		private FileInfo[] fileList ;
		private RegistrySettings settings = new RegistrySettings(Application.CompanyName, Application.ProductName) ;
		
		//constant string representing registry setting key names
		private readonly string WND_TOP = "top" ;
		private readonly string WND_LEFT = "left" ;
		private readonly string WND_WIDTH = "width" ;
		private readonly string WND_HEIGHT = "height" ;
		private readonly string WND_FONT = "font" ;
		
		//Load settings from the registry and aply them to main window,
		//such as last position, dimensions and font family & size
		private void LoadLastPos(){
			int top  ;
			int left  ;
			int height  ;
			int width  ;
			
			int.TryParse(settings.GetSetting(WND_TOP), out top) ;
			int.TryParse(settings.GetSetting(WND_LEFT), out left) ;
			int.TryParse(settings.GetSetting(WND_WIDTH), out width) ;
			int.TryParse(settings.GetSetting(WND_HEIGHT), out height) ;
			
			if(top > 0)
				Top = top ;
			
			if(left > 0)
				Left = left ;
			
			if(height >= MinimumSize.Height)
				Height = height ;
			
			if(width >= MinimumSize.Width)
				Width = width ;
			
			//load font 'serialized' string and convert it into a Font object, via the FontConverter class
			string fontStr ;
			fontStr = settings.GetSetting(WND_FONT) ;
			if(fontStr != ""){
				FontConverter fontCon = new FontConverter() ;
				try{
					Font fontObj = (Font)fontCon.ConvertFromString(fontStr) ;
					textBoxGreek.Font = fontObj ;
					textBoxLatin.Font = fontObj ;
				}catch(Exception){ }				
			}
		}

		//Save settings to the registry, such as last position, dimensions and font
		private void SaveLastPos(){
			settings.SetSetting(WND_TOP, Top.ToString()) ;
			settings.SetSetting(WND_LEFT, Left.ToString()) ;
			settings.SetSetting(WND_WIDTH, Width.ToString()) ;
			settings.SetSetting(WND_HEIGHT, Height.ToString()) ;
			
			//use FontConverter call to 'serialize' the current Font object into string
			FontConverter fontCon = new FontConverter() ;
			settings.SetSetting(WND_FONT, fontCon.ConvertToString(textBoxGreek.Font)) ;
		}
		
		//Transcript greek text placed in textBoxGreek and put it into textBoxLatin
		private void Transcript(){
			textBoxLatin.Text = el2lat.ToLatin(textBoxGreek.Text) ;
			
			//if upper or lower case convertion selected, apply it to the text
			if(!normalCaseToolStripMenuItem.Checked){
				if(toLowerCaseToolStripMenuItem.Checked)
					textBoxLatin.Text = textBoxLatin.Text.ToLower() ;
				else
					textBoxLatin.Text = textBoxLatin.Text.ToUpper() ;
			}
			
			//if any space replacement or trim selected, apply it to the text
			if(!spacesAsIsToolStripMenuItem.Checked){
				if(spacesToHypensToolStripMenuItem.Checked)
					textBoxLatin.Text = textBoxLatin.Text.Replace(" ", "-").Replace("\t", "-") ;
				else if(spacesToUnderscoresToolStripMenuItem.Checked)
					textBoxLatin.Text = textBoxLatin.Text.Replace(" ", "_").Replace("\t", "_") ;
				else
					textBoxLatin.Text = textBoxLatin.Text.Replace(" ", "").Replace("\t", "") ;
			}
			
			//update the status bar label
			toolStripStatusLabel.Text = textBoxGreek.Text.Length + " Greek chars | " + textBoxLatin.Text.Length + " Latin chars" ;
		}
		
		//in any textbox change, do the trnascription process
		void TextBoxGreekTextChanged(object sender, EventArgs e){
			Transcript() ;
		}
		
		//copy latin text to the clipboard
		void CopyLatinToolStripMenuItemClick(object sender, EventArgs e){
			Clipboard.SetText(textBoxLatin.Text) ;
		}
		
		//paste text from the clipboard to the textBoxGreek
		void PasteGreekToolStripMenuItemClick(object sender, EventArgs e){
			textBoxGreek.Text = Clipboard.GetText() ;
		}
		
		void SpacesToHypensToolStripMenuItemClick(object sender, EventArgs e){
			spacesAsIsToolStripMenuItem.Checked = false ;
			spacesToHypensToolStripMenuItem.Checked = true ;
			spacesToUnderscoresToolStripMenuItem.Checked = false ;
			trimSpacesToolStripMenuItem.Checked = false ;
			Transcript() ;
		}
		
		void SpacesToUnderscoresToolStripMenuItemClick(object sender, EventArgs e){
			spacesAsIsToolStripMenuItem.Checked = false ;
			spacesToHypensToolStripMenuItem.Checked = false ;
			spacesToUnderscoresToolStripMenuItem.Checked = true ;
			trimSpacesToolStripMenuItem.Checked = false ;
			Transcript() ;
		}
		
		void TrimSpacesToolStripMenuItemClick(object sender, EventArgs e){
			spacesAsIsToolStripMenuItem.Checked = false ;
			spacesToHypensToolStripMenuItem.Checked = false ;
			spacesToUnderscoresToolStripMenuItem.Checked = false ;
			trimSpacesToolStripMenuItem.Checked = true ;
			Transcript() ;
		}
		
		void SpacesAsIsToolStripMenuItemClick(object sender, EventArgs e){
			spacesAsIsToolStripMenuItem.Checked = true ;
			spacesToHypensToolStripMenuItem.Checked = false ;
			spacesToUnderscoresToolStripMenuItem.Checked = false ;
			trimSpacesToolStripMenuItem.Checked = false ;
			Transcript() ;
		}
		
		void NormalCaseToolStripMenuItemClick(object sender, EventArgs e){
			normalCaseToolStripMenuItem.Checked = true ;
			toUpperCaseToolStripMenuItem.Checked = false ;
			toLowerCaseToolStripMenuItem.Checked = false ;
			Transcript() ;
		}
		
		void ToUpperCaseToolStripMenuItemClick(object sender, EventArgs e){
			normalCaseToolStripMenuItem.Checked = false ;
			toUpperCaseToolStripMenuItem.Checked = true ;
			toLowerCaseToolStripMenuItem.Checked = false ;
			textBoxLatin.Text = textBoxLatin.Text.ToUpper() ;
		}
		
		void ToLowerCaseToolStripMenuItemClick(object sender, EventArgs e){
			normalCaseToolStripMenuItem.Checked = false ;
			toUpperCaseToolStripMenuItem.Checked = false ;
			toLowerCaseToolStripMenuItem.Checked = true ;
			textBoxLatin.Text = textBoxLatin.Text.ToLower() ;
		}		
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e){
			Application.Exit() ;
		}
		
		//in closing, hide form (to save time) and save settings to the registry
		void MainFormFormClosing(object sender, FormClosingEventArgs e){
			this.Hide() ;
			SaveLastPos() ;
		}
		
		//in form loading, load and apply settings from the registry
		void MainFormLoad(object sender, EventArgs e){			
			LoadLastPos() ;
		}
		
		//when drag files or text, apply the appropriate effects
		void TextBoxGreekDragEnter(object sender, DragEventArgs e){
			if(e.Data.GetDataPresent(DataFormats.FileDrop)){
				e.Effect = DragDropEffects.Copy ;
			}
			else if(e.Data.GetDataPresent(DataFormats.Text)){
				e.Effect = DragDropEffects.Move ;
			}
		}
		
		//when text droped, paste it into the text box
		//when files droped, initialize the program into 'Files Mode'
		void TextBoxGreekDragDrop(object sender, DragEventArgs e){
			if(e.Data.GetDataPresent(DataFormats.FileDrop)){
				string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
				InitFilesMode(files) ;
			}
			if (e.Data.GetDataPresent(DataFormats.Text)){
				string text = (string)e.Data.GetData(DataFormats.Text);
				textBoxGreek.Text = text ;
			}
		}
		
		// -- 'Files Mode' initializing --
		// make visual changes and load files list into a FileInfo array
		private void InitFilesMode(string[] fileNames){
			toolStripSplitButtonFilenameOperations.Visible = true ;
			toolStripStatusLabel.Visible = false ;
			textBoxGreek.ReadOnly = true ;
			textBoxGreek.Clear() ;
			filesNewnameCopyToolStripMenuItem.Enabled = true ;
			filesRenameToolStripMenuItem.Enabled = true ;
			loadGreekTextToolStripMenuItem.Enabled = false ;
			saveLatinTextToolStripMenuItem.Enabled = false ;
			fileList = new FileInfo[fileNames.Length] ;
			for(int i=0; i<fileNames.Length; i++){
				fileList[i] = new FileInfo(fileNames[i]) ;
				textBoxGreek.Text += fileList[i].Name + "\r\n" ;
			}
		}
		
		// -- 'Files Mode' destruction --
		// restore gui to 'normal mode'
		private void QuitFilesMode(){
			toolStripSplitButtonFilenameOperations.Visible = false ;
			toolStripStatusLabel.Visible = true ;
			textBoxGreek.ReadOnly = false ;
			loadGreekTextToolStripMenuItem.Enabled = true ;
			saveLatinTextToolStripMenuItem.Enabled = true ;
			textBoxGreek.Clear() ;
		}
		
		/// <summary>Rename files, with its transcripted name</summary>
		/// <param name="keepOriginal">False to rename files, true to copy them with new names</param>
		private void RenameFiles(bool keepOriginal){
			//transcripted filenames placed in the textBoxLatin, separated with windows 
			//new lines so, split them, and create a new string array with the filenames
			string[] newLineSeparator = {"\r\n"} ;
			string[] latFileNames = textBoxLatin.Text.Split(newLineSeparator, StringSplitOptions.None) ;
			
			//clear textBoxLatin, to print the results, and disable the rename and copy commands,
			//until the next file drop, because transcripted names aren't at the textBoxLatin anymore
			textBoxLatin.Clear() ;
			filesNewnameCopyToolStripMenuItem.Enabled = false ;
			filesRenameToolStripMenuItem.Enabled = false ;
			
			//rename file in the files list
			for(int i=0; i<fileList.Length; i++){
				try{
					if(fileList[i].Exists){
						string newFileName = fileList[i].DirectoryName + "\\" + latFileNames[i] ;
						if(keepOriginal){
							fileList[i].CopyTo(newFileName) ;
						}else{
							fileList[i].MoveTo(newFileName) ;
						}
					}
					//if theres not a file, but a dir, create DirectoryInfo object, to do the renaming
					else if(Directory.Exists(fileList[i].FullName)){
						if(keepOriginal){
							//DirectoryInfo, doesn't support dir copying
							throw new Exception("Can't copy directory, only rename it.") ;
						}else{
							DirectoryInfo dir = new DirectoryInfo(fileList[i].FullName) ;
							dir.MoveTo(dir.Parent.FullName + "\\" + latFileNames[i]) ;
						}
					}
					//if file not exist throw an exception
					else{
						throw new FileNotFoundException() ;
					}
					textBoxLatin.Text += fileList[i].Name + " => " + latFileNames[i] + " ... Done!\r\n" ;
				}catch(Exception err){
					textBoxLatin.Text += fileList[i].Name + " => " + latFileNames[i] + " ... Error! (" + err.Message + ")\r\n" ;
				}
			}
			
			//at the end, play a notification sound
			System.Media.SystemSounds.Beep.Play() ;
		}
		
		void FilesRenameToolStripMenuItemClick(object sender, EventArgs e){
			RenameFiles(false) ;
		}
		
		void FilesNewnameCopyToolStripMenuItemClick(object sender, EventArgs e){
			RenameFiles(true) ;
		}
		
		void CloseFilesModeToolStripMenuItemClick(object sender, EventArgs e){
			QuitFilesMode() ;
		}
		
		//show open file dialog, and try to load the file contents
		void LoadGreekTextToolStripMenuItemClick(object sender, EventArgs e){
			DialogResult result = openFileDialogGr.ShowDialog() ;
			if(result == DialogResult.OK){
				try{
					textBoxGreek.Text = File.ReadAllText(openFileDialogGr.FileName) ;
				}catch(Exception err){
					MessageBox.Show(err.Message, "Opening file error!", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
				}
			}
		}
		
		//show save file dialog, and try to store latin text into the file
		void SaveLatinTextToolStripMenuItemClick(object sender, EventArgs e){
			DialogResult result = saveFileDialogLat.ShowDialog() ;
			if(result == DialogResult.OK){
				try {
					File.WriteAllText(saveFileDialogLat.FileName, textBoxLatin.Text) ;
				} catch (Exception err) {
					MessageBox.Show(err.Message, "Saving file error!", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
				}
			}
		}
		
		void AboutToolStripMenuItemClick(object sender, EventArgs e){
			string info = "Ellat - Version 2.7\n(c) 2014, Petros Kyladitis\n<http://www.multipetros.gr/>\n\nA Greek to Latin transcriptor tool, for text and filenames.\n\nThis program is free software distributed under the FreeBSD License, for license details see at 'license.txt' file, distributed with this program, or see at <http://www.multipetros.gr/freebsd-license/>." ;
			MessageBox.Show(info, "About Ellat...", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
		}
		
		//show font selection dialog and load the Font object at greem & latin text boxes
		void ChangeFontToolStripMenuItemClick(object sender, EventArgs e){
			fontDialog.Font = textBoxGreek.Font ;
			DialogResult result = fontDialog.ShowDialog() ;
			if(result == DialogResult.OK){
				textBoxGreek.Font = fontDialog.Font ;
				textBoxLatin.Font = fontDialog.Font ;
			}
		}
	}
}
