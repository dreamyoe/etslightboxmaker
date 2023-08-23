using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightboxGenerator.Core
{
    public static class ModMaker
    {
        private static string selectedTruck = "None";

        public static void SelectTruck(string type)
        {
            selectedTruck = type;

            Program.mainWindow.upload.Enabled = true;
            Program.mainWindow.upload.Visible = true;

            Program.mainWindow.label4.Enabled = false;
            Program.mainWindow.label4.Visible = false;

            Program.mainWindow.label3.Enabled = true;
            Program.mainWindow.label3.Visible = true;

            Program.SetTruck(type);
        }
    }
}
