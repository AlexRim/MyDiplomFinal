﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogFormLibrary
{
    public partial class ClientDialog : Form
    {
        public ClientDialog()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox_ClientUNN.Enabled = true;
                textBox_ClientPassport.Enabled = false;
            }
            else
            {
                textBox_ClientUNN.Enabled = false;
                textBox_ClientPassport.Enabled = true;
            }
        }
    }
}
