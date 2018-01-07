namespace AddingToPlaylistContext
{
    partial class BrowsePlaylistFolderForm
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
            this.Folder_Directory = new System.Windows.Forms.TextBox();
            this.Folder_Directory_Label = new System.Windows.Forms.Label();
            this.Browse_Button = new System.Windows.Forms.Button();
            this.Folder_Browser = new System.Windows.Forms.FolderBrowserDialog();
            this.Confirm_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Remove_Context_Menu_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Folder_Directory
            // 
            this.Folder_Directory.Location = new System.Drawing.Point(128, 43);
            this.Folder_Directory.Name = "Folder_Directory";
            this.Folder_Directory.Size = new System.Drawing.Size(693, 26);
            this.Folder_Directory.TabIndex = 0;
            // 
            // Folder_Directory_Label
            // 
            this.Folder_Directory_Label.AutoSize = true;
            this.Folder_Directory_Label.Location = new System.Drawing.Point(12, 46);
            this.Folder_Directory_Label.Name = "Folder_Directory_Label";
            this.Folder_Directory_Label.Size = new System.Drawing.Size(110, 20);
            this.Folder_Directory_Label.TabIndex = 1;
            this.Folder_Directory_Label.Text = "Playlist Folder:";
            // 
            // Browse_Button
            // 
            this.Browse_Button.AutoSize = true;
            this.Browse_Button.Location = new System.Drawing.Point(827, 41);
            this.Browse_Button.Name = "Browse_Button";
            this.Browse_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Browse_Button.Size = new System.Drawing.Size(58, 30);
            this.Browse_Button.TabIndex = 2;
            this.Browse_Button.Text = "...";
            this.Browse_Button.UseVisualStyleBackColor = true;
            this.Browse_Button.Click += new System.EventHandler(this.Browse_Button_Click);
            // 
            // Confirm_Button
            // 
            this.Confirm_Button.Location = new System.Drawing.Point(792, 351);
            this.Confirm_Button.Name = "Confirm_Button";
            this.Confirm_Button.Size = new System.Drawing.Size(93, 37);
            this.Confirm_Button.TabIndex = 3;
            this.Confirm_Button.Text = "Confirm";
            this.Confirm_Button.UseVisualStyleBackColor = true;
            this.Confirm_Button.Click += new System.EventHandler(this.Confirm_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(679, 351);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(93, 37);
            this.Cancel_Button.TabIndex = 4;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            ".aac",
            ".ac3",
            ".aiff",
            ".aif",
            ".ape",
            ".asx",
            ".bwf",
            ".cda",
            ".cue",
            ".dff",
            ".dsd",
            ".dsf",
            ".flac",
            ".it",
            ".kar",
            ".m1a",
            ".m2a",
            ".m4a",
            ".m4b",
            ".mac",
            ".mid",
            ".mo3",
            ".mod",
            ".mp+",
            ".mp1",
            ".mp2",
            ".mp3",
            ".mp3pro",
            ".mpa",
            ".mpx",
            ".mpp",
            ".mtm",
            ".mus",
            ".ofr",
            ".ofs",
            ".ogg",
            ".opus",
            ".pls",
            ".s3m",
            ".spx",
            ".tak",
            ".tta",
            ".umx",
            ".wac",
            ".wma",
            ".wpl",
            ".wv",
            ".xm",
            ".xspf"});
            this.checkedListBox1.Location = new System.Drawing.Point(16, 84);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(199, 277);
            this.checkedListBox1.TabIndex = 5;
            // 
            // Remove_Context_Menu_Button
            // 
            this.Remove_Context_Menu_Button.Location = new System.Drawing.Point(471, 351);
            this.Remove_Context_Menu_Button.Name = "Remove_Context_Menu_Button";
            this.Remove_Context_Menu_Button.Size = new System.Drawing.Size(188, 37);
            this.Remove_Context_Menu_Button.TabIndex = 6;
            this.Remove_Context_Menu_Button.Text = "Remove Context Menu";
            this.Remove_Context_Menu_Button.UseVisualStyleBackColor = true;
            // 
            // BrowsePlaylistFolderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 400);
            this.Controls.Add(this.Remove_Context_Menu_Button);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Confirm_Button);
            this.Controls.Add(this.Browse_Button);
            this.Controls.Add(this.Folder_Directory_Label);
            this.Controls.Add(this.Folder_Directory);
            this.Name = "BrowsePlaylistFolderForm";
            this.Text = "BrowsePlaylistFolderForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Folder_Directory;
        private System.Windows.Forms.Label Folder_Directory_Label;
        private System.Windows.Forms.Button Browse_Button;
        private System.Windows.Forms.FolderBrowserDialog Folder_Browser;
        private System.Windows.Forms.Button Confirm_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button Remove_Context_Menu_Button;
    }
}