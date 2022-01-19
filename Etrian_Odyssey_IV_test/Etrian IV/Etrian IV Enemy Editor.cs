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
using Microsoft.WindowsAPICodePack.Dialogs; // used for the folder browser
//using OriginTablets.Types;

namespace Etrian_Odyssey_IV_test
{
    public partial class FormIVEnemyEditor : Form
    {
        String treeloaded = "No";
        byte[] enemydata_array; //This starts the array, the name after is what i name this array?
        public FormIVEnemyEditor()
        {
            InitializeComponent();
            //Properties.Settings.Default.EOIVPath = Path.GetDirectoryName(d_LoadFolderDialog.FileName);            
            //string enemydata_path = Properties.Settings.Default.EOIVPath;

            

            string enemydata_path = Properties.Settings.Default.EOIVRomFS + "\\romfs\\00040000000BD300\\Monster\\Table\\enemydata.tbl";
            int enemydata_length = (int)(new FileInfo(enemydata_path).Length);   //The leagth of the array?
            enemydata_array = File.ReadAllBytes(enemydata_path);


            //string enemydata_path = "D:\\__Mods made by Dawnbomb\\Etrian Editor\\Etrian_Odyssey_IV_test\\bin\\Debug\\gamefolder\\enemydata.tbl";     //This defines the path as a string, so i can refer to it by this string/name instead of the full path every time
            //int enemydata_length = (int)(new FileInfo(enemydata_path).Length);   //The leagth of the array?
            //enemydata_array = File.ReadAllBytes(enemydata_path);  //loads an array with whatever is in the path




            enemyTree.Nodes.Add("Grass Eater");
            enemyTree.Nodes.Add("Roller");
            enemyTree.Nodes.Add("Tree Rat");
            enemyTree.Nodes.Add("Mandrake");
            enemyTree.Nodes.Add("Ghost Owl");
            enemyTree.Nodes.Add("Angry Baboon");
            enemyTree.Nodes.Add("Jig Lizard");
            enemyTree.Nodes.Add("Woodfly");
            enemyTree.Nodes.Add("Big Roller");
            enemyTree.Nodes.Add("Fanged Vine");
            enemyTree.Nodes.Add("Deathstalker");
            enemyTree.Nodes.Add("Forest Frog");
            enemyTree.Nodes.Add("Hollow Roamer");
            enemyTree.Nodes.Add("Hollow Believer");
            enemyTree.Nodes.Add("War Bison");
            enemyTree.Nodes.Add("Great Lynx");
            enemyTree.Nodes.Add("Trip Mushroom");
            enemyTree.Nodes.Add("Largebill");
            enemyTree.Nodes.Add("Raging Boar");
            enemyTree.Nodes.Add("NONE");
            enemyTree.Nodes.Add("Petaloid");
            enemyTree.Nodes.Add("Black Claw");
            enemyTree.Nodes.Add("Fire Bulb");
            enemyTree.Nodes.Add("Forest Hare");
            enemyTree.Nodes.Add("Glutton Vine");
            enemyTree.Nodes.Add("Zapper Frog");
            enemyTree.Nodes.Add("Jumping Frog");
            enemyTree.Nodes.Add("Demon Hopper");
            enemyTree.Nodes.Add("Claw Bettle");
            enemyTree.Nodes.Add("Cave Bat");
            enemyTree.Nodes.Add("Magma Spawn");
            enemyTree.Nodes.Add("Glacier Spawn");
            enemyTree.Nodes.Add("Hexroot");
            enemyTree.Nodes.Add("Baboon");
            enemyTree.Nodes.Add("Venomshrrom");
            enemyTree.Nodes.Add("Maya Owl");
            enemyTree.Nodes.Add("Proto-Bot");
            enemyTree.Nodes.Add("Proto-Hunter");
            enemyTree.Nodes.Add("Flame Lynx");
            enemyTree.Nodes.Add("Flame Rat");
            enemyTree.Nodes.Add("Cursed Shroom");
            enemyTree.Nodes.Add("NONE");
            enemyTree.Nodes.Add("Eviloid");
            enemyTree.Nodes.Add("White Ape");
            enemyTree.Nodes.Add("Steel Barb");
            enemyTree.Nodes.Add("Medusa Tree");
            enemyTree.Nodes.Add("Suicide Hare");
            enemyTree.Nodes.Add("Plated Roller");
            enemyTree.Nodes.Add("Blue Wallaby");
            enemyTree.Nodes.Add("Peach Crow");
            enemyTree.Nodes.Add("Nightmare Ram");
            enemyTree.Nodes.Add("Tusked Crusher");
            enemyTree.Nodes.Add("Dragonfly");
            enemyTree.Nodes.Add("Angry Ape");
            enemyTree.Nodes.Add("Magma Beast");
            enemyTree.Nodes.Add("Glacier Beast ");
            enemyTree.Nodes.Add("Hollow Magus");
            enemyTree.Nodes.Add("Bloody Knuckle");
            enemyTree.Nodes.Add("Cruel Slayer");
            enemyTree.Nodes.Add("Venomfly");
            enemyTree.Nodes.Add("Ice Bulb");
            enemyTree.Nodes.Add("Gasser Tree");
            enemyTree.Nodes.Add("Evilroot Vampire");
            enemyTree.Nodes.Add("Bat");
            enemyTree.Nodes.Add("Clawed Mole");
            enemyTree.Nodes.Add("Curse Locust");
            enemyTree.Nodes.Add("Sleeping Lion");
            enemyTree.Nodes.Add("Flying Beetle");
            enemyTree.Nodes.Add("Beetle Lord");
            enemyTree.Nodes.Add("Purple Anoir");
            enemyTree.Nodes.Add("Stun Eryngii");
            enemyTree.Nodes.Add("Red Lion");
            enemyTree.Nodes.Add("Mad Mandrill??");
            enemyTree.Nodes.Add("Mauler Mole");
            enemyTree.Nodes.Add("Thunder Spawn");
            enemyTree.Nodes.Add("Volt Cat");
            enemyTree.Nodes.Add("Hollow Hoplite");
            enemyTree.Nodes.Add("NONE");
            enemyTree.Nodes.Add("Muskoid");
            enemyTree.Nodes.Add("Scorching Beast");
            enemyTree.Nodes.Add("Thunder Hare");
            enemyTree.Nodes.Add("Flame Rat 2");
            enemyTree.Nodes.Add("Cold Claw");
            enemyTree.Nodes.Add("Cutter");
            enemyTree.Nodes.Add("Bloodbear");
            enemyTree.Nodes.Add("Furyhorn");
            enemyTree.Nodes.Add("Furyfawn");
            enemyTree.Nodes.Add("Dinogator");
            enemyTree.Nodes.Add("Bounding Beast");
            enemyTree.Nodes.Add("Greedy Lizard");
            enemyTree.Nodes.Add("Big Moth");
            enemyTree.Nodes.Add("Giant Moa");
            enemyTree.Nodes.Add("Spotted Drog");
            enemyTree.Nodes.Add("Dream Eater");
            enemyTree.Nodes.Add("Omnihunter");
            enemyTree.Nodes.Add("Plated Chaser");
            enemyTree.Nodes.Add("Patrol Bat");
            enemyTree.Nodes.Add("Poison Lizard");
            enemyTree.Nodes.Add("Raging Raptor");
            enemyTree.Nodes.Add("Cold Watchman");
            enemyTree.Nodes.Add("Stalking Shadow");
            enemyTree.Nodes.Add("Golden Deer");
            enemyTree.Nodes.Add("Ancient Keeper");
            enemyTree.Nodes.Add("Supreme Wing");
            enemyTree.Nodes.Add("Silent Killer");
            enemyTree.Nodes.Add("Calm King");
            enemyTree.Nodes.Add("Huge Moa");
            enemyTree.Nodes.Add("Desouler");
            enemyTree.Nodes.Add("Death Mantis");
            enemyTree.Nodes.Add("Rafflesia");
            enemyTree.Nodes.Add("Wrath Bloom");
            enemyTree.Nodes.Add("King Dragonfly");
            enemyTree.Nodes.Add("Hexground");
            enemyTree.Nodes.Add("Trigourd");
            enemyTree.Nodes.Add("Flygourd");
            enemyTree.Nodes.Add("Moth Lord");
            enemyTree.Nodes.Add("Sky Emperor");
            enemyTree.Nodes.Add("Magma Spawn");
            enemyTree.Nodes.Add("Glacier Spawn");
            enemyTree.Nodes.Add("Thunder Spawn");
            enemyTree.Nodes.Add("Magma Beast");
            enemyTree.Nodes.Add("Glacier Beast ");
            enemyTree.Nodes.Add("Nomad Baboon");
            enemyTree.Nodes.Add("Guardian Judge");
            enemyTree.Nodes.Add("Pooka");
            enemyTree.Nodes.Add("Red Pooka");
            enemyTree.Nodes.Add("Metal Pooka");
            enemyTree.Nodes.Add("Gold Pooka");
            enemyTree.Nodes.Add("Rainbow Pooka");
            enemyTree.Nodes.Add("Glacier Fiend");
            enemyTree.Nodes.Add("Mega Pooka");

            


            TreeNodeCollection nodeCollect = enemyTree.Nodes;
            enemyTree.SelectedNode = nodeCollect[0];


        }







