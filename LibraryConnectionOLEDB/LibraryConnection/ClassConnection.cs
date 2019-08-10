using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace LibraryConnection
{
    public class ClassConnection
    {





        string ConnectionPath = "";

        public OleDbConnection ConnectionOpration()
        {

            //ConnectionPath = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
            // Application.StartupPath + @"\DataBaseLeaderSoft.mdb ;Jet OLEDB:Database Password=1223334444;";

            ConnectionPath = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " +
           Application.StartupPath + @"\DataBaseLeaderSoft.accdb ;";
 

            OleDbConnection Conn = new OleDbConnection(ConnectionPath);


            return Conn;
        }

        public void ExecuteQuery(string SQLInsert, bool ShowMessageBox)
        {

            OleDbConnection Conn = ConnectionOpration();
            OleDbCommand executequery = new OleDbCommand();
            executequery.Connection = Conn;
            executequery.CommandType = CommandType.Text;
            executequery.CommandText = SQLInsert;

            try
            {

                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
                Conn.Open();
                executequery.ExecuteNonQuery();
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
