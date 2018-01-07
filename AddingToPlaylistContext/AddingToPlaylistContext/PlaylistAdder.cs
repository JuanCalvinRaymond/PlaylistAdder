using System;
using System.Security.AccessControl;
using System.Diagnostics;
using System.IO;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;
using Microsoft.Win32;

namespace AddingToPlaylistContext
{
    public class PlaylistAdder
    {
        private const string M_MENUNAME = "MusicBee.MP3File\\shell\\PlaylistAdder";
        private const string M_COMMANDSTOREPATH = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\CommandStore\\shell\\";

        private static string m_playlistFolderDirectory;
        private static string[] m_arrayOfPlaylistFile;
        private static FileSystemWatcher m_watcher = new FileSystemWatcher();
        //Whether the file is already in the playlist or not
        private static bool isContain;

        private BackgroundWorker m_worker = new BackgroundWorker();

        [STAThread]
        private static void Main(string[] args)
        {
            if (args.Length > 1)
            {
                AddToPlaylist(args[0], args[1]);
            }
            else
            {
                OpenWindowFormDialog();
            }
        }

        private static void OpenWindowFormDialog()
        {
            BrowsePlaylistFolderForm m_windowsForm = new BrowsePlaylistFolderForm();
            m_windowsForm.OnConfirmButtonClick += SetFolderDirectory;
            m_windowsForm.ShowDialog();
        }

        private static void RegisterKey()
        {
            //Register to RegEdit
            RegistryKey regmenu = null;
            try
            {
                //Create context menu for each Filetype
                //TODO : read which extension user want to add the context menu and add it.
                //For now use MusicBee.MP3File key to test.
                regmenu = Registry.ClassesRoot.CreateSubKey(M_MENUNAME);
                if (regmenu != null)
                {
                    regmenu.SetValue("MUIVerb", "Add to playlist");
                    regmenu.SetValue("SubCommands", "");
                    RegistryKey shell = regmenu.CreateSubKey("Shell");
                    if (shell != null)
                    {
                        foreach (string playlist in m_arrayOfPlaylistFile)
                        {
                            string file = Path.GetFileNameWithoutExtension(playlist);
                            RegistryKey playlistKey = shell.CreateSubKey(file);
                            if (playlistKey != null)
                            {
                                RegistryKey commandKey = playlistKey.CreateSubKey("command");
                                if (commandKey != null)
                                {
                                    commandKey.SetValue("", "\"" + System.Windows.Forms.Application.ExecutablePath + "\"" + " \"%1\"" + " \"" + playlist + "\"");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }
            finally
            {
                if (regmenu != null)
                    regmenu.Close();
            }
        }

        private static void SetFolderDirectory(string aPlaylistDirectory)
        {
            m_playlistFolderDirectory = aPlaylistDirectory;
            m_arrayOfPlaylistFile = Directory.GetFiles(m_playlistFolderDirectory, "*.m3u");
            StartFolderWatcher(m_playlistFolderDirectory);
            RegisterKey();
        }

        private static void StartBackgroundProcess()
        {
            ServiceBase process = new ServiceBase();
            
        }

        private static void StartFolderWatcher(string aFolderDirectory)
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = aFolderDirectory;
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Filter = "*.*";
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnDeleted);
            watcher.EnableRaisingEvents = true;
        }

        private static void OnDeleted(object sender, FileSystemEventArgs e)
        {

        }

        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show("FolderModified");
        }

        private static void AddToPlaylist(string aAudiofile, string aPlaylist)
        {
            //If Playlist doesn't exist go out from main
            if (!File.Exists(aPlaylist))
            {
                return;
            }

            //Just in case, store the full path of file we want to add
            string filePath = Path.GetFullPath(aAudiofile);

            //Check if the file is already in the list or not
            string[] musicList = File.ReadAllLines(aPlaylist);
            isContain = false;
            foreach (string music in musicList)
            {
                if (filePath == music)
                {
                    isContain = true;
                    break;
                }
            }

            //If there's no file in the playlist then add it.
            if (!isContain)
            {
                File.AppendAllText(aPlaylist, Environment.NewLine + filePath);
            }
            else
            {
                MessageBox.Show("Error : Music is already on the list");
            }
        }
    }
}
