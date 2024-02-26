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
    public partial class Form8 : Form
    {
        DataGridView dtgridview;
        public Form8(DataGridView dtgridview)
        {
            InitializeComponent();
            this.dtgridview = dtgridview;
            this.CenterToScreen();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt = new DataTable();
                DataBaseHandler handler = new DataBaseHandler(String.Format("Select * from SaglikPersonelleri where personelid = {0}", textBox1.Text));
                dt = handler.TableExtracter();
                dtgridview.DataSource = dt;
            }

        }

        private void Form8_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
