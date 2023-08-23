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
    public partial class SelectTruck : Form
    {
        public SelectTruck()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModMaker.SelectTruck("Scania R 2009");
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModMaker.SelectTruck("Scania Streamline");
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModMaker.SelectTruck("Volvo FH16 2009");
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModMaker.SelectTruck("Volvo FH16 2012");
            Close();
        }
    }
}
