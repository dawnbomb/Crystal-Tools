﻿using System;
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
    public partial class FormILvScale : Form
    {
        public FormILvScale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormI f2 = new FormI(); //Create the new form
            f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
            f2.Location = this.Location; //Create the new window at the same location as current one
            f2.Show(); //Show the new window
            this.Close(); //Close the current window
        }
    }
}
