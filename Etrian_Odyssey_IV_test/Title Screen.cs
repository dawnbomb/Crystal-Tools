using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etrian_Odyssey_IV_test
{
	public partial class Form1 : Form
	{
		


		public Form1()
		{
			InitializeComponent();
		}
		public byte[] rom;
		Table_Manager tm = new Table_Manager();
		private void Form1_Load(object sender, EventArgs e)
		{
			
			
			/*if (System.IO.File.Exists(Properties.Settings.Default.LastRom))
				OpenROM(Properties.Settings.Default.LastRom);
			else
				OpenROMdialogue();
			*/
			
		}

        private void ButtonL2_Click(object sender, EventArgs e) //Etrian V Button
		{
			
        }


        private void Button3_Click(object sender, EventArgs e)   //Etrian IV Button
        {
			//Go to form 2
			//this.Hide(); //Hides this form
			//this.Close();
			FormIV f2 = new FormIV(); //Create the new form
			f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
			f2.Location = this.Location; //Create the new window at the same location as current one
			f2.Show();
			//f2.ShowDialog(); //Show the new form
			
			//f2 = null; //When the new form is closed
			//this.Show(); //we show form1 again

		}

        private void button1_Click_1(object sender, EventArgs e)  //Etrian I Button
        {
			//this.Hide(); //Hides this form
			FormI f2 = new FormI(); //Create the new form
			f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
			f2.Location = this.Location; //Create the new window at the same location as current one
			f2.Show();
			//f2 = null; //When the new form is closed
			//this.Show(); //we show form1 again
		}


        private void label13_Click(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e) //Etrian 2 Button
        {

        }

        private void button2_Click(object sender, EventArgs e) //Etrian III Button
        {

        }

        private void button5_Click(object sender, EventArgs e) //Etrian V Button
        {
			FormV f2 = new FormV(); //Create the new form
			f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
			f2.Location = this.Location; //Create the new window at the same location as current one
			f2.Show();
		}

		private void button11_Click(object sender, EventArgs e) //Etrian X Button
		{
			FormX f2 = new FormX(); //Create the new form
			f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
			f2.Location = this.Location; //Create the new window at the same location as current one
			f2.Show();
		}

		private void button6_Click(object sender, EventArgs e) //Etrian Untold Button
        {
			FormU f2 = new FormU(); //Create the new form
			f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
			f2.Location = this.Location; //Create the new window at the same location as current one
			f2.Show();
		}

        private void button7_Click(object sender, EventArgs e) //Etrian Untold 2 Button
        {
			FormU2 f2 = new FormU2(); //Create the new form
			f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
			f2.Location = this.Location; //Create the new window at the same location as current one
			f2.Show();
		}

        private void button8_Click(object sender, EventArgs e) // Persona Q Button
        {
			FormQ f2 = new FormQ(); //Create the new form
			f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
			f2.Location = this.Location; //Create the new window at the same location as current one
			f2.Show();
		}

        private void button9_Click(object sender, EventArgs e) //Persona Q2 Button
        {
			FormQ2 f2 = new FormQ2(); //Create the new form
			f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
			f2.Location = this.Location; //Create the new window at the same location as current one
			f2.Show();
		}

        private void button10_Click(object sender, EventArgs e) //Etrian Mystery Dungeon
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e) //Beta test zone
        {
			BetaTestForm f2 = new BetaTestForm(); //Create the new form
			f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
			f2.Location = this.Location; //Create the new window at the same location as current one
			f2.Show();
		}


		private void button15_Click(object sender, EventArgs e) //Fire Emblem Three Houses
		{
			FormFETH f2 = new FormFETH(); //Create the new form
			f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
			f2.Location = this.Location; //Create the new window at the same location as current one
			f2.Show();
		}












		//The following is written by violentlycar to deal with writing/saving mult-byte hex to files. 
		//it is not used here, but in other files, pretty much every editor uses this.
		//it is used via the following command
		//ByteWriter(value, destination_array, offset)
		//a semi-pratical example is ByteWriter(value, enemydata_array, 0x38 + (treeView1.SelectedNode.Index * 0x38) + 4)



		static public void ByteWriter<T>(T val, byte[] d_array, int start_offset)
		{
			if (val is byte || val is sbyte) // avoid using this one
			{
				d_array[start_offset] = Convert.ToByte(val);
			}
			else if (val is short)
			{
				short c_val = Convert.ToInt16(val);
				d_array[start_offset] = (byte)(c_val & 0xFF);
				d_array[start_offset + 1] = (byte)((c_val & 0xFF00) >> 8);
			}
			else if (val is ushort)
			{
				ushort c_val = Convert.ToUInt16(val);
				d_array[start_offset] = (byte)(c_val & 0xFF);
				d_array[start_offset + 1] = (byte)((c_val & 0xFF00) >> 8);
			}
			else if (val is int)
			{
				int c_val = Convert.ToInt32(val);
				d_array[start_offset] = (byte)(c_val & 0xFF);
				d_array[start_offset + 1] = (byte)((c_val & 0xFF00) >> 8);
				d_array[start_offset + 2] = (byte)((c_val & 0xFF0000) >> 16);
				d_array[start_offset + 3] = (byte)((c_val & 0xFF000000) >> 24);
			}
			else if (val is uint)
			{
				uint c_val = Convert.ToUInt32(val);
				d_array[start_offset] = (byte)(c_val & 0xFF);
				d_array[start_offset + 1] = (byte)((c_val & 0xFF00) >> 8);
				d_array[start_offset + 2] = (byte)((c_val & 0xFF0000) >> 16);
				d_array[start_offset + 3] = (byte)((c_val & 0xFF000000) >> 24);
			}
			else if (val is string)
			{
				byte[] str_bytes = Encoding.ASCII.GetBytes(Convert.ToString(val));
				for (int x = 0; x < str_bytes.Length; x++)
				{
					d_array[start_offset + x] = str_bytes[x];
				}
			}
			else
			{
				throw new Exception("Value passed was not one of supported type: byte, sbyte, ushort, short, uint, int, string.");
			}
		}

        private void button14_Click(object sender, EventArgs e) //Button patch notes
        {
			PatchNotes f2 = new PatchNotes(); //Create the new form
			f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
			f2.Location = this.Location; //Create the new window at the same location as current one
			f2.Show();
		}

        







        /*
		private void OpenROMdialogue()
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Title = "Open a GBA/NDS File";
			ofd.Filter = "GBA/NDS/3DS file(*.gba;*.nds;*.3ds)|*.gba;*.nds;*.3ds";
			if (ofd.ShowDialog() == DialogResult.OK) { OpenROM(ofd.FileName); }
		}
		//public static Bits rom = new Bits();
		//public static Bits ram = new Bits();
		//Public OpenFileDialog1 = ""
		public byte[] rom;
		string romfn;
		public int version = -1;
		int filetable = -1;
		char language;
		private void OpenROM(string filename)
		{
			//Whatever ROM/file verification you want to do can go here. I will omit this for this example.

			//Load ROM/file.
			rom = Bits.openFile(filename);

			//Maybe you want to check if things are loaded correctly. (Optional.)
			if (rom == null) { this.Text = "Error reading ROM file."; return; }
			
			
			romfn = filename; //Set save path.
			Properties.Settings.Default.LastRom = filename; //Set ROM to load when Editor is opened again.
			Properties.Settings.Default.Save();
		}

		//Toolbar > File menu
		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenROMdialogue();
		}
		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Bits.saveFile(romfn, rom);
		}
		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Title = "Save ROM File";
			//sfd.Filter = "GBA/NDS/3DS file(*.gba;*.nds;*.3ds)|*.gba;*.nds;*.3ds";
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				romfn = sfd.FileName;
				Bits.saveFile(romfn, rom);
				Properties.Settings.Default.LastRom = romfn;
				Properties.Settings.Default.Save();
			}
		}
		*/
    }
}
