namespace Hospital_Management_System
{
    partial class Form9
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SifreTextBox = new TextBox();
            SoyadiTextBox = new TextBox();
            AdiTextBox = new TextBox();
            IdTextBox = new TextBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(40, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 177);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı Bul";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 60);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Id";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 27);
            textBox1.TabIndex = 0;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 223);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(798, 188);
            dataGridView1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(SifreTextBox);
            groupBox2.Controls.Add(SoyadiTextBox);
            groupBox2.Controls.Add(AdiTextBox);
            groupBox2.Controls.Add(IdTextBox);
            groupBox2.Location = new Point(444, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(318, 177);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kullanıcı Kaydet";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(6, 105);
            button1.Name = "button1";
            button1.Size = new Size(63, 48);
            button1.TabIndex = 8;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Ekle_Butonu;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 144);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 7;
            label5.Text = "Şifre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 23);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 6;
            label4.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 105);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 5;
            label3.Text = "Soyadı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 64);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 4;
            label2.Text = "Adı";
            // 
            // SifreTextBox
            // 
            SifreTextBox.Location = new Point(149, 144);
            SifreTextBox.Name = "SifreTextBox";
            SifreTextBox.Size = new Size(125, 27);
            SifreTextBox.TabIndex = 3;
            SifreTextBox.UseSystemPasswordChar = true;
            // 
            // SoyadiTextBox
            // 
            SoyadiTextBox.Location = new Point(149, 102);
            SoyadiTextBox.Name = "SoyadiTextBox";
            SoyadiTextBox.Size = new Size(125, 27);
            SoyadiTextBox.TabIndex = 2;
            // 
            // AdiTextBox
            // 
            AdiTextBox.Location = new Point(149, 60);
            AdiTextBox.Name = "AdiTextBox";
            AdiTextBox.Size = new Size(125, 27);
            AdiTextBox.TabIndex = 1;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(149, 17);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(125, 27);
            IdTextBox.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Location = new Point(655, 417);
            button2.Name = "button2";
            button2.Size = new Size(94, 34);
            button2.TabIndex = 3;
            button2.Text = "Düzenle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Düzenle_Butonu;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 463);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Form9";
            Text = "Kullanıcı Yönetim";
            FormClosed += Form9_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private TextBox SifreTextBox;
        private TextBox SoyadiTextBox;
        private TextBox AdiTextBox;
        private TextBox IdTextBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}