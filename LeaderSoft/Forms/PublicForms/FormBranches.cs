using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibraryPublic.Table;
using LibraryConnection;
using LibraryPublic.PublicClass;
using LibraryPublic;
using LeaderSoft.Forms.PublicForms.SearchForm;

namespace LeaderSoft.Forms.PublicForms
{
    public partial class FormBranches : Form
    {

        DataTable dt = new DataTable();

        ClassSelect _ClassSelect = new ClassSelect();
        ClassInsert _ClassInsert = new ClassInsert();
        ClassUpdate _ClassUpdate = new ClassUpdate();
        ClassDelete _ClassDelete = new ClassDelete();

        DataTable DTGroupID = new DataTable();
        DataTable IDDataTable = new DataTable();
        
        ClassPublicVar.TypeOperation _TypeOperation = new ClassPublicVar.TypeOperation();
        ClassFillTree _ClassFillTree = new ClassFillTree();
        ClassTreeViewController _ClassTreeViewController = new ClassTreeViewController();


        //   حق النود المختارةID يحمل ال
        string NodeID = "";

        public FormBranches()
        {
            InitializeComponent();
        }

        public void SearchID(DataTable DtID)
        {

            foreach (DataRow row in DtID.Rows)
            {

                if (row[TableBranches.ID].ToString() == TextBoxID.Text)
                {
                    MessageBox.Show("موجود مسبقا");
                    TextBoxID.Focus();
                    TextBoxID.Clear();
                    break;
                }
            }

        }

