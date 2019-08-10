using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryConnection
{
    public class ClassInsert
    {

        ClassConnection _ClassConnection = new ClassConnection();

        public void InsertOpration(string[] SqlColumens, string[] SqlValue, string TableName, bool ShowMessageBox)
        {
            DataTable DS = new DataTable();
            string SQLColumnes = "";
            string SQLColumnesValue = "";

            try
            {
                for (int i = 0; i < SqlColumens.Length; i++)
                {

                    if (i == SqlColumens.Length - 1)
                    {
                        SQLColumnes += SqlColumens[i];
                    }
                    else
                    {
                        SQLColumnes += SqlColumens[i] + ",";
                    }
                }
                for (int i = 0; i < SqlValue.Length; i++)
                {
                    //if (SqlValue[i].ToString() == "''")
                    //{
                    //    SQLColumnesValue += "";
                    //}
                    if (i == SqlValue.Length - 1)
                    {
                        SQLColumnesValue += "'" + SqlValue[i] + "'";
                    }
                    else
                    {
                        SQLColumnesValue += "'" + SqlValue[i] + "',";
                    }
                }

                string SQLStatment = "insert into " + TableName + " ( " + SQLColumnes + " ) Values (" + SQLColumnesValue + " ) ";



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
