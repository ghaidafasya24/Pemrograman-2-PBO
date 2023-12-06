namespace P5_4_714220031
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
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpLahir = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbKomposer = new System.Windows.Forms.CheckBox();
            this.cbVokal = new System.Windows.Forms.CheckBox();
            this.cbDrum = new System.Windows.Forms.CheckBox();
            this.cbPiano = new System.Windows.Forms.CheckBox();
            this.cbKonduktor = new System.Windows.Forms.CheckBox();
            this.cbSaxophone = new System.Windows.Forms.CheckBox();
            this.cbGitar = new System.Windows.Forms.CheckBox();
            this.cbBiola = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_senin = new System.Windows.Forms.RadioButton();
            this.rb_selasa = new System.Windows.Forms.RadioButton();
            this.rb_sabtu = new System.Windows.Forms.RadioButton();
            this.rb_minggu = new System.Windows.Forms.RadioButton();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(458, 84);
            this.txtNama.Margin = new System.Windows.Forms.Padding(4);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(200, 23);
            this.txtNama.TabIndex = 0;
            this.txtNama.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "FORM PENDAFTARAN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Jenis Kelamin";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtpLahir
            // 
            this.dtpLahir.Location = new System.Drawing.Point(458, 173);
            this.dtpLahir.Name = "dtpLahir";
            this.dtpLahir.Size = new System.Drawing.Size(200, 23);
            this.dtpLahir.TabIndex = 4;
            this.dtpLahir.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tanggal Lahir";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pria",
            "Wanita"});
            this.comboBox1.Location = new System.Drawing.Point(458, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 26);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbKomposer);
            this.groupBox1.Controls.Add(this.cbVokal);
            this.groupBox1.Controls.Add(this.cbDrum);
            this.groupBox1.Controls.Add(this.cbPiano);
            this.groupBox1.Controls.Add(this.cbKonduktor);
            this.groupBox1.Controls.Add(this.cbSaxophone);
            this.groupBox1.Controls.Add(this.cbGitar);
            this.groupBox1.Controls.Add(this.cbBiola);
            this.groupBox1.Location = new System.Drawing.Point(171, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 200);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilihan Kelas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbKomposer
            // 
            this.cbKomposer.AutoSize = true;
            this.cbKomposer.Location = new System.Drawing.Point(168, 156);
            this.cbKomposer.Name = "cbKomposer";
            this.cbKomposer.Size = new System.Drawing.Size(87, 22);
            this.cbKomposer.TabIndex = 19;
            this.cbKomposer.Text = "Komposer";
            this.cbKomposer.UseVisualStyleBackColor = true;
            // 
            // cbVokal
            // 
            this.cbVokal.AutoSize = true;
            this.cbVokal.Location = new System.Drawing.Point(168, 119);
            this.cbVokal.Name = "cbVokal";
            this.cbVokal.Size = new System.Drawing.Size(59, 22);
            this.cbVokal.TabIndex = 18;
            this.cbVokal.Text = "Vokal";
            this.cbVokal.UseVisualStyleBackColor = true;
            this.cbVokal.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // cbDrum
            // 
            this.cbDrum.AutoSize = true;
            this.cbDrum.Location = new System.Drawing.Point(168, 81);
            this.cbDrum.Name = "cbDrum";
            this.cbDrum.Size = new System.Drawing.Size(60, 22);
            this.cbDrum.TabIndex = 17;
            this.cbDrum.Text = "Drum";
            this.cbDrum.UseVisualStyleBackColor = true;
            // 
            // cbPiano
            // 
            this.cbPiano.AutoSize = true;
            this.cbPiano.Location = new System.Drawing.Point(168, 43);
            this.cbPiano.Name = "cbPiano";
            this.cbPiano.Size = new System.Drawing.Size(61, 22);
            this.cbPiano.TabIndex = 16;
            this.cbPiano.Text = "Piano";
            this.cbPiano.UseVisualStyleBackColor = true;
            // 
            // cbKonduktor
            // 
            this.cbKonduktor.AutoSize = true;
            this.cbKonduktor.Location = new System.Drawing.Point(23, 157);
            this.cbKonduktor.Name = "cbKonduktor";
            this.cbKonduktor.Size = new System.Drawing.Size(91, 22);
            this.cbKonduktor.TabIndex = 15;
            this.cbKonduktor.Text = "Konduktor";
            this.cbKonduktor.UseVisualStyleBackColor = true;
            // 
            // cbSaxophone
            // 
            this.cbSaxophone.AutoSize = true;
            this.cbSaxophone.Location = new System.Drawing.Point(23, 119);
            this.cbSaxophone.Name = "cbSaxophone";
            this.cbSaxophone.Size = new System.Drawing.Size(93, 22);
            this.cbSaxophone.TabIndex = 14;
            this.cbSaxophone.Text = "Saxophone";
            this.cbSaxophone.UseVisualStyleBackColor = true;
            // 
            // cbGitar
            // 
            this.cbGitar.AutoSize = true;
            this.cbGitar.Location = new System.Drawing.Point(23, 81);
            this.cbGitar.Name = "cbGitar";
            this.cbGitar.Size = new System.Drawing.Size(58, 22);
            this.cbGitar.TabIndex = 13;
            this.cbGitar.Text = "Gitar";
            this.cbGitar.UseVisualStyleBackColor = true;
            // 
            // cbBiola
            // 
            this.cbBiola.AutoSize = true;
            this.cbBiola.Location = new System.Drawing.Point(23, 43);
            this.cbBiola.Name = "cbBiola";
            this.cbBiola.Size = new System.Drawing.Size(57, 22);
            this.cbBiola.TabIndex = 9;
            this.cbBiola.Text = "Biola";
            this.cbBiola.UseVisualStyleBackColor = true;
            this.cbBiola.CheckedChanged += new System.EventHandler(this.cbBiola_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_senin);
            this.groupBox2.Controls.Add(this.rb_selasa);
            this.groupBox2.Controls.Add(this.rb_sabtu);
            this.groupBox2.Controls.Add(this.rb_minggu);
            this.groupBox2.Location = new System.Drawing.Point(518, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 200);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilihan Jadwal";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rb_senin
            // 
            this.rb_senin.AutoSize = true;
            this.rb_senin.Location = new System.Drawing.Point(19, 42);
            this.rb_senin.Name = "rb_senin";
            this.rb_senin.Size = new System.Drawing.Size(204, 22);
            this.rb_senin.TabIndex = 9;
            this.rb_senin.TabStop = true;
            this.rb_senin.Text = "Senin && Rabu, 14.00 - 16.00";
            this.rb_senin.UseVisualStyleBackColor = true;
            this.rb_senin.CheckedChanged += new System.EventHandler(this.rb_senin_CheckedChanged);
            // 
            // rb_selasa
            // 
            this.rb_selasa.AutoSize = true;
            this.rb_selasa.Location = new System.Drawing.Point(19, 81);
            this.rb_selasa.Name = "rb_selasa";
            this.rb_selasa.Size = new System.Drawing.Size(213, 22);
            this.rb_selasa.TabIndex = 10;
            this.rb_selasa.TabStop = true;
            this.rb_selasa.Text = "Selasa && Kamis, 14.00 - 16.00";
            this.rb_selasa.UseVisualStyleBackColor = true;
            // 
            // rb_sabtu
            // 
            this.rb_sabtu.AutoSize = true;
            this.rb_sabtu.Location = new System.Drawing.Point(19, 119);
            this.rb_sabtu.Name = "rb_sabtu";
            this.rb_sabtu.Size = new System.Drawing.Size(218, 22);
            this.rb_sabtu.TabIndex = 11;
            this.rb_sabtu.TabStop = true;
            this.rb_sabtu.Text = "Sabtu && Minggu, 09.00 - 11.00";
            this.rb_sabtu.UseVisualStyleBackColor = true;
            // 
            // rb_minggu
            // 
            this.rb_minggu.AutoSize = true;
            this.rb_minggu.Location = new System.Drawing.Point(19, 156);
            this.rb_minggu.Name = "rb_minggu";
            this.rb_minggu.Size = new System.Drawing.Size(166, 22);
            this.rb_minggu.TabIndex = 12;
            this.rb_minggu.TabStop = true;
            this.rb_minggu.Text = "Minggu, 13.00 - 17.00";
            this.rb_minggu.UseVisualStyleBackColor = true;
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnTampilkan.Location = new System.Drawing.Point(404, 437);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(97, 23);
            this.btnTampilkan.TabIndex = 9;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = false;
            this.btnTampilkan.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button2.Location = new System.Drawing.Point(518, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Selesai";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(938, 546);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpLahir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNama);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpLahir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_senin;
        private System.Windows.Forms.RadioButton rb_sabtu;
        private System.Windows.Forms.RadioButton rb_selasa;
        private System.Windows.Forms.RadioButton rb_minggu;
        private System.Windows.Forms.CheckBox cbBiola;
        private System.Windows.Forms.CheckBox cbVokal;
        private System.Windows.Forms.CheckBox cbDrum;
        private System.Windows.Forms.CheckBox cbPiano;
        private System.Windows.Forms.CheckBox cbKonduktor;
        private System.Windows.Forms.CheckBox cbSaxophone;
        private System.Windows.Forms.CheckBox cbGitar;
        private System.Windows.Forms.CheckBox cbKomposer;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button button2;
    }
}

