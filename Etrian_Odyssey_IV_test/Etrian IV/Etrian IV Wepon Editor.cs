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
    public partial class FormIVWep : Form
    {

        String treeloaded = "No";
        byte[] enemydata_array; //This starts the array, the name after is what i name this array?
        public FormIVWep()
        {
            InitializeComponent();
            string enemydata_path = Properties.Settings.Default.EOIVRomFS + "\\romfs\\00040000000BD300\\Item\\equipitemtable.tbl";     //This defines the path as a string, so i can refer to it by this string/name instead of the full path every time
            int enemydata_length = (int)(new FileInfo(enemydata_path).Length);   //The leagth of the array?
            enemydata_array = File.ReadAllBytes(enemydata_path);  //loads an array with whatever is in the path

            //Add the EO1 Weapon list to the in editor list of weapon names (I am trusting terrence data dump, BLANKs may not be actually BLANK
            weaponTree.Nodes.Add("Shortsword");
            weaponTree.Nodes.Add("Kopis");
            weaponTree.Nodes.Add("Scramasax");
            weaponTree.Nodes.Add("Cutlass");
            weaponTree.Nodes.Add("Shamshir");
            weaponTree.Nodes.Add("Talwaar");
            weaponTree.Nodes.Add("Macuahuitl");
            weaponTree.Nodes.Add("Viking Sword");
            weaponTree.Nodes.Add("Walloon Sword");
            weaponTree.Nodes.Add("Falchion");
            weaponTree.Nodes.Add("Bastard Sword");
            weaponTree.Nodes.Add("Schiavona");
            weaponTree.Nodes.Add("Katzbalger");
            weaponTree.Nodes.Add("Macabuin");
            weaponTree.Nodes.Add("Dvergr Sword");
            weaponTree.Nodes.Add("Hrunting");
            weaponTree.Nodes.Add("Caladbolg");
            weaponTree.Nodes.Add("Dragonbane");
            weaponTree.Nodes.Add("Yggdrasil Sword");
            weaponTree.Nodes.Add("King Slicer");
            weaponTree.Nodes.Add("Escape Sword");
            weaponTree.Nodes.Add("Wiglaf Sword");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("Poison Blade");
            weaponTree.Nodes.Add("Falx");
            weaponTree.Nodes.Add("Harpe");
            weaponTree.Nodes.Add("Icy Almace");
            weaponTree.Nodes.Add("Durandal");
            weaponTree.Nodes.Add("Cavalier Killer");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("Ancient Kopis");
            weaponTree.Nodes.Add("Ancient Schiavona");
            weaponTree.Nodes.Add("Rare Sword10");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("Wakizashi");
            weaponTree.Nodes.Add("Uchigatana");
            weaponTree.Nodes.Add("Warabite");
            weaponTree.Nodes.Add("Dangosashi");
            weaponTree.Nodes.Add("Kumo Otoshi");
            weaponTree.Nodes.Add("Kijin Daiou");
            weaponTree.Nodes.Add("Ichimonji");
            weaponTree.Nodes.Add("Nenekirimaru");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("Ameno Habakiri");
            weaponTree.Nodes.Add("Yggdrasil Reitou");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("Mumeitou");
            weaponTree.Nodes.Add("Nikkari");
            weaponTree.Nodes.Add("Monohoshizao");
            weaponTree.Nodes.Add("Kotegiri");
            weaponTree.Nodes.Add("Youtou Nihiru");
            weaponTree.Nodes.Add("Rare Sword06");
            weaponTree.Nodes.Add("Rare Sword07");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("DUMMY");
            weaponTree.Nodes.Add("Imperial Blade");
            weaponTree.Nodes.Add("Peacemaker");
            weaponTree.Nodes.Add("Dragoon");
            weaponTree.Nodes.Add("Shiden");
            weaponTree.Nodes.Add("Fomalhaut");
            weaponTree.Nodes.Add("Yggdrasil Prince");
            weaponTree.Nodes.Add("A drive blade07");
            weaponTree.Nodes.Add("A drive blade08");
            weaponTree.Nodes.Add("A drive blade09");
            weaponTree.Nodes.Add("A drive blade10");
            weaponTree.Nodes.Add("A drive blade11");
            weaponTree.Nodes.Add("A drive blade12");
            weaponTree.Nodes.Add("A drive blade13");
            weaponTree.Nodes.Add("A drive blade14");
            weaponTree.Nodes.Add("A drive blade15");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Shiden EX");
            weaponTree.Nodes.Add("Reppu");
            weaponTree.Nodes.Add("Paralyzer");
            weaponTree.Nodes.Add("Rare Drive Sword04");
            weaponTree.Nodes.Add("Rare Drive Sword05");
            weaponTree.Nodes.Add("Rare Drive Sword06");
            weaponTree.Nodes.Add("Rare Drive Sword07");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("ダミー");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dagger");
            weaponTree.Nodes.Add("Makiri");
            weaponTree.Nodes.Add("Pugio");
            weaponTree.Nodes.Add("Balisong");
            weaponTree.Nodes.Add("Machete");
            weaponTree.Nodes.Add("Spatha");
            weaponTree.Nodes.Add("Ballock Knife");
            weaponTree.Nodes.Add("Ring Dagger");
            weaponTree.Nodes.Add("Kunai");
            weaponTree.Nodes.Add("Jamadhar");
            weaponTree.Nodes.Add("Parazonium");
            weaponTree.Nodes.Add("Aikuchi");
            weaponTree.Nodes.Add("Dirk");
            weaponTree.Nodes.Add("Baselard");
            weaponTree.Nodes.Add("Kukuri");
            weaponTree.Nodes.Add("Khanjar");
            weaponTree.Nodes.Add("Liuyedao");
            weaponTree.Nodes.Add("Futsuno Mitama");
            weaponTree.Nodes.Add("Yggdrasil Knife");
            weaponTree.Nodes.Add("Surgical Scalpel");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Main Gauche");
            weaponTree.Nodes.Add("Sanctus");
            weaponTree.Nodes.Add("Sonic Dagger");
            weaponTree.Nodes.Add("Keris");
            weaponTree.Nodes.Add("Ancient Makiri");
            weaponTree.Nodes.Add("Narcoleps");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Stun Knife");
            weaponTree.Nodes.Add("Epetam");
            weaponTree.Nodes.Add("Ancient Kunai");
            weaponTree.Nodes.Add("Assassin Dagger");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Fleuret");
            weaponTree.Nodes.Add("Panzerstecher");
            weaponTree.Nodes.Add("Town Sword");
            weaponTree.Nodes.Add("Pallasch");
            weaponTree.Nodes.Add("Pigsticker");
            weaponTree.Nodes.Add("Rapier");
            weaponTree.Nodes.Add("Espada Ropera");
            weaponTree.Nodes.Add("Verdun");
            weaponTree.Nodes.Add("Stiletto");
            weaponTree.Nodes.Add("Moralltach");
            weaponTree.Nodes.Add("Estoc");
            weaponTree.Nodes.Add("Misericorde");
            weaponTree.Nodes.Add("Colichemarde");
            weaponTree.Nodes.Add("Zirah Bouk");
            weaponTree.Nodes.Add("Egeking");
            weaponTree.Nodes.Add("Struggle");
            weaponTree.Nodes.Add("Last Estoc");
            weaponTree.Nodes.Add("Fragarach");
            weaponTree.Nodes.Add("Yggdrasil Rapier");
            weaponTree.Nodes.Add("Ancient Rapier");
            weaponTree.Nodes.Add("Acupuncture Pin");
            weaponTree.Nodes.Add("Matador Rapier");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Blinding Piercer");
            weaponTree.Nodes.Add("Sting");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Joyeuse");
            weaponTree.Nodes.Add("Hauteclaire");
            weaponTree.Nodes.Add("Panic Fleuret");
            weaponTree.Nodes.Add("Ascalon");
            weaponTree.Nodes.Add("Ancient Estoc");
            weaponTree.Nodes.Add("Flamberge");
            weaponTree.Nodes.Add("Rare Rapier10");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Wood Bow");
            weaponTree.Nodes.Add("Beast Bow");
            weaponTree.Nodes.Add("Short Bow");
            weaponTree.Nodes.Add("Recurve Bow");
            weaponTree.Nodes.Add("Hindi");
            weaponTree.Nodes.Add("Kamatha");
            weaponTree.Nodes.Add("Long Bow");
            weaponTree.Nodes.Add("Hunter Bow");
            weaponTree.Nodes.Add("Fin Bow");
            weaponTree.Nodes.Add("Higoyumi");
            weaponTree.Nodes.Add("Gendawa");
            weaponTree.Nodes.Add("Aquael");
            weaponTree.Nodes.Add("War Bow");
            weaponTree.Nodes.Add("Sigurd's Bow");
            weaponTree.Nodes.Add("Zamiel Bow");
            weaponTree.Nodes.Add("Shidgedou");
            weaponTree.Nodes.Add("Tristan's Bow");
            weaponTree.Nodes.Add("Yggdrasil Bow");
            weaponTree.Nodes.Add("Ancient Hindi");
            weaponTree.Nodes.Add("Quintet Bow");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Arm Shooter");
            weaponTree.Nodes.Add("Tension Bow");
            weaponTree.Nodes.Add("Apollo");
            weaponTree.Nodes.Add("Heaven Bow");
            weaponTree.Nodes.Add("Raijoudou");
            weaponTree.Nodes.Add("Yumiyawata");
            weaponTree.Nodes.Add("Sylvan Bow");
            weaponTree.Nodes.Add("Blaster");
            weaponTree.Nodes.Add("Rare Bow 09");
            weaponTree.Nodes.Add("Rare Bow10");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Light Mace");
            weaponTree.Nodes.Add("Nirrti");
            weaponTree.Nodes.Add("Crushing Club");
            weaponTree.Nodes.Add("Spiked Club");
            weaponTree.Nodes.Add("Meteor Hammer");
            weaponTree.Nodes.Add("Hex Club");
            weaponTree.Nodes.Add("Heavy Mace");
            weaponTree.Nodes.Add("Volcanic");
            weaponTree.Nodes.Add("Kanasaibou");
            weaponTree.Nodes.Add("Dramborleg");
            weaponTree.Nodes.Add("Jadagna");
            weaponTree.Nodes.Add("Langyabang");
            weaponTree.Nodes.Add("War Pick");
            weaponTree.Nodes.Add("Eliminator");
            weaponTree.Nodes.Add("Bolt Warhammer");
            weaponTree.Nodes.Add("Gennou");
            weaponTree.Nodes.Add("Yggdrasil Mace");
            weaponTree.Nodes.Add("Juncto Hammer");
            weaponTree.Nodes.Add("King Salmon");
            weaponTree.Nodes.Add("Lexxy's Hammer");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Macana");
            weaponTree.Nodes.Add("Komodo Hammer");
            weaponTree.Nodes.Add("Morgenstern");
            weaponTree.Nodes.Add("Metal Keisaku");
            weaponTree.Nodes.Add("Cataphract");
            weaponTree.Nodes.Add("Yagrush");
            weaponTree.Nodes.Add("Ancient Volcanic");
            weaponTree.Nodes.Add("Evil Eye Club");
            weaponTree.Nodes.Add("Skull Crusher");
            weaponTree.Nodes.Add("Bloody Hammer");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Wand");
            weaponTree.Nodes.Add("Bone Staff");
            weaponTree.Nodes.Add("Amud Staff");
            weaponTree.Nodes.Add("Feather Staff");
            weaponTree.Nodes.Add("Rune Wand");
            weaponTree.Nodes.Add("Fragrant Wand");
            weaponTree.Nodes.Add("Mist Rod");
            weaponTree.Nodes.Add("Wind Rod");
            weaponTree.Nodes.Add("Luck Staff");
            weaponTree.Nodes.Add("Jewel Staff");
            weaponTree.Nodes.Add("Vajra");
            weaponTree.Nodes.Add("Purple Rod");
            weaponTree.Nodes.Add("Mirage Rod");
            weaponTree.Nodes.Add("Khakkhara");
            weaponTree.Nodes.Add("Thyrsos");
            weaponTree.Nodes.Add("Arcana Rod");
            weaponTree.Nodes.Add("Sage Wand");
            weaponTree.Nodes.Add("Kerykeion");
            weaponTree.Nodes.Add("Yggdrasil Branch");
            weaponTree.Nodes.Add("Frigid Staff");
            weaponTree.Nodes.Add("Whispering Staff");
            weaponTree.Nodes.Add("Goddess Torch");
            weaponTree.Nodes.Add("Yggdrasil Baton");
            weaponTree.Nodes.Add("Dummy");
            weaponTree.Nodes.Add("Healing Wand");
            weaponTree.Nodes.Add("Old Wand");
            weaponTree.Nodes.Add("Death Wand");
            weaponTree.Nodes.Add("Ogre Vajra");
            weaponTree.Nodes.Add("Cranial Chill");
            weaponTree.Nodes.Add("Rare Wand06");
            weaponTree.Nodes.Add("Rare Wand07");
            weaponTree.Nodes.Add("Rare Wand08");
            weaponTree.Nodes.Add("Rare Wand09");
            weaponTree.Nodes.Add("Rare Wand10");



            comboBox1.Items.Add("None");
            comboBox1.Items.Add("Sword");
            comboBox1.Items.Add("Rapier");
            comboBox1.Items.Add("Mace");
            comboBox1.Items.Add("Knife");
            comboBox1.Items.Add("Staff");
            comboBox1.Items.Add("Bow"); 
            comboBox1.Items.Add("Katana");
            comboBox1.Items.Add("Drive Blade");
            comboBox1.Items.Add("777");
            


            TreeNodeCollection nodeCollect = weaponTree.Nodes;
            weaponTree.SelectedNode = nodeCollect[0];


        }

        private void FormIVWep_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            FormIV f2 = new FormIV(); //Create the new form
            f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
            f2.Location = this.Location; //Create the new window at the same location as current one
            f2.Show(); //Show the new window
            this.Close(); //Close the current window
        }

        private void weaponTree_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (treeloaded == "Yes")
            {
                //First offset INCLUDES decimal 0 (so Row leagth -1), row does NOT, neither does per row offset.
                Byte.TryParse(textBoxStr.Text, out byte value8); { Form1.ByteWriter(value8, enemydata_array, 63 + (weaponTree.SelectedNode.Index * 64) + 33); }//First 1 byte save
                Byte.TryParse(textBoxVit.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 63 + (weaponTree.SelectedNode.Index * 64) + 34); } 
                Byte.TryParse(textBoxAgi.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 63 + (weaponTree.SelectedNode.Index * 64) + 35); }
                Byte.TryParse(textBoxLuc.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 63 + (weaponTree.SelectedNode.Index * 64) + 36); }
                Byte.TryParse(textBoxTec.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 63 + (weaponTree.SelectedNode.Index * 64) + 37); }

                Byte.TryParse(textBoxAtk.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 63 + (weaponTree.SelectedNode.Index * 64) + 9); }

                //Byte.TryParse(textBox1.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 63 + (weaponTree.SelectedNode.Index * 64) + 1); } //weapon type

                if (comboBox1.Text == "None")        { Byte.TryParse("0", out value8); { Form1.ByteWriter(value8, enemydata_array, 63 + (weaponTree.SelectedNode.Index * 64) + 1); } }
                if (comboBox1.Text == "Sword")       { Byte.TryParse("1", out value8); { Form1.ByteWriter(value8, enemydata_array, 63 + (weaponTree.SelectedNode.Index * 64) + 1); } }
                if (comboBox1.Text == "Katana")      { Byte.TryParse("2", out value8); { Form1.ByteWriter(value8, enemydata_array, 63 + (weaponTree.SelectedNode.Index * 64) + 1); } }
                if (comboBox1.Text == "Drive Blade") { Byte.TryParse("3", out value8); { Form1.ByteWriter(value8, enemydata_array, 63 + (weaponTree.SelectedNode.Index * 64) + 1); } }
                if (comboBox1.Text == "Knife")       { Byte.TryParse("4", out value8); { Form1.ByteWriter(value8, enemydata_array, 63 + (weaponTree.SelectedNode.Index * 64) + 1); } }
                if (comboBox1.Text == "Rapier")      { Byte.TryParse("5", out value8); { Form1.ByteWriter(value8, enemydata_array, 63 + (weaponTree.SelectedNode.Index * 64) + 1); } }
                if (comboBox1.Text == "Bow")         { Byte.TryParse("6", out value8); { Form1.ByteWriter(value8, enemydata_array, 63 + (weaponTree.SelectedNode.Index * 64) + 1); } }
                if (comboBox1.Text == "777")         { Byte.TryParse("7", out value8); { Form1.ByteWriter(value8, enemydata_array, 63 + (weaponTree.SelectedNode.Index * 64) + 1); } }
                if (comboBox1.Text == "Mace")        { Byte.TryParse("8", out value8); { Form1.ByteWriter(value8, enemydata_array, 63 + (weaponTree.SelectedNode.Index * 64) + 1); } }
                if (comboBox1.Text == "Staff")       { Byte.TryParse("9", out value8); { Form1.ByteWriter(value8, enemydata_array, 63 + (weaponTree.SelectedNode.Index * 64) + 1); } }


                //UInt32.TryParse(textBoxBuy.Text, out uint value32); { Form1.ByteWriter(value32, enemydata_array, 63 + (weaponTree.SelectedNode.Index * 64) + 37); } //First 4 byte
                //UInt32.TryParse(textBoxSell.Text, out value32);  { Form1.ByteWriter(value32, enemydata_array, 63 + (weaponTree.SelectedNode.Index * 64) + 41); }
                File.WriteAllBytes(Properties.Settings.Default.EOIVRomFS + "\\romfs\\00040000000BD300\\Item\\equipitemtable.tbl", enemydata_array); //saves to the path i set, everything in the array/
            }
            else
            {
                treeloaded = "Yes";
            }
        }

        private void weaponTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBoxStr.Text = enemydata_array[63 + (weaponTree.SelectedNode.Index * 64) + 33].ToString("D");
            textBoxVit.Text = enemydata_array[63 + (weaponTree.SelectedNode.Index * 64) + 34].ToString("D");
            textBoxAgi.Text = enemydata_array[63 + (weaponTree.SelectedNode.Index * 64) + 35].ToString("D");
            textBoxLuc.Text = enemydata_array[63 + (weaponTree.SelectedNode.Index * 64) + 36].ToString("D");
            textBoxTec.Text = enemydata_array[63 + (weaponTree.SelectedNode.Index * 64) + 37].ToString("D");

            textBoxAtk.Text = enemydata_array[63 + (weaponTree.SelectedNode.Index * 64) + 9].ToString("D");

            string VarWeaponType = enemydata_array[63 + (weaponTree.SelectedNode.Index * 64) + 1].ToString("D"); //We put the hex into this string, and if the string is read, we make the text appear in the combo box.
            if (VarWeaponType == "0")   { comboBox1.SelectedIndex = comboBox1.FindStringExact("None"); }
            if (VarWeaponType == "1")   { comboBox1.SelectedIndex = comboBox1.FindStringExact("Sword");  }
            if (VarWeaponType == "2")   { comboBox1.SelectedIndex = comboBox1.FindStringExact("Katana"); } 
            if (VarWeaponType == "3")   { comboBox1.SelectedIndex = comboBox1.FindStringExact("Drive Blade"); }
            if (VarWeaponType == "4")   { comboBox1.SelectedIndex = comboBox1.FindStringExact("Knife"); }
            if (VarWeaponType == "5")   { comboBox1.SelectedIndex = comboBox1.FindStringExact("Rapier"); }
            if (VarWeaponType == "6")   { comboBox1.SelectedIndex = comboBox1.FindStringExact("Bow"); }
            if (VarWeaponType == "7")   { comboBox1.SelectedIndex = comboBox1.FindStringExact("777"); }
            if (VarWeaponType == "8")   { comboBox1.SelectedIndex = comboBox1.FindStringExact("Mace"); }
            if (VarWeaponType == "9")   { comboBox1.SelectedIndex = comboBox1.FindStringExact("Staff"); }


            //textBoxBuy.Text = BitConverter.ToUInt32(enemydata_array, 63 + (weaponTree.SelectedNode.Index * 64) + 37).ToString("D");
            //textBoxSell.Text = BitConverter.ToUInt32(enemydata_array, 63 + (weaponTree.SelectedNode.Index * 64) + 41).ToString("D");
        }

       


    }
}
