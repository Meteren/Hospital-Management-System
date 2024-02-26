using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    class DataBaseHandler
    {
        SqlConnection con = new SqlConnection("Integrated Security=SSPI;Initial Catalog=Hastane Yonetim");
        SqlCommand? cmd;
        List<Dictionary<string, dynamic>> tableRows = new List<Dictionary<string, dynamic>>();
        string? s;
        public DataBaseHandler(String? cm)
        {
            this.cmd = cm == null ? null : new SqlCommand(cm, con);
            this.s = cm;
        }

        public SqlCommand CMD
        {
            get { return this.cmd ?? new SqlCommand();}
        }


        public virtual void QueryRunner()
        {
            con.Open();
            if (cmd != null)
            {
                try
                {
                    this.cmd.ExecuteNonQuery();
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    con.Close();
                }
                
            }
            
        }

        public virtual string IndividualInfoReturn()
        {
            string s = "";
            con.Open();
            if (this.cmd != null)
            {
                s = this.cmd.ExecuteScalar().ToString() ?? "";
            }
            con.Close();
            return s;
        }

        public virtual List<Dictionary<string, dynamic>> ExecuteReading()
        {
            con.Open();
            if (cmd != null)
            {
                SqlDataReader read = cmd.ExecuteReader();

                if (read != null)
                {
                    while (read.Read())
                    {
                        Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>();
                        for (int i = 0; i < read.FieldCount; i++)
                        {
                            dict.Add(read.GetName(i), read.GetValue(i));
                        }
                        tableRows.Add(dict);

                    }
                }
            }
            con.Close();
            return tableRows;

        }

        public virtual DataTable TableExtracter()
        {
            DataTable dttb = new DataTable();
            con.Open();
            SqlDataAdapter data = new SqlDataAdapter(s,con);
            try
            {
               data.Fill(dttb);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata!!" + ex.Message.ToString());
            }
            
            return dttb;

        }

    }
}
