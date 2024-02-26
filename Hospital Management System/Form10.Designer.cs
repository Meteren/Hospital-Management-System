namespace Hospital_Management_System
{
    partial class Form10
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
            button2 = new Button();
            groupBox2 = new GroupBox();
            button1 = new Button();
            label4 = new Label();
            label2 = new Label();
            AdiTextBox = new TextBox();
            IdTextBox = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Location = new Point(654, 404);
            button2.Name = "button2";
            button2.Size = new Size(94, 34);
            button2.TabIndex = 7;
            button2.Text = "Düzenle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Duzenle_Butonu;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(AdiTextBox);
            groupBox2.Controls.Add(IdTextBox);
            groupBox2.Location = new Point(443, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(318, 177);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Poliklinik Kaydet";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(18, 114);
            button1.Name = "button1";
            button1.Size = new Size(63, 48);
            button1.TabIndex = 8;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Ekle_Butonu;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 42);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 6;
            label4.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 90);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 4;
            label2.Text = "Adı";
            // 
            // AdiTextBox
            // 
            AdiTextBox.Location = new Point(149, 90);
            AdiTextBox.Name = "AdiTextBox";
            AdiTextBox.Size = new Size(125, 27);
            AdiTextBox.TabIndex = 1;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(149, 42);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(125, 27);
            IdTextBox.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 210);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(798, 188);
            dataGridView1.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(39, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 177);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Poliklinik Bul";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 60);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 1;
            label1.Text = "Poliklinik Id";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 27);
            textBox1.TabIndex = 0;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Form10";
            Text = "Poliklinik İşlemleri";
            FormClosed += Form10_FormClosed;
            Load += Form10_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private GroupBox groupBox2;
        private Button button1;
        private Label label4;
        private Label label2;
        private TextBox AdiTextBox;
        private TextBox IdTextBox;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
    }
}