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
    public partial class FormQPowerSpotEditor : Form
    {

        String treeloaded = "No";
        byte[] enemydata_array; //This starts the array, the name after is what i name this array?
        public FormQPowerSpotEditor()
        {
            InitializeComponent();

            string enemydata_path = Properties.Settings.Default.PQRomFS + "\\dungeon\\itempoint.tbl"; //This defines the path as a string, so i can refer to it by this string/name instead of the full path every time
            int enemydata_length = (int)(new FileInfo(enemydata_path).Length);   //The leagth of the array?
            enemydata_array = File.ReadAllBytes(enemydata_path);  //loads an array with whatever is in the path

            //Add the EO1 enemy list to the in editor list of enemy names
            enemyTree.Nodes.Add("Spot 1");
            enemyTree.Nodes.Add("Spot 2");
            enemyTree.Nodes.Add("Spot 3");
            enemyTree.Nodes.Add("Spot 4");
            enemyTree.Nodes.Add("Spot 5");
            enemyTree.Nodes.Add("Spot 6");
            enemyTree.Nodes.Add("Spot 7");
            enemyTree.Nodes.Add("Spot 8");
            enemyTree.Nodes.Add("Spot 9");
            enemyTree.Nodes.Add("Spot 10");
            enemyTree.Nodes.Add("Spot 11");
            enemyTree.Nodes.Add("Spot 12");
            enemyTree.Nodes.Add("Spot 13");
            enemyTree.Nodes.Add("Spot 14");
            enemyTree.Nodes.Add("Spot 15");
            enemyTree.Nodes.Add("Spot 16");
            enemyTree.Nodes.Add("Spot 17");
            enemyTree.Nodes.Add("Spot 18");
            enemyTree.Nodes.Add("Spot 19");
            enemyTree.Nodes.Add("Spot 20");
            enemyTree.Nodes.Add("Spot 21");
            enemyTree.Nodes.Add("Spot 22");
            enemyTree.Nodes.Add("Spot 23");
            enemyTree.Nodes.Add("Spot 24");
            enemyTree.Nodes.Add("Spot 25");
            enemyTree.Nodes.Add("Spot 26");
            enemyTree.Nodes.Add("Spot 27");
            enemyTree.Nodes.Add("Spot 28");
            enemyTree.Nodes.Add("Spot 29");
            enemyTree.Nodes.Add("Spot 30");
            enemyTree.Nodes.Add("Spot 31");
            enemyTree.Nodes.Add("Spot 32");
            enemyTree.Nodes.Add("Spot 33");
            enemyTree.Nodes.Add("Spot 34");
            enemyTree.Nodes.Add("Spot 35");
            enemyTree.Nodes.Add("Spot 36");
            enemyTree.Nodes.Add("Spot 37");
            enemyTree.Nodes.Add("Spot 38");
            enemyTree.Nodes.Add("Spot 39");
            enemyTree.Nodes.Add("Spot 40");
            enemyTree.Nodes.Add("Spot 41");
            enemyTree.Nodes.Add("Spot 42");
            enemyTree.Nodes.Add("Spot 43");
            enemyTree.Nodes.Add("Spot 44");
            enemyTree.Nodes.Add("Spot 45");
            enemyTree.Nodes.Add("Spot 46");
            enemyTree.Nodes.Add("Spot 47");
            enemyTree.Nodes.Add("Spot 48");
            enemyTree.Nodes.Add("Spot 49");
            enemyTree.Nodes.Add("Spot 50");
            enemyTree.Nodes.Add("Spot 51");
            enemyTree.Nodes.Add("Spot 52");
            enemyTree.Nodes.Add("Spot 53");
            enemyTree.Nodes.Add("Spot 54");
            enemyTree.Nodes.Add("Spot 55");
            enemyTree.Nodes.Add("Spot 56");
            enemyTree.Nodes.Add("Spot 57");
            enemyTree.Nodes.Add("Spot 58");
            enemyTree.Nodes.Add("Spot 59");
            enemyTree.Nodes.Add("Spot 60");
            enemyTree.Nodes.Add("Spot 61");
            enemyTree.Nodes.Add("Spot 62");
            enemyTree.Nodes.Add("Spot 63");
            enemyTree.Nodes.Add("Spot 64");
            enemyTree.Nodes.Add("Spot 65");
            enemyTree.Nodes.Add("Spot 66");
            enemyTree.Nodes.Add("Spot 67");
            enemyTree.Nodes.Add("Spot 68");
            enemyTree.Nodes.Add("Spot 69");
            enemyTree.Nodes.Add("Spot 70");
            enemyTree.Nodes.Add("Spot 71");
            enemyTree.Nodes.Add("Spot 72");
            enemyTree.Nodes.Add("Spot 73");
            enemyTree.Nodes.Add("Spot 74");
            enemyTree.Nodes.Add("Spot 75");

            TreeNodeCollection nodeCollect = enemyTree.Nodes;
            enemyTree.SelectedNode = nodeCollect[0];
        }

        private void FormQPowerSpotEditor_Load(object sender, EventArgs e)
        {

        }

        private void enemyTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //Value 1 is distance / offset from the start of the file to the start of the array ("Start" in 010) (The first byte is 0) 
            //Value 2 is how many bytes / hexes are in a "row"   (First byte is 1 NOT 0)
            //Value 3 is how many bytes into the row info starts (The first byte is byte 0)

            richTextBox0.Text = enemydata_array[0 + (enemyTree.SelectedNode.Index * 36) + 0].ToString("D"); //Floor
            richTextBox1.Text = enemydata_array[0 + (enemyTree.SelectedNode.Index * 36) + 4].ToString("D"); //ID
            richTextBox2.Text = enemydata_array[0 + (enemyTree.SelectedNode.Index * 36) + 8].ToString("D"); //X
            richTextBox3.Text = enemydata_array[0 + (enemyTree.SelectedNode.Index * 36) + 12].ToString("D"); //Y
            richTextBox4.Text = enemydata_array[0 + (enemyTree.SelectedNode.Index * 36) + 16].ToString("D"); //Gather Attempts
            richTextBox5.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 36) + 20).ToString("D"); //Item 1
            richTextBox6.Text = BitConverter.ToUInt16(enemydata_array, 0 + (enemyTree.SelectedNode.Index * 36) + 24).ToString("D"); //Item 2
            richTextBox7.Text = enemydata_array[0 + (enemyTree.SelectedNode.Index * 36) + 28].ToString("D"); //Item 2 Chance
            richTextBox8.Text = enemydata_array[0 + (enemyTree.SelectedNode.Index * 36) + 32].ToString("D"); //Battle ID?
        }

        private void buttonSave_Click(object sender, EventArgs e) //Save Button
        {
            //B! .TryParse(Name! .Text, out type! value! ); { Form1.ByteWriter( value! , enemydata_array, StartingHex! + (treeView1.SelectedNode.Index * RowSize! ) + ArrayOfset! ); }
            //B=Byte size, 1="Byte" 2="UInt16" 4="UInt32"         Name!=the name of the textbox        type!= byte / ushort / uint, only include this in the FIRST time this ever happens in a form, later copies ommit this!
            //value!=Name of variable that holds the byte type (so byte/short/int has diffrent names)       StartingHex!= The hex offset      RowSize!=How many bytes in a row    Arrayofset! = how far into the row do we start grabbing info or saving it
            
            Byte.TryParse(richTextBox0.Text, out byte value8); { Form1.ByteWriter(value8, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 36) + 0); } //First 1 byte save
            Byte.TryParse(richTextBox1.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 36) + 4); }
            Byte.TryParse(richTextBox2.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 36) + 8); }
            Byte.TryParse(richTextBox3.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 36) + 12); }
            Byte.TryParse(richTextBox4.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 36) + 16); }
            UInt16.TryParse(richTextBox5.Text, out ushort value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 36) + 20); } //First 2 byte save
            UInt16.TryParse(richTextBox6.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 36) + 24); } 
            Byte.TryParse(richTextBox7.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 36) + 28); }
            Byte.TryParse(richTextBox8.Text, out value8); { Form1.ByteWriter(value8, enemydata_array, 0 + (enemyTree.SelectedNode.Index * 36) + 32); }

            File.WriteAllBytes(Properties.Settings.Default.PQRomFS + "\\dungeon\\itempoint.tbl", enemydata_array); //saves to the path i set, everything in the array/
        }
    }
}
