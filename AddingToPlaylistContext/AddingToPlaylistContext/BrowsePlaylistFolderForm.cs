using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddingToPlaylistContext
{
    public partial class BrowsePlaylistFolderForm : Form
    {
        private string m_playlistDirectory;

        public delegate void delegButtonClick(string aPlaylistDirectory);
        public event delegButtonClick OnConfirmButtonClick; 

        public string PPlaylistDirectory
        {
            get
            {
                return m_playlistDirectory;
            }
        }

        public BrowsePlaylistFolderForm()
        {
            InitializeComponent();
        }
        
        private void Browse_Button_Click(object sender, EventArgs e)
        {
            // Show the FolderBrowserDialog.
            DialogResult result = Folder_Browser.ShowDialog();
            if (result == DialogResult.OK)
            {
                m_playlistDirectory = Folder_Browser.SelectedPath;
                Folder_Directory.Text = m_playlistDirectory;
            }
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            if (OnConfirmButtonClick != null)
            {
                OnConfirmButtonClick.Invoke(m_playlistDirectory);
            }
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
        }
    }
}
