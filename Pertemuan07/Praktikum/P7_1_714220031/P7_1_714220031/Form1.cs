using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace P7_1_714220031
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(400, 251);
        }

        private void button_tutuppesan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(txt_nama.Text))
            {
                errorMessage += "Nama belum diisi\n";
            }

            if (string.IsNullOrWhiteSpace(txt_prodi.Text))
            {
                errorMessage += "Prodi belum diisi\n";
            }

            else if (!Regex.IsMatch(txt_prodi.Text, @"^[A-Za-z0-9]+-[A-Za-z0-9]+$"))
            {
                errorMessage += "Prodi harus berformat [Strata]-[Prodi]\n";
            }

            if (string.IsNullOrWhiteSpace(txt_kelas.Text))
            {
                errorMessage += "Kelas belum diisi\n";
            }

            if (string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(
                    "Lengkap",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                this.Size = new Size(400, 470);
            }
            else
            {
                MessageBox.Show(
                    errorMessage,
                   "Informasi Data Submit",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning
                   );
            }

        }

        private void cb_traveling_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            /*txt_nama.Text = null;
            txt_prodi.Text = null;
            txt_kelas.Text = null;*/

            // 
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Text = string.Empty;
                else if (control is RadioButton)
                    ((RadioButton)control).Checked = false;
                else if (control is CheckBox)
                    ((CheckBox)control).Checked = false;
                else if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = -1;
            }

            this.Size = new Size(400, 259);
        }

        private void rb_senin_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_senin.Checked)
            {
                cb_kuliah.Enabled = true; cb_kuliah.Checked = true;
                cb_traveling.Enabled = false; cb_traveling.Checked = false;
                cb_tidur.Enabled = true; cb_tidur.Checked = false;
            }
        }

        private void rb_minggu_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_minggu.Checked)
            {
                cb_kuliah.Enabled = false;
                cb_traveling.Enabled = true;
                cb_tidur.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_prodi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