        private void FormIVEnemyEditor_Load(object sender, EventArgs e)
        {
            //This makes the label be transparent onto the image it is ontop of, to look stylish.
            labelLv.Parent = pictureBoxLv;
            labelLv.BackColor = System.Drawing.Color.Transparent;
            labelLv.Location = new Point(labelLv.Left - pictureBoxLv.Left, labelLv.Top - pictureBoxLv.Top);

            labelExp.Parent = pictureBoxExp;
            labelExp.BackColor = System.Drawing.Color.Transparent;
            labelExp.Location = new Point(labelExp.Left - pictureBoxExp.Left, labelExp.Top - pictureBoxExp.Top);

            labelStr.Parent = pictureBoxStr;
            labelStr.BackColor = System.Drawing.Color.Transparent;
            labelStr.Location = new Point(labelStr.Left - pictureBoxStr.Left, labelStr.Top - pictureBoxStr.Top);

            labelVit.Parent = pictureBoxVit;
            labelVit.BackColor = System.Drawing.Color.Transparent;
            labelVit.Location = new Point(labelVit.Left - pictureBoxVit.Left, labelVit.Top - pictureBoxVit.Top);

            labelAgi.Parent = pictureBoxAgi;
            labelAgi.BackColor = System.Drawing.Color.Transparent;
            labelAgi.Location = new Point(labelAgi.Left - pictureBoxAgi.Left, labelAgi.Top - pictureBoxAgi.Top);

            labelLuc.Parent = pictureBoxLuc;
            labelLuc.BackColor = System.Drawing.Color.Transparent;
            labelLuc.Location = new Point(labelLuc.Left - pictureBoxLuc.Left, labelLuc.Top - pictureBoxLuc.Top);

            labelTec.Parent = pictureBoxTec;
            labelTec.BackColor = System.Drawing.Color.Transparent;
            labelTec.Location = new Point(labelTec.Left - pictureBoxTec.Left, labelTec.Top - pictureBoxTec.Top);

            labelCut.Parent = pictureBoxCut;
            labelCut.BackColor = System.Drawing.Color.Transparent;
            labelCut.Location = new Point(labelCut.Left - pictureBoxCut.Left, labelCut.Top - pictureBoxCut.Top);

            labelBash.Parent = pictureBoxBash;
            labelBash.BackColor = System.Drawing.Color.Transparent;
            labelBash.Location = new Point(labelBash.Left - pictureBoxBash.Left, labelBash.Top - pictureBoxBash.Top);

            labelStab.Parent = pictureBoxStab;
            labelStab.BackColor = System.Drawing.Color.Transparent;
            labelStab.Location = new Point(labelStab.Left - pictureBoxStab.Left, labelStab.Top - pictureBoxStab.Top);

            labelFire.Parent = pictureBoxFire;
            labelFire.BackColor = System.Drawing.Color.Transparent;
            labelFire.Location = new Point(labelFire.Left - pictureBoxFire.Left, labelFire.Top - pictureBoxFire.Top);

            labelIce.Parent = pictureBoxIce;
            labelIce.BackColor = System.Drawing.Color.Transparent;
            labelIce.Location = new Point(labelIce.Left - pictureBoxIce.Left, labelIce.Top - pictureBoxIce.Top);

            labelVolt.Parent = pictureBoxVolt;
            labelVolt.BackColor = System.Drawing.Color.Transparent;
            labelVolt.Location = new Point(labelVolt.Left - pictureBoxVolt.Left, labelVolt.Top - pictureBoxVolt.Top);

            labelDeath.Parent = pictureBoxDeath;
            labelDeath.BackColor = System.Drawing.Color.Transparent;
            labelDeath.Location = new Point(labelDeath.Left - pictureBoxDeath.Left, labelDeath.Top - pictureBoxDeath.Top);

            labelOther.Parent = pictureBoxOther;
            labelOther.BackColor = System.Drawing.Color.Transparent;
            labelOther.Location = new Point(labelOther.Left - pictureBoxOther.Left, labelOther.Top - pictureBoxOther.Top);

            labelStone.Parent = pictureBoxStone;
            labelStone.BackColor = System.Drawing.Color.Transparent;
            labelStone.Location = new Point(labelStone.Left - pictureBoxStone.Left, labelStone.Top - pictureBoxStone.Top);

            labelPanic.Parent = pictureBoxPanic;
            labelPanic.BackColor = System.Drawing.Color.Transparent;
            labelPanic.Location = new Point(labelPanic.Left - pictureBoxPanic.Left, labelPanic.Top - pictureBoxPanic.Top);

            labelSleep.Parent = pictureBoxSleep;
            labelSleep.BackColor = System.Drawing.Color.Transparent;
            labelSleep.Location = new Point(labelSleep.Left - pictureBoxSleep.Left, labelSleep.Top - pictureBoxSleep.Top);

            labelPsn.Parent = pictureBoxPsn;
            labelPsn.BackColor = System.Drawing.Color.Transparent;
            labelPsn.Location = new Point(labelPsn.Left - pictureBoxPsn.Left, labelPsn.Top - pictureBoxPsn.Top);

            labelBlind.Parent = pictureBoxBlind;
            labelBlind.BackColor = System.Drawing.Color.Transparent;
            labelBlind.Location = new Point(labelBlind.Left - pictureBoxBlind.Left, labelBlind.Top - pictureBoxBlind.Top);

            labelCurse.Parent = pictureBoxCurse;
            labelCurse.BackColor = System.Drawing.Color.Transparent;
            labelCurse.Location = new Point(labelCurse.Left - pictureBoxCurse.Left, labelCurse.Top - pictureBoxCurse.Top);

            labelPara.Parent = pictureBoxPara;
            labelPara.BackColor = System.Drawing.Color.Transparent;
            labelPara.Location = new Point(labelPara.Left - pictureBoxPara.Left, labelPara.Top - pictureBoxPara.Top);

            labelStun.Parent = pictureBoxStun;
            labelStun.BackColor = System.Drawing.Color.Transparent;
            labelStun.Location = new Point(labelStun.Left - pictureBoxStun.Left, labelStun.Top - pictureBoxStun.Top);

            labelFear.Parent = pictureBoxFear;
            labelFear.BackColor = System.Drawing.Color.Transparent;
            labelFear.Location = new Point(labelFear.Left - pictureBoxFear.Left, labelFear.Top - pictureBoxFear.Top);

            labelHead.Parent = pictureBoxHead;
            labelHead.BackColor = System.Drawing.Color.Transparent;
            labelHead.Location = new Point(labelHead.Left - pictureBoxHead.Left, labelHead.Top - pictureBoxHead.Top);

            labelArm.Parent = pictureBoxArm;
            labelArm.BackColor = System.Drawing.Color.Transparent;
            labelArm.Location = new Point(labelArm.Left - pictureBoxArm.Left, labelArm.Top - pictureBoxArm.Top);

            labelLeg.Parent = pictureBoxLeg;
            labelLeg.BackColor = System.Drawing.Color.Transparent;
            labelLeg.Location = new Point(labelLeg.Left - pictureBoxLeg.Left, labelLeg.Top - pictureBoxLeg.Top);

        }





