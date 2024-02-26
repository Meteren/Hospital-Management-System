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
    public partial class Form4 : Form
    {
        TextBox dosyaNoTextBox;
        TextBox adBox;
        TextBox soyAdBox;
        TextBox telefonNoBox;
        public Form4(TextBox dosyaNoTextBox)
        {
            InitializeComponent();
            this.dosyaNoTextBox = dosyaNoTextBox;
            adBox = new TextBox();
            soyAdBox = new TextBox();
            telefonNoBox = new TextBox();
            adBox.Location = new Point(comboBox1.Location.X + comboBox1.Width + 10, comboBox1.Location.Y);
            soyAdBox.Location = new Point(adBox.Location.X + adBox.Width + 10, comboBox1.Location.Y);
            telefonNoBox.Location = new Point(comboBox1.Location.X + comboBox1.Width + 10, comboBox1.Location.Y);
            telefonNoBox.Size = new Size(comboBox1.Width - 20, comboBox1.Width);
            this.CenterToScreen();

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Ad ve Soyad")
            {
                if (this.Controls.Contains(telefonNoBox))
                {
                    this.Controls.Remove(telefonNoBox);
                }

                this.Controls.Add(adBox);
                this.Controls.Add(soyAdBox);

            }
            if (comboBox1.SelectedItem.ToString() == "Telefon No")
            {

                if (this.Controls.Contains(adBox) && this.Controls.Contains(soyAdBox))
                {
                    this.Controls.Remove(adBox);
                    this.Controls.Remove(soyAdBox);
                }
                this.Controls.Add(telefonNoBox);
            }
        }

        private void Sorgula_Butonu(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem.ToString() == "Ad ve Soyad")
                {
                    DataTable dt = new DataTable();
                    DataBaseHandler handler = new DataBaseHandler(String.Format("select hi.dosyano, hi.sevktarihi " +
                        "from HastaIslemleri hi JOIN Hastalar h " +
                        "ON hi.hastaid = h.hastaid where h.hastaadi = '{0}' and h.hastasoyadi = '{1}'", adBox.Text, soyAdBox.Text));
                    dt = handler.TableExtracter();
                    dataGridView1.DataSource = dt;

                }
                if (comboBox1.SelectedItem.ToString() == "Telefon No")
                {

                    DataTable dt = new DataTable();
                    DataBaseHandler handler = new DataBaseHandler(String.Format("select hi.dosyano, hi.sevktarihi " +
                        "from HastaIslemleri hi JOIN Hastalar h " +
                        "ON hi.hastaid = h.hastaid where h.telefonno = '{0}'", telefonNoBox.Text));
                    dt = handler.TableExtracter();
                    dataGridView1.DataSource = dt;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Lütfen gerekli bilgileri seçiniz");
            }

        }

        private void Aktar_Butonu(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                try
                {
                    if (dataGridView1.SelectedRows.Count != 1)
                    {
                        MessageBox.Show("Lütfen bir adet dosya seçiniz.");
                        break;
                    }
                    else
                    {

                        dosyaNoTextBox.Text = dataGridView1.Rows[row.Index].Cells[0].Value.ToString();
                        MessageBox.Show("Aktarıldı");
                        this.Close();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata meydana geldi!! " + ex.Message.ToString());
                }
            }
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
