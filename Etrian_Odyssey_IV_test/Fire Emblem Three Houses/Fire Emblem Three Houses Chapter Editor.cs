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
using System.Diagnostics;   //35 is the row leagth, this loops creating cells untill it hits that many cells.
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Etrian_Odyssey_IV_test
{
    public partial class FormFETHChapter : Form
    {

        public const int CELL_SIZE = 34;
        public const int CELL_SPACING = 1;
        public static SolidBrush WHITE_BRUSH = new SolidBrush(Color.FromArgb(0, 20, 50));
        protected override void OnPaint(PaintEventArgs e)
        {
            for (int x = 0; x < 32; x++)
            {
                for (int y = 0; y < 28; y++)
                {
                    Rectangle pos = new Rectangle
                    (
                        220 + x * (CELL_SIZE + CELL_SPACING),
                        10 + y * (CELL_SIZE + CELL_SPACING),
                        CELL_SIZE,
                        CELL_SIZE
        
                    );
                    e.Graphics.FillRectangle(WHITE_BRUSH, pos);
                }
            }
        }




        public FormFETHChapter()
        {
            InitializeComponent();
        }

        private void FormFETHChapter_Load(object sender, EventArgs e) //On form load
        {

        }

        private void button1_Click(object sender, EventArgs e) //Red Route Button
        {

        }

        private void button2_Click(object sender, EventArgs e) //Blue Route Button
        {

        }
        
        private void button3_Click(object sender, EventArgs e) //Yellow Route Button
        {

        }

        public class MapTile //Class for a tiles on the map
        {
        public ushort encounter_id { get; set; }
        public ushort danger { get; set; }
        public ushort unknown_1 { get; set; } //Used very rarely and only ever has a value of 1 if used.
        public ushort unknown_2 { get; set; } //Never used.
        }


        


    }
}
