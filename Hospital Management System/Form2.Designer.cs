namespace Hospital_Management_System
{
    partial class Form2
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
            textBox1 = new TextBox();
            KullaniciAdi = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 27);
            textBox1.TabIndex = 0;
            // 
            // KullaniciAdi
            // 
            KullaniciAdi.AutoSize = true;
            KullaniciAdi.Location = new Point(12, 34);
            KullaniciAdi.Name = "KullaniciAdi";
            KullaniciAdi.Size = new Size(92, 20);
            KullaniciAdi.TabIndex = 1;
            KullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 89);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 2;
            label1.Text = "Şifre";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(289, 27);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(12, 134);
            button1.Name = "button1";
            button1.Size = new Size(94, 61);
            button1.TabIndex = 4;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Giris_Butonu;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(126, 134);
            button2.Name = "button2";
            button2.Size = new Size(94, 61);
            button2.TabIndex = 5;
            button2.Text = "Temizle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Temizle_Butonu;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(293, 134);
            button3.Name = "button3";
            button3.Size = new Size(94, 61);
            button3.TabIndex = 6;
            button3.Text = "Çıkış";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Cikis_Butonu;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(402, 207);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(KullaniciAdi);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Hastane Otomasyon-Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label KullaniciAdi;
        private Label label1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}