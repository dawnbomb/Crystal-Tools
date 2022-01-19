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
    public partial class FormQ2 : Form
    {
        public FormQ2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Enemy Editor
        {
            if (File.Exists(Properties.Settings.Default.PQ2RomFS + "\\EO1 Modded\\data\\Data\\Param\\EnemyData.tbb"))
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

        private void button5_Click(object sender, EventArgs e) //Set RomFS Directory
        {
            //System.Windows.Forms.MessageBox.Show("Please select the romfs folder. This makes it so everything you need automatically loads inside Etrian Editor, and it will remember this directory. For the best modding experience: You can right click the game in Citra and select Dump RomFS, then right click and open mods folder. put the dumped RomFS folder there, then select that location as the directory in Etrian Editor. This is the best because the moment you make a change in etrian editor, you can boot/restart the game, and changes will apply instantly, without moving any files. However, this means you should be diligent about keeping backups yourself!");



            CommonOpenFileDialog d_LoadFolderDialog = new CommonOpenFileDialog()
            {

                IsFolderPicker = true,
                Title = "Select Persona Q2 RomFS Folder"
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
                Properties.Settings.Default.PQ2RomFS = Path.GetDirectoryName(d_LoadFolderDialog.FileName);
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

        private void button2_Click(object sender, EventArgs e) //Clear RomFS Directory
        {
            Properties.Settings.Default.PQ2RomFS = "";
            Properties.Settings.Default.Save();
        }
    }
}
