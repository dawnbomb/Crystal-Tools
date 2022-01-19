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
    public partial class FormI : Form
    {
        public FormI()
        {
            InitializeComponent();
        }

		

	private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(Properties.Settings.Default.EOIRomFS + "\\EO1 Modded\\data\\Data\\Param\\EnemyData.tbb"))
            {
                FormIEnemyEditor f2 = new FormIEnemyEditor(); //Create the new form
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

        private void FormI_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //Button Level Scaling Editor
        {
            FormILvScale f2 = new FormILvScale(); //Create the new form
            f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
            f2.Location = this.Location; //Create the new window at the same location as current one
            f2.Show(); //Show the new window
            this.Close(); //Close the current window
        }

        private void button3_Click(object sender, EventArgs e) // Button Weapon Editor
        {
            FormIWep f2 = new FormIWep(); //Create the new form
            f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
            f2.Location = this.Location; //Create the new window at the same location as current one
            f2.Show(); //Show the new window
            this.Close(); //Close the current window
        }

        private void button4_Click(object sender, EventArgs e) // Button Armor Editor
        {
            FormIArmor f2 = new FormIArmor(); //Create the new form
            f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
            f2.Location = this.Location; //Create the new window at the same location as current one
            f2.Show(); //Show the new window
            this.Close(); //Close the current window
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }



        private void button5_Click(object sender, EventArgs e) //Button Set I Directory
        {
            CommonOpenFileDialog d_LoadFolderDialog = new CommonOpenFileDialog()
            {

                IsFolderPicker = true,
                Title = "Select Etrian Odyssey IV RomFS folder"
            };
            if (d_LoadFolderDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                
                Properties.Settings.Default.EOIRomFS = Path.GetDirectoryName(d_LoadFolderDialog.FileName);
                Properties.Settings.Default.Save();

              
            }
        }





    }
}
