using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt = new DataTable();
                DataBaseHandler handler = new DataBaseHandler(String.Format("Select * from Kullanicilar where KullaniciId = {0}", textBox1.Text));
                dt = handler.TableExtracter();
                dataGridView1.DataSource = dt;
            }
        }

        private void Ekle_Butonu(object sender, EventArgs e)
        {
            try
            {
                DataBaseHandler handler = new DataBaseHandler(String.Format("Insert Into Kullanicilar values({0},'{1}','{2}','{3}')",
                IdTextBox.Text, AdiTextBox.Text, SoyadiTextBox.Text, SifreTextBox.Text));
                handler.QueryRunner();
                MessageBox.Show("Kullanıcı başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata!! " + ex.Message.ToString());
            }

        }

        private void Düzenle_Butonu(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView1.Rows[0];
            try
            {
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    try
                    {
                        DataBaseHandler handler = new DataBaseHandler(String.Format("Update Kullanicilar Set {0} = '{1}' where KullaniciId = {2}",
                       column.Name, row.Cells[column.Name].Value, row.Cells["KullaniciId"].Value));
                        handler.QueryRunner();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata!!! " + ex.Message.ToString());
                    }

                }
                MessageBox.Show("Düzenleme işlemi başarılı!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata!!! " + ex.Message.ToString());
            }

        }

        private void Form9_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
