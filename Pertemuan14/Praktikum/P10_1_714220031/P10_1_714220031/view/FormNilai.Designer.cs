namespace P10_1_714220031.view
{
    partial class FormNilai
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
            this.gb_form_datamhs = new System.Windows.Forms.GroupBox();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.cbkategori = new System.Windows.Forms.ComboBox();
            this.cbmatkul = new System.Windows.Forms.ComboBox();
            this.tbnilai = new System.Windows.Forms.TextBox();
            this.cbnpm = new System.Windows.Forms.ComboBox();
            this.label_alamat = new System.Windows.Forms.Label();
            this.label_npm = new System.Windows.Forms.Label();
            this.label_kategori = new System.Windows.Forms.Label();
            this.label_matkul = new System.Windows.Forms.Label();
            this.gb_datamhs = new System.Windows.Forms.GroupBox();
            this.DataNilai = new System.Windows.Forms.DataGridView();
            this.ExportExcel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gb_tbl_admin.SuspendLayout();
            this.gb_form_datamhs.SuspendLayout();
            this.gb_datamhs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataNilai)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ExportExcel);
            this.groupBox1.Controls.Add(this.tbCariData);
            this.groupBox1.Controls.Add(this.label_caridata);
            this.groupBox1.Location = new System.Drawing.Point(441, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 82);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Pencarian";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(63, 22);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(220, 20);
            this.tbCariData.TabIndex = 12;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // label_caridata
            // 
            this.label_caridata.AutoSize = true;
            this.label_caridata.Location = new System.Drawing.Point(6, 25);
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
            this.gb_tbl_admin.Location = new System.Drawing.Point(441, 294);
            this.gb_tbl_admin.Name = "gb_tbl_admin";
            this.gb_tbl_admin.Size = new System.Drawing.Size(306, 151);
            this.gb_tbl_admin.TabIndex = 6;
            this.gb_tbl_admin.TabStop = false;
            this.gb_tbl_admin.Text = "Tombol Action";
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
            // gb_form_datamhs
            // 
            this.gb_form_datamhs.Controls.Add(this.tbnama);
            this.gb_form_datamhs.Controls.Add(this.cbkategori);
            this.gb_form_datamhs.Controls.Add(this.cbmatkul);
            this.gb_form_datamhs.Controls.Add(this.tbnilai);
            this.gb_form_datamhs.Controls.Add(this.cbnpm);
            this.gb_form_datamhs.Controls.Add(this.label_alamat);
            this.gb_form_datamhs.Controls.Add(this.label_npm);
            this.gb_form_datamhs.Controls.Add(this.label_kategori);
            this.gb_form_datamhs.Controls.Add(this.label_matkul);
            this.gb_form_datamhs.Location = new System.Drawing.Point(9, 202);
            this.gb_form_datamhs.Name = "gb_form_datamhs";
            this.gb_form_datamhs.Size = new System.Drawing.Size(426, 240);
            this.gb_form_datamhs.TabIndex = 5;
            this.gb_form_datamhs.TabStop = false;
            this.gb_form_datamhs.Text = "Form Input Nilai";
            // 
            // tbnama
            // 
            this.tbnama.Location = new System.Drawing.Point(262, 102);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(158, 20);
            this.tbnama.TabIndex = 14;
            // 
            // cbkategori
            // 
            this.cbkategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkategori.FormattingEnabled = true;
            this.cbkategori.Items.AddRange(new object[] {
            "UTS",
            "UAS"});
            this.cbkategori.Location = new System.Drawing.Point(67, 60);
            this.cbkategori.Name = "cbkategori";
            this.cbkategori.Size = new System.Drawing.Size(189, 21);
            this.cbkategori.TabIndex = 13;
            // 
            // cbmatkul
            // 
            this.cbmatkul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmatkul.FormattingEnabled = true;
            this.cbmatkul.Items.AddRange(new object[] {
            "Pemrograman I",
            "Pemrograman II",
            "Pemrograman II",
            "Pemrograman IV",
            "Literasi Data",
            "Sistem ERP",
            "RPL",
            "Metodologi Penelitian",
            "PKN",
            "General English I"});
            this.cbmatkul.Location = new System.Drawing.Point(67, 20);
            this.cbmatkul.Name = "cbmatkul";
            this.cbmatkul.Size = new System.Drawing.Size(189, 21);
            this.cbmatkul.TabIndex = 12;
            // 
            // tbnilai
            // 
            this.tbnilai.Location = new System.Drawing.Point(67, 144);
            this.tbnilai.Name = "tbnilai";
            this.tbnilai.Size = new System.Drawing.Size(189, 20);
            this.tbnilai.TabIndex = 10;
            // 
            // cbnpm
            // 
            this.cbnpm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbnpm.FormattingEnabled = true;
            this.cbnpm.Location = new System.Drawing.Point(67, 102);
            this.cbnpm.Name = "cbnpm";
            this.cbnpm.Size = new System.Drawing.Size(189, 21);
            this.cbnpm.TabIndex = 9;
            this.cbnpm.SelectedIndexChanged += new System.EventHandler(this.cbnpm_SelectedIndexChanged);
            // 
            // label_alamat
            // 
            this.label_alamat.AutoSize = true;
            this.label_alamat.Location = new System.Drawing.Point(7, 147);
            this.label_alamat.Name = "label_alamat";
            this.label_alamat.Size = new System.Drawing.Size(27, 13);
            this.label_alamat.TabIndex = 3;
            this.label_alamat.Text = "Nilai";
            // 
            // label_npm
            // 
            this.label_npm.AutoSize = true;
            this.label_npm.Location = new System.Drawing.Point(7, 105);
            this.label_npm.Name = "label_npm";
            this.label_npm.Size = new System.Drawing.Size(31, 13);
            this.label_npm.TabIndex = 2;
            this.label_npm.Text = "NPM";
            // 
            // label_kategori
            // 
            this.label_kategori.AutoSize = true;
            this.label_kategori.Location = new System.Drawing.Point(7, 63);
            this.label_kategori.Name = "label_kategori";
            this.label_kategori.Size = new System.Drawing.Size(46, 13);
            this.label_kategori.TabIndex = 1;
            this.label_kategori.Text = "Kategori";
            // 
            // label_matkul
            // 
            this.label_matkul.AutoSize = true;
            this.label_matkul.Location = new System.Drawing.Point(7, 23);
            this.label_matkul.Name = "label_matkul";
            this.label_matkul.Size = new System.Drawing.Size(39, 13);
            this.label_matkul.TabIndex = 0;
            this.label_matkul.Text = "Matkul";
            // 
            // gb_datamhs
            // 
            this.gb_datamhs.Controls.Add(this.DataNilai);
            this.gb_datamhs.Location = new System.Drawing.Point(9, 8);
            this.gb_datamhs.Name = "gb_datamhs";
            this.gb_datamhs.Size = new System.Drawing.Size(738, 188);
            this.gb_datamhs.TabIndex = 4;
            this.gb_datamhs.TabStop = false;
            this.gb_datamhs.Text = "Table Data Nilai";
            // 
            // DataNilai
            // 
            this.DataNilai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataNilai.Location = new System.Drawing.Point(10, 19);
            this.DataNilai.Name = "DataNilai";
            this.DataNilai.Size = new System.Drawing.Size(711, 163);
            this.DataNilai.TabIndex = 0;
            this.DataNilai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataNilai_CellClick);
            // 
            // ExportExcel
            // 
            this.ExportExcel.BackColor = System.Drawing.Color.Green;
            this.ExportExcel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ExportExcel.Location = new System.Drawing.Point(63, 51);
            this.ExportExcel.Name = "ExportExcel";
            this.ExportExcel.Size = new System.Drawing.Size(220, 23);
            this.ExportExcel.TabIndex = 4;
            this.ExportExcel.Text = "Export Excel";
            this.ExportExcel.UseVisualStyleBackColor = false;
            this.ExportExcel.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_tbl_admin);
            this.Controls.Add(this.gb_form_datamhs);
            this.Controls.Add(this.gb_datamhs);
            this.Name = "FormNilai";
            this.Text = "FormNilai";
            this.Load += new System.EventHandler(this.FormNilai_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_tbl_admin.ResumeLayout(false);
            this.gb_form_datamhs.ResumeLayout(false);
            this.gb_form_datamhs.PerformLayout();
            this.gb_datamhs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataNilai)).EndInit();
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
        private System.Windows.Forms.GroupBox gb_form_datamhs;
        private System.Windows.Forms.TextBox tbnilai;
        private System.Windows.Forms.ComboBox cbnpm;
        private System.Windows.Forms.Label label_alamat;
        private System.Windows.Forms.Label label_npm;
        private System.Windows.Forms.Label label_kategori;
        private System.Windows.Forms.Label label_matkul;
        private System.Windows.Forms.GroupBox gb_datamhs;
        private System.Windows.Forms.DataGridView DataNilai;
        private System.Windows.Forms.ComboBox cbkategori;
        private System.Windows.Forms.ComboBox cbmatkul;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.Button ExportExcel;
    }
}