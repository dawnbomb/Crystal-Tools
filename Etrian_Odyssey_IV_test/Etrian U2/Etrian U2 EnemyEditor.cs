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
    public partial class FormU2EnemyEditor : Form
    {
        byte[] enemydata_array; //This starts the array, the name after is what i name this array?
        public FormU2EnemyEditor()
        {
            InitializeComponent();
            string enemydata_path = "D:\\__Mods made by Dawnbomb\\Etrian Editor\\Etrian_Odyssey_IV_test\\bin\\Debug\\Untold\\ENEMYDATA.TBL";     //This defines the path as a string, so i can refer to it by this string/name instead of the full path every time
            int enemydata_length = (int)(new FileInfo(enemydata_path).Length);   //The leagth of the array?
            enemydata_array = File.ReadAllBytes(enemydata_path);  //loads an array with whatever is in the path

            //Add the EO1 enemy list to the in editor list of enemy names
        }

        private void FormU2EnemyEditor_Load(object sender, EventArgs e)
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

            labelOther.Parent = pictureBoxOther;
            labelOther.BackColor = System.Drawing.Color.Transparent;
            labelOther.Location = new Point(labelOther.Left - pictureBoxOther.Left, labelOther.Top - pictureBoxOther.Top);

            labelDeath.Parent = pictureBoxDeath;
            labelDeath.BackColor = System.Drawing.Color.Transparent;
            labelDeath.Location = new Point(labelDeath.Left - pictureBoxDeath.Left, labelDeath.Top - pictureBoxDeath.Top);

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

            labelPlague.Parent = pictureBoxPlague;
            labelPlague.BackColor = System.Drawing.Color.Transparent;
            labelPlague.Location = new Point(labelPlague.Left - pictureBoxPlague.Left, labelPlague.Top - pictureBoxPlague.Top);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //First offset INCLUDES decimal 0, row does NOT, neither does per row offset.
            textBoxLv.Text = enemydata_array[101 + (enemyTree.SelectedNode.Index * 100) + 1].ToString("D");
            textBoxExp.Text = BitConverter.ToUInt32(enemydata_array, 101 + (enemyTree.SelectedNode.Index * 96) + 5).ToString("D");
            textBoxOther.Text = BitConverter.ToUInt16(enemydata_array, 101 + (enemyTree.SelectedNode.Index * 100) + 3).ToString("D"); //Codex Entry

            textBoxStr.Text = BitConverter.ToUInt16(enemydata_array, 101 + (enemyTree.SelectedNode.Index * 100) + 25).ToString("D");   //Makes the array Hexes appear as Decimal (Numbers). D Means Decimal, X is hex, 2 is to display 2 digits (this is one byte, more bytes need more respectively?) 
            textBoxVit.Text = BitConverter.ToUInt16(enemydata_array, 101 + (enemyTree.SelectedNode.Index * 100) + 27).ToString("D");
            textBoxAgi.Text = BitConverter.ToUInt16(enemydata_array, 101 + (enemyTree.SelectedNode.Index * 100) + 29).ToString("D"); //Core Stats
            textBoxLuc.Text = BitConverter.ToUInt16(enemydata_array, 101 + (enemyTree.SelectedNode.Index * 100) + 31).ToString("D");
            textBoxTec.Text = BitConverter.ToUInt16(enemydata_array, 101 + (enemyTree.SelectedNode.Index * 100) + 33).ToString("D");

            textBoxCut.Text = BitConverter.ToUInt16(enemydata_array, 101 + (enemyTree.SelectedNode.Index * 100) + 41).ToString("D");
            textBoxStab.Text = BitConverter.ToUInt16(enemydata_array, 101 + (enemyTree.SelectedNode.Index * 100) + 43).ToString("D"); //Damage Resistances
            textBoxBash.Text = BitConverter.ToUInt16(enemydata_array, 101 + (enemyTree.SelectedNode.Index * 100) + 45).ToString("D");
            textBoxFire.Text = BitConverter.ToUInt16(enemydata_array, 101 + (enemyTree.SelectedNode.Index * 100) + 47).ToString("D");
            textBoxIce.Text = BitConverter.ToUInt16(enemydata_array, 101 + (enemyTree.SelectedNode.Index * 100) + 49).ToString("D");
            textBoxVolt.Text = BitConverter.ToUInt16(enemydata_array, 101 + (enemyTree.SelectedNode.Index * 100) + 51).ToString("D");

            textBoxDeath.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 53).ToString("D");
            textBoxHead.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 74).ToString("D"); //Ailment Resistances
            textBoxArm.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 76).ToString("D");
            textBoxLeg.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 78).ToString("D");

            textBoxStone.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 55).ToString("D");
            textBoxSleep.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 57).ToString("D");
            textBoxPanic.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 59).ToString("D");
            textBoxPsn.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 63).ToString("D");
            textBoxBlind.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 65).ToString("D");
            textBoxCurse.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 67).ToString("D");
            textBoxPara.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 69).ToString("D");
            textBoxStun.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 71).ToString("D");
            textBoxFear.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 79).ToString("D");

            textBoxPlague.Text = BitConverter.ToUInt16(enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 61).ToString("D");
        }

        private void button1_Click(object sender, EventArgs e)
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

            UInt16.TryParse(textBoxDeath.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 53); } 
            
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

            UInt16.TryParse(textBoxPlague.Text, out value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 79); }

            File.WriteAllBytes("D:\\__Mods made by Dawnbomb\\Etrian Editor\\Etrian_Odyssey_IV_test\\bin\\Debug\\Untold\\ENEMYDATA.TBL", enemydata_array); //saves to the path i set, everything in the array/
        }
    }
}
