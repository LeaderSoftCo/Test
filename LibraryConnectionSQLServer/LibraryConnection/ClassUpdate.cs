using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryConnection
{
    public class ClassUpdate
    {

        ClassConnection _ClassConnection = new ClassConnection();

        public void UpdateOpration(string[] SqlColumens, string[] SqlValue, string[] SqlWhere, string[] SqlWhereValue, string TableName, bool ShowMessageBox)
        {
            DataTable DS = new DataTable();
            string SQLColumnesANDValue = "";
            string SQLWhereANDValue = "";

            try
            {

                for (int i = 0; i < SqlColumens.Length; i++)
                {
                    if (i == SqlColumens.Length - 1)
                    {
                        SQLColumnesANDValue += SqlColumens[i] + "='" + SqlValue[i] + "'";
                    }
                    else
                    {
                        SQLColumnesANDValue += SqlColumens[i] + "='" + SqlValue[i] + "',";
                    }
                }
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

                string SQLStatment = "Update " + TableName + " Set " + SQLColumnesANDValue + (SQLWhereANDValue == "" ? "" : (" Where " + SQLWhereANDValue));
                SqlConnection Conn = _ClassConnection.ConnectionOpration();

                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }

                Conn.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(SQLStatment, Conn);
                Adapter.Fill(DS);
                Conn.Close();

                if (ShowMessageBox == true)
                {
                    MessageBox.Show("تمت العملية بنجاح");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
