using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714220031
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = "";
            string jenisKelamin = comboBox1.SelectedItem.ToString();
            DateTime tanggalLahir = dtpLahir.Value;


            string kelas = "";
            string jadwal = "";

            if (cbBiola.Checked)
            {
                kelas += "Biola, ";
            }
            if (cbGitar.Checked)
            {
                kelas += "Gitar, ";
            }
            if (cbSaxophone.Checked)
            {
                kelas += "Saxophone, ";
            }
            if (cbKonduktor.Checked)
            {
                kelas += "Konduktor, ";
            }
            if (cbPiano.Checked)
            {
                kelas += "Piano, ";
            }
            if (cbDrum.Checked)
            {
                kelas += "Drum, ";
            }
            if (cbVokal.Checked)
            {
                kelas += "Vokal, ";
            }
            if (cbKomposer.Checked)
            {
                kelas += "Komposer, ";
            }
            else if (string.IsNullOrEmpty(kelas))
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan kelas", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (rb_senin.Checked)
            {
                jadwal = "Senin && Rabu, 14.00 - 16.00";
            }
            else if (rb_selasa.Checked)
            {
                jadwal = "Selasa && Kamis, 14.00 - 16.00";
            }
            else if (rb_sabtu.Checked)
            {
                jadwal = "Sabtu && Minggu, 09.00 - 11.00";
            }
            else if (rb_minggu.Checked)
            {
                jadwal = "Minggu, 13.00 - 13.00";
            }
            else if (string.IsNullOrEmpty(jadwal))
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan jadwal", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show(
             "Nama : " + nama +
             "\nJenis Kelamin: " + jenisKelamin +
             "\nTanggal Lahir: " + tanggalLahir.ToString("dd MMMM yyyy") +
             "\nPilihan Kelas : " + kelas +
             "\nPilihan Jadwal : " + jadwal,
             "Informasi Pendaftaran",
             MessageBoxButtons.OK, MessageBoxIcon.Information
         );


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbBiola_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_senin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Pria");
            comboBox1.Items.Add("Wanita");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
