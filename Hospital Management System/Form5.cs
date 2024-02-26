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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            this.CenterToScreen();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox1.Enabled = true;
            }
            if (radioButton1.Checked == false)
            {
                textBox1.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textBox2.Enabled = true;
            }
            if (radioButton2.Checked == false)
            {
                textBox2.Enabled = false;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt = new DataTable();
                DataBaseHandler handler = new DataBaseHandler(
                    String.Format("select * from Hastalar where hastaid = {0}", textBox1.Text));
                dt = handler.TableExtracter();
                dataGridView1.DataSource = dt;
            }
        }

        private void Duzenle_Butonu(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[0];
            try
            {
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    //MessageBox.Show(column.Name + row.Cells[column.Name].Value);

                    DataBaseHandler handler = new DataBaseHandler(String.Format("Update Hastalar Set {0} = '{1}'  where hastaid = {2}",
                       column.Name, row.Cells[column.Name].Value, row.Cells["hastaid"].Value));
                    handler.QueryRunner();

                }
                MessageBox.Show("Düzenleme işlemi başarılı!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata!!! " + ex.Message.ToString());
            }


        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt = new DataTable();
                DataBaseHandler handler = new DataBaseHandler(
                    String.Format("select * from Hastalar where telefonno = {0}", textBox2.Text));
                dt = handler.TableExtracter();
                dataGridView1.DataSource = dt;
            }
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}

