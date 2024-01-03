namespace P10_1_714220031.view
{
    partial class FormTransaksiBarang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.label_caridata = new System.Windows.Forms.Label();
            this.gb_tbl_admin = new System.Windows.Forms.GroupBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gb_form_transaksibarang = new System.Windows.Forms.GroupBox();
            this.harga_barang = new System.Windows.Forms.TextBox();
            this.nama_barang = new System.Windows.Forms.TextBox();
            this.label_harga = new System.Windows.Forms.Label();
            this.label_barang = new System.Windows.Forms.Label();
            this.gb_transaksibarang = new System.Windows.Forms.GroupBox();
            this.DataTransaksiBarang = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_id_barang = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.TextBox();
            this.id_barang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_qty = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gb_tbl_admin.SuspendLayout();
            this.gb_form_transaksibarang.SuspendLayout();
            this.gb_transaksibarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksiBarang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCariData);
            this.groupBox1.Controls.Add(this.label_caridata);
            this.groupBox1.Location = new System.Drawing.Point(430, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 69);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Pencarian";
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(85, 28);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(182, 20);
            this.tbCariData.TabIndex = 12;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // label_caridata
            // 
            this.label_caridata.AutoSize = true;
            this.label_caridata.Location = new System.Drawing.Point(6, 31);
            this.label_caridata.Name = "label_caridata";
            this.label_caridata.Size = new System.Drawing.Size(51, 13);
            this.label_caridata.TabIndex = 12;
            this.label_caridata.Text = "Cari Data";
            // 
            // gb_tbl_admin
            // 
            this.gb_tbl_admin.Controls.Add(this.btnHapus);
            this.gb_tbl_admin.Controls.Add(this.btnUbah);
            this.gb_tbl_admin.Controls.Add(this.btnSimpan);
            this.gb_tbl_admin.Controls.Add(this.btnRefresh);
            this.gb_tbl_admin.Location = new System.Drawing.Point(430, 277);
            this.gb_tbl_admin.Name = "gb_tbl_admin";
            this.gb_tbl_admin.Size = new System.Drawing.Size(306, 154);
            this.gb_tbl_admin.TabIndex = 10;
            this.gb_tbl_admin.TabStop = false;
            this.gb_tbl_admin.Text = "Tombol Admin";
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(15, 122);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(274, 23);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(15, 88);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(274, 23);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(15, 56);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(274, 23);
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Location = new System.Drawing.Point(15, 23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(274, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gb_form_transaksibarang
            // 
            this.gb_form_transaksibarang.Controls.Add(this.label3);
            this.gb_form_transaksibarang.Controls.Add(this.total);
            this.gb_form_transaksibarang.Controls.Add(this.label2);
            this.gb_form_transaksibarang.Controls.Add(this.label_qty);
            this.gb_form_transaksibarang.Controls.Add(this.qty);
            this.gb_form_transaksibarang.Controls.Add(this.label_id_barang);
            this.gb_form_transaksibarang.Controls.Add(this.groupBox2);
            this.gb_form_transaksibarang.Location = new System.Drawing.Point(-2, 195);
            this.gb_form_transaksibarang.Name = "gb_form_transaksibarang";
            this.gb_form_transaksibarang.Size = new System.Drawing.Size(426, 191);
            this.gb_form_transaksibarang.TabIndex = 9;
            this.gb_form_transaksibarang.TabStop = false;
            this.gb_form_transaksibarang.Text = "Form Transaksi Barang";
            // 
            // harga_barang
            // 
            this.harga_barang.Location = new System.Drawing.Point(182, 60);
            this.harga_barang.Name = "harga_barang";
            this.harga_barang.Size = new System.Drawing.Size(149, 20);
            this.harga_barang.TabIndex = 7;
            this.harga_barang.TextChanged += new System.EventHandler(this.harga_barang_TextChanged);
            // 
            // nama_barang
            // 
            this.nama_barang.Location = new System.Drawing.Point(6, 60);
            this.nama_barang.Name = "nama_barang";
            this.nama_barang.Size = new System.Drawing.Size(146, 20);
            this.nama_barang.TabIndex = 6;
            // 
            // label_harga
            // 
            this.label_harga.AutoSize = true;
            this.label_harga.Location = new System.Drawing.Point(179, 44);
            this.label_harga.Name = "label_harga";
            this.label_harga.Size = new System.Drawing.Size(73, 13);
            this.label_harga.TabIndex = 1;
            this.label_harga.Text = "Harga Barang";
            this.label_harga.Click += new System.EventHandler(this.label_harga_Click);
            // 
            // label_barang
            // 
            this.label_barang.AutoSize = true;
            this.label_barang.Location = new System.Drawing.Point(5, 44);
            this.label_barang.Name = "label_barang";
            this.label_barang.Size = new System.Drawing.Size(72, 13);
            this.label_barang.TabIndex = 0;
            this.label_barang.Text = "Nama Barang";
            this.label_barang.Click += new System.EventHandler(this.label_barang_Click);
            // 
            // gb_transaksibarang
            // 
            this.gb_transaksibarang.Controls.Add(this.DataTransaksiBarang);
            this.gb_transaksibarang.Location = new System.Drawing.Point(-2, 1);
            this.gb_transaksibarang.Name = "gb_transaksibarang";
            this.gb_transaksibarang.Size = new System.Drawing.Size(738, 188);
            this.gb_transaksibarang.TabIndex = 8;
            this.gb_transaksibarang.TabStop = false;
            this.gb_transaksibarang.Text = "Table Transaksi Barang";
            // 
            // DataTransaksiBarang
            // 
            this.DataTransaksiBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataTransaksiBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTransaksiBarang.Location = new System.Drawing.Point(10, 19);
            this.DataTransaksiBarang.Name = "DataTransaksiBarang";
            this.DataTransaksiBarang.Size = new System.Drawing.Size(711, 163);
            this.DataTransaksiBarang.TabIndex = 0;
            this.DataTransaksiBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTransaksiBarang_CellClick);
            this.DataTransaksiBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTransaksiBarang_CellContentClick);
            this.DataTransaksiBarang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataTransaksiBarang_CellFormatting);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.id_barang);
            this.groupBox2.Controls.Add(this.harga_barang);
            this.groupBox2.Controls.Add(this.label_harga);
            this.groupBox2.Controls.Add(this.nama_barang);
            this.groupBox2.Controls.Add(this.label_barang);
            this.groupBox2.Location = new System.Drawing.Point(77, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // label_id_barang
            // 
            this.label_id_barang.AutoSize = true;
            this.label_id_barang.Location = new System.Drawing.Point(14, 31);
            this.label_id_barang.Name = "label_id_barang";
            this.label_id_barang.Size = new System.Drawing.Size(53, 13);
            this.label_id_barang.TabIndex = 13;
            this.label_id_barang.Text = "Id Barang";
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(82, 123);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(147, 20);
            this.qty.TabIndex = 14;
            this.qty.TextChanged += new System.EventHandler(this.qty_TextChanged);
            // 
            // id_barang
            // 
            this.id_barang.FormattingEnabled = true;
            this.id_barang.Location = new System.Drawing.Point(6, 11);
            this.id_barang.Name = "id_barang";
            this.id_barang.Size = new System.Drawing.Size(146, 21);
            this.id_barang.TabIndex = 0;
            this.id_barang.SelectedIndexChanged += new System.EventHandler(this.id_barang_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Rp.";
            // 
            // label_qty
            // 
            this.label_qty.AutoSize = true;
            this.label_qty.Location = new System.Drawing.Point(14, 126);
            this.label_qty.Name = "label_qty";
            this.label_qty.Size = new System.Drawing.Size(46, 13);
            this.label_qty.TabIndex = 15;
            this.label_qty.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Total";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(82, 155);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(147, 20);
            this.total.TabIndex = 17;
            this.total.TextChanged += new System.EventHandler(this.total_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Rp.";
            // 
            // FormTransaksiBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 438);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_tbl_admin);
            this.Controls.Add(this.gb_form_transaksibarang);
            this.Controls.Add(this.gb_transaksibarang);
            this.Name = "FormTransaksiBarang";
            this.Text = "FormTransaksiBarang";
            this.Load += new System.EventHandler(this.FormTransaksiBarang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_tbl_admin.ResumeLayout(false);
            this.gb_form_transaksibarang.ResumeLayout(false);
            this.gb_form_transaksibarang.PerformLayout();
            this.gb_transaksibarang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksiBarang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.Label label_caridata;
        private System.Windows.Forms.GroupBox gb_tbl_admin;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox gb_form_transaksibarang;
        private System.Windows.Forms.TextBox harga_barang;
        private System.Windows.Forms.TextBox nama_barang;
        private System.Windows.Forms.Label label_harga;
        private System.Windows.Forms.Label label_barang;
        private System.Windows.Forms.GroupBox gb_transaksibarang;
        private System.Windows.Forms.DataGridView DataTransaksiBarang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_id_barang;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.ComboBox id_barang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_qty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox total;
    }
}