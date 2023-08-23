using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightboxGenerator
{
    public partial class Window : Form
    {
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

        }
    }
}
