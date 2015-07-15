namespace Ellat
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
			this.menuStripMain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadGreekTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveLatinTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteGreekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyLatinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.normalCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toUpperCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toLowerCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.spacesToHypensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.spacesToUnderscoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trimSpacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.spacesAsIsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStripMain = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripSplitButtonFilenameOperations = new System.Windows.Forms.ToolStripDropDownButton();
			this.filesNewnameCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.filesRenameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.closeFilesModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainerMain = new System.Windows.Forms.SplitContainer();
			this.textBoxGreek = new System.Windows.Forms.TextBox();
			this.textBoxLatin = new System.Windows.Forms.TextBox();
			this.openFileDialogGr = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialogLat = new System.Windows.Forms.SaveFileDialog();
			this.fontDialog = new System.Windows.Forms.FontDialog();
			this.menuStripMain.SuspendLayout();
			this.statusStripMain.SuspendLayout();
			this.splitContainerMain.Panel1.SuspendLayout();
			this.splitContainerMain.Panel2.SuspendLayout();
			this.splitContainerMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStripMain
			// 
			this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.editToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.menuStripMain.Location = new System.Drawing.Point(0, 0);
			this.menuStripMain.Name = "menuStripMain";
			this.menuStripMain.Size = new System.Drawing.Size(461, 24);
			this.menuStripMain.TabIndex = 0;
			this.menuStripMain.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.loadGreekTextToolStripMenuItem,
									this.saveLatinTextToolStripMenuItem,
									this.changeFontToolStripMenuItem,
									this.toolStripSeparator4,
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// loadGreekTextToolStripMenuItem
			// 
			this.loadGreekTextToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loadGreekTextToolStripMenuItem.Image")));
			this.loadGreekTextToolStripMenuItem.Name = "loadGreekTextToolStripMenuItem";
			this.loadGreekTextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.loadGreekTextToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.loadGreekTextToolStripMenuItem.Text = "&Load Greek text";
			this.loadGreekTextToolStripMenuItem.ToolTipText = "Load text from a plain text file";
			this.loadGreekTextToolStripMenuItem.Click += new System.EventHandler(this.LoadGreekTextToolStripMenuItemClick);
			// 
			// saveLatinTextToolStripMenuItem
			// 
			this.saveLatinTextToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveLatinTextToolStripMenuItem.Image")));
			this.saveLatinTextToolStripMenuItem.Name = "saveLatinTextToolStripMenuItem";
			this.saveLatinTextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveLatinTextToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.saveLatinTextToolStripMenuItem.Text = "&Save Latin text";
			this.saveLatinTextToolStripMenuItem.ToolTipText = "Save transcripted plain text to a file";
			this.saveLatinTextToolStripMenuItem.Click += new System.EventHandler(this.SaveLatinTextToolStripMenuItemClick);
			// 
			// changeFontToolStripMenuItem
			// 
			this.changeFontToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changeFontToolStripMenuItem.Image")));
			this.changeFontToolStripMenuItem.Name = "changeFontToolStripMenuItem";
			this.changeFontToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.changeFontToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.changeFontToolStripMenuItem.Text = "Select &Font";
			this.changeFontToolStripMenuItem.ToolTipText = "Select Font Family and Size";
			this.changeFontToolStripMenuItem.Click += new System.EventHandler(this.ChangeFontToolStripMenuItemClick);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(195, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.ToolTipText = "Quit the program";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.pasteGreekToolStripMenuItem,
									this.copyLatinToolStripMenuItem,
									this.toolStripSeparator1,
									this.normalCaseToolStripMenuItem,
									this.toUpperCaseToolStripMenuItem,
									this.toLowerCaseToolStripMenuItem,
									this.toolStripSeparator2,
									this.spacesToHypensToolStripMenuItem,
									this.spacesToUnderscoresToolStripMenuItem,
									this.trimSpacesToolStripMenuItem,
									this.spacesAsIsToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "&Edit";
			// 
			// pasteGreekToolStripMenuItem
			// 
			this.pasteGreekToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteGreekToolStripMenuItem.Image")));
			this.pasteGreekToolStripMenuItem.Name = "pasteGreekToolStripMenuItem";
			this.pasteGreekToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
			this.pasteGreekToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			this.pasteGreekToolStripMenuItem.Text = "&Paste Greek";
			this.pasteGreekToolStripMenuItem.ToolTipText = "Paste Greek text from the clipboard";
			this.pasteGreekToolStripMenuItem.Click += new System.EventHandler(this.PasteGreekToolStripMenuItemClick);
			// 
			// copyLatinToolStripMenuItem
			// 
			this.copyLatinToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyLatinToolStripMenuItem.Image")));
			this.copyLatinToolStripMenuItem.Name = "copyLatinToolStripMenuItem";
			this.copyLatinToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
			this.copyLatinToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			this.copyLatinToolStripMenuItem.Text = "&Copy Latin";
			this.copyLatinToolStripMenuItem.ToolTipText = "Copy Latin text to the clipboard";
			this.copyLatinToolStripMenuItem.Click += new System.EventHandler(this.CopyLatinToolStripMenuItemClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(208, 6);
			// 
			// normalCaseToolStripMenuItem
			// 
			this.normalCaseToolStripMenuItem.Checked = true;
			this.normalCaseToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.normalCaseToolStripMenuItem.Name = "normalCaseToolStripMenuItem";
			this.normalCaseToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
			this.normalCaseToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			this.normalCaseToolStripMenuItem.Text = "&Normal Case";
			this.normalCaseToolStripMenuItem.ToolTipText = "Transcript text case as entered";
			this.normalCaseToolStripMenuItem.Click += new System.EventHandler(this.NormalCaseToolStripMenuItemClick);
			// 
			// toUpperCaseToolStripMenuItem
			// 
			this.toUpperCaseToolStripMenuItem.Name = "toUpperCaseToolStripMenuItem";
			this.toUpperCaseToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.toUpperCaseToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			this.toUpperCaseToolStripMenuItem.Text = "&Upper Case";
			this.toUpperCaseToolStripMenuItem.ToolTipText = "Upper Case the Transcript text";
			this.toUpperCaseToolStripMenuItem.Click += new System.EventHandler(this.ToUpperCaseToolStripMenuItemClick);
			// 
			// toLowerCaseToolStripMenuItem
			// 
			this.toLowerCaseToolStripMenuItem.Name = "toLowerCaseToolStripMenuItem";
			this.toLowerCaseToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
			this.toLowerCaseToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			this.toLowerCaseToolStripMenuItem.Text = "&Lower Case";
			this.toLowerCaseToolStripMenuItem.ToolTipText = "Lower Case the Transcript text";
			this.toLowerCaseToolStripMenuItem.Click += new System.EventHandler(this.ToLowerCaseToolStripMenuItemClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(208, 6);
			// 
			// spacesToHypensToolStripMenuItem
			// 
			this.spacesToHypensToolStripMenuItem.Name = "spacesToHypensToolStripMenuItem";
			this.spacesToHypensToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
			this.spacesToHypensToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			this.spacesToHypensToolStripMenuItem.Text = "Spaces to &Hypens";
			this.spacesToHypensToolStripMenuItem.ToolTipText = "Convert Spaces and tabs to Hypens at the transcripted text";
			this.spacesToHypensToolStripMenuItem.Click += new System.EventHandler(this.SpacesToHypensToolStripMenuItemClick);
			// 
			// spacesToUnderscoresToolStripMenuItem
			// 
			this.spacesToUnderscoresToolStripMenuItem.Name = "spacesToUnderscoresToolStripMenuItem";
			this.spacesToUnderscoresToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
			this.spacesToUnderscoresToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			this.spacesToUnderscoresToolStripMenuItem.Text = "Spaces to Un&derscores";
			this.spacesToUnderscoresToolStripMenuItem.ToolTipText = "Convert Spaces and tabs to Underscores at the transcripted text";
			this.spacesToUnderscoresToolStripMenuItem.Click += new System.EventHandler(this.SpacesToUnderscoresToolStripMenuItemClick);
			// 
			// trimSpacesToolStripMenuItem
			// 
			this.trimSpacesToolStripMenuItem.Name = "trimSpacesToolStripMenuItem";
			this.trimSpacesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
			this.trimSpacesToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			this.trimSpacesToolStripMenuItem.Text = "&Trim Spaces";
			this.trimSpacesToolStripMenuItem.ToolTipText = "Trim Spaces and tabs at the transcripted text";
			this.trimSpacesToolStripMenuItem.Click += new System.EventHandler(this.TrimSpacesToolStripMenuItemClick);
			// 
			// spacesAsIsToolStripMenuItem
			// 
			this.spacesAsIsToolStripMenuItem.Checked = true;
			this.spacesAsIsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.spacesAsIsToolStripMenuItem.Name = "spacesAsIsToolStripMenuItem";
			this.spacesAsIsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
			this.spacesAsIsToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			this.spacesAsIsToolStripMenuItem.Text = "Spaces \"&As Is\"";
			this.spacesAsIsToolStripMenuItem.ToolTipText = "Leave spaces and tabs as the are";
			this.spacesAsIsToolStripMenuItem.Click += new System.EventHandler(this.SpacesAsIsToolStripMenuItemClick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.ShortcutKeyDisplayString = "F1";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.ToolTipText = "Show info about this program";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// statusStripMain
			// 
			this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel,
									this.toolStripSplitButtonFilenameOperations});
			this.statusStripMain.Location = new System.Drawing.Point(0, 300);
			this.statusStripMain.Name = "statusStripMain";
			this.statusStripMain.Size = new System.Drawing.Size(461, 22);
			this.statusStripMain.TabIndex = 1;
			this.statusStripMain.Text = "statusStripBottom";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(152, 17);
			this.toolStripStatusLabel.Text = "0 Greek chars | 0 Latin chars";
			// 
			// toolStripSplitButtonFilenameOperations
			// 
			this.toolStripSplitButtonFilenameOperations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.filesNewnameCopyToolStripMenuItem,
									this.filesRenameToolStripMenuItem,
									this.toolStripSeparator3,
									this.closeFilesModeToolStripMenuItem});
			this.toolStripSplitButtonFilenameOperations.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonFilenameOperations.Image")));
			this.toolStripSplitButtonFilenameOperations.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButtonFilenameOperations.Name = "toolStripSplitButtonFilenameOperations";
			this.toolStripSplitButtonFilenameOperations.Size = new System.Drawing.Size(149, 20);
			this.toolStripSplitButtonFilenameOperations.Text = "F&iles Opeartion Mode";
			this.toolStripSplitButtonFilenameOperations.Visible = false;
			// 
			// filesNewnameCopyToolStripMenuItem
			// 
			this.filesNewnameCopyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("filesNewnameCopyToolStripMenuItem.Image")));
			this.filesNewnameCopyToolStripMenuItem.Name = "filesNewnameCopyToolStripMenuItem";
			this.filesNewnameCopyToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
			this.filesNewnameCopyToolStripMenuItem.Text = "&Copy Files with new name";
			this.filesNewnameCopyToolStripMenuItem.ToolTipText = "Keep old files and create copies with latin names. This can\'t work with folders.";
			this.filesNewnameCopyToolStripMenuItem.Click += new System.EventHandler(this.FilesNewnameCopyToolStripMenuItemClick);
			// 
			// filesRenameToolStripMenuItem
			// 
			this.filesRenameToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("filesRenameToolStripMenuItem.Image")));
			this.filesRenameToolStripMenuItem.Name = "filesRenameToolStripMenuItem";
			this.filesRenameToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
			this.filesRenameToolStripMenuItem.Text = "&Rename Files";
			this.filesRenameToolStripMenuItem.ToolTipText = "Rename files and folders with transcripted latin names";
			this.filesRenameToolStripMenuItem.Click += new System.EventHandler(this.FilesRenameToolStripMenuItemClick);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(209, 6);
			// 
			// closeFilesModeToolStripMenuItem
			// 
			this.closeFilesModeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("closeFilesModeToolStripMenuItem.Image")));
			this.closeFilesModeToolStripMenuItem.Name = "closeFilesModeToolStripMenuItem";
			this.closeFilesModeToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
			this.closeFilesModeToolStripMenuItem.Text = "&Quit Files Mode";
			this.closeFilesModeToolStripMenuItem.ToolTipText = "Enable Text Transcript Mode";
			this.closeFilesModeToolStripMenuItem.Click += new System.EventHandler(this.CloseFilesModeToolStripMenuItemClick);
			// 
			// splitContainerMain
			// 
			this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerMain.Location = new System.Drawing.Point(0, 24);
			this.splitContainerMain.Name = "splitContainerMain";
			this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainerMain.Panel1
			// 
			this.splitContainerMain.Panel1.Controls.Add(this.textBoxGreek);
			this.splitContainerMain.Panel1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 2);
			// 
			// splitContainerMain.Panel2
			// 
			this.splitContainerMain.Panel2.Controls.Add(this.textBoxLatin);
			this.splitContainerMain.Panel2.Padding = new System.Windows.Forms.Padding(5, 2, 5, 5);
			this.splitContainerMain.Size = new System.Drawing.Size(461, 276);
			this.splitContainerMain.SplitterDistance = 124;
			this.splitContainerMain.TabIndex = 2;
			// 
			// textBoxGreek
			// 
			this.textBoxGreek.AcceptsReturn = true;
			this.textBoxGreek.AcceptsTab = true;
			this.textBoxGreek.AllowDrop = true;
			this.textBoxGreek.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxGreek.Location = new System.Drawing.Point(5, 5);
			this.textBoxGreek.MaxLength = 0;
			this.textBoxGreek.Multiline = true;
			this.textBoxGreek.Name = "textBoxGreek";
			this.textBoxGreek.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxGreek.Size = new System.Drawing.Size(451, 117);
			this.textBoxGreek.TabIndex = 0;
			this.textBoxGreek.TextChanged += new System.EventHandler(this.TextBoxGreekTextChanged);
			this.textBoxGreek.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBoxGreekDragDrop);
			this.textBoxGreek.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBoxGreekDragEnter);
			// 
			// textBoxLatin
			// 
			this.textBoxLatin.AcceptsReturn = true;
			this.textBoxLatin.AcceptsTab = true;
			this.textBoxLatin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxLatin.Location = new System.Drawing.Point(5, 2);
			this.textBoxLatin.MaxLength = 0;
			this.textBoxLatin.Multiline = true;
			this.textBoxLatin.Name = "textBoxLatin";
			this.textBoxLatin.ReadOnly = true;
			this.textBoxLatin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxLatin.Size = new System.Drawing.Size(451, 141);
			this.textBoxLatin.TabIndex = 0;
			// 
			// openFileDialogGr
			// 
			this.openFileDialogGr.FileName = "openFileDialog1";
			// 
			// fontDialog
			// 
			this.fontDialog.FontMustExist = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(461, 322);
			this.Controls.Add(this.splitContainerMain);
			this.Controls.Add(this.statusStripMain);
			this.Controls.Add(this.menuStripMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(346, 235);
			this.Name = "MainForm";
			this.Text = "Ellat - Greek to Latin Transcripter";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.menuStripMain.ResumeLayout(false);
			this.menuStripMain.PerformLayout();
			this.statusStripMain.ResumeLayout(false);
			this.statusStripMain.PerformLayout();
			this.splitContainerMain.Panel1.ResumeLayout(false);
			this.splitContainerMain.Panel1.PerformLayout();
			this.splitContainerMain.Panel2.ResumeLayout(false);
			this.splitContainerMain.Panel2.PerformLayout();
			this.splitContainerMain.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem changeFontToolStripMenuItem;
		private System.Windows.Forms.FontDialog fontDialog;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.SaveFileDialog saveFileDialogLat;
		private System.Windows.Forms.OpenFileDialog openFileDialogGr;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem saveLatinTextToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadGreekTextToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem closeFilesModeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem filesRenameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem filesNewnameCopyToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButtonFilenameOperations;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.ToolStripMenuItem spacesAsIsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem normalCaseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem trimSpacesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem spacesToUnderscoresToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem spacesToHypensToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem toLowerCaseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toUpperCaseToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteGreekToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyLatinToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStripMain;
		private System.Windows.Forms.StatusStrip statusStripMain;
		private System.Windows.Forms.SplitContainer splitContainerMain;
		private System.Windows.Forms.TextBox textBoxGreek;
		private System.Windows.Forms.TextBox textBoxLatin;
	}
}
