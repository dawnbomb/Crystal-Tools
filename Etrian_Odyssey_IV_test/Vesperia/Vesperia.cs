using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Etrian_Odyssey_IV_test
{
    public partial class FormVesperia : Form
    {
        public FormVesperia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Enemy Editor
        {
            if (File.Exists(Properties.Settings.Default.VesperiaData64 + "\\Data64\\btl.svo"))
            {
                FormVesperiaEnemyEditor f2 = new FormVesperiaEnemyEditor(); //Create the new form
                f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
                f2.Location = this.Location; //Create the new window at the same location as current one
                f2.Show(); //Show the new window
                this.Close(); //Close the current window
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The mod directory is not set");
            }
        }

        private void button2_Click(object sender, EventArgs e) //Items and Equipment Editor
        {
            if (File.Exists(Properties.Settings.Default.VesperiaData64 + "\\Data64\\item.svo"))
            {
                FormVesperiaItem f2 = new FormVesperiaItem(); //Create the new form
                f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
                f2.Location = this.Location; //Create the new window at the same location as current one
                f2.Show(); //Show the new window
                this.Close(); //Close the current window
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The mod directory is not set");
            }
        }

        private void button4_Click(object sender, EventArgs e) //Arte Editor
        {
            if (File.Exists(Properties.Settings.Default.VesperiaData64 + "\\Data64\\btl.svo"))
            {
                FormVesperiaArteEditor f2 = new FormVesperiaArteEditor(); //Create the new form
                f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
                f2.Location = this.Location; //Create the new window at the same location as current one
                f2.Show(); //Show the new window
                this.Close(); //Close the current window
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The mod directory is not set");
            }
        }

        private void button6_Click(object sender, EventArgs e) //Skill Editor
        {
            if (File.Exists(Properties.Settings.Default.VesperiaData64 + "\\Data64\\btl.svo"))
            {
                FormVesperiaSkillEditor f2 = new FormVesperiaSkillEditor(); //Create the new form
                f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
                f2.Location = this.Location; //Create the new window at the same location as current one
                f2.Show(); //Show the new window
                this.Close(); //Close the current window
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The mod directory is not set");
            }
        }



        private void button5_Click(object sender, EventArgs e) //Set Data64 Directory
        {
            //System.Windows.Forms.MessageBox.Show("Please select the romfs folder. This makes it so everything you need automatically loads inside Etrian Editor, and it will remember this directory. For the best modding experience: You can right click the game in Citra and select Dump RomFS, then right click and open mods folder. put the dumped RomFS folder there, then select that location as the directory in Etrian Editor. This is the best because the moment you make a change in etrian editor, you can boot/restart the game, and changes will apply instantly, without moving any files. However, this means you should be diligent about keeping backups yourself!");



            CommonOpenFileDialog d_LoadFolderDialog = new CommonOpenFileDialog()
            {

                IsFolderPicker = true,
                Title = "Select Vesperia's Data64 Folder"
            };
            if (d_LoadFolderDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                
                Properties.Settings.Default.VesperiaData64 = Path.GetDirectoryName(d_LoadFolderDialog.FileName);
                Properties.Settings.Default.Save();

               

            }


        }

        private void button3_Click(object sender, EventArgs e) //Clear data64 Directory
        {
            Properties.Settings.Default.VesperiaData64 = "";
            Properties.Settings.Default.Save();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Gamefaqs Link
        {
            System.Diagnostics.Process.Start("https://gamefaqs.gamespot.com/boards/241013-tales-of-vesperia-definitive-edition");
        }

        
    }
}
