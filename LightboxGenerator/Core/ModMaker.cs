using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightboxGenerator.Core
{
    public static class ModMaker
    {
        public static string selectedTruck = "None";

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

        public static bool CheckForValidModID(string id)
        {
            if (id == "Mod ID*")
            {
                return false;
            }

            string numbers = "0123456789";
            char[] numbersChars = numbers.ToCharArray();

            for (int i = 0; i < numbersChars.Length; i++)
            {
                if (numbers.Contains(numbersChars[i]))
                {
                    return false;
                }
            }

            char[] idchars = id.ToCharArray();

            for (int i = 0; i < idchars.Length; i++)
            {
                if (char.IsUpper(idchars[i]))
                {
                    return false;
                }
            }

            if (id.Contains(' '))
            {
                return false;
            }

            return true;
        }
    }
}
