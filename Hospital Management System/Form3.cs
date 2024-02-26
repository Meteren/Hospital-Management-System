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
using static System.Net.Mime.MediaTypeNames;

namespace Hospital_Management_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            SiraNoTextBox.Enabled = false;
            PolIdTextBox.Enabled = false;
            this.CenterToScreen();
        }

        Form5 form5 = new Form5();


        string dosyano = "";
        private void Ekle_Butonu(object sender, EventArgs e)
        {
            bool check = false;
            bool contains = false;
            TimeSpan currentTime = DateTime.Now.TimeOfDay;
            Random rnd = new Random();
            DataBaseHandler handler = new DataBaseHandler("Select * from HastaIslemleri");
            List<Dictionary<string, dynamic>> tableRows = new List<Dictionary<string, dynamic>>();
            tableRows = handler.ExecuteReading();

            while (!check)
            {
                int random = rnd.Next(100);
                foreach (Dictionary<string, dynamic> s in tableRows)
                {
                    if (s["siraNo"] == random)
                    {
                        //string si = s["siraNo"].ToString();
                        //MessageBox.Show(si);
                        break;
                    }
                    else
                    {
                        //MessageBox.Show(tableRows.IndexOf(s).ToString());
                        if (tableRows.IndexOf(s) + 1 == tableRows.Count)
                        {
                            check = true;
                            SiraNoTextBox.Text = random.ToString();
                        }
                    }
                }
            }
            check = false;

            tableRows.Clear();

            handler = new DataBaseHandler("Select * from Hastalar");
            tableRows = handler.ExecuteReading();

            for (int i = 0; i < tableRows.Count; i++)
            {
                int s = tableRows[i]["hastaid"];

                if (s.ToString() == HastaIdTextBox.Text)
                {
                    contains = true;
                    break;
                }
            }

            try
            {
                if (!contains)
                {
                    handler = new DataBaseHandler(
                    String.Format(
                    "Insert Into Hastalar values('{0}','{1}','{2}','{3}','{4}')", HastaIdTextBox.Text, HastaAdiTextBox.Text,
                    HastaSoyadTextBox.Text, HastaNoTextBox.Text, KurumAdiTextBox.Text));
                    handler.QueryRunner();
                    contains = false;
                }

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Boş değerlere dikkat edin!!");
            }

            try
            {
                string drkod = DoktorKoduTextBox.Text;
                handler = new DataBaseHandler(String.Format("Select polid from Doktorlar where drkodu = {0}", drkod));
                string sKod = handler.IndividualInfoReturn();
                PolIdTextBox.Text = sKod;
                handler = new DataBaseHandler(
               String.Format(
                   "Insert Into HastaIslemleri values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", DosyaNoTextBox.Text, SiraNoTextBox.Text,
                   currentTime.Hours.ToString() + ":" + currentTime.Minutes.ToString(), YapılanIslemTextBox.Text,
                   PolIdTextBox.Text, HastaIdTextBox.Text, DoktorKoduTextBox.Text, numericUpDown1.Value.ToString(), BirimFiyatTextBox.Text, "Hayır", SevkDateTimePicker.Value.ToString("MM-dd-yyyy")
                   ));
                handler.QueryRunner();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Boş değerlere dikkat edin!!");
            }

            MessageBox.Show("Girdiler başarıyla eklendi");

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            dosyano = DosyaNoTextBox.Text;
            DataTable dt = new DataTable();
            if (e.KeyCode == Keys.Enter)
            {
                DataBaseHandler handler = new DataBaseHandler(
                    String.Format("select p.poladi,h.dosyano, h.sirano, h.saat, h.yapilanislem, h.drkodu, h.miktar,h.birimfiyati " +
                   "from Poliklinikler p JOIN HastaIslemleri h ON p.polid = h.polid where h.dosyano = '{0}'"
                   , DosyaNoTextBox.Text)
                   );
                dt = handler.TableExtracter();
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Böyle bir dosya numarası bulunmamaktadır.");
                }
                else
                {
                    dataGridView1.DataSource = dt;
                    double miktar = Convert.ToDouble(dataGridView1.Rows[0].Cells["Miktar"].Value);
                    double birimFiyat = Convert.ToDouble(dataGridView1.Rows[0].Cells["Birimfiyatı"].Value);
                    double tutar = miktar * birimFiyat;
                    TutarLabel.Text = tutar.ToString();

                }

            }
        }

        private void Yeni_Butonu(object sender, EventArgs e)
        {

            foreach (var control in groupBox1.Controls)
            {


                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();
                }
            }
            foreach (var control in groupBox4.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();
                }
            }
            PolIdTextBox.Clear();
            numericUpDown1.Value = 0;
        }

        private void Sec_Sil_Butonu(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                /*DataBaseHandler handler = new DataBaseHandler(
                    String.Format("Delete HastaIslemleri where siraNo = {0}", dataGridView1.Rows[item.Index].Cells[1].Value));
                */
                dataGridView1.Rows.RemoveAt(item.Index);
                //handler.QueryRunner();

            }
        }

        private void Taburcu_Butonu(object sender, EventArgs e)
        {

            try
            {
                string s = "";
                foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
                {
                    DataBaseHandler handler = new DataBaseHandler(String.Format("Select taburcuedildimi from HastaIslemleri where dosyano = {0}",
                        dataGridView1.Rows[row.Index].Cells[1].Value));
                    s = handler.IndividualInfoReturn();
                    if (s != "Evet")
                    {
                        handler = new DataBaseHandler(String.Format("Update HastaIslemleri Set taburcuedildimi = 'Evet'" +
                         " where dosyano = '{0}'", dataGridView1.Rows[row.Index].Cells[1].Value));
                        handler.QueryRunner();
                    }
                    else
                    {
                        MessageBox.Show("Hasta zaten taburcu edilmiş!");
                    }

                }
                if (s != "Evet")
                    MessageBox.Show("Hasta taburcu edildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata!! " + ex.Message.ToString());
            }


        }

        private void Bul_Butonu(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(DosyaNoTextBox);
            form4.ShowDialog();
        }

        private void Hasta_Bilgileri_Butonu(object sender, EventArgs e)
        {
            if (form5.IsDisposed)
            {
                form5 = new Form5();
            }
            form5.ShowDialog();
        }

        private void Cikis_Butonu(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
