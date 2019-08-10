using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryConnection
{
    public class ClassSelect
    {

        ClassConnection _ClassConnection = new ClassConnection();


        public enum join
        {
            inner,
            left,
            right
        }

        public enum Operation
        {
            or,
            and
        }

        // ***************** مختصرة Select جملة  ********************      
        //public DataTable SelectOpration(string TableName)
        //{
        //    DataTable DS = new DataTable();
        //    try
        //    {
        //        string SQLStatment = "select * From " + TableName;

        //        OleDbConnection Conn = _ClassConnection.ConnectionOpration();

        //        if (Conn.State == ConnectionState.Open)
        //        {
        //            Conn.Close();
        //        }
        //        Conn.Open();
        //        OleDbDataAdapter Adapter = new OleDbDataAdapter(SQLStatment, Conn);
        //        Adapter.Fill(DS);
        //        Conn.Close();


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }


        //    return DS;
        //}




        ////////////////////////////////////////////////////////////////////////////////////////////////////






        // 1. select * from Same Table 
        public DataTable SelectOpration(string TableName)
        {
            DataTable DS = new DataTable();

            try
            {

                string SQLStatment = "select * From " + TableName;

                SqlConnection Conn = _ClassConnection.ConnectionOpration();

                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
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


            return DS;
        }


        // 2. select * from Same Table  order by ColName 

        public DataTable SelectOpration(string TableName, string[] orderColName)
        {
            DataTable DS = new DataTable();
            string orederCols = "";

            try
            {

                for (int i = 0; i < orderColName.Length; i++)
                {
                    if (i == orderColName.Length - 1)
                    {
                        orederCols += orderColName[i];
                    }
                    else
                    {
                        orederCols += orderColName[i] + ",";
                    }
                }


                string SQLStatment = "select * From " + TableName + " order by " + orederCols;


                SqlConnection Conn = _ClassConnection.ConnectionOpration();

                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
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

            return DS;
        }





        // 3. Select Specific Columns from Same Table  

        public DataTable SelectOpration(string[] ColumnName, string TableName)
        {
            DataTable DS = new DataTable();
            string SpecificCols = " ";

            try
            {

                for (int i = 0; i < ColumnName.Length; i++)
                {
                    if (i == ColumnName.Length - 1)
                    {
                        SpecificCols += ColumnName[i];
                    }
                    else
                    {
                        SpecificCols += ColumnName[i] + ",";
                    }
                }
                string SQLStatment = "select " + SpecificCols + " From " + TableName;


                SqlConnection Conn = _ClassConnection.ConnectionOpration();

                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
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

            return DS;
        }




        // 4.Select Specific Columns from Same Table order by ColName 

        public DataTable SelectOpration(string[] ColumnName, string TableName, string[] orderColName)
        {
            DataTable DS = new DataTable();
            string SpecificCols = "";
            string orederCols = "";

            try
            {
                for (int i = 0; i < ColumnName.Length; i++)
                {
                    if (i == ColumnName.Length - 1)
                    {
                        SpecificCols += ColumnName[i];
                    }
                    else
                    {
                        SpecificCols += ColumnName[i] + ",";
                    }
                }

                for (int i = 0; i < orderColName.Length; i++)
                {
                    if (i == orderColName.Length - 1)
                    {
                        orederCols += orderColName[i];
                    }
                    else
                    {
                        orederCols += orderColName[i] + ",";
                    }
                }

                string SQLStatment = "select " + SpecificCols + " From " + TableName + " order by " + orederCols;

                SqlConnection Conn = _ClassConnection.ConnectionOpration();

                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
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

            return DS;
        }





        // 5. Select * from Same Table with Where     

        public DataTable SelectOpration(string TableName, string[] WhereColName, string[] WhrereColValue)
        {
            DataTable DS = new DataTable();

            string WhereStatment = "";

            try
            {


                for (int i = 0; i < WhereColName.Length; i++)
                {
                    if (i == WhereColName.Length - 1)
                    {
                        WhereStatment += WhereColName[i] + "='" + WhrereColValue[i] + "'";
                    }
                    else
                    {
                        WhereStatment += WhereColName[i] + "='" + WhrereColValue[i] + "' or ";
                    }
                }

                string SQLStatment = "select * From " + TableName + " Where " + WhereStatment;

                SqlConnection Conn = _ClassConnection.ConnectionOpration();

                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
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

            return DS;
        }





        // 6. Select * from Same Table Where and order 

        public DataTable SelectOpration(string TableName, string[] WhereColName
                                   , string[] WhrereColValue, string[] orderColName)
        {
            DataTable DS = new DataTable();
            string orederCols = "";
            string WhereStatment = "";

            try
            {

                for (int i = 0; i < WhereColName.Length; i++)
                {
                    if (i == WhereColName.Length - 1)
                    {
                        WhereStatment += WhereColName[i] + "='" + WhrereColValue[i] + "'";
                    }
                    else
                    {
                        WhereStatment += WhereColName[i] + "='" + WhrereColValue[i] + "' or ";
                    }
                }

                for (int i = 0; i < orderColName.Length; i++)
                {
                    if (i == orderColName.Length - 1)
                    {
                        orederCols += orderColName[i];
                    }
                    else
                    {
                        orederCols += orderColName[i] + ",";
                    }
                }

                string SQLStatment = "select * From " + TableName + " Where " + WhereStatment + " order by " + orederCols;

                SqlConnection Conn = _ClassConnection.ConnectionOpration();

                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
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


            return DS;
        }



        // 7. Select Specific Columns from Same Table Where 

        public DataTable SelectOpration(string[] ColumnName, string TableName
                                   , string[] WhereColName, string[] WhrereColValue)
        {
            DataTable DS = new DataTable();
            string SpecificCols = "";
            string WhereStatment = "";

            try
            {

                for (int i = 0; i < ColumnName.Length; i++)
                {
                    if (i == ColumnName.Length - 1)
                    {
                        SpecificCols += ColumnName[i];
                    }
                    else
                    {
                        SpecificCols += ColumnName[i] + ",";
                    }
                }


                for (int i = 0; i < WhereColName.Length; i++)
                {
                    if (i == WhereColName.Length - 1)
                    {
                        WhereStatment += WhereColName[i] + "='" + WhrereColValue[i] + "'";
                    }
                    else
                    {
                        WhereStatment += WhereColName[i] + "='" + WhrereColValue[i] + "' or ";
                    }
                }

                string SQLStatment = "select " + SpecificCols + " From " + TableName + " Where " + WhereStatment;

                SqlConnection Conn = _ClassConnection.ConnectionOpration();

                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
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


            return DS;
        }


        // 8. Select Specific Columns from SameTable with Where and Order

        public DataTable SelectOpration(string[] ColumnName, string TableName
                                   , string[] WhereColName, string[] WhrereColValue
                                   , string[] orderColName)
        {
            DataTable DS = new DataTable();
            string SpecificCols = "";
            string WhereStatment = "";
            string orederCols = "";

            try
            {

                for (int i = 0; i < ColumnName.Length; i++)
                {
                    if (i == ColumnName.Length - 1)
                    {
                        SpecificCols += ColumnName[i];
                    }
                    else
                    {
                        SpecificCols += ColumnName[i] + ",";
                    }
                }


                for (int i = 0; i < WhereColName.Length; i++)
                {
                    if (i == WhereColName.Length - 1)
                    {
                        WhereStatment += WhereColName[i] + "='" + WhrereColValue[i] + "'";
                    }
                    else
                    {
                        WhereStatment += WhereColName[i] + "='" + WhrereColValue[i] + "' or ";
                    }
                }

                for (int i = 0; i < orderColName.Length; i++)
                {
                    if (i == orderColName.Length - 1)
                    {
                        orederCols += orderColName[i];
                    }
                    else
                    {
                        orederCols += orderColName[i] + ",";
                    }
                }

                string SQLStatment = "select " + SpecificCols + " From " + TableName + " Where " + WhereStatment + " order by " + orederCols;


                SqlConnection Conn = _ClassConnection.ConnectionOpration();

                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
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


            return DS;
        }




        // 9. Select Specific Columns From Different Table


        //  SELECT  class.class_name, techer.tch_name, section1.section_name
        //   FROM 
        //   ( class  INNER JOIN  section1      ON     class.section_id = section1.section_id )
        //             INNER JOIN  techer        ON         class.tch_id = techer.tch_id;

        //  Older Function 
        public DataTable SelectOpration(string[] ColumnName, string[] TableName1
                                   , string[] F_Column, string[] TableName2
                                   , string[] S_Column, join[] JOIN)
        {
            DataTable DS = new DataTable();

            string ColsName = "";
            string Tables = "";

            try
            {

                for (int i = 0; i < ColumnName.Length; i++)
                {
                    if (i == ColumnName.Length - 1)
                    {
                        ColsName += ColumnName[i];
                    }
                    else
                    {
                        ColsName += ColumnName[i] + " , ";
                    }
                }

                for (int i = 0; i < JOIN.Length; i++)
                {
                    Tables += "(";
                }
                //   ( class  INNER JOIN  section1      ON     class.section_id = section1.section_id )
                //            INNER JOIN  techer        ON         class.tch_id = techer.tch_id;
                Tables += " " + TableName1[0] + " " + JOIN[0].ToString() + " join " + TableName2[0] + " on " + TableName1[0] + "." + F_Column[0] + " = " + TableName2[0] + "." + S_Column[0] + " ) ";
                for (int i = 1; i < TableName1.Length; i++)
                {

                    Tables += JOIN[i].ToString() + " join " + TableName2[i] + " on " + TableName1[i] + "." + F_Column[i] + " = " + TableName2[i] + "." + S_Column[i] + " ) ";

                }

                string SQLStatment = "select " + ColsName + " from " + Tables;


                SqlConnection Conn = _ClassConnection.ConnectionOpration();

                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
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



            return DS;
        }



        //   New and Complete Function 

        public DataTable SelectOpration(string[] Selected_Table, string[] Selected_Column
                                    , string[] TableName1, string[] F_Column
                                    , string[] TableName2, string[] S_Column
                                    , join[] JOIN)
        {
            DataTable DS = new DataTable();
            string ColsName = "";
            string Tables = "";

            try
            {

                for (int i = 0; i < Selected_Table.Length; i++)
                {
                    if (i == Selected_Table.Length - 1)
                    {
                        ColsName += Selected_Table[i] + "." + Selected_Column[i];
                    }
                    else
                    {
                        ColsName += Selected_Table[i] + "." + Selected_Column[i] + ",";
                    }
                }

                for (int i = 0; i < JOIN.Length; i++)
                {
                    Tables += "(";
                }
                //   ( class  INNER JOIN  section1      ON     class.section_id = section1.section_id )
                //            INNER JOIN  techer        ON         class.tch_id = techer.tch_id;

                Tables += " " + TableName1[0] + " " + JOIN[0].ToString() + " join " + TableName2[0] + " on "
                              + TableName1[0] + "." + F_Column[0] + " = " + TableName2[0] + "." + S_Column[0] + " ) ";

                for (int i = 1; i < TableName1.Length; i++)
                {

                    Tables += JOIN[i].ToString() + " join " + TableName2[i] + " on " + TableName1[i] + "." + F_Column[i] + " = " + TableName2[i] + "." + S_Column[i] + " ) ";

                }

                string SQLStatment = "select " + ColsName + " from " + Tables;


                SqlConnection Conn = _ClassConnection.ConnectionOpration();

                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
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

            return DS;
        }




        // 10. Select Specific Columns From Different Table with Order

        public DataTable SelectOpration(string[] Selected_Table, string[] Selected_Column
                                    , string[] TableName1, string[] F_Column
                                    , string[] TableName2, string[] S_Column, join[] JOIN
                                    , string[] orderTable, string[] orderColumn)
        {
            DataTable DS = new DataTable();
            string ColsName = "";
            string Tables = "";
            string orederCols = "";


            try
            {

                for (int i = 0; i < Selected_Table.Length; i++)
                {
                    if (i == Selected_Table.Length - 1)
                    {
                        ColsName += Selected_Table[i] + "." + Selected_Column[i];
                    }
                    else
                    {
                        ColsName += Selected_Table[i] + "." + Selected_Column[i] + ",";
                    }
                }

                for (int i = 0; i < JOIN.Length; i++)
                {
                    Tables += "(";
                }
                //   ( class  INNER JOIN  section1      ON     class.section_id = section1.section_id )
                //            INNER JOIN  techer        ON         class.tch_id = techer.tch_id;
                Tables += " " + TableName1[0] + " " + JOIN[0].ToString() + " join " + TableName2[0] + " on " + TableName1[0] + "." + F_Column[0] + " = " + TableName2[0] + "." + S_Column[0] + " ) ";
                for (int i = 1; i < TableName1.Length; i++)
                {

                    Tables += JOIN[i].ToString() + " join " + TableName2[i] + " on " + TableName1[i] + "." + F_Column[i] + " = " + TableName2[i] + "." + S_Column[i] + " ) ";

                }

                for (int i = 0; i < orderTable.Length; i++)
                {
                    if (i == orderTable.Length - 1)
                    {
                        orederCols += orderTable[i] + "." + orderColumn[i];
                    }

                    else
                    {
                        orederCols += orderTable[i] + "." + orderColumn[i] + ",";
                    }

                }


                string SQLStatment = "select " + ColsName + " from " + Tables + " order by " + orederCols;

                SqlConnection Conn = _ClassConnection.ConnectionOpration();

                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
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

            return DS;
        }





        // 11. Select Specific Columns From Different Table with Where 
        public DataTable SelectOpration(string[] Selected_Table, string[] Selected_Column
                                   , string[] TableName1, string[] F_Column
                                   , string[] TableName2, string[] S_Column, join[] JOIN
                                   , string[] TableWhere, string[] Column_where, string[] WhrerValue)
        {
            DataTable DS = new DataTable();
            string ColsName = "";
            string Tables = "";
            string WhereStatment = "";

            try
            {

                for (int i = 0; i < Selected_Table.Length; i++)
                {
                    if (i == Selected_Table.Length - 1)
                    {
                        ColsName += Selected_Table[i] + "." + Selected_Column[i];
                    }
                    else
                    {
                        ColsName += Selected_Table[i] + "." + Selected_Column[i] + ",";
                    }
                }

                for (int i = 0; i < JOIN.Length; i++)
                {
                    Tables += "(";
                }

                Tables += " " + TableName1[0] + " " + JOIN[0].ToString() + " join " + TableName2[0] +
                          " on " + TableName1[0] + "." + F_Column[0] + " = " + TableName2[0] + "." + S_Column[0] + " ) ";
                for (int i = 1; i < TableName1.Length; i++)
                {

                    Tables += JOIN[i].ToString() + " join " + TableName2[i] + " on " + TableName1[i] + "." + F_Column[i] + " = " + TableName2[i] + "." + S_Column[i] + " ) ";

                }

                for (int i = 0; i < TableWhere.Length; i++)
                {
                    if (i == TableWhere.Length - 1)
                    {
                        WhereStatment += " Where " + TableWhere[i] + "." + Column_where[i] + " ='" + WhrerValue[i] + "'";
                    }
                    else
                    {
                        WhereStatment += " Where " + TableWhere[i] + "." + Column_where[i] + " ='" + WhrerValue[i]
                                         + "'" + Operation.or.ToString();
                    }
                }

                string SQLStatment = "select " + ColsName + " from " + Tables + WhereStatment;

                SqlConnection Conn = _ClassConnection.ConnectionOpration();

                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
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


            return DS;
        }





        // 12. Select Specific Columns From Different Table with Where and Order 
        public DataTable SelectOpration(string[] Selected_Table, string[] Selected_Column
                                   , string[] TableName1, string[] F_Column
                                   , string[] TableName2, string[] S_Column, join[] JOIN
                                   , string[] TableWhere, string[] Column_where, string[] WhrerValue
                                   , string[] orderTable, string[] orderColumn)
        {

            DataTable DS = new DataTable();
            string ColsName = "";
            string Tables = "";
            string WhereStatment = "";
            string orederCols = "";

            try
            {

                for (int i = 0; i < Selected_Table.Length; i++)
                {
                    if (i == Selected_Table.Length - 1)
                    {
                        ColsName += Selected_Table[i] + "." + Selected_Column[i];
                    }
                    else
                    {
                        ColsName += Selected_Table[i] + "." + Selected_Column[i] + ",";
                    }
                }

                for (int i = 0; i < JOIN.Length; i++)
                {
                    Tables += "(";
                }

                Tables += " " + TableName1[0] + " " + JOIN[0].ToString() + " join " + TableName2[0] +
                          " on " + TableName1[0] + "." + F_Column[0] + " = " + TableName2[0] + "." + S_Column[0] + " ) ";
                for (int i = 1; i < TableName1.Length; i++)
                {

                    Tables += JOIN[i].ToString() + " join " + TableName2[i] + " on " + TableName1[i] + "." + F_Column[i] + " = " + TableName2[i] + "." + S_Column[i] + " ) ";

                }

                for (int i = 0; i < TableWhere.Length; i++)
                {
                    if (i == TableWhere.Length - 1)
                    {
                        WhereStatment += " Where " + TableWhere[i] + "." + Column_where[i] + " ='" + WhrerValue[i] + "'";
                    }
                    else
                    {
                        WhereStatment += " Where " + TableWhere[i] + "." + Column_where[i] + " ='" + WhrerValue[i] + "'" + Operation.or;
                    }
                }

                for (int i = 0; i < orderTable.Length; i++)
                {
                    if (i == orderTable.Length - 1)
                    {
                        orederCols += orderTable[i] + "." + orderColumn[i];
                    }

                    else
                    {
                        orederCols += orderTable[i] + "." + orderColumn[i] + ",";
                    }

                }

                string SQLStatment = "select " + ColsName + " from " + Tables + WhereStatment + " order by " + orederCols;

                SqlConnection Conn = _ClassConnection.ConnectionOpration();

                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
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


            return DS;
        }




        //================================================================================================


        // 13. Select Specific Column From Same Table with using 'as' to change Column Name

        public DataTable SelectOpration(string[] ColumnName, string[] as_Name, string TableName)
        {
            DataTable DS = new DataTable();
            string ColsName = "";

            try
            {

                for (int i = 0; i < ColumnName.Length; i++)
                {
                    if (i == ColumnName.Length - 1)
                    {
                        ColsName += ColumnName[i] + " as [" + as_Name[i] + "]";
                    }
                    else
                    {
                        ColsName += ColumnName[i] + " as [" + as_Name[i] + "]" + " , ";
                    }

                }

                string SQLStatment = "Select " + ColsName + " from " + TableName;


                SqlConnection Conn = _ClassConnection.ConnectionOpration();

                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
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


            return DS;
        }





        // 14. Select Specific Column From Same Table with using 'as' with Order 

        public DataTable SelectOpration(string[] ColumnName, string[] as_Name, string TableName, string[] orderColumn)
        {
            DataTable DS = new DataTable();
            string ColsName = "";
            string orederCols = "";

            try
            {

                for (int i = 0; i < ColumnName.Length; i++)
                {
                    if (i == ColumnName.Length - 1)
                    {
                        ColsName += ColumnName[i] + " as [" + as_Name[i] + "]";
                    }
                    else
                    {
                        ColsName += ColumnName[i] + " as [" + as_Name[i] + "]" + " , ";
                    }

                }

                for (int i = 0; i < orderColumn.Length; i++)
                {
                    if (i == orderColumn.Length - 1)
                    {
                        orederCols += orderColumn[i];
                    }
                    else
                    {
                        orederCols += orderColumn[i] + ",";
                    }

                }
                string SQLStatment = "Select " + ColsName + " from " + TableName + " order by " + orederCols;

                SqlConnection Conn = _ClassConnection.ConnectionOpration();

                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
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


            return DS;
        }


        // 15. Select Specific Column From Same Table with using 'as' with Where 

        public DataTable SelectOpration(string[] ColumnName, string[] as_Name, string TableName
                                   , string[] WhereColName, string[] WhrereColValue)
        {
            DataTable DS = new DataTable();
            string ColsName = "";
            string WhereStatment = "";

            try
            {

                for (int i = 0; i < ColumnName.Length; i++)
                {
                    if (i == ColumnName.Length - 1)
                    {
                        ColsName += ColumnName[i] + " as [" + as_Name[i] + "]";
                    }
                    else
                    {
                        ColsName += ColumnName[i] + " as [" + as_Name[i] + "]" + " , ";
                    }

                }

                for (int i = 0; i < WhereColName.Length; i++)
                {
                    if (i == WhereColName.Length - 1)
                    {
                        WhereStatment += WhereColName[i] + "<=" + WhrereColValue[i];
                    }

                    else
                    {
                        WhereStatment += WhereColName[i] + "<=" + WhrereColValue[i]
                                      + " " + Operation.or.ToString() + " ";
                    }

                }


                string SQLStatment = "Select " + ColsName + " from " + TableName + " where " + WhereStatment;

                SqlConnection Conn = _ClassConnection.ConnectionOpration();

                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
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

            return DS;
        }





        // 16. Select Specific Column From Same Table with using 'as' , Where and Order

        public DataTable SelectOpration(string[] ColumnName, string[] as_Name, string TableName
                                   , string[] WhereColName, string[] WhrereColValue, string[] orderColumn)
        {
            DataTable DS = new DataTable();
            string ColsName = "";
            string WhereStatment = "";
            string orederCols = "";

            try
            {

                for (int i = 0; i < ColumnName.Length; i++)
                {
                    if (i == ColumnName.Length - 1)
                    {
                        ColsName += ColumnName[i] + " as [" + as_Name[i] + "]";
                    }
                    else
                    {
                        ColsName += ColumnName[i] + " as [" + as_Name[i] + "]" + " , ";
                    }

                }

                for (int i = 0; i < WhereColName.Length; i++)
                {
                    if (i == WhereColName.Length - 1)
                    {
                        WhereStatment += WhereColName[i] + "<=" + WhrereColValue[i];
                    }

                    else
                    {
                        WhereStatment += WhereColName[i] + "<=" + WhrereColValue[i]
                                      + " " + Operation.or.ToString() + " ";
                    }

                }

                for (int i = 0; i < orderColumn.Length; i++)
                {
                    if (i == orderColumn.Length - 1)
                    {
                        orederCols += orderColumn[i];
                    }
                    else
                    {
                        orederCols += orderColumn[i] + ",";
                    }

                }

                string SQLStatment = "Select " + ColsName + " from " + TableName + " where " + WhereStatment + " order by " + orederCols;

                SqlConnection Conn = _ClassConnection.ConnectionOpration();

                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
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

            return DS;
        }


        //string[] TableWhere, string[] ColumnWhere , string[] WhrerValue


        // 17. Select Specific Column From Same Table with using 'as'

        public DataTable SelectOpration(string[] Selected_Table, string[] Selected_Column, string[] as_Name
                                    , string[] TableName1, string[] F_Column
                                    , string[] TableName2, string[] S_Column
                                    , join[] JOIN)
        {
            DataTable DS = new DataTable();
            string ColsName = "";
            string Tables = "";

            try
            {

                for (int i = 0; i < Selected_Table.Length; i++)
                {
                    if (i == Selected_Table.Length - 1)
                    {
                        ColsName += Selected_Table[i] + "." + Selected_Column[i] + " as [" + as_Name[i] + "] ";
                    }
                    else
                    {
                        ColsName += Selected_Table[i] + "." + Selected_Column[i] + " as [" + as_Name[i] + "] " + ",";
                    }
                }

                for (int i = 0; i < JOIN.Length; i++)
                {
                    Tables += "(";
                }
                //   ( class  INNER JOIN  section1      ON     class.section_id = section1.section_id )
                //            INNER JOIN  techer        ON         class.tch_id = techer.tch_id;

                Tables += " " + TableName1[0] + " " + JOIN[0].ToString() + " join " + TableName2[0] + " on "
                              + TableName1[0] + "." + F_Column[0] + " = " + TableName2[0] + "." + S_Column[0] + " ) ";

                for (int i = 1; i < TableName1.Length; i++)
                {

                    Tables += JOIN[i].ToString() + " join " + TableName2[i] + " on " + TableName1[i] + "." + F_Column[i] + " = " + TableName2[i] + "." + S_Column[i] + " ) ";

                }

                string SQLStatment = "select " + ColsName + " from " + Tables;


                SqlConnection Conn = _ClassConnection.ConnectionOpration();

                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
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

            return DS;
        }


        // 18. Select Specific Column From Same Table with using 'as' and Order
        public DataTable SelectOpration(string[] Selected_Table, string[] Selected_Column, string[] as_Name
                                   , string[] TableName1, string[] F_Column
                                   , string[] TableName2, string[] S_Column
                                   , join[] JOIN, string[] orderTable, string[] orderColumn)
        {
            DataTable DS = new DataTable();
            string ColsName = "";
            string Tables = "";
            string orederCols = "";

            try
            {

                for (int i = 0; i < Selected_Table.Length; i++)
                {
                    if (i == Selected_Table.Length - 1)
                    {
                        ColsName += Selected_Table[i] + "." + Selected_Column[i] + " as [" + as_Name[i] + "] ";
                    }
                    else
                    {
                        ColsName += Selected_Table[i] + "." + Selected_Column[i] + " as [" + as_Name[i] + "] " + ",";
                    }
                }

                for (int i = 0; i < JOIN.Length; i++)
                {
                    Tables += "(";
                }
                //   ( class  INNER JOIN  section1      ON     class.section_id = section1.section_id )
                //            INNER JOIN  techer        ON         class.tch_id = techer.tch_id;

                Tables += " " + TableName1[0] + " " + JOIN[0].ToString() + " join " + TableName2[0] + " on "
                              + TableName1[0] + "." + F_Column[0] + " = " + TableName2[0] + "." + S_Column[0] + " ) ";

                for (int i = 1; i < TableName1.Length; i++)
                {

                    Tables += JOIN[i].ToString() + " join " + TableName2[i] + " on " + TableName1[i] + "." + F_Column[i] + " = " + TableName2[i] + "." + S_Column[i] + " ) ";

                }


                for (int i = 0; i < orderTable.Length; i++)
                {
                    if (i == orderTable.Length - 1)
                    {
                        orederCols += orderTable[i] + "." + orderColumn[i];
                    }

                    else
                    {
                        orederCols += orderTable[i] + "." + orderColumn[i] + ",";
                    }

                }

                string SQLStatment = "select " + ColsName + " from " + Tables + " order by " + orederCols;

                SqlConnection Conn = _ClassConnection.ConnectionOpration();

                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
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

            return DS;
        }





        // 19. Select Specific Column From Diffrente Tables with using 'as' with Where

        public DataTable SelectOpration(string[] Selected_Table, string[] Selected_Column, string[] as_Name
                                   , string[] TableName1, string[] F_Column
                                   , string[] TableName2, string[] S_Column
                                   , join[] JOIN, string[] TableWhere, string[] ColumnWhere, string[] WhrerValue)
        {
            DataTable DS = new DataTable();
            string ColsName = "";
            string Tables = "";
            string WhereStatment = "";

            try
            {

                for (int i = 0; i < Selected_Table.Length; i++)
                {
                    if (i == Selected_Table.Length - 1)
                    {
                        ColsName += Selected_Table[i] + "." + Selected_Column[i] + " as [" + as_Name[i] + "] ";
                    }
                    else
                    {
                        ColsName += Selected_Table[i] + "." + Selected_Column[i] + " as [" + as_Name[i] + "] " + ",";
                    }
                }

                for (int i = 0; i < JOIN.Length; i++)
                {
                    Tables += "(";
                }
                //   ( class  INNER JOIN  section1      ON     class.section_id = section1.section_id )
                //            INNER JOIN  techer        ON         class.tch_id = techer.tch_id;

                Tables += " " + TableName1[0] + " " + JOIN[0].ToString() + " join " + TableName2[0] + " on "
                              + TableName1[0] + "." + F_Column[0] + " = " + TableName2[0] + "." + S_Column[0] + " ) ";

                for (int i = 1; i < TableName1.Length; i++)
                {

                    Tables += JOIN[i].ToString() + " join " + TableName2[i] + " on " + TableName1[i] + "." + F_Column[i] + " = " + TableName2[i] + "." + S_Column[i] + " ) ";

                }


                for (int i = 0; i < TableWhere.Length; i++)
                {
                    if (i == TableWhere.Length - 1)
                    {
                        WhereStatment += TableWhere[i] + "." + ColumnWhere[i] + "<=" + WhrerValue[i];
                    }

                    else
                    {
                        WhereStatment += TableWhere[i] + "." + ColumnWhere[i] + "<=" + WhrerValue[i] + " " + Operation.or.ToString() + " ";
                    }

                }

                string SQLStatment = "select " + ColsName + " from " + Tables + " where " + WhereStatment;

                SqlConnection Conn = _ClassConnection.ConnectionOpration();

                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
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

            return DS;
        }




        // 20. Select Specific Column From Diffrente Tables with using 'as' , Where and Order

        public DataTable SelectOpration(string[] Selected_Table, string[] Selected_Column, string[] as_Name
                                   , string[] TableName1, string[] F_Column
                                   , string[] TableName2, string[] S_Column
                                   , join[] JOIN, string[] TableWhere, string[] ColumnWhere, string[] WhrerValue
                                   , string[] orderTable, string[] orderColumn)
        {
            DataTable DS = new DataTable();
            string ColsName = "";
            string Tables = "";
            string WhereStatment = "";
            string orederCols = "";

            try
            {

                for (int i = 0; i < Selected_Table.Length; i++)
                {
                    if (i == Selected_Table.Length - 1)
                    {
                        ColsName += Selected_Table[i] + "." + Selected_Column[i] + " as [" + as_Name[i] + "] ";
                    }
                    else
                    {
                        ColsName += Selected_Table[i] + "." + Selected_Column[i] + " as [" + as_Name[i] + "] " + ",";
                    }
                }

                for (int i = 0; i < JOIN.Length; i++)
                {
                    Tables += "(";
                }
                //   ( class  INNER JOIN  section1      ON     class.section_id = section1.section_id )
                //            INNER JOIN  techer        ON         class.tch_id = techer.tch_id;

                Tables += " " + TableName1[0] + " " + JOIN[0].ToString() + " join " + TableName2[0] + " on "
                              + TableName1[0] + "." + F_Column[0] + " = " + TableName2[0] + "." + S_Column[0] + " ) ";

                for (int i = 1; i < TableName1.Length; i++)
                {

                    Tables += JOIN[i].ToString() + " join " + TableName2[i] + " on " + TableName1[i] + "." + F_Column[i] + " = " + TableName2[i] + "." + S_Column[i] + " ) ";

                }


                for (int i = 0; i < TableWhere.Length; i++)
                {
                    if (i == TableWhere.Length - 1)
                    {
                        WhereStatment += TableWhere[i] + "." + ColumnWhere[i] + "<=" + WhrerValue[i];
                    }

                    else
                    {
                        WhereStatment += TableWhere[i] + "." + ColumnWhere[i] + "<=" + WhrerValue[i] + " " + Operation.or.ToString() + " ";
                    }

                }


                for (int i = 0; i < orderTable.Length; i++)
                {
                    if (i == orderTable.Length - 1)
                    {
                        orederCols += orderTable[i] + "." + orderColumn[i];
                    }

                    else
                    {
                        orederCols += orderTable[i] + "." + orderColumn[i] + ",";
                    }

                }


                string SQLStatment = "select " + ColsName + " from " + Tables + " where " + WhereStatment + " order by " + orederCols;

                SqlConnection Conn = _ClassConnection.ConnectionOpration();

                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
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

            return DS;
        }


    }
}