        private void ToolsStatus()
        {
            if (_TypeOperation == ClassPublicVar.TypeOperation.Show)
            {
                TextBoxMainID.ReadOnly = true;
                TextBoxMainName.ReadOnly = true;
                TextBoxID.ReadOnly = true;
                TextBoxGroupID.ReadOnly = true;
                TextBoxGroupName.ReadOnly = true;
                TextBoxNameLng1.ReadOnly = true;
                TextBoxNameLng2.ReadOnly = true;
                TextBoxPhone.ReadOnly = true;
                TextBoxeFax.ReadOnly = true;
                TextBoxAddress.ReadOnly = true;
                TextBoxRentStartDate.ReadOnly = true;
                TextBoxRentEndDate.ReadOnly = true;
                TextBoxCrNO.ReadOnly = true;
                TextBoxCrLssDate.ReadOnly = true;
                TextBoxCrExpDate.ReadOnly = true;
                TextBoxMunicp.ReadOnly = true;
                TextBoxMunicpLssDate.ReadOnly = true;
                TextBoxMunicpExpDate.ReadOnly = true;
                TxtBoxAdvocatteship.ReadOnly = true;
                TxtBoxAdvocatteshipLssDate.ReadOnly = true;
                TxtBoxAdvocatteshipExpDate.ReadOnly = true;

                ButtonNew.Enabled = true;
                ButtonEdit.Enabled = true;
                ButtonSave.Enabled = false;
                ButtonDelete.Enabled = true;
                ButtonPrint.Enabled = true;
                ButtonSearch.Enabled = true;
                ButtonCancel.Enabled = false;
                ButtonExit.Enabled = true;

                TreeViewMain.Enabled = true;
                
                RadioBtnGroup.Enabled = false;
                RadioBtnNotGroup.Enabled = false;
                buttonGroupSearch.Enabled = false;

                ButtonLast.Enabled = true;
                ButtonNext.Enabled = true;
                ButtonPrevious.Enabled = true;
                ButtonFirst.Enabled = true;

                TextBoxMainID.Clear();
                TextBoxMainName.Clear();
                TextBoxID.Clear();
                TextBoxGroupID.Clear();
                TextBoxGroupName.Clear();
                TextBoxNameLng1.Clear();
                TextBoxNameLng2.Clear();
                TextBoxPhone.Clear();
                TextBoxeFax.Clear();
                TextBoxAddress.Clear();
                TextBoxRentStartDate.Clear();
                TextBoxRentEndDate.Clear();
                TextBoxCrNO.Clear();
                TextBoxCrLssDate.Clear();
                TextBoxCrExpDate.Clear();
                TextBoxMunicp.Clear();
                TextBoxMunicpLssDate.Clear();
                TextBoxMunicpExpDate.Clear();
                TxtBoxAdvocatteship.Clear();
                TxtBoxAdvocatteshipLssDate.Clear();
                TxtBoxAdvocatteshipExpDate.Clear();

            }

            else if (_TypeOperation == ClassPublicVar.TypeOperation.Add)
            {
                TextBoxMainID.ReadOnly = false;
                TextBoxMainName.ReadOnly = false;
                TextBoxID.ReadOnly = false;
                TextBoxGroupID.ReadOnly = false;
                TextBoxGroupName.ReadOnly = true;
                TextBoxNameLng1.ReadOnly = false;
                TextBoxNameLng2.ReadOnly = false;
                TextBoxPhone.ReadOnly = false;
                TextBoxeFax.ReadOnly = false;
                TextBoxAddress.ReadOnly = false;
                TextBoxRentStartDate.ReadOnly = false;
                TextBoxRentEndDate.ReadOnly = false;
                TextBoxCrNO.ReadOnly = false;
                TextBoxCrLssDate.ReadOnly = false;
                TextBoxCrExpDate.ReadOnly = false;
                TextBoxMunicp.ReadOnly = false;
                TextBoxMunicpLssDate.ReadOnly = false;
                TextBoxMunicpExpDate.ReadOnly = false;
                TxtBoxAdvocatteship.ReadOnly = false;
                TxtBoxAdvocatteshipLssDate.ReadOnly = false;
                TxtBoxAdvocatteshipExpDate.ReadOnly = false;

                RadioBtnNotGroup.Checked = true;

                ButtonNew.Enabled = true;
                ButtonEdit.Enabled = false;
                ButtonSave.Enabled = true;
                ButtonDelete.Enabled = false;
                ButtonPrint.Enabled = false;
                ButtonSearch.Enabled = false;
                ButtonCancel.Enabled = true;
                ButtonExit.Enabled = false;

                TreeViewMain.Enabled = false;
                
                RadioBtnGroup.Enabled = true;
                RadioBtnNotGroup.Enabled = true;
                buttonGroupSearch.Enabled = true;

                ButtonLast.Enabled = false;
                ButtonNext.Enabled = false;
                ButtonPrevious.Enabled = false;
                ButtonFirst.Enabled = false;

                TextBoxMainID.Clear();
                TextBoxMainName.Clear();
                TextBoxID.Clear();
                TextBoxGroupID.Clear();
                TextBoxGroupName.Clear();
                TextBoxNameLng1.Clear();
                TextBoxNameLng2.Clear();
                TextBoxPhone.Clear();
                TextBoxeFax.Clear();
                TextBoxAddress.Clear();
                TextBoxRentStartDate.Clear();
                TextBoxRentEndDate.Clear();
                TextBoxCrNO.Clear();
                TextBoxCrLssDate.Clear();
                TextBoxCrExpDate.Clear();
                TextBoxMunicp.Clear();
                TextBoxMunicpLssDate.Clear();
                TextBoxMunicpExpDate.Clear();
                TxtBoxAdvocatteship.Clear();
                TxtBoxAdvocatteshipLssDate.Clear();
                TxtBoxAdvocatteshipExpDate.Clear();
            }

            else if (_TypeOperation == ClassPublicVar.TypeOperation.Edit)
            {
                TextBoxMainID.ReadOnly = false;
                TextBoxMainName.ReadOnly = false;
                TextBoxID.ReadOnly = true;
                TextBoxGroupID.ReadOnly = false;
                TextBoxGroupName.ReadOnly = true;
                TextBoxNameLng1.ReadOnly = false;
                TextBoxNameLng2.ReadOnly = false;
                TextBoxPhone.ReadOnly = false;
                TextBoxeFax.ReadOnly = false;
                TextBoxAddress.ReadOnly = false;
                TextBoxRentStartDate.ReadOnly = false;
                TextBoxRentEndDate.ReadOnly = false;
                TextBoxCrNO.ReadOnly = false;
                TextBoxCrLssDate.ReadOnly = false;
                TextBoxCrExpDate.ReadOnly = false;
                TextBoxMunicp.ReadOnly = false;
                TextBoxMunicpLssDate.ReadOnly = false;
                TextBoxMunicpExpDate.ReadOnly = false;
                TxtBoxAdvocatteship.ReadOnly = false;
                TxtBoxAdvocatteshipLssDate.ReadOnly = false;
                TxtBoxAdvocatteshipExpDate.ReadOnly = false;

                ButtonNew.Enabled = false;
                ButtonEdit.Enabled = false;
                ButtonSave.Enabled = true;
                ButtonDelete.Enabled = false;
                ButtonPrint.Enabled = false;
                ButtonSearch.Enabled = false;
                ButtonCancel.Enabled = true;
                ButtonExit.Enabled = false;

                TreeViewMain.Enabled = false;

                RadioBtnGroup.Enabled = true;
                RadioBtnNotGroup.Enabled = true;
                buttonGroupSearch.Enabled = true;

                ButtonLast.Enabled = false;
                ButtonNext.Enabled = false;
                ButtonPrevious.Enabled = false;
                ButtonFirst.Enabled = false;

                //TextBoxMainID.Clear();
                //TextBoxMainName.Clear();
                //TextBoxID.Clear();
                //TextBoxGroupID.Clear();
                //TextBoxGroupName.Clear();
                //TextBoxNameLng1.Clear();
                //TextBoxNameLng2.Clear();
                //TextBoxPhone.Clear();
                //TextBoxeFax.Clear();
                //TextBoxAddress.Clear();
                //TextBoxRentStartDate.Clear();
                //TextBoxRentEndDate.Clear();
                //TextBoxCrNO.Clear();
                //TextBoxCrLssDate.Clear();
                //TextBoxCrExpDate.Clear();
                //TextBoxMunicp.Clear();
                //TextBoxMunicpLssDate.Clear();
                //TextBoxMunicpExpDate.Clear();
                //TxtBoxAdvocatteship.Clear();
                //TxtBoxAdvocatteshipLssDate.Clear();
                //TxtBoxAdvocatteshipExpDate.Clear();
            }
        }


