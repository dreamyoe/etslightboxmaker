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
    }
}
