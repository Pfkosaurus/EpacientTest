using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace E_Pacient
{
    class dbcontrol
    {
        SqlConnection cn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Dell\source\repos\E-Pacient\dbtest.mdf;Integrated Security = True");
        SqlCommand cm;
        public SqlDataAdapter da;
        private List<SqlParameter> Params = new List<SqlParameter>();
        public DataTable dt;
        public int recordcount;
        public string exception;
        

        public void query(string name, SqlConnection sqlconn)
        {
            recordcount = 0;
            exception = null;
            try
            {
                cn.Open();
                cm = new SqlCommand(name, cn);
                Params.ForEach(p => cm.Parameters.Add(p));
                Params.Clear();
                dt = new DataTable();
                da = new SqlDataAdapter(cm);
                recordcount = da.Fill(dt);

            }
            catch (Exception e)
            {
                exception = "Problem : " + e.Message;
            }
            finally
            {
                {
                    if (cn.State == ConnectionState.Open)
                    {
                        cn.Close();
                    }
                }
            }
        }

        public void Param(string name, object value)
        {
            SqlParameter newparam = new SqlParameter(name, value);
            Params.Add(newparam);
        }

        public bool CheckForError(bool err = false)
        {
            if (string.IsNullOrEmpty(exception))
            {
                return false;
            }

            if (err == true)
            {
                MessageBox.Show(exception, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return true;

        }
    }
}
