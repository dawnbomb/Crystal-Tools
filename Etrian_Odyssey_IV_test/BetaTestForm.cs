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

namespace Etrian_Odyssey_IV_test
{
    public partial class BetaTestForm : Form
    {

        byte[] enemydata_array; //This starts the array, the name after is what i name this array?
        public BetaTestForm()
        {
            InitializeComponent();
            string enemydata_path = "C:\\Users\\Sketter\\Downloads\\TestSave.bin";     //This defines the path as a string, so i can refer to it by this string/name instead of the full path every time
            int enemydata_length = (int)(new FileInfo(enemydata_path).Length);   //The leagth of the array?
            enemydata_array = File.ReadAllBytes(enemydata_path);  //loads an array with whatever is in the path
            //textBox1.Text = enemydata_array[0].ToString("D");  //Makes the array Hexes appear as Decimal (Numbers). D Means Decimal, X is hex, 2 is to display 2 digits (this is one byte, more bytes need more respectively?) 
            //textBox2.Text = File.ReadAllText(enemydata_path); //Makes the hexes appear as hex in bigger textbox
            //textBox3.Text = enemydata_array[1].ToString("D");
            //textBox4.Text = enemydata_array[2].ToString("D");

            //enemydata_array[0x37 + (listView1.SelectedIndex * 37) + 0] //[] stands for index! 0x is the starting offset *X is a row leagth like each enemys info, +
            treeView1.Nodes.Add("Enemy 3 (Line 4)");
            //string[] arr = new string[0];
            //ListViewItem item;
            //arr[0] = "Added";
            //item = new ListViewItem(arr);
            //listView1.Items.Add(item);
        }

        
        private void button1_Click(object sender, EventArgs e) //popup text button
        {
            System.Windows.Forms.MessageBox.Show("My message here");
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //Fancy Eo1 style textbox
        {

            if (!string.IsNullOrEmpty(textBox1.Text))  //If the text box is NOT empty, then we....
            {
                if (Convert.ToInt32(textBox1.Text) > 255) //Check if the value is above 255 (1 byte) and if it is, then we....
                {
                    textBox1.Text = "255";  //change the value down to 255 (Max size of 1 byte in hex) 
                    
                }
            }
        }

        private void textBox1_Leave(object sender, EventArgs e) //Fancy EO1 Textbox when it loses focus
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "0";
            }
            if (Convert.ToInt32(textBox1.Text) > 255)
            {
                System.Windows.Forms.MessageBox.Show("Values bigger then 255 not allowed");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)  //big textbox (loads the full hex file in initialize)
        {

        }

        private void button4_Click(object sender, EventArgs e) //The save button
        {
            enemydata_array[0] = Byte.Parse(textBox1.Text); //THIS [] byte turns into the text in this textbox, after it is parsed back into hex, then we....
            File.WriteAllBytes("C:\\Users\\Sketter\\Downloads\\TestSave.bin", enemydata_array); //saves to the path i set, everything in the array/
        }



        private void BetaTestForm_Load(object sender, EventArgs e) //The form itself when it loads. Not currently in use.
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)//ListView (List) of editable things (Enemies, Skills, Ect). This triggers when the selected thing in the list changes.
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)  // a second textbox
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)  //a third Eo1 Textbox
        {

        }

        private void button2_Click(object sender, EventArgs e) //Button Load Tree Index
        {
            textBox1.Text = enemydata_array[0x38 + (treeView1.SelectedNode.Index * 0x38) + 1].ToString("D");  //Makes the array Hexes appear as Decimal (Numbers). D Means Decimal, X is hex, 2 is to display 2 digits (this is one byte, more bytes need more respectively?) 
            //textBox3.Text = enemydata_array[0x38 + (treeView1.SelectedNode.Index * 0x38) + 2].ToString("D");
            textBox3.Text = BitConverter.ToUInt16(enemydata_array, 0x38 + (treeView1.SelectedNode.Index * 0x38) + 2).ToString("D");
            textBox4.Text = BitConverter.ToUInt32(enemydata_array, 0x38 + (treeView1.SelectedNode.Index * 0x38) + 4).ToString("D");

            //textBox4.Text = BitConverter.ToUInt16(< array name >, < offset >);   enemydata_array[0x38 + (treeView1.SelectedNode.Index * 0x38) + 4].ToString("D");
            //textBox4.Text = enemydata_array[0x38 + (treeView1.SelectedNode.Index * 0x38) + 4].ToString("D");
            //textBox4.Text = enemydata_array[0x38 + (treeView1.SelectedNode.Index * 0x38) + 4].ToString("D");
            //textBox4.Text = enemydata_array[0x38 + (treeView1.SelectedNode.Index * 0x38) + 4].ToString("D");
            //textBox4.Text = enemydata_array[0x38 + (treeView1.SelectedNode.Index * 0x38) + 4].ToString("D");
            //BitConverter.ToUInt16(<array name>, <offset>);
        }

        public void button3_Click(object sender, EventArgs e)//Button Save tree Index
        {
            //enemydata_array[0x38 + (treeView1.SelectedNode.Index * 0x38) + 0] = Byte.Parse(textBox1.Text); //THIS [] byte turns into the text in this textbox, after it is parsed back into hex, then we....
            //enemydata_array[0x38 + (treeView1.SelectedNode.Index * 0x38) + 2] = Byte.Parse(textBox3.Text); // the + X is the offset in DECIMAL, even using 0x0A will not work! USE DECIMAL ONLY!
            //enemydata_array[0x38 + (treeView1.SelectedNode.Index * 0x38) + 4] = Byte.TryParse(textBox4.Text, out byte value);
            //B! .TryParse(Name! .Text, out type! value! ); { Form1.ByteWriter( value! , enemydata_array, StartingHex! + (treeView1.SelectedNode.Index * RowSize! ) + ArrayOfset! ); }
            //B=Byte size, 1="Byte" 2="UInt16" 4="UInt32"         Name!=the name of the textbox        type!= byte / ushort / uint, only include this in the FIRST time this ever happens in a form, later copies ommit this!
            //value!=Name of variable that holds the byte type (so byte/short/int has diffrent names)       StartingHex!= The hex offset      RowSize!=How many bytes in a row    Arrayofset! = how far into the row do we start grabbing info or saving it
            Byte.TryParse(textBox1.Text, out byte value8); { Form1.ByteWriter(value8, enemydata_array, 0x38 + (treeView1.SelectedNode.Index * 0x38) + 1); }
            UInt16.TryParse(textBox3.Text, out ushort value16); { Form1.ByteWriter(value16, enemydata_array, 0x38 + (treeView1.SelectedNode.Index * 0x38) + 2); }
            UInt32.TryParse(textBox4.Text, out uint value32);  { Form1.ByteWriter(value32, enemydata_array, 0x38 + (treeView1.SelectedNode.Index * 0x38) + 4);  }
            File.WriteAllBytes("C:\\Users\\Sketter\\Downloads\\TestSave.bin", enemydata_array); //saves to the path i set, everything in the array/
        }
    }
}
