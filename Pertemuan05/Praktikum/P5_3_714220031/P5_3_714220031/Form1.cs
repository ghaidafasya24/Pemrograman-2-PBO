﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_3_714220031
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMerkHP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rb_android_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            string os = "";
            string status = "";

            if (rb_android.Checked == true)
            {
                os = "Android";
            }
            else if (rb_ios.Checked == true)
            {
                os = "iOS";
            }

            if (cbYa.Checked == true)
            {
                status = "Ya, sudah diperbaiki";
            }

            MessageBox.Show(
                "Merk HP: " + txtMerkHP.Text +
                "\nSistem Operasi : " + os +
                "\nStatus Perbaikan : " + status,
                "Informasi Service HP" ,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbYa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_ios_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
