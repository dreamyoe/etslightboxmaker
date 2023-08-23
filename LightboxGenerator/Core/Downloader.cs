using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LightboxGenerator.Menus;

namespace LightboxGenerator.Core
{
    public static class Downloader
    {
        private static PresetDownloaderPopup form;
        public static void ShowDownloadPresetWindow()
        {
            form = new PresetDownloaderPopup();

            form.ShowDialog();
        }

        public static void DownloadPreset(int id)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = Directory.GetCurrentDirectory();
            dialog.Title = "Save preset...";
            dialog.OverwritePrompt = true;
            dialog.DefaultExt = ".dds";
            dialog.AddExtension = true;

            dialog.ShowDialog();

            form.Close();

            if (dialog.FileName == "") { MessageBox.Show("Please enter a file name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if (id == 1) // Scania R 2009
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile("https://github.com/dreamyoe/etslightboxmaker/raw/main/Downloads/dd-light-scaniar2009.dds", Path.Combine(dialog.InitialDirectory, dialog.FileName));
                    DownloadComplete();
                }
            }

            if (id == 2) // Scania Streamline
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile("https://github.com/dreamyoe/etslightboxmaker/raw/main/Downloads/dd-light-scaniastreamline.dds", Path.Combine(dialog.InitialDirectory, dialog.FileName));
                    DownloadComplete();
                }
            }

            if (id == 3) // Volvo FH16 2009
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile("https://github.com/dreamyoe/etslightboxmaker/raw/main/Downloads/dd-light-volvo-fh16-2009.dds", Path.Combine(dialog.InitialDirectory, dialog.FileName));
                    DownloadComplete();
                }
            }

            if (id == 4) // Volvo FH16 2012
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile("https://github.com/dreamyoe/etslightboxmaker/raw/main/Downloads/dd-light-volvo-fh16-2012.dds", Path.Combine(dialog.InitialDirectory, dialog.FileName));
                    DownloadComplete();
                }
            }
        }

        private static void DownloadComplete()
        {
            MessageBox.Show("Download complete!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
