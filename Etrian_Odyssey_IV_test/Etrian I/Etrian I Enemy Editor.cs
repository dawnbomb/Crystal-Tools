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

namespace Etrian_Odyssey_IV_test
{
    public partial class FormIEnemyEditor : Form
    {
        String treeloaded = "No";
        byte[] enemydata_array; //This starts the array, the name after is what i name this array?
        public FormIEnemyEditor()
        {
            InitializeComponent();
            string enemydata_path = Properties.Settings.Default.EOIRomFS + "\\EO1 Modded\\data\\Data\\Param\\EnemyData.tbb"; //This defines the path as a string, so i can refer to it by this string/name instead of the full path every time
            int enemydata_length = (int)(new FileInfo(enemydata_path).Length);   //The leagth of the array?
            enemydata_array = File.ReadAllBytes(enemydata_path);  //loads an array with whatever is in the path

            //Add the EO1 enemy list to the in editor list of enemy names
            enemyTree.Nodes.Add("Wolf");
            enemyTree.Nodes.Add("Dummy");
            enemyTree.Nodes.Add("Direwolf");
            enemyTree.Nodes.Add("Treerat");
            enemyTree.Nodes.Add("Flamerat");
            enemyTree.Nodes.Add("Hare");
            enemyTree.Nodes.Add("Darkhare");
            enemyTree.Nodes.Add("Roller");
            enemyTree.Nodes.Add("Armoroll");
            enemyTree.Nodes.Add("Mole");
            enemyTree.Nodes.Add("Maul");
            enemyTree.Nodes.Add("Sloth");
            enemyTree.Nodes.Add("Dummy");
            enemyTree.Nodes.Add("Armoth");
            enemyTree.Nodes.Add("Treetusk");
            enemyTree.Nodes.Add("Fender");
            enemyTree.Nodes.Add("Goldeer");
            enemyTree.Nodes.Add("Warbull");
            enemyTree.Nodes.Add("Hellbull");
            enemyTree.Nodes.Add("Cutter");
            enemyTree.Nodes.Add("Redclaw");
            enemyTree.Nodes.Add("Desouler");
            enemyTree.Nodes.Add("Sleepgel");
            enemyTree.Nodes.Add("Venomgel");
            enemyTree.Nodes.Add("Burstgel");
            enemyTree.Nodes.Add("Flamegel");
            enemyTree.Nodes.Add("Muckdile");
            enemyTree.Nodes.Add("Kingdile");
            enemyTree.Nodes.Add("Treefrog");
            enemyTree.Nodes.Add("Hexfrog");
            enemyTree.Nodes.Add("Kingfrog");
            enemyTree.Nodes.Add("Shelltor");
            enemyTree.Nodes.Add("Shellord");
            enemyTree.Nodes.Add("Clawbug");
            enemyTree.Nodes.Add("Clawfly");
            enemyTree.Nodes.Add("Clawlord");
            enemyTree.Nodes.Add("Moriyana");
            enemyTree.Nodes.Add("Kingyana");
            enemyTree.Nodes.Add("Waspior");
            enemyTree.Nodes.Add("Kingapis");
            enemyTree.Nodes.Add("Madworm");
            enemyTree.Nodes.Add("Meltworm");
            enemyTree.Nodes.Add("Woodfly");
            enemyTree.Nodes.Add("Venomfly");
            enemyTree.Nodes.Add("Hazefly");
            enemyTree.Nodes.Add("Hellfly");
            enemyTree.Nodes.Add("Spider");
            enemyTree.Nodes.Add("Silker");
            enemyTree.Nodes.Add("Scorpion");
            enemyTree.Nodes.Add("Metalion");
            enemyTree.Nodes.Add("Deathant");
            enemyTree.Nodes.Add("Guardant");
            enemyTree.Nodes.Add("Largeant");
            enemyTree.Nodes.Add("Sickwood");
            enemyTree.Nodes.Add("Rockwood");
            enemyTree.Nodes.Add("Fangleaf");
            enemyTree.Nodes.Add("Maneater");
            enemyTree.Nodes.Add("Petaloid");
            enemyTree.Nodes.Add("Eviloid");
            enemyTree.Nodes.Add("Muskoid");
            enemyTree.Nodes.Add("Firebird");
            enemyTree.Nodes.Add("Songbird");
            enemyTree.Nodes.Add("Glowbird");
            enemyTree.Nodes.Add("Redbeak");
            enemyTree.Nodes.Add("Lucifird");
            enemyTree.Nodes.Add("Bolter");
            enemyTree.Nodes.Add("Zapper");
            enemyTree.Nodes.Add("Shocker");
            enemyTree.Nodes.Add("Shocking");
            enemyTree.Nodes.Add("Sworder");
            enemyTree.Nodes.Add("Blader");
            enemyTree.Nodes.Add("Cutcrab");
            enemyTree.Nodes.Add("Ironcrab");
            enemyTree.Nodes.Add("Dinolich");
            enemyTree.Nodes.Add("Teralich");
            enemyTree.Nodes.Add("Soldier");
            enemyTree.Nodes.Add("Warrior");
            enemyTree.Nodes.Add("Mystic");
            enemyTree.Nodes.Add("Druid");
            enemyTree.Nodes.Add("Pixie");
            enemyTree.Nodes.Add("Faerie");
            enemyTree.Nodes.Add("Ogre");
            enemyTree.Nodes.Add("Hunter");
            enemyTree.Nodes.Add("Stalker");
            enemyTree.Nodes.Add("Mantis");
            enemyTree.Nodes.Add("Moa");
            enemyTree.Nodes.Add("Immoa");
            enemyTree.Nodes.Add("Mandrake");
            enemyTree.Nodes.Add("Hexroot");
            enemyTree.Nodes.Add("Evilroot");
            enemyTree.Nodes.Add("Dummy1");
            enemyTree.Nodes.Add("Dummy2");
            enemyTree.Nodes.Add("Dummy3");
            enemyTree.Nodes.Add("Dummy4");
            enemyTree.Nodes.Add("Dummy5");
            enemyTree.Nodes.Add("Dummy6");
            enemyTree.Nodes.Add("Dummy7");
            enemyTree.Nodes.Add("Dummy8");
            enemyTree.Nodes.Add("Dummy9");
            enemyTree.Nodes.Add("Wyvern");
            enemyTree.Nodes.Add("Cernunos");
            enemyTree.Nodes.Add("Royalant");
            enemyTree.Nodes.Add("Cotrangl");
            enemyTree.Nodes.Add("Iwaopeln");
            enemyTree.Nodes.Add("Etreant");
            enemyTree.Nodes.Add("Wyrm");
            enemyTree.Nodes.Add("Drake");
            enemyTree.Nodes.Add("Alraune");
            enemyTree.Nodes.Add("Primevil");
            enemyTree.Nodes.Add("Dragon");
            enemyTree.Nodes.Add("Manticor");
            enemyTree.Nodes.Add("Golem");
            enemyTree.Nodes.Add("Ren");
            enemyTree.Nodes.Add("Tlachtga");
            enemyTree.Nodes.Add("Dummy25");
            enemyTree.Nodes.Add("Dummy26");
            enemyTree.Nodes.Add("Dummy27");
            enemyTree.Nodes.Add("Dummy28");
            enemyTree.Nodes.Add("Dummy29");
            enemyTree.Nodes.Add("Fireater");
            enemyTree.Nodes.Add("Toxinfly");
            enemyTree.Nodes.Add("Redcap");
            enemyTree.Nodes.Add("Omnivore");
            enemyTree.Nodes.Add("Steelweb");
            enemyTree.Nodes.Add("Goudarat");
            enemyTree.Nodes.Add("Curoller");
            enemyTree.Nodes.Add("Drainbat");
            enemyTree.Nodes.Add("Nightoad");
            enemyTree.Nodes.Add("Hextoad");
            enemyTree.Nodes.Add("Skoll");
            enemyTree.Nodes.Add("Phoenix");
            enemyTree.Nodes.Add("Dummy42");
            enemyTree.Nodes.Add("Dummy43");
            enemyTree.Nodes.Add("Dummy44");
            enemyTree.Nodes.Add("Dummy45");
            enemyTree.Nodes.Add("Dummy46");
            enemyTree.Nodes.Add("Dummy47");
            enemyTree.Nodes.Add("Dummy48");
            enemyTree.Nodes.Add("Dummy49");
            enemyTree.Nodes.Add("Dummy50");
            enemyTree.Nodes.Add("Dummy51");
            enemyTree.Nodes.Add("Dummy52");
            enemyTree.Nodes.Add("Dummy53");
            enemyTree.Nodes.Add("Dummy54");
            enemyTree.Nodes.Add("Dummy55");
            enemyTree.Nodes.Add("Dummy56");
            enemyTree.Nodes.Add("Dummy57");
            enemyTree.Nodes.Add("Dummy58");
            enemyTree.Nodes.Add("Dummy59");
            enemyTree.Nodes.Add("Dummy60");
            enemyTree.Nodes.Add("Fenrir");
            enemyTree.Nodes.Add("Stingmaw");
            enemyTree.Nodes.Add("Varaha");
            enemyTree.Nodes.Add("Woodbat");
            enemyTree.Nodes.Add("Vampbat");
            enemyTree.Nodes.Add("Cruella");
            enemyTree.Nodes.Add("Diabolix");
            enemyTree.Nodes.Add("Sprout");
            enemyTree.Nodes.Add("Bud");
            enemyTree.Nodes.Add("Clover");
            enemyTree.Nodes.Add("Monocyte");
            enemyTree.Nodes.Add("Red Cell");
            enemyTree.Nodes.Add("Sabremaw");
            enemyTree.Nodes.Add("Pondclaw");
            enemyTree.Nodes.Add("Ragelope");
            enemyTree.Nodes.Add("Kuyutha");
            enemyTree.Nodes.Add("Assassin");
            enemyTree.Nodes.Add("Bloodant");
            enemyTree.Nodes.Add("Servant");
            enemyTree.Nodes.Add("Killclaw");
            enemyTree.Nodes.Add("Dummy81");
            enemyTree.Nodes.Add("Macabre");
            enemyTree.Nodes.Add("Dragoid");
            enemyTree.Nodes.Add("Wyrmoid");
            enemyTree.Nodes.Add("Drakoid");
            enemyTree.Nodes.Add("Dummy86");
            enemyTree.Nodes.Add("Dummy87");
            enemyTree.Nodes.Add("Dummy88");
            enemyTree.Nodes.Add("Dummy89");
            enemyTree.Nodes.Add("Dummy90");
            enemyTree.Nodes.Add("Dummy91");
            enemyTree.Nodes.Add("Dummy92");
            enemyTree.Nodes.Add("Dummy93");
            enemyTree.Nodes.Add("Dummy94");
            enemyTree.Nodes.Add("Dummy95");
            enemyTree.Nodes.Add("Dummy96");
            enemyTree.Nodes.Add("Dummy97");
            enemyTree.Nodes.Add("Dummy98");
            enemyTree.Nodes.Add("Dummy99");
            enemyTree.Nodes.Add("Dumy100");
            enemyTree.Nodes.Add("Dumy101");
            enemyTree.Nodes.Add("Dumy102");
            enemyTree.Nodes.Add("Dumy103");
            enemyTree.Nodes.Add("Dumy104");
            enemyTree.Nodes.Add("Dumy105");
            enemyTree.Nodes.Add("Dumy106");
            enemyTree.Nodes.Add("Dumy107");
            enemyTree.Nodes.Add("Dumy108");
            enemyTree.Nodes.Add("Dumy109");


            TreeNodeCollection nodeCollect = enemyTree.Nodes;
            enemyTree.SelectedNode = nodeCollect[0];
        }

