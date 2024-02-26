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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public string Distributor(string taburcuedildimi, string dt1, string dt2)
        {
            string s = "";
            if (taburcuedildimi != "Hepsi")
            {
                s = String.Format("select hi.dosyano, h.hastaadi, h.hastasoyadi, hi.sevktarihi, p.poladi, d.dradi, d.drsoyadi from Hastalar h JOIN HastaIslemleri hi " +
                               "ON h.hastaid = hi.hastaid JOIN Doktorlar d " +
                               "ON d.drkodu = hi.drkodu JOIN Poliklinikler p " +
                               "ON p.polid = hi.polid where hi.sevktarihi between '{0}' and '{1}' and hi.taburcuedildimi = '{2}'", dt1, dt2, taburcuedildimi);
            }
            else
            {
                s = String.Format("select hi.dosyano, h.hastaadi, h.hastasoyadi, hi.sevktarihi, p.poladi, d.dradi, d.drsoyadi from Hastalar h JOIN HastaIslemleri hi " +
                                "ON h.hastaid = hi.hastaid JOIN Doktorlar d " +
                                "ON d.drkodu = hi.drkodu JOIN Poliklinikler p " +
                                "ON p.polid = hi.polid where hi.sevktarihi between '{0}' and '{1}'", dt1, dt2);
            }

            return s;
        }

        private void Sorgula(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string dt1 = dateTimePicker1.Value.ToString("MM-dd-yyyy");
            string dt2 = dateTimePicker2.Value.ToString("MM-dd-yyyy");
            if (radioButton1.Checked)
            {
                DataBaseHandler handler = new DataBaseHandler(Distributor("Evet", dt1, dt2));
                dt = handler.TableExtracter();
                dataGridView1.DataSource = dt;

            }
            if (radioButton2.Checked)
            {
                DataBaseHandler handler = new DataBaseHandler(Distributor("Hayır", dt1, dt2));
                dt = handler.TableExtracter();
                dataGridView1.DataSource = dt;
            }
            if (radioButton3.Checked)
            {
                DataBaseHandler handler = new DataBaseHandler(Distributor("Hepsi", dt1, dt2));
                dt = handler.TableExtracter();
                dataGridView1.DataSource = dt;
            }

        }

        private void Temizle_Butonu(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
