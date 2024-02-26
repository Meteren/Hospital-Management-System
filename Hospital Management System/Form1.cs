using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class Form1 : Form
    {
        Form10 form10 = new Form10();
        Form8 form8;
        Form2 form2;
        Form7 form7;
        Form9 form9 = new Form9();
        Form3 form3 = new Form3();
        Form6 form6 = new Form6();
        public Form1(Form2 form2)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.form2 = form2;
            form7 = new Form7(dataGridView1);
            form8 = new Form8(dataGridView1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (form3.IsDisposed)
            {
                form3 = new Form3();
            }
            form3.ShowDialog();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (form6.IsDisposed)
            {
                form6 = new Form6();
            }
            form6.ShowDialog();
        }

        private void Cikis_Butonu(object sender, EventArgs e)
        {
            this.Close();
            form2.Close();
        }

        private void Doktor_Goster_Butonu(object sender, EventArgs e)
        {
            if (form7.IsDisposed)
            {
                form7 = new Form7(dataGridView1);
            }
            form7.ShowDialog();

        }

        private void Personel_Goster_Butonu(object sender, EventArgs e)
        {
            if (form8.IsDisposed)
            {
                form8 = new Form8(dataGridView1);
            }
            form8.ShowDialog();
        }

        private void Kullanicilari_Gor_Butonu(object sender, EventArgs e)
        {
            if (form9.IsDisposed)
            {
                form9 = new Form9();
            }
            form9.ShowDialog();
        }

        private void Poliklinik_Sec_Butonu(object sender, EventArgs e)
        {
            if (form10.IsDisposed)
            {
                form10 = new Form10();
            }
            form10.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            form2.Close();
        }
    }

}