        private void button3_Click(object sender, EventArgs e) //Etrian V Button
        {
            FormIV f2 = new FormIV(); //Create the new form
            f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
            f2.Location = this.Location; //Create the new window at the same location as current one
            f2.Show(); //Show the new window
            this.Close(); //Close the current window

        }


        
        private void button1_Click_1(object sender, EventArgs e) //Button Save
        {
            //B! .TryParse(Name! .Text, out type! value! ); { Form1.ByteWriter( value! , enemydata_array, StartingHex! + (treeView1.SelectedNode.Index * RowSize! ) + ArrayOfset! ); }
            //B=Byte size, 1="Byte" 2="UInt16" 4="UInt32"         Name!=the name of the textbox        type!= byte / ushort / uint, only include this in the FIRST time this ever happens in a form, later copies ommit this!
            //value!=Name of variable that holds the byte type (so byte/short/int has diffrent names)       StartingHex!= The hex offset      RowSize!=How many bytes in a row    Arrayofset! = how far into the row do we start grabbing info or saving it
            Byte.TryParse(textBoxLv.Text, out byte value8); { Form1.ByteWriter(value8, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 1); } //First 1 byte save
            UInt32.TryParse(textBoxExp.Text, out uint value32); { Form1.ByteWriter(value32, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 5); } //First 4 byte save
            UInt16.TryParse(textBoxOther.Text, out ushort value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 3); } //First 2 byte save

