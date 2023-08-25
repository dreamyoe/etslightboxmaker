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

        private string ddsPath;

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

            ddsPath = Path.Combine(dialog.InitialDirectory, dialog.FileName);

            if (ddsPath != null)
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

            if (modname.Text == "Mod Name*")
            {
                MessageBox.Show("Please enter a valid mod name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ModMaker.CheckForValidModID(modid.Text))
            {
                MessageBox.Show("Please enter a valid mod id!\nA valid mod id must contain:\n- No spaces\n- No capitals\n-No numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (modversion.Text == "Version*")
            {
                MessageBox.Show("Please enter a valid version!\nExample: 1.0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (WebClient client = new WebClient())
                {
                    string zippath = Path.Combine(dialog.SelectedPath, "result.zip");
                    string extractpath = Path.Combine(dialog.SelectedPath, modid.Text);
                    client.DownloadFile("https://github.com/dreamyoe/etslightboxmaker/raw/main/Downloads/mod%20preset/mod.zip", zippath);

                    ZipFile.ExtractToDirectory(zippath, extractpath);

                    File.Delete(zippath);

                    File.WriteAllText(Path.Combine(extractpath, "moddescription.txt"), moddescription.Text);

                    string manifest = File.ReadAllText(Path.Combine(extractpath, "manifest.sii"));

                    manifest = manifest.Replace("packname", modname.Text);
                    manifest = manifest.Replace("packauthor", modauthor.Text);
                    manifest = manifest.Replace("packversion", modversion.Text);

                    File.WriteAllText(Path.Combine(extractpath, "manifest.sii"), manifest);

                    if (ModMaker.selectedTruck == "Scania R 2009")
                    {
                        Directory.Delete(Path.Combine(extractpath, "vehicle/truck/upgrade/roofgrill/scania_streamline"), true);
                        Directory.Delete(Path.Combine(extractpath, "vehicle/truck/upgrade/roofgrill/volvo_fh16_2009"), true);
                        Directory.Delete(Path.Combine(extractpath, "vehicle/truck/upgrade/roofgrill/volvo_fh16_2012"), true);

                        Directory.Delete(Path.Combine(extractpath, "def/vehicle/truck/scania.streamline"), true);
                        Directory.Delete(Path.Combine(extractpath, "def/vehicle/truck/volvo.fh16"), true);
                        Directory.Delete(Path.Combine(extractpath, "def/vehicle/truck/volvo.fh16_2012"), true);

                        File.Replace(ddsPath, Path.Combine(extractpath, "vehicle/truck/upgrade/roofgrill/scania_rcab_2009/textures/dd-light.dds"), Path.Combine(extractpath, "vehicle/truck/upgrade/roofgrill/scania_rcab_2009/textures/dd-light_OLD.dds"));
                    }

                    if (ModMaker.selectedTruck == "Scania Streamline")
                    {
                        Directory.Delete(Path.Combine(extractpath, "vehicle/truck/upgrade/roofgrill/scania_rcab_2009"), true);
                        Directory.Delete(Path.Combine(extractpath, "vehicle/truck/upgrade/roofgrill/volvo_fh16_2009"), true);
                        Directory.Delete(Path.Combine(extractpath, "vehicle/truck/upgrade/roofgrill/volvo_fh16_2012"), true);

                        Directory.Delete(Path.Combine(extractpath, "def/vehicle/truck/scania_rcab_2009"), true);
                        Directory.Delete(Path.Combine(extractpath, "def/vehicle/truck/volvo.fh16"), true);
                        Directory.Delete(Path.Combine(extractpath, "def/vehicle/truck/volvo.fh16_2012"), true);

                        File.Replace(ddsPath, Path.Combine(extractpath, "vehicle/truck/upgrade/roofgrill/scania_streamline/textures/dd-light.dds"), Path.Combine(extractpath, "vehicle/truck/upgrade/roofgrill/scania_streamline/textures/dd-light_OLD.dds"));
                    }

                    if (ModMaker.selectedTruck == "Volvo FH16 2009")
                    {
                        Directory.Delete(Path.Combine(extractpath, "vehicle/truck/upgrade/roofgrill/scania_rcab_2009"), true);
                        Directory.Delete(Path.Combine(extractpath, "vehicle/truck/upgrade/roofgrill/scania_streamline"), true);
                        Directory.Delete(Path.Combine(extractpath, "vehicle/truck/upgrade/roofgrill/volvo_fh16_2012"), true);

                        Directory.Delete(Path.Combine(extractpath, "def/vehicle/truck/scania_rcab_2009"), true);
                        Directory.Delete(Path.Combine(extractpath, "def/vehicle/truck/scania.streamline"), true);
                        Directory.Delete(Path.Combine(extractpath, "def/vehicle/truck/volvo.fh16_2012"), true);

                        File.Replace(ddsPath, Path.Combine(extractpath, "vehicle/truck/upgrade/roofgrill/volvo_fh16_2009/textures/dd-light.dds"), Path.Combine(extractpath, "vehicle/truck/upgrade/roofgrill/volvo_fh16_2009/textures/dd-light_OLD.dds"));
                    }

                    if (ModMaker.selectedTruck == "Volvo FH16 2012")
                    {
                        Directory.Delete(Path.Combine(extractpath, "vehicle/truck/upgrade/roofgrill/scania_rcab_2009"), true);
                        Directory.Delete(Path.Combine(extractpath, "vehicle/truck/upgrade/roofgrill/scania_streamline"), true);
                        Directory.Delete(Path.Combine(extractpath, "vehicle/truck/upgrade/roofgrill/volvo_fh16_2009"), true);

                        Directory.Delete(Path.Combine(extractpath, "def/vehicle/truck/scania_rcab_2009"), true);
                        Directory.Delete(Path.Combine(extractpath, "def/vehicle/truck/scania.streamline"), true);
                        Directory.Delete(Path.Combine(extractpath, "def/vehicle/truck/volvo.fh16"), true);

                        File.Replace(ddsPath, Path.Combine(extractpath, "vehicle/truck/upgrade/roofgrill/volvo_fh16_2012/textures/dd-light.dds"), Path.Combine(extractpath, "vehicle/truck/upgrade/roofgrill/volvo_fh16_2012/textures/dd-light_OLD.dds"));
                    }
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show("There was an critical error generating your mod:\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            MessageBox.Show("Successfully generated mod!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
