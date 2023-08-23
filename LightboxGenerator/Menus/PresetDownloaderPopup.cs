using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LightboxGenerator.Core;

namespace LightboxGenerator.Menus
{
    public partial class PresetDownloaderPopup : Form
    {
        public PresetDownloaderPopup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Downloader.DownloadPreset(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Downloader.DownloadPreset(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Downloader.DownloadPreset(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Downloader.DownloadPreset(4);
        }
    }
}
