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
    public partial class FormQ : Form
    {
        public FormQ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Enemy Editor
        {
            if (File.Exists(Properties.Settings.Default.PQRomFS + "\\battle\\table\\enemydata.tbl"))
            {
                FormQEnemyEditor f2 = new FormQEnemyEditor(); //Create the new form
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

        private void button5_Click(object sender, EventArgs e) //Set RomFS Directory Button
        {
            //System.Windows.Forms.MessageBox.Show("Please select the romfs folder. This makes it so everything you need automatically loads inside Etrian Editor, and it will remember this directory. For the best modding experience: You can right click the game in Citra and select Dump RomFS, then right click and open mods folder. put the dumped RomFS folder there, then select that location as the directory in Etrian Editor. This is the best because the moment you make a change in etrian editor, you can boot/restart the game, and changes will apply instantly, without moving any files. However, this means you should be diligent about keeping backups yourself!");



            CommonOpenFileDialog d_LoadFolderDialog = new CommonOpenFileDialog()
            {

                IsFolderPicker = true,
                Title = "Select Persona Q RomFS Folder"
            };
            if (d_LoadFolderDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                //enemydata_list.Clear();
                //enemygraphic_list.Clear();
                //enemypassive_list.Clear();
                //Properties.Settings.Default.LastPath = Path.GetDirectoryName(d_LoadFolderDialog.FileName);
                //Properties.Settings.Default.Save();
                //string enemydata_path = d_LoadFolderDialog.FileName + "\\Enemy\\enemydata.tbl";
                //string enemygraphic_path = d_LoadFolderDialog.FileName + "\\Enemy\\enemygraphic.tbl";
                //string enemyhaveskilldata_path = d_LoadFolderDialog.FileName + "\\Enemy\\enemyhaveskilldata.tbl";
                //string enemynametable_path = d_LoadFolderDialog.FileName + "\\Enemy\\enemynametable.tbl";
                //string btlscrfiletable_path = d_LoadFolderDialog.FileName + "\\Enemy\\AI\\btlscrfiletable.tbl";
                //string useitemnametable_path = d_LoadFolderDialog.FileName + "\\Item\\useitemnametable.tbl";
                //string dictionary_enemy_explain_path = d_LoadFolderDialog.FileName + "\\InterfaceFile\\dictionary_enemy_explain.mbm";
                Properties.Settings.Default.PQRomFS = Path.GetDirectoryName(d_LoadFolderDialog.FileName);
                Properties.Settings.Default.Save();

                //string enemydata_path = d_LoadFolderDialog.FileName + "\\00040000000BD300\\Monster\\Table\\enemydata.tbl";
                //int enemydata_length = (int)(new FileInfo(enemydata_path).Length);   //The leagth of the array?
                //enemydata_array = File.ReadAllBytes(enemydata_path);  //loads an array with whatever is in the path
                //if (Properties.Settings.Default.EOIVPath != "")
                //{
                //    return Properties.Settings.Default.EOIVPath;
                //}




            }


            //string enemydata_path = d_LoadFolderDialog.FileName + "\\00040000000BD300\\Monster\\Table\\enemydata.tbl";
        }

        private void button2_Click(object sender, EventArgs e) //Clear Directory Button
        {
            Properties.Settings.Default.PQRomFS = "";
            Properties.Settings.Default.Save();
        }

        private void button3_Click(object sender, EventArgs e) //Skill Editor Button
        {
            if (File.Exists(Properties.Settings.Default.PQRomFS + "\\battle\\table\\skilltable.tbl"))
            {
                FormQSkillEditor f2 = new FormQSkillEditor(); //Create the new form
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

        private void button4_Click(object sender, EventArgs e) //Persona Editor Button
        {
            FormQPersonaEditor f2 = new FormQPersonaEditor(); //Create the new form
            f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
            f2.Location = this.Location; //Create the new window at the same location as current one
            f2.Show(); //Show the new window
            this.Close(); //Close the current window
        }

        private void FormQ_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e) //Power Spot Editor
        {
            FormQPowerSpotEditor f2 = new FormQPowerSpotEditor(); //Create the new form
            f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
            f2.Location = this.Location; //Create the new window at the same location as current one
            f2.Show(); //Show the new window
            this.Close(); //Close the current window
        }

        private void button7_Click(object sender, EventArgs e) //Button 7
        {
            System.Windows.Forms.MessageBox.Show("Step 1: Download the Persona Q Modding Toolkit. Also get the US version of persona Q, and the citra emulaitor.  " +
                "\n\nStep 2: In citra, right click the game and select DumpRomFS. " +
                "\n\nStep 3: Inside romfs is a CPK file, move this to the modding toolkit / CPK tool. Use the CPKTools unpacker feature to fully unpack it. " +
                "\n\nStep 4: Create three folders None of the names are specific, but the guide and editor will use these default names. " +
                "\n1: 'Origonal romfs', move the unpacked CPK game files here. This is a backup incase you fuck something up." +
                "\n2: 'Editor romfs', it's where files the editor modifies will go." +
                "\n3: 'Final romfs', in the toolkit move EVERYTHING from the 'empty mod' folder into this folder." +
                "\n\nStep 5: In the PQ editor (Right below this tutorial) click set romfs directory button and select the (presumably still empty) Editor romfs folder." +
                "\n\nStep 6: Clicking on any editor will tell you what files it needs to be put in the Editors romfs folder. Do so and you can now open that editor. " +
                "\n\nI recommend testing the editor with Cowardly Maya's HP, it's the first enemy in the game, and it's HP is shown in the enempedia ingame (in system / enempedia). After you have made some changes and clicked save, proceed onward." +
                "\n\nStep 7: In the modding toolkit run the CPK tool again, this time we are going to pack the Editor romfs folder. save the CPK it makes to the 'Final romfs' folder we made in step 3. The CPK must be named EXACTLY 'mod.cpk' or you will get a fatal error in step 8." +
                "\n\nStep 8: Copy the entire contents of 'Final romfs' (not the folder itself). In citra right click the game and select 'Open Mods Location'. Paste the files here, then run the game and it should work!", "Persona Q USA Rom Modding Guide");

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Skill Data
        {
            System.Diagnostics.Process.Start("https://docs.google.com/spreadsheets/d/1PX3nzCx6rWDoMECvjyAz0wOCQNUuEOpi_n8Mx8wSvsk/edit#gid=970728080");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Enemy Data
        {
        
            System.Diagnostics.Process.Start("https://docs.google.com/spreadsheets/d/1G5TS2PuGirZT2rjC_Xy0dTkDNpt7zwOw9MIGZOxBWIs/edit#gid=0");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Power Spot Data
        {
            System.Diagnostics.Process.Start("https://docs.google.com/spreadsheets/d/1GKUfjlpvXwUFkFiyhlQkiEZKgVVeCh3uxm_pSPvvEyE/edit#gid=0");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Undub
        {
             System.Diagnostics.Process.Start("https://gbatemp.net/threads/release-persona-q-undub.374428/");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Skill Card List
        {
            System.Diagnostics.Process.Start("https://gamefaqs.gamespot.com/3ds/739685-persona-q-shadow-of-the-labyrinth/faqs/70777");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Shadows List
        {
            System.Diagnostics.Process.Start("https://gamefaqs.gamespot.com/3ds/739685-persona-q-shadow-of-the-labyrinth/faqs/71197?page=6#You%20in%20Wonderland%20Shadows");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Gamefaqs Board Link
        {
            System.Diagnostics.Process.Start("https://gamefaqs.gamespot.com/boards/739685-persona-q-shadow-of-the-labyrinth");
        }

        private void button8_Click(object sender, EventArgs e) //Ai Editor
        {
            FormPQAIEditor f2 = new FormPQAIEditor(); //Create the new form
            f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
            f2.Location = this.Location; //Create the new window at the same location as current one
            f2.Show(); //Show the new window
            this.Close(); //Close the current window
        }
    }
}
