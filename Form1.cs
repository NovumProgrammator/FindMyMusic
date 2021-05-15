using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace FindMyMusic
{
    public partial class FindMyMusic : Form
    {
        public string playlistPath;
        public string destinationFolder = @"C:\Users\vovch\Downloads\Music from playlist";
        private int countFilesToCopy;
        public string musicFilePathOld;
        public string musicFilePathNew;
        private bool stopToCopy = false;
        List<string> musicFiles = new List<string>();

        public FindMyMusic()
        {
            InitializeComponent();
            labelPlaylistPath.Text = playlistPath;
            labelDestFolderPath.Text = destinationFolder;
        }

        public int GetNumberFilesToCopy()
        {
            countFilesToCopy = 0;
            foreach (var item in musicFiles)
            {
                if (item.Contains("media"))
                {
                    countFilesToCopy++;
                }
            }
            progressBar.Maximum = countFilesToCopy;
            return countFilesToCopy;
        }

        async public void CopyFiles()
        {
            await Task.Run(() =>
            {
                foreach (var item in musicFiles)
                {
                    if (stopToCopy == true)
                    {
                        break;
                    }

                    if (item.Contains("media"))
                    {
                        musicFilePathOld = item.Substring(24).Remove(item.Substring(24).IndexOf("\""));
                        musicFilePathOld = musicFilePathOld.Replace(@"&apos;", @"'");
                        musicFilePathOld = musicFilePathOld.Replace("&amp;", "&");
                        musicFilePathNew = musicFilePathOld;

                        while (musicFilePathNew.Contains("\\"))
                        {
                            musicFilePathNew = musicFilePathNew.Substring(musicFilePathNew.IndexOf("\\") + 1);
                        }

                        File.Copy(musicFilePathOld, destinationFolder + $"\\{musicFilePathNew}", true);
                        progressBar.Value++;

                        if (progressBar.Value == progressBar.Maximum)
                        {
                            MessageBox.Show("Done", "", MessageBoxButtons.OK);
                        }

                    }
                }
            });
        }

        OpenFileDialog fileDialog = new OpenFileDialog();
        FolderBrowserDialog folder = new FolderBrowserDialog();

        private void bPlayList_Click(object sender, EventArgs e)
        {
            fileDialog.Filter = "WPL|*.wpl";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                playlistPath = fileDialog.FileName;
                labelPlaylistPath.Text = fileDialog.FileName;
                musicFiles = new List<string>(File.ReadAllLines(playlistPath));
            }
        }

        private void bFolderToCopy_Click(object sender, EventArgs e)
        {
            if (folder.ShowDialog() == DialogResult.OK)
            {
                destinationFolder = folder.SelectedPath;
                labelDestFolderPath.Text = folder.SelectedPath;
            }
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            stopToCopy = true;
        }

        private void bCopy_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(destinationFolder);

            if (playlistPath != null)
            {
                stopToCopy = false;
                GetNumberFilesToCopy();

                //CheckForIllegalCrossThreadCalls = false;
                Thread thread = new Thread(() =>
                {
                    Action act = () =>
                    {
                        progressBar.Value = 0;
                        CopyFiles();
                    };

                    if (InvokeRequired)
                    {
                        Invoke(act);
                    }
                    else
                    {
                        act();
                    }
                });
                thread.Start();
            }
            else
            {
                MessageBox.Show("Choose your playlist and destination folder");
            }
        }


    }
}
