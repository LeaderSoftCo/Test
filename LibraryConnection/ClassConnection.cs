using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace LibraryConnection
{
    public class ClassConnection
    {





        string ConnectionPath = "";

        public SqlConnection ConnectionOpration()
        {


           // ConnectionPath = @"Data Source=LAPTOP-6GH5SCH0;Initial Catalog=Test_LeadreSoft; User ID=LeadrSoft; password=1223334444; MultipleActiveResultSets=True;App=EntityFramework";
            ConnectionPath = @"Data Source=LAPTOP-6GH5SCH0;Initial Catalog=DataBaseLeaderSoft;User ID=LeadrSoft";
            SqlConnection Conn = new SqlConnection(ConnectionPath);


            return Conn;
        }

        public void ExecuteQuery(string SQLInsert, bool ShowMessageBox)
        {

            SqlConnection Conn = ConnectionOpration();
            SqlCommand executequery = new SqlCommand();
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
