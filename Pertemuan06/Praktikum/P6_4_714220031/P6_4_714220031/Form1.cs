using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_4_714220031
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label_npm_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                epWarning.SetError(textBox2, " Textbox buruf tidak boleh kosong !");
                epWrong.SetError(textBox2, "");
                epCorrect.SetError(textBox2, "");

            }
            else
            {
                if ((textBox2.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(textBox2, "Betul!");
                    epWarning.SetError(textBox2, "");
                    epWrong.SetError(textBox2, "");
                }
                else
                {
                    epCorrect.SetError(textBox2, "");
                    epWarning.SetError(textBox2, "");
                    epWrong.SetError(textBox2, "Inputan hanya boleh Angka !");
                }
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                epWarning.SetError(textBox1, " Textbox huruf tidak boleh kososng !");
                epWrong.SetError(textBox1, "");
                epCorrect.SetError(textBox1, "");

            }
            else
            {
                if ((textBox1.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(textBox1, "");
                    epWrong.SetError(textBox1, "");
                    epCorrect.SetError(textBox1, "Betul!");
                }
                else
                {
                    epWrong.SetError(textBox1, "Inputan hanya boleh huruf!");
                    epWarning.SetError(textBox1, "");
                    epCorrect.SetError(textBox1, "");
                }
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            // Mengubah teks menjadi huruf kapital
            textBox3.Text = textBox3.Text.ToUpper();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox4.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                epWarning.SetError(textBox4, "");
                epWrong.SetError(textBox4, "");
                epCorrect.SetError(textBox4, "Betul!");
            }
            else
            {
                epWrong.SetError(textBox4, "Format email salah!\nContoh: a@b.c");
                epWarning.SetError(textBox4, "");
                epCorrect.SetError(textBox4, "");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        
            {
                if (textBox3.Text == "")
                {
                    epWarning.SetError(textBox3, " Textbox huruf tidak boleh kososng !");
                    epWrong.SetError(textBox3, "");
                    epCorrect.SetError(textBox3, "");

                }
                else
                {
                    if ((textBox1.Text).All(Char.IsLetter))
                    {
                        epWarning.SetError(textBox3, "");
                        epWrong.SetError(textBox3, "");
                        epCorrect.SetError(textBox3, "Betul!");
                    }
                    else
                    {
                        epWrong.SetError(textBox3, "Inputan hanya boleh huruf!");
                        epWarning.SetError(textBox3, "");
                        epCorrect.SetError(textBox3, "");
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text;
            string input = textBox1.Text;

            if (!string.IsNullOrEmpty(input))
            {
                // Ubah huruf pertama menjadi huruf besar (upper case)
                input = char.ToUpper(input[0]) + input.Substring(1).ToLower();

                // Perbarui teks dalam TextBox
                textBox1.Text = input;

                // Pindahkan kursor ke akhir teks
                textBox1.SelectionStart = input.Length;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            // ada batasan karakter yang dimasukkan 
            if (textBox5.Text.Length > 30)
            {
                epWrong.SetError(textBox5, "Teks terlalu panjang (maksimum 30 karakter)!");
                epWarning.SetError(textBox5, "");
                epCorrect.SetError(textBox5, "");
            }
            else if (textBox5.Text == "")
            {
                epWarning.SetError(textBox5, "Textbox huruf tidak boleh kosong!");
                epWrong.SetError(textBox5, "");
                epCorrect.SetError(textBox5, "");
            }
            else
            {
                if (textBox5.Text.All(Char.IsLetter))
                {
                    epWarning.SetError(textBox5, "");
                    epWrong.SetError(textBox5, "");
                    epCorrect.SetError(textBox5, "Betul!");
                }
                else
                {
                    epWrong.SetError(textBox5, "Inputan hanya boleh huruf!");
                    epWarning.SetError(textBox5, "");
                    epCorrect.SetError(textBox5, "");
                }

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rb_tingkat2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string PilihanTingkatan ="";
            /*string textBox1 = "";
            string textBox2 = "";
            string textBox3 = "";
            string textBox4 = "";
            string textBox5 = "";*/

            /*string errorMessage = "";
            if (string.IsNullOrEmpty())*/


            if (rb_tingkat1.Checked)
            {
                PilihanTingkatan = "Tingkat 1";
            }
            if (rb_tingkat2.Checked)
            {
                PilihanTingkatan = "Tingkat 2";
            }
            if (rb_tingkat3.Checked)
            {
                PilihanTingkatan = "Tingkat 3";
            }
            else if (string.IsNullOrEmpty(PilihanTingkatan))
            {
                MessageBox.Show("Anda harus memilih tingkatan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show(
            "Nama : " + textBox1.Text +
            "\nNPM : " + textBox2.Text +
            "\nJurusan : " + textBox3.Text +
            "\nEmail : " + textBox4.Text +
            "\nAlasan Masuk : " + textBox5.Text,
            "Informasi Pendaftaran",
            MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                epWarning.SetError(textBox5, " Textbox huruf tidak boleh kososng !");
                epWrong.SetError(textBox5, "");
                epCorrect.SetError(textBox5, "");

            }
            else
            {
                if ((textBox1.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(textBox5, "");
                    epWrong.SetError(textBox5, "");
                    epCorrect.SetError(textBox5, "Betul!");
                }
                else
                {
                    epWrong.SetError(textBox5, "Inputan hanya boleh huruf!");
                    epWarning.SetError(textBox5, "");
                    epCorrect.SetError(textBox5, "");
                }
            }
        }

        private void rb_tingkat3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_EnabledChanged(object sender, EventArgs e)
        {

        }
    }
}