        private void FormIEnemyEditor_Load(object sender, EventArgs e)
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

            labelHead.Parent = pictureBoxHead;
            labelHead.BackColor = System.Drawing.Color.Transparent;
            labelHead.Location = new Point(labelHead.Left - pictureBoxHead.Left, labelHead.Top - pictureBoxHead.Top);

            labelArm.Parent = pictureBoxArm;
            labelArm.BackColor = System.Drawing.Color.Transparent;
            labelArm.Location = new Point(labelArm.Left - pictureBoxArm.Left, labelArm.Top - pictureBoxArm.Top);

            labelLeg.Parent = pictureBoxLeg;
            labelLeg.BackColor = System.Drawing.Color.Transparent;
            labelLeg.Location = new Point(labelLeg.Left - pictureBoxLeg.Left, labelLeg.Top - pictureBoxLeg.Top);

            labelDrop1.Parent = pictureBoxDrop1;
            labelDrop1.BackColor = System.Drawing.Color.Transparent;
            labelDrop1.Location = new Point(labelDrop1.Left - pictureBoxDrop1.Left, labelDrop1.Top - pictureBoxDrop1.Top);

            labelDrop2.Parent = pictureBoxDrop2;
            labelDrop2.BackColor = System.Drawing.Color.Transparent;
            labelDrop2.Location = new Point(labelDrop2.Left - pictureBoxDrop2.Left, labelDrop2.Top - pictureBoxDrop2.Top);