            UInt16.TryParse(textBoxStr.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 25); } 
            UInt16.TryParse(textBoxVit.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 27); }
            UInt16.TryParse(textBoxAgi.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 29); }
            UInt16.TryParse(textBoxLuc.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 31); }
            UInt16.TryParse(textBoxTec.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 33); }

            UInt16.TryParse(textBoxCut.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 41); }
            UInt16.TryParse(textBoxStab.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 43); }
            UInt16.TryParse(textBoxBash.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 45); }
            UInt16.TryParse(textBoxFire.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 47); }
            UInt16.TryParse(textBoxIce.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 49); }
            UInt16.TryParse(textBoxVolt.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 51); }

            UInt16.TryParse(textBoxDeath.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 53); } //Unused in EO4
            
            UInt16.TryParse(textBoxHead.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 73); }
            UInt16.TryParse(textBoxArm.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 75); }
            UInt16.TryParse(textBoxLeg.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 77); }

            UInt16.TryParse(textBoxStone.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 55); }
            UInt16.TryParse(textBoxSleep.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 57); }
            UInt16.TryParse(textBoxPanic.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 59); }
            UInt16.TryParse(textBoxPsn.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 63); }
            UInt16.TryParse(textBoxBlind.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 65); }
            UInt16.TryParse(textBoxCurse.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 67); }
            UInt16.TryParse(textBoxPara.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 69); }
            UInt16.TryParse(textBoxStun.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 71); }
            UInt16.TryParse(textBoxFear.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 79); }

            File.WriteAllBytes(Properties.Settings.Default.EOIVRomFS + "\\romfs\\00040000000BD300\\Monster\\Table\\enemydata.tbl", enemydata_array); //saves to the path i set, everything in the array/

        }


        /*
        private void button4_Click(object sender, EventArgs e) // LOAD DIRECTORY
        {
            
            CommonOpenFileDialog d_LoadFolderDialog = new CommonOpenFileDialog()
            {
                
                IsFolderPicker = true,
                Title = "Select Etrian Odyssey III Data folder"
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

                Properties.Settings.Default.EOIVRomFS = Path.GetDirectoryName(d_LoadFolderDialog.FileName);
                Properties.Settings.Default.Save();
                string enemydata_path = Properties.Settings.Default.EOIVRomFS + "\\romfs\\00040000000BD300\\Monster\\Table\\enemydata.tbl";
                int enemydata_length = (int)(new FileInfo(enemydata_path).Length);   //The leagth of the array?
                enemydata_array = File.ReadAllBytes(enemydata_path);

                //string enemydata_path = d_LoadFolderDialog.FileName + "\\00040000000BD300\\Monster\\Table\\enemydata.tbl";
                //int enemydata_length = (int)(new FileInfo(enemydata_path).Length);   //The leagth of the array?
                //enemydata_array = File.ReadAllBytes(enemydata_path);  //loads an array with whatever is in the path
                //if (Properties.Settings.Default.EOIVPath != "")
                //{
                //    return Properties.Settings.Default.EOIVPath;
                //}




            }

        }
        */

        private void enemyTree_AfterSelect(object sender, TreeViewEventArgs e) //Trigger: After select anything on tree - Loads enemy info
        {

            


            //First offset INCLUDES decimal 0, row does NOT, neither does per row offset.
            textBoxLv.Text = enemydata_array[99 + (enemyTree.SelectedNode.Index * 100) + 1].ToString("D");
            textBoxExp.Text =   BitConverter.ToUInt32(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 5).ToString("D");
            textBoxOther.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 3).ToString("D"); //Codex Entry

            textBoxStr.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 25).ToString("D");   //Makes the array Hexes appear as Decimal (Numbers). D Means Decimal, X is hex, 2 is to display 2 digits (this is one byte, more bytes need more respectively?) 
            textBoxVit.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 27).ToString("D");
            textBoxAgi.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 29).ToString("D"); //Core Stats
            textBoxLuc.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 31).ToString("D");
            textBoxTec.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 33).ToString("D");

            textBoxCut.Text =  BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 41).ToString("D");
            textBoxStab.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 43).ToString("D"); //Damage Resistances
            textBoxBash.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 45).ToString("D");
            textBoxFire.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 47).ToString("D");
            textBoxIce.Text =  BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 49).ToString("D");
            textBoxVolt.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 51).ToString("D");

            textBoxDeath.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 53).ToString("D");
            textBoxHead.Text =  BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 73).ToString("D"); //Ailment Resistances
            textBoxArm.Text =   BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 75).ToString("D");
            textBoxLeg.Text =   BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 77).ToString("D");

            textBoxStone.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 55).ToString("D");
            textBoxSleep.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 57).ToString("D");
            textBoxPanic.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 59).ToString("D");
            textBoxPsn.Text =   BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 63).ToString("D");
            textBoxBlind.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 65).ToString("D");
            textBoxCurse.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 67).ToString("D");
            textBoxPara.Text =  BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 69).ToString("D");
            textBoxStun.Text =  BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 71).ToString("D");
            textBoxFear.Text =  BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 79).ToString("D");
        }

        private void enemyTree_BeforeSelect(object sender, TreeViewCancelEventArgs e)//Trigger: Before select anything on tree - Loads enemy info   //Before we select the tree, we save everything, unless its the first time a enemy is loaded
        {
            if (treeloaded == "Yes")
            {
            
            //B! .TryParse(Name! .Text, out type! value! ); { Form1.ByteWriter( value! , enemydata_array, StartingHex! + (treeView1.SelectedNode.Index * RowSize! ) + ArrayOfset! ); }
            //B=Byte size, 1="Byte" 2="UInt16" 4="UInt32"         Name!=the name of the textbox        type!= byte / ushort / uint, only include this in the FIRST time this ever happens in a form, later copies ommit this!
            //value!=Name of variable that holds the byte type (so byte/short/int has diffrent names)       StartingHex!= The hex offset      RowSize!=How many bytes in a row    Arrayofset! = how far into the row do we start grabbing info or saving it
            Byte.TryParse(textBoxLv.Text,          out byte value8); { Form1.ByteWriter(value8, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 1); } //First 1 byte save
            UInt32.TryParse(textBoxExp.Text,     out uint value32); { Form1.ByteWriter(value32, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 5); } //First 4 byte save
            UInt16.TryParse(textBoxOther.Text, out ushort value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 3); } //First 2 byte save

            UInt16.TryParse(textBoxStr.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 25); } 
            UInt16.TryParse(textBoxVit.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 27); }
            UInt16.TryParse(textBoxAgi.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 29); }
            UInt16.TryParse(textBoxLuc.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 31); }
            UInt16.TryParse(textBoxTec.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 33); }

            UInt16.TryParse(textBoxCut.Text,  out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 41); }
            UInt16.TryParse(textBoxStab.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 43); }
            UInt16.TryParse(textBoxBash.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 45); }
            UInt16.TryParse(textBoxFire.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 47); }
            UInt16.TryParse(textBoxIce.Text,  out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 49); }
            UInt16.TryParse(textBoxVolt.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 51); }

            UInt16.TryParse(textBoxDeath.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 53); } //Unused in EO4 
            
            UInt16.TryParse(textBoxHead.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 73); }
            UInt16.TryParse(textBoxArm.Text,  out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 75); }
            UInt16.TryParse(textBoxLeg.Text,  out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 77); }

            UInt16.TryParse(textBoxStone.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 55); }
            UInt16.TryParse(textBoxSleep.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 57); }
            UInt16.TryParse(textBoxPanic.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 59); }
            UInt16.TryParse(textBoxPsn.Text,   out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 63); }
            UInt16.TryParse(textBoxBlind.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 65); }
            UInt16.TryParse(textBoxCurse.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 67); }
            UInt16.TryParse(textBoxPara.Text,  out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 69); }
            UInt16.TryParse(textBoxStun.Text,  out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 71); }
            UInt16.TryParse(textBoxFear.Text,  out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 79); }

            File.WriteAllBytes(Properties.Settings.Default.EOIVRomFS + "\\romfs\\00040000000BD300\\Monster\\Table\\enemydata.tbl", enemydata_array); //saves to the path i set, everything in the array/
            }
            else
            {
                treeloaded = "Yes";
            }
                        
        }
    }
}
