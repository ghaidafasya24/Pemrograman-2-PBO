namespace P10_1_714220031.view
{
    partial class FormBarang
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
            this.gb_form_inputbarang = new System.Windows.Forms.GroupBox();
            this.nama_barang = new System.Windows.Forms.TextBox();
            this.label_barang = new System.Windows.Forms.Label();
            this.gb_datamhs = new System.Windows.Forms.GroupBox();
            this.DataBarang = new System.Windows.Forms.DataGridView();
            this.label_harga = new System.Windows.Forms.Label();
            this.harga = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gb_tbl_admin.SuspendLayout();
            this.gb_form_inputbarang.SuspendLayout();
            this.gb_datamhs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCariData);
            this.groupBox1.Controls.Add(this.label_caridata);
            this.groupBox1.Location = new System.Drawing.Point(1, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 69);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Pencarian";
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(85, 28);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(266, 20);
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
            this.gb_tbl_admin.Location = new System.Drawing.Point(433, 190);
            this.gb_tbl_admin.Name = "gb_tbl_admin";
            this.gb_tbl_admin.Size = new System.Drawing.Size(306, 151);
            this.gb_tbl_admin.TabIndex = 6;
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
            // gb_form_inputbarang
            // 
            this.gb_form_inputbarang.Controls.Add(this.harga);
            this.gb_form_inputbarang.Controls.Add(this.nama_barang);
            this.gb_form_inputbarang.Controls.Add(this.label_harga);
            this.gb_form_inputbarang.Controls.Add(this.label_barang);
            this.gb_form_inputbarang.Location = new System.Drawing.Point(1, 183);
            this.gb_form_inputbarang.Name = "gb_form_inputbarang";
            this.gb_form_inputbarang.Size = new System.Drawing.Size(426, 84);
            this.gb_form_inputbarang.TabIndex = 5;
            this.gb_form_inputbarang.TabStop = false;
            this.gb_form_inputbarang.Text = "Form Input Barang";
            // 
            // nama_barang
            // 
            this.nama_barang.Location = new System.Drawing.Point(85, 20);
            this.nama_barang.Name = "nama_barang";
            this.nama_barang.Size = new System.Drawing.Size(266, 20);
            this.nama_barang.TabIndex = 6;
            // 
            // label_barang
            // 
            this.label_barang.AutoSize = true;
            this.label_barang.Location = new System.Drawing.Point(7, 23);
            this.label_barang.Name = "label_barang";
            this.label_barang.Size = new System.Drawing.Size(72, 13);
            this.label_barang.TabIndex = 0;
            this.label_barang.Text = "Nama Barang";
            // 
            // gb_datamhs
            // 
            this.gb_datamhs.Controls.Add(this.DataBarang);
            this.gb_datamhs.Location = new System.Drawing.Point(1, -11);
            this.gb_datamhs.Name = "gb_datamhs";
            this.gb_datamhs.Size = new System.Drawing.Size(738, 188);
            this.gb_datamhs.TabIndex = 4;
            this.gb_datamhs.TabStop = false;
            this.gb_datamhs.Text = "Table Data Mahasiswa";
            // 
            // DataBarang
            // 
            this.DataBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBarang.Location = new System.Drawing.Point(10, 19);
            this.DataBarang.Name = "DataBarang";
            this.DataBarang.Size = new System.Drawing.Size(711, 163);
            this.DataBarang.TabIndex = 0;
            this.DataBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataBarang_CellClick);
            this.DataBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataBarang_CellContentClick);
            this.DataBarang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataBarang_CellFormatting);
            // 
            // label_harga
            // 
            this.label_harga.AutoSize = true;
            this.label_harga.Location = new System.Drawing.Point(7, 56);
            this.label_harga.Name = "label_harga";
            this.label_harga.Size = new System.Drawing.Size(36, 13);
            this.label_harga.TabIndex = 1;
            this.label_harga.Text = "Harga";
            // 
            // harga
            // 
            this.harga.Location = new System.Drawing.Point(85, 56);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(266, 20);
            this.harga.TabIndex = 7;
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 348);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_tbl_admin);
            this.Controls.Add(this.gb_form_inputbarang);
            this.Controls.Add(this.gb_datamhs);
            this.Name = "FormBarang";
            this.Text = "FormBarang";
            this.Load += new System.EventHandler(this.FormBarang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_tbl_admin.ResumeLayout(false);
            this.gb_form_inputbarang.ResumeLayout(false);
            this.gb_form_inputbarang.PerformLayout();
            this.gb_datamhs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataBarang)).EndInit();
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
        private System.Windows.Forms.GroupBox gb_form_inputbarang;
        private System.Windows.Forms.TextBox nama_barang;
        private System.Windows.Forms.Label label_barang;
        private System.Windows.Forms.GroupBox gb_datamhs;
        private System.Windows.Forms.DataGridView DataBarang;
        private System.Windows.Forms.Label label_harga;
        private System.Windows.Forms.TextBox harga;
    }
}