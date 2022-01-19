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
    public partial class FormIWep : Form
    {
        String treeloaded = "No";
        byte[] enemydata_array; //This starts the array, the name after is what i name this array?
        public FormIWep()
        {
            InitializeComponent();
            string enemydata_path = Properties.Settings.Default.EOIRomFS + "\\EO1 Modded\\data\\Data\\Param\\Item.tbb";     //This defines the path as a string, so i can refer to it by this string/name instead of the full path every time
            int enemydata_length = (int)(new FileInfo(enemydata_path).Length);   //The leagth of the array?
            enemydata_array = File.ReadAllBytes(enemydata_path);  //loads an array with whatever is in the path

            //Add the EO1 Weapon list to the in editor list of weapon names (I am trusting terrence data dump, BLANKs may not be actually BLANK
            weaponTree.Nodes.Add("Knife ");
            weaponTree.Nodes.Add("Scramasax ");
            weaponTree.Nodes.Add("Dagger ");
            weaponTree.Nodes.Add("Shortsword ");
            weaponTree.Nodes.Add("Boar Spear");
            weaponTree.Nodes.Add("Broadsword ");
            weaponTree.Nodes.Add("Rapier ");
            weaponTree.Nodes.Add("Viking ");
            weaponTree.Nodes.Add("Shamshir ");
            weaponTree.Nodes.Add("Claymore ");
            weaponTree.Nodes.Add("Executor ");
            weaponTree.Nodes.Add("Katzbalger ");
            weaponTree.Nodes.Add("Steelsword ");
            weaponTree.Nodes.Add("Epee ");
            weaponTree.Nodes.Add("Last Estoc");
            weaponTree.Nodes.Add("Pattisa ");
            weaponTree.Nodes.Add("Flamberge ");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("Duergar ");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("Shinryuu ");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("Bone Axe");
            weaponTree.Nodes.Add("Hand Axe");
            weaponTree.Nodes.Add("Celtis ");
            weaponTree.Nodes.Add("Broadaxe ");
            weaponTree.Nodes.Add("Battle Axe");
            weaponTree.Nodes.Add("Biliomg ");
            weaponTree.Nodes.Add("Tabar ");
            weaponTree.Nodes.Add("Great Axe");
            weaponTree.Nodes.Add("Bardiche ");
            weaponTree.Nodes.Add("Halberd ");
            weaponTree.Nodes.Add("Wand ");
            weaponTree.Nodes.Add("Breaker ");
            weaponTree.Nodes.Add("Labyris ");
            weaponTree.Nodes.Add("Francisca ");
            weaponTree.Nodes.Add("Bhuj ");
            weaponTree.Nodes.Add("Fasces Axe");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("Flame Axe");
            weaponTree.Nodes.Add("Meteor Axe");
            weaponTree.Nodes.Add("Hatchet ");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("Staff ");
            weaponTree.Nodes.Add("Bone Staff");
            weaponTree.Nodes.Add("Bone Mace");
            weaponTree.Nodes.Add("Down Staff");
            weaponTree.Nodes.Add("Bone Flail");
            weaponTree.Nodes.Add("Gem Staff");
            weaponTree.Nodes.Add("War Mace");
            weaponTree.Nodes.Add("Luck Staff");
            weaponTree.Nodes.Add("Godendag ");
            weaponTree.Nodes.Add("Mystic Rod");
            weaponTree.Nodes.Add("Warhammer ");
            weaponTree.Nodes.Add("Arcana Rod");
            weaponTree.Nodes.Add("Sage Wand");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("Wakizashi ");
            weaponTree.Nodes.Add("Uchigatana ");
            weaponTree.Nodes.Add("Ohdachi ");
            weaponTree.Nodes.Add("Kogarasu ");
            weaponTree.Nodes.Add("Shida ");
            weaponTree.Nodes.Add("Zanmatou ");
            weaponTree.Nodes.Add("Kuzunosada ");
            weaponTree.Nodes.Add("Hachi ");
            weaponTree.Nodes.Add("Hisamemaru ");
            weaponTree.Nodes.Add("Masamune ");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("Wood Bow");
            weaponTree.Nodes.Add("Enamel Bow");
            weaponTree.Nodes.Add("Short Bow");
            weaponTree.Nodes.Add("Beast Bow");
            weaponTree.Nodes.Add("Hard Sling");
            weaponTree.Nodes.Add("Long Bow");
            weaponTree.Nodes.Add("Hindi ");
            weaponTree.Nodes.Add("Self Bow");
            weaponTree.Nodes.Add("Hunter Bow");
            weaponTree.Nodes.Add("Fin Bow");
            weaponTree.Nodes.Add("Vine Bow");
            weaponTree.Nodes.Add("Heaven Bow");
            weaponTree.Nodes.Add("Shidgedou ");
            weaponTree.Nodes.Add("War Bow");
            weaponTree.Nodes.Add("Arbalest ");
            weaponTree.Nodes.Add("Failnaught ");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("Zamiel Bow");
            weaponTree.Nodes.Add("Arc Drawer");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("Light Whip");
            weaponTree.Nodes.Add("Fang Whip");
            weaponTree.Nodes.Add("Bullwhip ");
            weaponTree.Nodes.Add("Vine Whip");
            weaponTree.Nodes.Add("Nail Whip");
            weaponTree.Nodes.Add("Edge Whip");
            weaponTree.Nodes.Add("Toxic Whip");
            weaponTree.Nodes.Add("Gum Whip");
            weaponTree.Nodes.Add("Wind Whip");
            weaponTree.Nodes.Add("Shred Whip");
            weaponTree.Nodes.Add("Sting Whip");
            weaponTree.Nodes.Add("Blade Whip");
            weaponTree.Nodes.Add("Nine Tails");
            weaponTree.Nodes.Add("Knout ");
            weaponTree.Nodes.Add("Dead Whip");
            weaponTree.Nodes.Add("Tormentor ");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("Dominator ");
            weaponTree.Nodes.Add("BLANK");
            weaponTree.Nodes.Add("Volt Whip");
            weaponTree.Nodes.Add("Thorn Whip");



            comboBox1.Items.Add("Landsknetcht");
            comboBox1.Items.Add("Paladin");
            comboBox1.Items.Add("Medic");
            comboBox1.Items.Add("Survivalist");
            comboBox1.Items.Add("Alchemist");
            comboBox1.Items.Add("Dancer");
            comboBox1.Items.Add("Dark Hunter");
            comboBox1.Items.Add("Ronin");
            comboBox1.Items.Add("Hexer");


            checkedListBox1.Items.Add("Landsknetcht");
            checkedListBox1.Items.Add("Paladin");
            checkedListBox1.Items.Add("Medic");
            checkedListBox1.Items.Add("Survivalist");
            checkedListBox1.Items.Add("Alchemist");
            checkedListBox1.Items.Add("Dancer");
            checkedListBox1.Items.Add("Dark Hunter");
            checkedListBox1.Items.Add("Ronin");
            checkedListBox1.Items.Add("Hexer");
            //checkedListBox1.SelectedItem = "Landsknetcht";
            //checkedListBox1.ThreeState = true;
            //checkedListBox1.SetItemChecked("Landsknetcht", true);
            
            
            TreeNodeCollection nodeCollect = weaponTree.Nodes;
            weaponTree.SelectedNode = nodeCollect[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormI f2 = new FormI(); //Create the new form
            f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
            f2.Location = this.Location; //Create the new window at the same location as current one
            f2.Show(); //Show the new window
            this.Close(); //Close the current window
        }

        private void FormIWep_Load(object sender, EventArgs e)
        {
            //This makes the label be transparent onto the image it is ontop of, to look stylish.
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

            labelBuy.Parent = pictureBoxBuy;
            labelBuy.BackColor = System.Drawing.Color.Transparent;
            labelBuy.Location = new Point(labelBuy.Left - pictureBoxBuy.Left, labelBuy.Top - pictureBoxBuy.Top);

            labelSell.Parent = pictureBoxSell;
            labelSell.BackColor = System.Drawing.Color.Transparent;
            labelSell.Location = new Point(labelSell.Left - pictureBoxSell.Left, labelSell.Top - pictureBoxSell.Top);

            labelAtk.Parent = pictureBoxAtk;
            labelAtk.BackColor = System.Drawing.Color.Transparent;
            labelAtk.Location = new Point(labelAtk.Left - pictureBoxAtk.Left, labelAtk.Top - pictureBoxAtk.Top);
        }


        private void button3_Click(object sender, EventArgs e) //Button Save
        {
            //First offset INCLUDES decimal 0, row does NOT, neither does per row offset.
            Byte.TryParse(textBoxStr.Text, out byte value8); { Form1.ByteWriter(value8, enemydata_array, 43 + (weaponTree.SelectedNode.Index * 44) + 28); }//First 1 byte save
            Byte.TryParse(textBoxVit.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 43 + (weaponTree.SelectedNode.Index * 44) + 29); }
            Byte.TryParse(textBoxAgi.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 43 + (weaponTree.SelectedNode.Index * 44) + 30); }
            Byte.TryParse(textBoxLuc.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 43 + (weaponTree.SelectedNode.Index * 44) + 31); }
            Byte.TryParse(textBoxTec.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 43 + (weaponTree.SelectedNode.Index * 44) + 32); }

            Byte.TryParse(textBoxAtk.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 43 + (weaponTree.SelectedNode.Index * 44) + 9); }

            UInt32.TryParse(textBoxBuy.Text, out uint value32); { Form1.ByteWriter(value32, enemydata_array, 44 + (weaponTree.SelectedNode.Index * 44) + 37); } //First 4 byte
            UInt32.TryParse(textBoxSell.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 44 + (weaponTree.SelectedNode.Index * 44) + 41); }
            File.WriteAllBytes(Properties.Settings.Default.EOIRomFS + "\\EO1 Modded\\data\\Data\\Param\\Item.tbb", enemydata_array); //saves to the path i set, everything in the array/
        }

        private void weaponTree_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (treeloaded == "Yes")
            {
                //First offset INCLUDES decimal 0 (so Row leagth -1), row does NOT, neither does per row offset.
                Byte.TryParse(textBoxStr.Text, out byte value8); { Form1.ByteWriter(value8, enemydata_array, 43 + (weaponTree.SelectedNode.Index * 44) + 28); }//First 1 byte save
                Byte.TryParse(textBoxVit.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 43 + (weaponTree.SelectedNode.Index * 44) + 29); }
                Byte.TryParse(textBoxAgi.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 43 + (weaponTree.SelectedNode.Index * 44) + 30); }
                Byte.TryParse(textBoxLuc.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 43 + (weaponTree.SelectedNode.Index * 44) + 31); }
                Byte.TryParse(textBoxTec.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 44 + (weaponTree.SelectedNode.Index * 44) + 32); }

                Byte.TryParse(textBoxAtk.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 43 + (weaponTree.SelectedNode.Index * 44) + 9); }

                UInt32.TryParse(textBoxBuy.Text, out uint value32); { Form1.ByteWriter(value32, enemydata_array, 43 + (weaponTree.SelectedNode.Index * 44) + 37); } //First 4 byte
                UInt32.TryParse(textBoxSell.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 43 + (weaponTree.SelectedNode.Index * 44) + 41); }
                File.WriteAllBytes(Properties.Settings.Default.EOIRomFS + "\\EO1 Modded\\data\\Data\\Param\\Item.tbb", enemydata_array); //saves to the path i set, everything in the array/
            }
            else
            {
                treeloaded = "Yes";
            }






        }

        private void weaponTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBoxStr.Text = enemydata_array[43 + (weaponTree.SelectedNode.Index * 44) + 28].ToString("D");
            textBoxVit.Text = enemydata_array[43 + (weaponTree.SelectedNode.Index * 44) + 29].ToString("D");
            textBoxAgi.Text = enemydata_array[43 + (weaponTree.SelectedNode.Index * 44) + 30].ToString("D");
            textBoxLuc.Text = enemydata_array[43 + (weaponTree.SelectedNode.Index * 44) + 31].ToString("D");
            textBoxTec.Text = enemydata_array[43 + (weaponTree.SelectedNode.Index * 44) + 32].ToString("D");

            textBoxAtk.Text = enemydata_array[43 + (weaponTree.SelectedNode.Index * 44) + 9].ToString("D");

            textBoxBuy.Text = BitConverter.ToUInt32(enemydata_array, 43 + (weaponTree.SelectedNode.Index * 44) + 37).ToString("D");
            textBoxSell.Text = BitConverter.ToUInt32(enemydata_array, 43 + (weaponTree.SelectedNode.Index * 44) + 41).ToString("D");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
