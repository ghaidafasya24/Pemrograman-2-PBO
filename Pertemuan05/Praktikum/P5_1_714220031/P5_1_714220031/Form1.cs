﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_1_714220031
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HellooButton_Click(object sender, EventArgs e)
        {
            OutputLabel.Text = "Hello Ghaida";
        }

        private void ExittButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
