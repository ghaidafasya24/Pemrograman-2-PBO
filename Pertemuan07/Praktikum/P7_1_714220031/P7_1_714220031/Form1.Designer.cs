namespace P7_1_714220031
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
            this.label_nama = new System.Windows.Forms.Label();
            this.label_prodi = new System.Windows.Forms.Label();
            this.label_kelas = new System.Windows.Forms.Label();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.txt_prodi = new System.Windows.Forms.TextBox();
            this.txt_kelas = new System.Windows.Forms.TextBox();
            this.btn_tpesan = new System.Windows.Forms.Button();
            this.btn_cek = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_senin = new System.Windows.Forms.RadioButton();
            this.rb_minggu = new System.Windows.Forms.RadioButton();
            this.cb_kuliah = new System.Windows.Forms.CheckBox();
            this.cb_traveling = new System.Windows.Forms.CheckBox();
            this.cb_tidur = new System.Windows.Forms.CheckBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_nama
            // 
            this.label_nama.AutoSize = true;
            this.label_nama.Location = new System.Drawing.Point(35, 46);
            this.label_nama.Name = "label_nama";
            this.label_nama.Size = new System.Drawing.Size(35, 13);
            this.label_nama.TabIndex = 0;
            this.label_nama.Text = "Nama";
            // 
            // label_prodi
            // 
            this.label_prodi.AutoSize = true;
            this.label_prodi.Location = new System.Drawing.Point(35, 89);
            this.label_prodi.Name = "label_prodi";
            this.label_prodi.Size = new System.Drawing.Size(31, 13);
            this.label_prodi.TabIndex = 1;
            this.label_prodi.Text = "Prodi";
            // 
            // label_kelas
            // 
            this.label_kelas.AutoSize = true;
            this.label_kelas.Location = new System.Drawing.Point(35, 135);
            this.label_kelas.Name = "label_kelas";
            this.label_kelas.Size = new System.Drawing.Size(33, 13);
            this.label_kelas.TabIndex = 2;
            this.label_kelas.Text = "Kelas";
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(113, 43);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(204, 20);
            this.txt_nama.TabIndex = 3;
            this.txt_nama.TextChanged += new System.EventHandler(this.txt_nama_TextChanged);
            // 
            // txt_prodi
            // 
            this.txt_prodi.Location = new System.Drawing.Point(113, 86);
            this.txt_prodi.Name = "txt_prodi";
            this.txt_prodi.Size = new System.Drawing.Size(204, 20);
            this.txt_prodi.TabIndex = 4;
            this.txt_prodi.TextChanged += new System.EventHandler(this.txt_prodi_TextChanged);
            // 
            // txt_kelas
            // 
            this.txt_kelas.Location = new System.Drawing.Point(113, 135);
            this.txt_kelas.Name = "txt_kelas";
            this.txt_kelas.Size = new System.Drawing.Size(204, 20);
            this.txt_kelas.TabIndex = 5;
            // 
            // btn_tpesan
            // 
            this.btn_tpesan.Location = new System.Drawing.Point(234, 177);
            this.btn_tpesan.Name = "btn_tpesan";
            this.btn_tpesan.Size = new System.Drawing.Size(83, 23);
            this.btn_tpesan.TabIndex = 6;
            this.btn_tpesan.Text = "Tutup Pesan";
            this.btn_tpesan.UseVisualStyleBackColor = true;
            this.btn_tpesan.Click += new System.EventHandler(this.button_tutuppesan_Click);
            // 
            // btn_cek
            // 
            this.btn_cek.Location = new System.Drawing.Point(131, 177);
            this.btn_cek.Name = "btn_cek";
            this.btn_cek.Size = new System.Drawing.Size(75, 23);
            this.btn_cek.TabIndex = 7;
            this.btn_cek.Text = "Cek";
            this.btn_cek.UseVisualStyleBackColor = true;
            this.btn_cek.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "LIST KEGIATAN";
            // 
            // rb_senin
            // 
            this.rb_senin.AutoSize = true;
            this.rb_senin.Location = new System.Drawing.Point(38, 264);
            this.rb_senin.Name = "rb_senin";
            this.rb_senin.Size = new System.Drawing.Size(52, 17);
            this.rb_senin.TabIndex = 9;
            this.rb_senin.TabStop = true;
            this.rb_senin.Text = "Senin";
            this.rb_senin.UseVisualStyleBackColor = true;
            this.rb_senin.CheckedChanged += new System.EventHandler(this.rb_senin_CheckedChanged);
            // 
            // rb_minggu
            // 
            this.rb_minggu.AutoSize = true;
            this.rb_minggu.Location = new System.Drawing.Point(38, 287);
            this.rb_minggu.Name = "rb_minggu";
            this.rb_minggu.Size = new System.Drawing.Size(60, 17);
            this.rb_minggu.TabIndex = 10;
            this.rb_minggu.TabStop = true;
            this.rb_minggu.Text = "Minggu";
            this.rb_minggu.UseVisualStyleBackColor = true;
            this.rb_minggu.CheckedChanged += new System.EventHandler(this.rb_minggu_CheckedChanged);
            // 
            // cb_kuliah
            // 
            this.cb_kuliah.AutoSize = true;
            this.cb_kuliah.Location = new System.Drawing.Point(38, 320);
            this.cb_kuliah.Name = "cb_kuliah";
            this.cb_kuliah.Size = new System.Drawing.Size(55, 17);
            this.cb_kuliah.TabIndex = 11;
            this.cb_kuliah.Text = "Kuliah";
            this.cb_kuliah.UseVisualStyleBackColor = true;
            // 
            // cb_traveling
            // 
            this.cb_traveling.AutoSize = true;
            this.cb_traveling.Location = new System.Drawing.Point(38, 343);
            this.cb_traveling.Name = "cb_traveling";
            this.cb_traveling.Size = new System.Drawing.Size(70, 17);
            this.cb_traveling.TabIndex = 12;
            this.cb_traveling.Text = "Traveling";
            this.cb_traveling.UseVisualStyleBackColor = true;
            this.cb_traveling.CheckedChanged += new System.EventHandler(this.cb_traveling_CheckedChanged);
            // 
            // cb_tidur
            // 
            this.cb_tidur.AutoSize = true;
            this.cb_tidur.Location = new System.Drawing.Point(38, 366);
            this.cb_tidur.Name = "cb_tidur";
            this.cb_tidur.Size = new System.Drawing.Size(50, 17);
            this.cb_tidur.TabIndex = 13;
            this.cb_tidur.Text = "Tidur";
            this.cb_tidur.UseVisualStyleBackColor = true;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(131, 396);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 14;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(242, 396);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 15;
            this.btn_reset.Text = "Reset Form";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(384, 220);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.cb_tidur);
            this.Controls.Add(this.cb_traveling);
            this.Controls.Add(this.cb_kuliah);
            this.Controls.Add(this.rb_minggu);
            this.Controls.Add(this.rb_senin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cek);
            this.Controls.Add(this.btn_tpesan);
            this.Controls.Add(this.txt_kelas);
            this.Controls.Add(this.txt_prodi);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.label_kelas);
            this.Controls.Add(this.label_prodi);
            this.Controls.Add(this.label_nama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nama;
        private System.Windows.Forms.Label label_prodi;
        private System.Windows.Forms.Label label_kelas;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.TextBox txt_prodi;
        private System.Windows.Forms.TextBox txt_kelas;
        private System.Windows.Forms.Button btn_tpesan;
        private System.Windows.Forms.Button btn_cek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_senin;
        private System.Windows.Forms.RadioButton rb_minggu;
        private System.Windows.Forms.CheckBox cb_kuliah;
        private System.Windows.Forms.CheckBox cb_traveling;
        private System.Windows.Forms.CheckBox cb_tidur;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_reset;
    }
}

