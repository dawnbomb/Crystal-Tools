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
    public partial class FormV : Form
    {
        public FormV()
        {
            
            InitializeComponent();
            string enemydata_path = "C:\\Users\\Sketter\\Downloads\\Test.bin";                 //This defines the path as a string, so i can refer to it by this string/name instead of the full path every time
            int enemydata_length = (int)(new FileInfo(enemydata_path).Length);                                                                              
            enemydata_array = File.ReadAllBytes(enemydata_path);
            textBox1.Text = enemydata_array[0].ToString("D");  //D Means Decimal, X is hex, 2 is to display 2 digits (this is one byte, more bytes need more respectively?) 
            textBox2.Text = File.ReadAllText(enemydata_path);
        }

        byte[] enemydata_array; //byte[] starts an array, the name after is what i name this array?

        private void textBox1_Leave(object sender, EventArgs e) //Textbox 1 leave / lose focus
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



        private void button1_Click(object sender, EventArgs e) //Etrian IV Button
        {
            FormIV f2 = new FormIV(); //Create the new form
            f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
            f2.Location = this.Location; //Create the new window at the same location as current one
            f2.Show(); //Show the new window
            this.Close(); //Close the current window
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //Test Button V
        {

        }

        private void button3_Click(object sender, EventArgs e) // Enemy Editor Button
        {
            //FormVEnemyEditor f2 = new FormVEnemyEditor(); //Create the new form
            //f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
            //f2.Location = this.Location; //Create the new window at the same location as current one
            //f2.Show(); //Show the new window
            //this.Close(); //Close the current window
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //The text dummy text box 1 triggers when text is changed
        {

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (Convert.ToInt32(textBox1.Text) > 255)
                {
                    textBox1.Text = "255";
                    //System.Windows.Forms.MessageBox.Show("Values bigger then 255 not allowed");
                }
            }

            
        }


        private void button4_Click(object sender, EventArgs e) // save button
        {
            //object Box1 = textBox1.Text;
            //Box1 = Byte.Parse("2");
            enemydata_array[0] = Byte.Parse(textBox1.Text);
            File.WriteAllBytes("C:\\Users\\Sketter\\Downloads\\TestSave.bin", enemydata_array);
            //  textBox1.Text = enemydata_array[0].ToString("D");  //X is display as hex, 2 is to display 2 digits (this is one byte, more bytes need more respectively?)  D is Decimal?
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormV_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormVEnemyEditor f2 = new FormVEnemyEditor(); //Create the new form
            f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
            f2.Location = this.Location; //Create the new window at the same location as current one
            f2.Show(); //Show the new window
            this.Close(); //Close the current window
        }
    }
}
