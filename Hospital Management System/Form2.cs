using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2()
        {
            InitializeComponent();
            this.CenterToScreen();
            form1 = new Form1(this);
            
        }

        List<Dictionary<string, dynamic>> tableRows = new List<Dictionary<string, dynamic>>();
        


        private void Giris_Butonu(object sender, EventArgs e)
        {
            DataBaseHandler handler = new DataBaseHandler("Select * from Kullanicilar");
            tableRows = handler.ExecuteReading();
            for (int i = 0; i < tableRows.Count; i++)
            {

                if (tableRows[i]["KullaniciAdi"] == textBox1.Text && tableRows[i]["KullaniciSifre"] == textBox2.Text)
                {

                    form1.Show();
                    this.Hide();
                    MessageBox.Show("Giriş başarılı.");
                    
                    
                    break;
                }

                if (i + 1 == tableRows.Count)
                {
                    MessageBox.Show("Böyle bir kayıt sistemde yer almamaktadır.");
                }


            }
        }

        private void Temizle_Butonu(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Cikis_Butonu(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