            labelDrop3.Parent = pictureBoxDrop3;
            labelDrop3.BackColor = System.Drawing.Color.Transparent;
            labelDrop3.Location = new Point(labelDrop3.Left - pictureBoxDrop3.Left, labelDrop3.Top - pictureBoxDrop3.Top);

            labelItem1Drop.Parent = pictureBoxItem1Drop;
            labelItem1Drop.BackColor = System.Drawing.Color.Transparent;
            labelItem1Drop.Location = new Point(labelItem1Drop.Left - pictureBoxItem1Drop.Left, labelItem1Drop.Top - pictureBoxItem1Drop.Top);

            labelItem2Drop.Parent = pictureBoxItem2Drop;
            labelItem2Drop.BackColor = System.Drawing.Color.Transparent;
            labelItem2Drop.Location = new Point(labelItem2Drop.Left - pictureBoxItem2Drop.Left, labelItem2Drop.Top - pictureBoxItem2Drop.Top);

            labelItem3Drop.Parent = pictureBoxItem3Drop;
            labelItem3Drop.BackColor = System.Drawing.Color.Transparent;
            labelItem3Drop.Location = new Point(labelItem3Drop.Left - pictureBoxItem3Drop.Left, labelItem3Drop.Top - pictureBoxItem3Drop.Top);

        }


