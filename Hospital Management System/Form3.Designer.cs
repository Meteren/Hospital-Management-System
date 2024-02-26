namespace Hospital_Management_System
{
    partial class Form3
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Miktar = new DataGridViewTextBoxColumn();
            BirimFiyatı = new DataGridViewTextBoxColumn();
            button1 = new Button();
            groupBox1 = new GroupBox();
            KurumAdiTextBox = new TextBox();
            label14 = new Label();
            button4 = new Button();
            HastaNoTextBox = new TextBox();
            HastaSoyadTextBox = new TextBox();
            HastaIdTextBox = new TextBox();
            label7 = new Label();
            HastaAdiTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            SevkDateTimePicker = new DateTimePicker();
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            DosyaNoTextBox = new TextBox();
            groupBox4 = new GroupBox();
            PolIdTextBox = new TextBox();
            label13 = new Label();
            BirimFiyatTextBox = new TextBox();
            label12 = new Label();
            DoktorKoduTextBox = new TextBox();
            label11 = new Label();
            YapılanIslemTextBox = new TextBox();
            label10 = new Label();
            SiraNoTextBox = new TextBox();
            label9 = new Label();
            label8 = new Label();
            numericUpDown1 = new NumericUpDown();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            label15 = new Label();
            TutarLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column8, Column2, Column3, Column4, Column5, Miktar, BirimFiyatı });
            dataGridView1.Location = new Point(3, 281);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(957, 209);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "poladi";
            Column1.HeaderText = "Poliklinik";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "dosyano";
            Column8.HeaderText = "Dosya No";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "sirano";
            Column2.HeaderText = "Sıra No";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "saat";
            Column3.HeaderText = "Saat";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "yapilanislem";
            Column4.HeaderText = "Yapılan İşlem";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "drkodu";
            Column5.HeaderText = "Dr. Kodu";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Miktar
            // 
            Miktar.DataPropertyName = "miktar";
            Miktar.HeaderText = "Miktar";
            Miktar.MinimumWidth = 6;
            Miktar.Name = "Miktar";
            Miktar.Width = 125;
            // 
            // BirimFiyatı
            // 
            BirimFiyatı.DataPropertyName = "birimfiyati";
            BirimFiyatı.HeaderText = "Birim Fiyatı";
            BirimFiyatı.MinimumWidth = 6;
            BirimFiyatı.Name = "BirimFiyatı";
            BirimFiyatı.Width = 125;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(850, 15);
            button1.Name = "button1";
            button1.Size = new Size(94, 58);
            button1.TabIndex = 1;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Ekle_Butonu;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(KurumAdiTextBox);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(HastaNoTextBox);
            groupBox1.Controls.Add(HastaSoyadTextBox);
            groupBox1.Controls.Add(HastaIdTextBox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(HastaAdiTextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(SevkDateTimePicker);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(DosyaNoTextBox);
            groupBox1.Location = new Point(0, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(966, 188);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // KurumAdiTextBox
            // 
            KurumAdiTextBox.Location = new Point(486, 140);
            KurumAdiTextBox.Name = "KurumAdiTextBox";
            KurumAdiTextBox.Size = new Size(125, 27);
            KurumAdiTextBox.TabIndex = 18;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(391, 140);
            label14.Name = "label14";
            label14.Size = new Size(79, 20);
            label14.TabIndex = 17;
            label14.Text = "Kurum Adı";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.GradientActiveCaption;
            button4.Location = new Point(643, 53);
            button4.Name = "button4";
            button4.Size = new Size(277, 106);
            button4.TabIndex = 16;
            button4.Text = "Hasta Bilgileri";
            button4.UseVisualStyleBackColor = false;
            button4.Click += Hasta_Bilgileri_Butonu;
            // 
            // HastaNoTextBox
            // 
            HastaNoTextBox.Location = new Point(486, 107);
            HastaNoTextBox.Name = "HastaNoTextBox";
            HastaNoTextBox.Size = new Size(125, 27);
            HastaNoTextBox.TabIndex = 15;
            // 
            // HastaSoyadTextBox
            // 
            HastaSoyadTextBox.Location = new Point(486, 74);
            HastaSoyadTextBox.Name = "HastaSoyadTextBox";
            HastaSoyadTextBox.Size = new Size(125, 27);
            HastaSoyadTextBox.TabIndex = 14;
            // 
            // HastaIdTextBox
            // 
            HastaIdTextBox.Location = new Point(486, 11);
            HastaIdTextBox.Name = "HastaIdTextBox";
            HastaIdTextBox.Size = new Size(33, 27);
            HastaIdTextBox.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(406, 15);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 12;
            label7.Text = "Hasta Id";
            // 
            // HastaAdiTextBox
            // 
            HastaAdiTextBox.Location = new Point(486, 43);
            HastaAdiTextBox.Name = "HastaAdiTextBox";
            HastaAdiTextBox.Size = new Size(125, 27);
            HastaAdiTextBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(396, 48);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 10;
            label6.Text = "Hasta Adı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(374, 77);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 9;
            label5.Text = "Hasta Soyadı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(356, 110);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 8;
            label4.Text = "Hasta Telefon No";
            // 
            // SevkDateTimePicker
            // 
            SevkDateTimePicker.Location = new Point(97, 87);
            SevkDateTimePicker.Name = "SevkDateTimePicker";
            SevkDateTimePicker.Size = new Size(235, 27);
            SevkDateTimePicker.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Location = new Point(248, 44);
            button2.Name = "button2";
            button2.Size = new Size(56, 29);
            button2.TabIndex = 3;
            button2.Text = "Bul";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Bul_Butonu;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 92);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 2;
            label2.Text = "Sevk Tarihi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 1;
            label1.Text = "Dosya No";
            // 
            // DosyaNoTextBox
            // 
            DosyaNoTextBox.Location = new Point(107, 46);
            DosyaNoTextBox.Name = "DosyaNoTextBox";
            DosyaNoTextBox.Size = new Size(125, 27);
            DosyaNoTextBox.TabIndex = 0;
            DosyaNoTextBox.KeyDown += textBox1_KeyDown;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ActiveCaption;
            groupBox4.Controls.Add(PolIdTextBox);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(BirimFiyatTextBox);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(DoktorKoduTextBox);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(YapılanIslemTextBox);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(SiraNoTextBox);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(numericUpDown1);
            groupBox4.Controls.Add(button1);
            groupBox4.Location = new Point(0, 195);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(960, 80);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            // 
            // PolIdTextBox
            // 
            PolIdTextBox.Location = new Point(12, 38);
            PolIdTextBox.Name = "PolIdTextBox";
            PolIdTextBox.Size = new Size(125, 27);
            PolIdTextBox.TabIndex = 14;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(738, 15);
            label13.Name = "label13";
            label13.Size = new Size(79, 20);
            label13.TabIndex = 13;
            label13.Text = "Birim Fiyat";
            // 
            // BirimFiyatTextBox
            // 
            BirimFiyatTextBox.Location = new Point(719, 37);
            BirimFiyatTextBox.Name = "BirimFiyatTextBox";
            BirimFiyatTextBox.Size = new Size(125, 27);
            BirimFiyatTextBox.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(623, 15);
            label12.Name = "label12";
            label12.Size = new Size(51, 20);
            label12.TabIndex = 11;
            label12.Text = "Miktar";
            // 
            // DoktorKoduTextBox
            // 
            DoktorKoduTextBox.Location = new Point(459, 38);
            DoktorKoduTextBox.Name = "DoktorKoduTextBox";
            DoktorKoduTextBox.Size = new Size(125, 27);
            DoktorKoduTextBox.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(472, 15);
            label11.Name = "label11";
            label11.Size = new Size(94, 20);
            label11.TabIndex = 9;
            label11.Text = "Doktor Kodu";
            // 
            // YapılanIslemTextBox
            // 
            YapılanIslemTextBox.Location = new Point(309, 38);
            YapılanIslemTextBox.Name = "YapılanIslemTextBox";
            YapılanIslemTextBox.Size = new Size(125, 27);
            YapılanIslemTextBox.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(320, 13);
            label10.Name = "label10";
            label10.Size = new Size(96, 20);
            label10.TabIndex = 7;
            label10.Text = "Yapılan İşlem";
            // 
            // SiraNoTextBox
            // 
            SiraNoTextBox.Location = new Point(163, 38);
            SiraNoTextBox.Name = "SiraNoTextBox";
            SiraNoTextBox.Size = new Size(125, 27);
            SiraNoTextBox.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(188, 15);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 5;
            label9.Text = "Sıra No";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 14);
            label8.Name = "label8";
            label8.Size = new Size(84, 20);
            label8.TabIndex = 4;
            label8.Text = "Poliklinik Id";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(607, 37);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(91, 27);
            numericUpDown1.TabIndex = 2;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.GradientActiveCaption;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(3, 538);
            button5.Name = "button5";
            button5.Size = new Size(101, 52);
            button5.TabIndex = 4;
            button5.Text = "Yeni";
            button5.UseVisualStyleBackColor = false;
            button5.Click += Yeni_Butonu;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.GradientActiveCaption;
            button6.ForeColor = Color.Red;
            button6.Location = new Point(122, 538);
            button6.Name = "button6";
            button6.Size = new Size(101, 52);
            button6.TabIndex = 5;
            button6.Text = "Seç-Sil";
            button6.UseVisualStyleBackColor = false;
            button6.Click += Sec_Sil_Butonu;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.GradientActiveCaption;
            button7.ForeColor = Color.Black;
            button7.Location = new Point(248, 538);
            button7.Name = "button7";
            button7.Size = new Size(101, 52);
            button7.TabIndex = 6;
            button7.Text = "Taburcu";
            button7.UseVisualStyleBackColor = false;
            button7.Click += Taburcu_Butonu;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.GradientActiveCaption;
            button8.ForeColor = Color.Black;
            button8.Location = new Point(819, 538);
            button8.Name = "button8";
            button8.Size = new Size(101, 52);
            button8.TabIndex = 7;
            button8.Text = "Çıkış";
            button8.UseVisualStyleBackColor = false;
            button8.Click += Cikis_Butonu;
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label15.Location = new Point(752, 501);
            label15.Name = "label15";
            label15.Size = new Size(120, 25);
            label15.TabIndex = 8;
            label15.Text = "Toplam Tutar:";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TutarLabel
            // 
            TutarLabel.AutoSize = true;
            TutarLabel.Location = new Point(878, 503);
            TutarLabel.Name = "TutarLabel";
            TutarLabel.Size = new Size(17, 20);
            TutarLabel.TabIndex = 9;
            TutarLabel.Text = "0";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(959, 599);
            Controls.Add(TutarLabel);
            Controls.Add(label15);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form3";
            Text = "Hasta İşlemleri";
            FormClosed += Form3_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private GroupBox groupBox1;
        private DateTimePicker SevkDateTimePicker;
        private Button button2;
        private Label label2;
        private Label label1;
        private TextBox DosyaNoTextBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox HastaAdiTextBox;
        private Label label7;
        private Button button4;
        private TextBox HastaNoTextBox;
        private TextBox HastaSoyadTextBox;
        private TextBox HastaIdTextBox;
        private GroupBox groupBox4;
        private NumericUpDown numericUpDown1;
        private Label label9;
        private Label label8;
        private Label label13;
        private TextBox BirimFiyatTextBox;
        private Label label12;
        private TextBox DoktorKoduTextBox;
        private Label label11;
        private TextBox YapılanIslemTextBox;
        private Label label10;
        private TextBox SiraNoTextBox;
        private Label label14;
        private TextBox KurumAdiTextBox;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private TextBox PolIdTextBox;
        private Label label15;
        private Label TutarLabel;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Miktar;
        private DataGridViewTextBoxColumn BirimFiyatı;
    }
}