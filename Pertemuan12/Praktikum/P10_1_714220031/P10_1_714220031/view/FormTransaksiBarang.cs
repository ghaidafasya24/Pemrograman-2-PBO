using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using P10_1_714220031.controller;
using P10_1_714220031.model;

namespace P10_1_714220031.view
{
    public partial class FormTransaksiBarang : Form
    {
        Koneksi koneksi = new Koneksi();
        string id_transaksi;
        M_transaksi_barang transaksi = new M_transaksi_barang();
        M_barang m_barang = new M_barang();

        public FormTransaksiBarang()
        {
            InitializeComponent();

            nama_barang.ReadOnly = true;
            nama_barang.Enabled = false;
            harga_barang.Enabled = false;
            harga_barang.ReadOnly = true;
            total.Enabled = false;
            total.ReadOnly = true;

            LoadIdBarang();
        }

        public void Tampil()
        {
            DataTransaksiBarang.DataSource = koneksi.ShowData("SELECT id_transaksi, b.id_barang, nama_barang, harga, qty, total FROM t_transaksi t JOIN t_barang b ON (t.id_barang = b.id_barang)");
            DataTransaksiBarang.Columns[0].HeaderText = "ID";
            DataTransaksiBarang.Columns[1].HeaderText = "ID Barang";
            DataTransaksiBarang.Columns[2].HeaderText = "Nama Barang";
            DataTransaksiBarang.Columns[3].HeaderText = "Harga";
            DataTransaksiBarang.Columns[4].HeaderText = "QTY";
            DataTransaksiBarang.Columns[5].HeaderText = "Total Harga";
        }

        public void ResetForm()
        {
            id_barang.Text = "";
            nama_barang.Text = "";
            harga_barang.Text = "";
            qty.Text = "";
            total.Text = "";
            tbCariData.Text = "";
        }

        public void LoadIdBarang()
        {
            koneksi.OpenConnection();

            string query = "SELECT id_barang FROM t_barang";
            object dataTable = koneksi.ShowData(query);

            id_barang.DisplayMember = "id_barang";
            id_barang.ValueMember = "id_barang";
            id_barang.DataSource = dataTable;

            koneksi.CloseConnection();
        }

        public void GetDataBarang(int selectIdBarang)
        {
            koneksi.OpenConnection();

            string query = $"SELECT nama_barang, harga FROM t_barang WHERE id_barang = {selectIdBarang}";
            MySqlDataReader reader = koneksi.reader(query);

            if (reader.Read())
            {
                nama_barang.Text = reader["nama_barang"].ToString();
                harga_barang.Text = reader["harga"].ToString();
            }

            reader.Close();
            koneksi.CloseConnection();
        }

        private void TotalHarga()
        {
            if (double.TryParse(qty.Text, out double qty_barang) && double.TryParse(harga_barang.Text.Replace(".", ""), out double harga))
            {
                double totals = qty_barang * harga;

                string formattedTotal = string.Format("{0:#,##0}", totals);

                total.Text = formattedTotal;
            }
        }

        private string FormatDigitAngka(int number)
        {
            return string.Format("Rp {0:N0}", number);
        }

        private void FormatDigit(TextBox textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text) && textBox.Text.All(char.IsDigit))
            {
                string number = textBox.Text.Replace(".", "");

                number = string.Format("{0:#,##0}", double.Parse(number));

                textBox.Text = number;
                textBox.SelectionStart = textBox.Text.Length;
            }
        }




        private void label_barang_Click(object sender, EventArgs e)
        {

        }

        private void label_harga_Click(object sender, EventArgs e)
        {

        }

        private void FormTransaksiBarang_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (id_barang.Text == "" || nama_barang.Text == "" || harga_barang.Text == "" || qty.Text == "" || total.Text == "" || id_barang.Text.Any(Char.IsLetter) || qty.Text.Any(Char.IsLetter) || id_barang.SelectedItem == null)
            {
                MessageBox.Show("Isi form dengan benar sebelum disimpan!", "Gagal Menyimpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TransaksiBarang tr_brg = new TransaksiBarang();
                transaksi.Id_barang = id_barang.Text;
                transaksi.Qty = qty.Text;

                string formattedTotal = total.Text.Replace("Rp ", "").Replace(",", "");
                if (double.TryParse(formattedTotal, out double numericTotal))
                {
                    transaksi.Total = numericTotal.ToString();
                }

                tr_brg.Insert(transaksi);
                ResetForm();
                Tampil();
            }
        }

        private void id_barang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (id_barang.SelectedValue != null)
            {
                int selectIdBarang;
                if (int.TryParse(id_barang.SelectedValue.ToString(), out selectIdBarang))
                {
                    GetDataBarang(selectIdBarang);
                }
            }
        }

        private void harga_barang_TextChanged(object sender, EventArgs e)
        {
            FormatDigit(harga_barang);
        }

        private void total_TextChanged(object sender, EventArgs e)
        {
            TotalHarga();
        }

        private void qty_TextChanged(object sender, EventArgs e)
        {
            TotalHarga();
        }

        private void DataTransaksiBarang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int number))
                {
                    e.Value = FormatDigitAngka(number);
                    e.FormattingApplied = true;
                }
            }

            if (e.ColumnIndex == 5 && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int number))
                {
                    e.Value = FormatDigitAngka(number);
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void DataTransaksiBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataTransaksiBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_transaksi = DataTransaksiBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
            id_barang.Text = DataTransaksiBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
            nama_barang.Text = DataTransaksiBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
            harga_barang.Text = DataTransaksiBarang.Rows[e.RowIndex].Cells[3].Value.ToString();
            qty.Text = DataTransaksiBarang.Rows[e.RowIndex].Cells[4].Value.ToString();

            TotalHarga();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (id_barang.Text != "" || nama_barang.Text != "" || harga_barang.Text != "" || qty.Text != "" || total.Text != "" || !id_barang.Text.Any(Char.IsLetter) || !qty.Text.Any(Char.IsLetter) || id_barang.SelectedItem != null)
            {
                TransaksiBarang tr_brg = new TransaksiBarang();
                transaksi.Id_barang = id_barang.Text;
                transaksi.Qty = qty.Text;


                string formattedTotal = total.Text.Replace("Rp ", "").Replace(",", "");
                if (double.TryParse(formattedTotal, out double numericTotal))
                {
                    transaksi.Total = numericTotal.ToString();
                }

                tr_brg.Update(transaksi, id_transaksi);
                ResetForm();
                Tampil();
            }

            else
            {
                MessageBox.Show("Isi data dengan benar sebelum diperbarui!", "Terjadi Kesalahan Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            DataTransaksiBarang.DataSource = koneksi.ShowData("SELECT id_transaksi, b.id_barang, nama_barang, harga, qty, total FROM t_transaksi t JOIN t_barang b ON (t.id_barang = b.id_barang) WHERE id_transaksi LIKE '%' '" + tbCariData.Text + "' '%' OR t.id_barang LIKE '%' '" + tbCariData.Text + "' '%' OR b.id_barang LIKE '%' '" + tbCariData.Text + "' '%' OR nama_barang LIKE '%' '" + tbCariData.Text + "' '%' OR harga LIKE '%' '" + tbCariData.Text + "' '%' OR qty LIKE '%' '" + tbCariData.Text + "' '%' OR total LIKE '%' '" + tbCariData.Text + "' '%'");
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Apakah kamu yakin ingin menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                TransaksiBarang tr_brg = new TransaksiBarang();
                tr_brg.Delete(id_transaksi);
                ResetForm();
                Tampil();
            }
        }
    }
}
