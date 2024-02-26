namespace Hospital_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button4 = new Button();
            button5 = new Button();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            button7 = new Button();
            label4 = new Label();
            button6 = new Button();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(63, 78);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Seç";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Doktor_Goster_Butonu;
            // 
            // button2
            // 
            button2.Location = new Point(77, 78);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Seç";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(76, 142);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Seç";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(199, 40);
            label1.Name = "label1";
            label1.Size = new Size(213, 42);
            label1.TabIndex = 5;
            label1.Text = "Hoş Geldiniz";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 55);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 6;
            label2.Text = "Hasta İşlemleri İçin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 119);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 7;
            label3.Text = "Raporlar İçin";
            // 
            // button4
            // 
            button4.Location = new Point(530, 602);
            button4.Name = "button4";
            button4.Size = new Size(94, 40);
            button4.TabIndex = 8;
            button4.Text = "Çıkış";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Cikis_Butonu;
            // 
            // button5
            // 
            button5.Location = new Point(63, 206);
            button5.Name = "button5";
            button5.Size = new Size(94, 28);
            button5.TabIndex = 9;
            button5.Text = "Seç";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Kullanicilari_Gor_Butonu;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button5);
            groupBox1.Location = new Point(28, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 257);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personeller Bloğu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 183);
            label8.Name = "label8";
            label8.Size = new Size(169, 20);
            label8.TabIndex = 10;
            label8.Text = "Kullanıcıları Görmek İçin";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 119);
            label7.Name = "label7";
            label7.Size = new Size(156, 20);
            label7.TabIndex = 4;
            label7.Text = "Sağlık Personelleri İçin";
            // 
            // button7
            // 
            button7.Location = new Point(63, 142);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 3;
            button7.Text = "Seç";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Personel_Goster_Butonu;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 55);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 2;
            label4.Text = "Doktorlar İçin";
            // 
            // button6
            // 
            button6.Location = new Point(76, 206);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 3;
            button6.Text = "Seç";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Poliklinik_Sec_Butonu;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-2, 408);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(635, 188);
            dataGridView1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 385);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 13;
            label6.Text = "Personel Bilgileri";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(button3);
            groupBox2.Location = new Point(357, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 257);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hastane İşlemleri Bloğu";
            // 
            // label5
            // 
            label5.Location = new Point(57, 183);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 4;
            label5.Text = "Poliklinikler İçin";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(636, 652);
            Controls.Add(groupBox2);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ana Sayfa";
            FormClosed += Form1_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button4;
        private Button button5;
        private GroupBox groupBox1;
        private Label label4;
        private Button button6;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label7;
        private Button button7;
        private GroupBox groupBox2;
        private Label label8;
        private Label label5;
    }
}