        private void button2_Click(object sender, EventArgs e) ///Save Button
        {
            //B! .TryParse(Name! .Text, out type! value! ); { Form1.ByteWriter( value! , enemydata_array, StartingHex! + (treeView1.SelectedNode.Index * RowSize! ) + ArrayOfset! ); }
            //B=Byte size, 1="Byte" 2="UInt16" 4="UInt32"         Name!=the name of the textbox        type!= byte / ushort / uint, only include this in the FIRST time this ever happens in a form, later copies ommit this!
            //value!=Name of variable that holds the byte type (so byte/short/int has diffrent names)       StartingHex!= The hex offset      RowSize!=How many bytes in a row    Arrayofset! = how far into the row do we start grabbing info or saving it
            Byte.TryParse(textBoxLv.Text, out byte value8); { Form1.ByteWriter(value8, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 96); } //First 1 byte save
            UInt16.TryParse(textBoxExp.Text, out ushort value16); { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 92); } //First 2 byte save

            UInt16.TryParse(textBoxStr.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 48); }
            UInt16.TryParse(textBoxVit.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 50); }
            UInt16.TryParse(textBoxAgi.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 52); }
            UInt16.TryParse(textBoxLuc.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 54); }
            UInt16.TryParse(textBoxTec.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 56); }

            UInt16.TryParse(textBoxCut.Text, out value16);  { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 58); }
            UInt16.TryParse(textBoxBash.Text, out value16);  { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 60); }
            UInt16.TryParse(textBoxStab.Text, out value16);  { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 62); }
            UInt16.TryParse(textBoxFire.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 64); }
            UInt16.TryParse(textBoxIce.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 66); }
            UInt16.TryParse(textBoxVolt.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 68); }

            UInt16.TryParse(textBoxDeath.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 70); }
            UInt16.TryParse(textBoxOther.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 72); }
            UInt16.TryParse(textBoxHead.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 74); }
            UInt16.TryParse(textBoxArm.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 76); }
            UInt16.TryParse(textBoxLeg.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 78); }

            Byte.TryParse(textBoxItem1Drop.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 86); }
            Byte.TryParse(textBoxItem2Drop.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 87); }
            Byte.TryParse(textBoxItem3Drop.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 88); }


            //UInt16.TryParse(textBoxLv.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 96); }
            File.WriteAllBytes(Properties.Settings.Default.EOIRomFS + "\\EO1 Modded\\data\\Data\\Param\\EnemyData.tbb", enemydata_array); //saves to the path i set, everything in the array/
        }

        private void button3_Click(object sender, EventArgs e) //Etrian I Button
        {
            FormI f2 = new FormI(); //Create the new form
            f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
            f2.Location = this.Location; //Create the new window at the same location as current one
            f2.Show(); //Show the new window
            this.Close(); //Close the current window
        }

        private void enemyTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBoxLv.Text = enemydata_array[104 + (enemyTree.SelectedNode.Index * 96) + 96].ToString("D");
            textBoxExp.Text = BitConverter.ToUInt16(enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 92).ToString("D");

            textBoxStr.Text = BitConverter.ToUInt16(enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 48).ToString("D");   //Makes the array Hexes appear as Decimal (Numbers). D Means Decimal, X is hex, 2 is to display 2 digits (this is one byte, more bytes need more respectively?) 
            textBoxVit.Text = BitConverter.ToUInt16(enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 50).ToString("D");
            textBoxAgi.Text = BitConverter.ToUInt16(enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 52).ToString("D"); //Core Stats
            textBoxLuc.Text = BitConverter.ToUInt16(enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 54).ToString("D");
            textBoxTec.Text = BitConverter.ToUInt16(enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 56).ToString("D");

            textBoxCut.Text = BitConverter.ToUInt16(enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 58).ToString("D");
            textBoxBash.Text = BitConverter.ToUInt16(enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 60).ToString("D");
            textBoxStab.Text = BitConverter.ToUInt16(enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 62).ToString("D"); //Damage Resistances
            textBoxFire.Text = BitConverter.ToUInt16(enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 64).ToString("D");
            textBoxIce.Text = BitConverter.ToUInt16(enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 66).ToString("D");
            textBoxVolt.Text = BitConverter.ToUInt16(enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 68).ToString("D");

            textBoxDeath.Text = BitConverter.ToUInt16(enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 70).ToString("D");
            textBoxOther.Text = BitConverter.ToUInt16(enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 72).ToString("D");
            textBoxHead.Text = BitConverter.ToUInt16(enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 74).ToString("D"); //Ailment Resistances
            textBoxArm.Text = BitConverter.ToUInt16(enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 76).ToString("D");
            textBoxLeg.Text = BitConverter.ToUInt16(enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 78).ToString("D");

            textBoxItem1Drop.Text = enemydata_array[104 + (enemyTree.SelectedNode.Index * 96) + 86].ToString("D"); //Item Drops
            textBoxItem2Drop.Text = enemydata_array[104 + (enemyTree.SelectedNode.Index * 96) + 87].ToString("D");
            textBoxItem3Drop.Text = enemydata_array[104 + (enemyTree.SelectedNode.Index * 96) + 88].ToString("D");
        }

        private void enemyTree_BeforeSelect(object sender, TreeViewCancelEventArgs e) //Before we select the tree, we save everything, unless its the first time a enemy is loaded
        {
            if (treeloaded == "Yes")
            {
                //B! .TryParse(Name! .Text, out type! value! ); { Form1.ByteWriter( value! , enemydata_array, StartingHex! + (treeView1.SelectedNode.Index * RowSize! ) + ArrayOfset! ); }
                //B=Byte size, 1="Byte" 2="UInt16" 4="UInt32"         Name!=the name of the textbox        type!= byte / ushort / uint, only include this in the FIRST time this ever happens in a form, later copies ommit this!
                //value!=Name of variable that holds the byte type (so byte/short/int has diffrent names)       StartingHex!= The hex offset      RowSize!=How many bytes in a row    Arrayofset! = how far into the row do we start grabbing info or saving it
                Byte.TryParse(textBoxLv.Text, out byte value8); { Form1.ByteWriter(value8, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 96); } //First 1 byte save
                UInt16.TryParse(textBoxExp.Text, out ushort value16); { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 92); } //First 2 byte save

                UInt16.TryParse(textBoxStr.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 48); }
                UInt16.TryParse(textBoxVit.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 50); }
                UInt16.TryParse(textBoxAgi.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 52); }
                UInt16.TryParse(textBoxLuc.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 54); }
                UInt16.TryParse(textBoxTec.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 56); }

                UInt16.TryParse(textBoxCut.Text, out value16);  { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 58); }
                UInt16.TryParse(textBoxBash.Text, out value16);  { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 60); }
                UInt16.TryParse(textBoxStab.Text, out value16);  { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 62); }
                UInt16.TryParse(textBoxFire.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 64); }
                UInt16.TryParse(textBoxIce.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 66); }
                UInt16.TryParse(textBoxVolt.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 68); }

                UInt16.TryParse(textBoxDeath.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 70); }
                UInt16.TryParse(textBoxOther.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 72); }
                UInt16.TryParse(textBoxHead.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 74); }
                UInt16.TryParse(textBoxArm.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 76); }
                UInt16.TryParse(textBoxLeg.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 78); }

                Byte.TryParse(textBoxItem1Drop.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 86); }
                Byte.TryParse(textBoxItem2Drop.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 87); }
                Byte.TryParse(textBoxItem3Drop.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 104 + (enemyTree.SelectedNode.Index * 96) + 88); }

                File.WriteAllBytes(Properties.Settings.Default.EOIRomFS + "\\EO1 Modded\\data\\Data\\Param\\EnemyData.tbb", enemydata_array); //saves to the path i set, everything in the array/
            }
            else
            {
                treeloaded = "Yes";
            }
        }





    }
}
