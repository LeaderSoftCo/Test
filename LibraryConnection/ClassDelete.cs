using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryConnection
{
    public class ClassDelete
    {
        ClassConnection _ClassConnection = new ClassConnection();

        public void DeleteOpration(string[] SqlWhere, string[] SqlWhereValue, string TableName, bool ShowMessageBox)
        {
            DataTable DS = new DataTable();
            string SQLWhereANDValue = "";

            try
            {

                if (SqlWhere != null)
                {

                    for (int i = 0; i < SqlWhere.Length; i++)
                    {
                        if (i == SqlWhere.Length - 1)
                        {
                            SQLWhereANDValue += SqlWhere[i] + "='" + SqlWhereValue[i] + "'";
                        }
                        else
                        {
                            SQLWhereANDValue += SqlWhere[i] + "='" + SqlWhereValue[i] + "',";
                        }
                    }
                }
                string SQLStatment = "Delete From " + TableName + (SQLWhereANDValue == "" ? "" : (" Where " + SQLWhereANDValue));

                SqlConnection Conn = _ClassConnection.ConnectionOpration();

                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }

                if (ShowMessageBox == true)
                {
                    MessageBox.Show("تمت العملية بنجاح");
                }

                Conn.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(SQLStatment, Conn);
                Adapter.Fill(DS);
                Conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
