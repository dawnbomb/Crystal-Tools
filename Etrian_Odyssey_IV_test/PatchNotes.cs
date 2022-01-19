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
    public partial class PatchNotes : Form
    {
        public PatchNotes()
        {
            InitializeComponent();
            richTextBoxPatchNotes.Text = "Hello";
            


        }

        private void richTextBoxPatchNotes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
