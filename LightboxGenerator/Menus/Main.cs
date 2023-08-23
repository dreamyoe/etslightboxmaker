using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LightboxGenerator.Core;
using LightboxGenerator.Menus;

namespace LightboxGenerator
{
    public partial class Window : Form
    {
        private SelectTruck selectTruck;

        public Window()
        {
            InitializeComponent();
        }

        private void quitbox_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void downloadtemplate_Click(object sender, EventArgs e)
        {
            Downloader.ShowDownloadPresetWindow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectTruck = new SelectTruck();

            selectTruck.ShowDialog();
        }

        private void upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Select lightbox skin (.dds)";

            dialog.ShowDialog();

            string path = Path.Combine(dialog.InitialDirectory, dialog.FileName);

            if (path != null)
            {
                if (!dialog.FileName.Contains(".dds"))
                {
                    MessageBox.Show("Invalid file format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                uploadlabel1.Text = "Uploaded file!\nWhen you are ready, press 'Export mod'";

                exportmodbutton.Enabled = true;
                exportmodbutton.Visible = true;
            }
        }

        private void exportmodbutton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            dialog.Description = "Select your ETS mod folder";

            dialog.ShowDialog();

            using (WebClient client = new WebClient())
            {
                client.DownloadFile("https://github.com/dreamyoe/etslightboxmaker/raw/main/Downloads/mod%20preset/mod.zip", dialog.SelectedPath);
            }
        }
    }
}