        private void FormBranches_Load(object sender, EventArgs e)
        {
             try
            {

                _TypeOperation = ClassPublicVar.TypeOperation.Show;

                _ClassFillTree.FillTree(TreeViewMain, _ClassSelect.SelectOpration("TableBranches"), TableBranches.GroupID, TableBranches.ID, TableBranches.NameLng1, TableBranches.IsGroup);

                ToolsStatus();
                // استرجاع اول بيانات أول نود عند النقر على تعديل لتجنب بقاء مربعات النص فارغة 
                TreeViewMain.SelectedNode = TreeViewMain.Nodes[0].FirstNode;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TreeViewMain_AfterSelect(object sender, TreeViewEventArgs e)
        {


            for (int i = 0; i < e.Node.Text.Length; i++)
            {
                if (e.Node.Text[i] == '>')
                {
                    i += 2;
                    NodeID = e.Node.Text.Substring(i, e.Node.Text.Length - i);
                }
            }


            // تلوين النود عند اختيارها لتجنب اللون الاسود عند الاختيار
            _ClassFillTree.ColorTreeNode(TreeViewMain.Nodes[0]);
            dt = _ClassSelect.SelectOpration("TableBranches", new string[] { "ID" }, new string[] { NodeID });
            try
            {
                 // عملنا الشرط لنحدد كيفية تعبئة مربعات النص حسب نوع العملية ( عرض و تعديل أو جديد )
                if (_TypeOperation == ClassPublicVar.TypeOperation.Show)
                {

                    TextBoxID.Text = dt.Rows[0][TableBranches.ID].ToString();

                    TextBoxGroupID.Text = dt.Rows[0][TableBranches.GroupID].ToString();

                    TextBoxGroupName.Text = dt.Rows[0][TableBranches.GroupName].ToString();

                    TextBoxNameLng1.Text = dt.Rows[0][TableBranches.NameLng1].ToString();

                    TextBoxNameLng2.Text = dt.Rows[0][TableBranches.NameLng2].ToString();

                    TextBoxPhone.Text = dt.Rows[0][TableBranches.Phone].ToString();

                    TextBoxeFax.Text = dt.Rows[0][TableBranches.Fax].ToString();

                    TextBoxAddress.Text = dt.Rows[0][TableBranches.Address].ToString();

                    TextBoxRentStartDate.Text = dt.Rows[0][TableBranches.RentStartDate].ToString();

                    TextBoxRentEndDate.Text = dt.Rows[0][TableBranches.RentEndDate].ToString();

                    TextBoxCrNO.Text = dt.Rows[0][TableBranches.CrNO].ToString();

                    TextBoxCrLssDate.Text = dt.Rows[0][TableBranches.CrLssDate].ToString();

                    TextBoxCrExpDate.Text = dt.Rows[0][TableBranches.CrExpDate].ToString();

                    TextBoxMunicp.Text = dt.Rows[0][TableBranches.Municp].ToString();

                    TextBoxMunicpLssDate.Text = dt.Rows[0][TableBranches.MunicpLssDate].ToString();

                    TextBoxMunicpExpDate.Text = dt.Rows[0][TableBranches.MunicpExpDate].ToString();

                    TxtBoxAdvocatteship.Text = dt.Rows[0][TableBranches.Advocatteship].ToString();

                    TxtBoxAdvocatteshipLssDate.Text = dt.Rows[0][TableBranches.AdvocatteshipLssDate].ToString();

                    TxtBoxAdvocatteshipExpDate.Text = dt.Rows[0][TableBranches.AdvocatteshipExpDate].ToString();

                    if (dt.Rows[0][TableBranches.IsGroup].ToString() == "0")
                    {
                        RadioBtnNotGroup.Checked = true;
                    }
                    else
                    {
                        RadioBtnGroup.Checked = true;
                    }
                }

                // عملنا الشرط لنحدد كيفية تعبئة مربعات النص حسب نوع العملية ( عرض و تعديل أو جديد )
                else if (_TypeOperation == ClassPublicVar.TypeOperation.Add)
                {
                    TextBoxGroupID.Text = dt.Rows[0][TableBranches.ID].ToString();

                    TextBoxGroupName.Text = dt.Rows[0][TableBranches.NameLng1].ToString();
                    TextBoxNameLng1.Focus();
                }

            }
            catch
            {

            }
        }


        private void re_Click(object sender, EventArgs e)
        {
            if (Pan.Height == 494 & Pan.Width == 168)
            {
                Pan.Height = 494;
                Pan.Width = 33;
            }
            else if (Pan.Height == 494 & Pan.Width == 33)
            {
                Pan.Height = 494;
                Pan.Width = 168;
            }
        }

        private void ButtonLast_Click(object sender, EventArgs e)
        {
            _ClassTreeViewController.LastNode(ref TreeViewMain);
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            _ClassTreeViewController.NextNode(ref TreeViewMain);
        }

        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            _ClassTreeViewController.PerviousNode(ref TreeViewMain);
        }

        private void ButtonFirst_Click(object sender, EventArgs e)
        {
            _ClassTreeViewController.FirstNode(ref TreeViewMain);
        }

        private void TextBoxID_Leave(object sender, EventArgs e)
        {
            if (_TypeOperation == ClassPublicVar.TypeOperation.Add)
            {
                IDDataTable = _ClassSelect.SelectOpration(new string[] { TableBranches.ID }, "TableBranches");
                SearchID(IDDataTable);
            } 
        }

        private void TextBoxGroupID_Leave(object sender, EventArgs e)
        {
            try
            {
                bool Exsists = false;
                if (_TypeOperation == ClassPublicVar.TypeOperation.Add)
                {
                    DTGroupID = _ClassSelect.SelectOpration(new string[] { TableBranches.ID, TableBranches.GroupName, TableBranches.NameLng1, TableBranches.IsGroup }, "TableBranches");

                    if (TextBoxGroupID.Text == "")
                    {
                    }
                    else if (TextBoxGroupID.Text == "0")
                    {
                        TextBoxGroupID.Text = "0";
                        TextBoxGroupName.Text = "Root";
                    }
                    else
                    {
                        foreach (DataRow row in DTGroupID.Rows)
                        {
                            if (row[TableBranches.ID].ToString() == TextBoxGroupID.Text)
                            {

                                if (row[TableBranches.IsGroup].ToString() == "0")
                                {
                                    MessageBox.Show("لا يمكن الإضافة لفرد");
                                    TextBoxGroupID.Focus();
                                    TextBoxGroupID.Clear();
                                    Exsists = true;
                                }

                                else
                                {
                                    TextBoxGroupID.Text = row[TableBranches.ID].ToString();
                                    TextBoxGroupName.Text = row[TableBranches.NameLng1].ToString();
                                    Exsists = true;
                                    break;
                                }

                            }

                        }


                        if (Exsists == false)
                        {

                            MessageBox.Show("غير موجود");
                            TextBoxGroupID.Clear();
                            DTGroupID.Clear();
                            TextBoxGroupID.Focus();
                            buttonGroupSearch_Click(sender, e);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {

            try
            {
                _ClassFillTree.FillTree(TreeViewMain, _ClassSelect.SelectOpration("TableBranches"), TableBranches.GroupID, TableBranches.ID, TableBranches.NameLng1, TableBranches.IsGroup);
                _TypeOperation = ClassPublicVar.TypeOperation.Add;
                ToolsStatus();

                TextBoxID.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                _ClassFillTree.FillTree(TreeViewMain, _ClassSelect.SelectOpration("TableBranches"), TableBranches.GroupID, TableBranches.ID, TableBranches.NameLng1, TableBranches.IsGroup);
                _TypeOperation = ClassPublicVar.TypeOperation.Edit;
                ToolsStatus();

                // استرجاع اول بيانات أول نود عند النقر على تعديل لتجنب بقاء مربعات النص فارغة 
                // treeView1.SelectedNode = treeView1.Nodes[0].FirstNode;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {

            try
            {
                string IDNew = "";

                if (_TypeOperation == ClassPublicVar.TypeOperation.Add)
                {
                    if (TextBoxGroupID.Text != "" && TextBoxGroupID.Text != " ")
                    {

                        if (RadioBtnGroup.Checked)
                        {
                            _ClassInsert.InsertOpration(new string[] { TableBranches.MainID ,TableBranches.ID , TableBranches.GroupID ,TableBranches.GroupName , TableBranches.NameLng1
                                                                  , TableBranches.NameLng2 , TableBranches.Phone, TableBranches.Fax , TableBranches.Address
                                                                  , TableBranches.RentStartDate , TableBranches.RentEndDate , TableBranches.CrNO 
                                                                  , TableBranches.CrLssDate, TableBranches.CrExpDate , TableBranches.Municp 
                                                                  , TableBranches.MunicpLssDate , TableBranches.MunicpExpDate , TableBranches.Advocatteship 
                                                                  , TableBranches.AdvocatteshipLssDate , TableBranches.AdvocatteshipExpDate , TableBranches.IsGroup }

                                                       , new string[] { TextBoxMainID.Text , TextBoxID.Text   , TextBoxGroupID.Text , TextBoxGroupName.Text, TextBoxNameLng1.Text , TextBoxNameLng2.Text 
                                                                  , TextBoxPhone.Text  , TextBoxeFax.Text , TextBoxAddress.Text , TextBoxRentStartDate.Text , TextBoxRentEndDate.Text
                                                                  , TextBoxCrNO.Text   , TextBoxCrLssDate.Text , TextBoxCrExpDate.Text , TextBoxMunicp.Text , TextBoxMunicpLssDate.Text
                                                                  , TextBoxMunicpExpDate.Text , TxtBoxAdvocatteship.Text , TxtBoxAdvocatteshipLssDate.Text  , TxtBoxAdvocatteshipExpDate.Text
                                                                  ,"1"}
                                                       , "TableBranches"
                                                       , true
                                                       );
                        }

                        else if (RadioBtnNotGroup.Checked)
                        {
                            _ClassInsert.InsertOpration(new string[] { TableBranches.MainID ,TableBranches.ID , TableBranches.GroupID , TableBranches.GroupName ,TableBranches.NameLng1
                                                                  , TableBranches.NameLng2 , TableBranches.Phone, TableBranches.Fax , TableBranches.Address
                                                                  , TableBranches.RentStartDate , TableBranches.RentEndDate , TableBranches.CrNO 
                                                                  , TableBranches.CrLssDate, TableBranches.CrExpDate , TableBranches.Municp 
                                                                  , TableBranches.MunicpLssDate , TableBranches.MunicpExpDate , TableBranches.Advocatteship 
                                                                  , TableBranches.AdvocatteshipLssDate , TableBranches.AdvocatteshipExpDate , TableBranches.IsGroup }

                                                       , new string[] { TextBoxMainID.Text , TextBoxID.Text   , TextBoxGroupID.Text , TextBoxGroupName.Text, TextBoxNameLng1.Text , TextBoxNameLng2.Text 
                                                                  , TextBoxPhone.Text  , TextBoxeFax.Text , TextBoxAddress.Text , TextBoxRentStartDate.Text , TextBoxRentEndDate.Text
                                                                  , TextBoxCrNO.Text   , TextBoxCrLssDate.Text , TextBoxCrExpDate.Text , TextBoxMunicp.Text , TextBoxMunicpLssDate.Text
                                                                  , TextBoxMunicpExpDate.Text , TxtBoxAdvocatteship.Text , TxtBoxAdvocatteshipLssDate.Text  , TxtBoxAdvocatteshipExpDate.Text
                                                                  ,"0"}
                                                       , "TableBranches"
                                                       , true
                                                       );
                        }
                    }
                    else if (TextBoxGroupID.Text == "" || TextBoxGroupID.Text == " ")
                    {
                        _ClassInsert.InsertOpration(new string[] { TableBranches.MainID ,TableBranches.ID , TableBranches.GroupID , TableBranches.GroupName ,TableBranches.NameLng1
                                                                  , TableBranches.NameLng2 , TableBranches.Phone, TableBranches.Fax , TableBranches.Address
                                                                  , TableBranches.RentStartDate , TableBranches.RentEndDate , TableBranches.CrNO 
                                                                  , TableBranches.CrLssDate, TableBranches.CrExpDate , TableBranches.Municp 
                                                                  , TableBranches.MunicpLssDate , TableBranches.MunicpExpDate , TableBranches.Advocatteship 
                                                                  , TableBranches.AdvocatteshipLssDate , TableBranches.AdvocatteshipExpDate , TableBranches.IsGroup }

                                                       , new string[] { TextBoxMainID.Text , TextBoxID.Text   , "0" , "Root" , TextBoxNameLng1.Text , TextBoxNameLng2.Text 
                                                                  , TextBoxPhone.Text  , TextBoxeFax.Text , TextBoxAddress.Text , TextBoxRentStartDate.Text , TextBoxRentEndDate.Text
                                                                  , TextBoxCrNO.Text   , TextBoxCrLssDate.Text , TextBoxCrExpDate.Text , TextBoxMunicp.Text , TextBoxMunicpLssDate.Text
                                                                  , TextBoxMunicpExpDate.Text , TxtBoxAdvocatteship.Text , TxtBoxAdvocatteshipLssDate.Text  , TxtBoxAdvocatteshipExpDate.Text
                                                                  ,"0"}
                                                       , "TableBranches"
                                                       , true
                                                       );
                    }
                }
                else if (_TypeOperation == ClassPublicVar.TypeOperation.Edit)
                {
                    if (TextBoxGroupID.Text != "" && TextBoxGroupID.Text != " ")
                    {

                        if (RadioBtnGroup.Checked)
                        {
                            _ClassUpdate.UpdateOpration(new string[] { TableBranches.MainID ,TableBranches.ID , TableBranches.GroupID ,TableBranches.GroupName , TableBranches.NameLng1
                                                                  , TableBranches.NameLng2 , TableBranches.Phone, TableBranches.Fax , TableBranches.Address
                                                                  , TableBranches.RentStartDate , TableBranches.RentEndDate , TableBranches.CrNO 
                                                                  , TableBranches.CrLssDate, TableBranches.CrExpDate , TableBranches.Municp 
                                                                  , TableBranches.MunicpLssDate , TableBranches.MunicpExpDate , TableBranches.Advocatteship 
                                                                  , TableBranches.AdvocatteshipLssDate , TableBranches.AdvocatteshipExpDate , TableBranches.IsGroup }

                                                       , new string[] { TextBoxMainID.Text , TextBoxID.Text   , TextBoxGroupID.Text , TextBoxGroupName.Text ,TextBoxNameLng1.Text , TextBoxNameLng2.Text 
                                                                  , TextBoxPhone.Text  , TextBoxeFax.Text , TextBoxAddress.Text , TextBoxRentStartDate.Text , TextBoxRentEndDate.Text
                                                                  , TextBoxCrNO.Text   , TextBoxCrLssDate.Text , TextBoxCrExpDate.Text , TextBoxMunicp.Text , TextBoxMunicpLssDate.Text
                                                                  , TextBoxMunicpExpDate.Text , TxtBoxAdvocatteship.Text , TxtBoxAdvocatteshipLssDate.Text  , TxtBoxAdvocatteshipExpDate.Text
                                                                  ,"1"}

                                                       , new string[] { TableBranches.ID }, new string[] { NodeID }
                                                       , "TableBranches", true);
                        }
                        else if (RadioBtnNotGroup.Checked)
                        {
                            _ClassUpdate.UpdateOpration(new string[] { TableBranches.MainID ,TableBranches.ID , TableBranches.GroupID , TableBranches.GroupName , TableBranches.NameLng1
                                                                  , TableBranches.NameLng2 , TableBranches.Phone, TableBranches.Fax , TableBranches.Address
                                                                  , TableBranches.RentStartDate , TableBranches.RentEndDate , TableBranches.CrNO 
                                                                  , TableBranches.CrLssDate, TableBranches.CrExpDate , TableBranches.Municp 
                                                                  , TableBranches.MunicpLssDate , TableBranches.MunicpExpDate , TableBranches.Advocatteship 
                                                                  , TableBranches.AdvocatteshipLssDate , TableBranches.AdvocatteshipExpDate , TableBranches.IsGroup }

                                                       , new string[] { TextBoxMainID.Text , TextBoxID.Text   , TextBoxGroupID.Text , TextBoxGroupName.Text, TextBoxNameLng1.Text , TextBoxNameLng2.Text 
                                                                  , TextBoxPhone.Text  , TextBoxeFax.Text , TextBoxAddress.Text , TextBoxRentStartDate.Text , TextBoxRentEndDate.Text
                                                                  , TextBoxCrNO.Text   , TextBoxCrLssDate.Text , TextBoxCrExpDate.Text , TextBoxMunicp.Text , TextBoxMunicpLssDate.Text
                                                                  , TextBoxMunicpExpDate.Text , TxtBoxAdvocatteship.Text , TxtBoxAdvocatteshipLssDate.Text  , TxtBoxAdvocatteshipExpDate.Text
                                                                  ,"0"}

                                                       , new string[] { TableBranches.ID }, new string[] { NodeID }
                                                       , "TableBranches", true);
                        }
                    }
                    else if (TextBoxGroupID.Text == "" || TextBoxGroupID.Text == " ")
                    {
                        _ClassUpdate.UpdateOpration(new string[] { TableBranches.MainID ,TableBranches.ID , TableBranches.GroupID , TableBranches.GroupName , TableBranches.NameLng1
                                                                  , TableBranches.NameLng2 , TableBranches.Phone, TableBranches.Fax , TableBranches.Address
                                                                  , TableBranches.RentStartDate , TableBranches.RentEndDate , TableBranches.CrNO 
                                                                  , TableBranches.CrLssDate, TableBranches.CrExpDate , TableBranches.Municp 
                                                                  , TableBranches.MunicpLssDate , TableBranches.MunicpExpDate , TableBranches.Advocatteship 
                                                                  , TableBranches.AdvocatteshipLssDate , TableBranches.AdvocatteshipExpDate , TableBranches.IsGroup }

                                                      , new string[] { TextBoxMainID.Text , TextBoxID.Text   , "0" , "Root", TextBoxNameLng1.Text , TextBoxNameLng2.Text 
                                                                  , TextBoxPhone.Text  , TextBoxeFax.Text , TextBoxAddress.Text , TextBoxRentStartDate.Text , TextBoxRentEndDate.Text
                                                                  , TextBoxCrNO.Text   , TextBoxCrLssDate.Text , TextBoxCrExpDate.Text , TextBoxMunicp.Text , TextBoxMunicpLssDate.Text
                                                                  , TextBoxMunicpExpDate.Text , TxtBoxAdvocatteship.Text , TxtBoxAdvocatteshipLssDate.Text  , TxtBoxAdvocatteshipExpDate.Text
                                                                  ,"0"}

                                                      , new string[] { TableBranches.ID }, new string[] { NodeID }
                                                      , "TableBranches", true);
                    }

                }

                // عرض النود الجديد
                IDNew = TextBoxID.Text;

                _TypeOperation = ClassPublicVar.TypeOperation.Show;
                _ClassFillTree.FillTree(TreeViewMain, _ClassSelect.SelectOpration("TableBranches"), TableBranches.GroupID, TableBranches.ID, TableBranches.NameLng1, TableBranches.IsGroup);
                ToolsStatus();

                _ClassTreeViewController.SelectfromTree(ref TreeViewMain, IDNew);
                //FormBranches_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("هل تريد الحذف بالفعل ؟", "تأكيد الحذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _ClassDelete.DeleteOpration(new string[] { TableBranches.ID }, new string[] { NodeID }, "TableBranches", true);
                    FormBranches_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            FormBranches_Load(sender, e);
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGroupSearch_Click(object sender, EventArgs e)
        {
            TreeSearchForm _TreeSearchForm = new TreeSearchForm("TableBranches", true);

            _TreeSearchForm.ShowDialog();

            if (_TreeSearchForm.DialogResult == DialogResult.OK)
            {
                _ClassTreeViewController.SelectfromTree(ref TreeViewMain, _TreeSearchForm.NodeID);

            }

            else if (_TreeSearchForm.DialogResult == DialogResult.Ignore)
            {
                MessageBox.Show(" لا يمكنك اختيار مجموعة هنا");
                _TreeSearchForm.ShowDialog();
            }
        }



    }
}
