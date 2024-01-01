namespace P10_1_714220031
{
    partial class Form1
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
            this.gb_datamhs = new System.Windows.Forms.GroupBox();
            this.DataMahasiswa = new System.Windows.Forms.DataGridView();
            this.gb_form_datamhs = new System.Windows.Forms.GroupBox();
            this.nohp = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.angkatan = new System.Windows.Forms.ComboBox();
            this.alamat = new System.Windows.Forms.TextBox();
            this.nama = new System.Windows.Forms.TextBox();
            this.npm = new System.Windows.Forms.TextBox();
            this.label_nohp = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_alamat = new System.Windows.Forms.Label();
            this.label_angkatan = new System.Windows.Forms.Label();
            this.label_nama = new System.Windows.Forms.Label();
            this.label_npm = new System.Windows.Forms.Label();
            this.gb_tbl_admin = new System.Windows.Forms.GroupBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_caridata = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.gb_datamhs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).BeginInit();
            this.gb_form_datamhs.SuspendLayout();
            this.gb_tbl_admin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_datamhs
            // 
            this.gb_datamhs.Controls.Add(this.DataMahasiswa);
            this.gb_datamhs.Location = new System.Drawing.Point(12, 12);
            this.gb_datamhs.Name = "gb_datamhs";
            this.gb_datamhs.Size = new System.Drawing.Size(738, 188);
            this.gb_datamhs.TabIndex = 0;
            this.gb_datamhs.TabStop = false;
            this.gb_datamhs.Text = "Table Data Mahasiswa";
            // 
            // DataMahasiswa
            // 
            this.DataMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMahasiswa.Location = new System.Drawing.Point(10, 19);
            this.DataMahasiswa.Name = "DataMahasiswa";
            this.DataMahasiswa.Size = new System.Drawing.Size(711, 163);
            this.DataMahasiswa.TabIndex = 0;
            this.DataMahasiswa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataMahasiswa_CellClick);
            // 
            // gb_form_datamhs
            // 
            this.gb_form_datamhs.Controls.Add(this.nohp);
            this.gb_form_datamhs.Controls.Add(this.email);
            this.gb_form_datamhs.Controls.Add(this.angkatan);
            this.gb_form_datamhs.Controls.Add(this.alamat);
            this.gb_form_datamhs.Controls.Add(this.nama);
            this.gb_form_datamhs.Controls.Add(this.npm);
            this.gb_form_datamhs.Controls.Add(this.label_nohp);
            this.gb_form_datamhs.Controls.Add(this.label_email);
            this.gb_form_datamhs.Controls.Add(this.label_alamat);
            this.gb_form_datamhs.Controls.Add(this.label_angkatan);
            this.gb_form_datamhs.Controls.Add(this.label_nama);
            this.gb_form_datamhs.Controls.Add(this.label_npm);
            this.gb_form_datamhs.Location = new System.Drawing.Point(12, 206);
            this.gb_form_datamhs.Name = "gb_form_datamhs";
            this.gb_form_datamhs.Size = new System.Drawing.Size(426, 240);
            this.gb_form_datamhs.TabIndex = 1;
            this.gb_form_datamhs.TabStop = false;
            this.gb_form_datamhs.Text = "Form Data Mahasiswa";
            // 
            // nohp
            // 
            this.nohp.Location = new System.Drawing.Point(67, 194);
            this.nohp.Name = "nohp";
            this.nohp.Size = new System.Drawing.Size(284, 20);
            this.nohp.TabIndex = 11;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(67, 158);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(284, 20);
            this.email.TabIndex = 10;
            // 
            // angkatan
            // 
            this.angkatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.angkatan.FormattingEnabled = true;
            this.angkatan.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.angkatan.Location = new System.Drawing.Point(67, 83);
            this.angkatan.Name = "angkatan";
            this.angkatan.Size = new System.Drawing.Size(284, 21);
            this.angkatan.TabIndex = 9;
            this.angkatan.SelectedIndexChanged += new System.EventHandler(this.angkatan_SelectedIndexChanged);
            // 
            // alamat
            // 
            this.alamat.Location = new System.Drawing.Point(67, 113);
            this.alamat.Multiline = true;
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(284, 38);
            this.alamat.TabIndex = 8;
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(67, 53);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(284, 20);
            this.nama.TabIndex = 7;
            // 
            // npm
            // 
            this.npm.Location = new System.Drawing.Point(67, 20);
            this.npm.Name = "npm";
            this.npm.Size = new System.Drawing.Size(284, 20);
            this.npm.TabIndex = 6;
            // 
            // label_nohp
            // 
            this.label_nohp.AutoSize = true;
            this.label_nohp.Location = new System.Drawing.Point(7, 197);
            this.label_nohp.Name = "label_nohp";
            this.label_nohp.Size = new System.Drawing.Size(39, 13);
            this.label_nohp.TabIndex = 5;
            this.label_nohp.Text = "No HP";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(7, 161);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(32, 13);
            this.label_email.TabIndex = 4;
            this.label_email.Text = "Email";
            // 
            // label_alamat
            // 
            this.label_alamat.AutoSize = true;
            this.label_alamat.Location = new System.Drawing.Point(7, 113);
            this.label_alamat.Name = "label_alamat";
            this.label_alamat.Size = new System.Drawing.Size(39, 13);
            this.label_alamat.TabIndex = 3;
            this.label_alamat.Text = "Alamat";
            // 
            // label_angkatan
            // 
            this.label_angkatan.AutoSize = true;
            this.label_angkatan.Location = new System.Drawing.Point(7, 86);
            this.label_angkatan.Name = "label_angkatan";
            this.label_angkatan.Size = new System.Drawing.Size(53, 13);
            this.label_angkatan.TabIndex = 2;
            this.label_angkatan.Text = "Angkatan";
            // 
            // label_nama
            // 
            this.label_nama.AutoSize = true;
            this.label_nama.Location = new System.Drawing.Point(7, 56);
            this.label_nama.Name = "label_nama";
            this.label_nama.Size = new System.Drawing.Size(35, 13);
            this.label_nama.TabIndex = 1;
            this.label_nama.Text = "Nama";
            // 
            // label_npm
            // 
            this.label_npm.AutoSize = true;
            this.label_npm.Location = new System.Drawing.Point(7, 23);
            this.label_npm.Name = "label_npm";
            this.label_npm.Size = new System.Drawing.Size(31, 13);
            this.label_npm.TabIndex = 0;
            this.label_npm.Text = "NPM";
            // 
            // gb_tbl_admin
            // 
            this.gb_tbl_admin.Controls.Add(this.btnHapus);
            this.gb_tbl_admin.Controls.Add(this.btnUbah);
            this.gb_tbl_admin.Controls.Add(this.btnSimpan);
            this.gb_tbl_admin.Controls.Add(this.btnRefresh);
            this.gb_tbl_admin.Location = new System.Drawing.Point(444, 295);
            this.gb_tbl_admin.Name = "gb_tbl_admin";
            this.gb_tbl_admin.Size = new System.Drawing.Size(306, 151);
            this.gb_tbl_admin.TabIndex = 2;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCariData);
            this.groupBox1.Controls.Add(this.label_caridata);
            this.groupBox1.Location = new System.Drawing.Point(444, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 69);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Pencarian";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(63, 28);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(220, 20);
            this.tbCariData.TabIndex = 12;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_tbl_admin);
            this.Controls.Add(this.gb_form_datamhs);
            this.Controls.Add(this.gb_datamhs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_datamhs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).EndInit();
            this.gb_form_datamhs.ResumeLayout(false);
            this.gb_form_datamhs.PerformLayout();
            this.gb_tbl_admin.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_datamhs;
        private System.Windows.Forms.GroupBox gb_form_datamhs;
        private System.Windows.Forms.Label label_angkatan;
        private System.Windows.Forms.Label label_nama;
        private System.Windows.Forms.Label label_npm;
        private System.Windows.Forms.GroupBox gb_tbl_admin;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.ComboBox angkatan;
        private System.Windows.Forms.TextBox alamat;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.TextBox npm;
        private System.Windows.Forms.Label label_nohp;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_alamat;
        private System.Windows.Forms.DataGridView DataMahasiswa;
        private System.Windows.Forms.TextBox nohp;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label_caridata;
        private System.Windows.Forms.TextBox tbCariData;
    }
}

