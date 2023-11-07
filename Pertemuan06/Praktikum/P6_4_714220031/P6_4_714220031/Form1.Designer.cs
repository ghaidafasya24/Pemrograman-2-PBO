namespace P6_4_714220031
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.form = new System.Windows.Forms.Label();
            this.label_nama = new System.Windows.Forms.Label();
            this.label_npm = new System.Windows.Forms.Label();
            this.label_jurusan = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.label_alasanmasuk = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_tingkat3 = new System.Windows.Forms.RadioButton();
            this.rb_tingkat2 = new System.Windows.Forms.RadioButton();
            this.rb_tingkat1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // form
            // 
            this.form.AutoSize = true;
            this.form.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form.Location = new System.Drawing.Point(76, 23);
            this.form.Name = "form";
            this.form.Size = new System.Drawing.Size(416, 24);
            this.form.TabIndex = 0;
            this.form.Text = "FORM PENDAFTARAN ORGANISASI MAHASISWA";
            // 
            // label_nama
            // 
            this.label_nama.AutoSize = true;
            this.label_nama.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nama.Location = new System.Drawing.Point(41, 74);
            this.label_nama.Name = "label_nama";
            this.label_nama.Size = new System.Drawing.Size(42, 18);
            this.label_nama.TabIndex = 1;
            this.label_nama.Text = "Nama";
            // 
            // label_npm
            // 
            this.label_npm.AutoSize = true;
            this.label_npm.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_npm.Location = new System.Drawing.Point(41, 113);
            this.label_npm.Name = "label_npm";
            this.label_npm.Size = new System.Drawing.Size(35, 18);
            this.label_npm.TabIndex = 2;
            this.label_npm.Text = "NPM";
            this.label_npm.Click += new System.EventHandler(this.label_npm_Click);
            // 
            // label_jurusan
            // 
            this.label_jurusan.AutoSize = true;
            this.label_jurusan.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_jurusan.Location = new System.Drawing.Point(41, 151);
            this.label_jurusan.Name = "label_jurusan";
            this.label_jurusan.Size = new System.Drawing.Size(58, 18);
            this.label_jurusan.TabIndex = 3;
            this.label_jurusan.Text = "Jurusan";
            this.label_jurusan.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(41, 191);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(41, 18);
            this.label_email.TabIndex = 4;
            this.label_email.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(155, 148);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(198, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(155, 188);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(198, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.Click += new System.EventHandler(this.textBox4_Click);
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // label_alasanmasuk
            // 
            this.label_alasanmasuk.AutoSize = true;
            this.label_alasanmasuk.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_alasanmasuk.Location = new System.Drawing.Point(44, 228);
            this.label_alasanmasuk.Name = "label_alasanmasuk";
            this.label_alasanmasuk.Size = new System.Drawing.Size(90, 18);
            this.label_alasanmasuk.TabIndex = 9;
            this.label_alasanmasuk.Text = "Alasan Masuk";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(155, 225);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(198, 20);
            this.textBox5.TabIndex = 10;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox5.Leave += new System.EventHandler(this.textBox5_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_tingkat3);
            this.groupBox1.Controls.Add(this.rb_tingkat2);
            this.groupBox1.Controls.Add(this.rb_tingkat1);
            this.groupBox1.Location = new System.Drawing.Point(372, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tingkatan";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rb_tingkat3
            // 
            this.rb_tingkat3.AutoSize = true;
            this.rb_tingkat3.Location = new System.Drawing.Point(7, 68);
            this.rb_tingkat3.Name = "rb_tingkat3";
            this.rb_tingkat3.Size = new System.Drawing.Size(70, 17);
            this.rb_tingkat3.TabIndex = 2;
            this.rb_tingkat3.TabStop = true;
            this.rb_tingkat3.Text = "Tingkat 3";
            this.rb_tingkat3.UseVisualStyleBackColor = true;
            // 
            // rb_tingkat2
            // 
            this.rb_tingkat2.AutoSize = true;
            this.rb_tingkat2.Location = new System.Drawing.Point(7, 44);
            this.rb_tingkat2.Name = "rb_tingkat2";
            this.rb_tingkat2.Size = new System.Drawing.Size(70, 17);
            this.rb_tingkat2.TabIndex = 1;
            this.rb_tingkat2.TabStop = true;
            this.rb_tingkat2.Text = "Tingkat 2";
            this.rb_tingkat2.UseVisualStyleBackColor = true;
            this.rb_tingkat2.CheckedChanged += new System.EventHandler(this.rb_tingkat2_CheckedChanged);
            // 
            // rb_tingkat1
            // 
            this.rb_tingkat1.AutoSize = true;
            this.rb_tingkat1.Location = new System.Drawing.Point(7, 20);
            this.rb_tingkat1.Name = "rb_tingkat1";
            this.rb_tingkat1.Size = new System.Drawing.Size(70, 17);
            this.rb_tingkat1.TabIndex = 0;
            this.rb_tingkat1.TabStop = true;
            this.rb_tingkat1.Text = "Tingkat 1";
            this.rb_tingkat1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label_alasanmasuk);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_jurusan);
            this.Controls.Add(this.label_npm);
            this.Controls.Add(this.label_nama);
            this.Controls.Add(this.form);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label form;
        private System.Windows.Forms.Label label_nama;
        private System.Windows.Forms.Label label_npm;
        private System.Windows.Forms.Label label_jurusan;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label_alasanmasuk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_tingkat2;
        private System.Windows.Forms.RadioButton rb_tingkat1;
        private System.Windows.Forms.RadioButton rb_tingkat3;
        private System.Windows.Forms.Button button1;
    }
}

