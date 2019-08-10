using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibraryConnection;
using LibraryPublic.PublicClass;
using LibraryPublic.Table;
using LibraryPublic;
using LeaderSoft.Forms.PublicForms.SearchForm;

namespace LeaderSoft.Forms.PublicForms
{
    public partial class FormDebentures : Form
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


        public FormDebentures()
        {
            InitializeComponent();
        }


        //  لفحص القيمة المدخلة هل هي موجوده مسبقا او لا\TextboxID دالة فحص
        public void SearchID(DataTable DtID)
        {

            foreach (DataRow row in DtID.Rows)
            {

                if (row[TableDebentures.ID].ToString() == TextBoxID.Text)
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
                TextBoxID.ReadOnly = true;
                TextBoxGroupID.ReadOnly = true;
                TextBoxGroupName.ReadOnly = true;
                TextBoxNameLng1.ReadOnly = true;
                TextBoxNameLng2.ReadOnly = true;

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

                TextBoxID.Clear();
                TextBoxGroupID.Clear();
                TextBoxGroupName.Clear();
                TextBoxNameLng1.Clear();
                TextBoxNameLng2.Clear();

            }

            else if (_TypeOperation == ClassPublicVar.TypeOperation.Add)
            {
                TextBoxID.ReadOnly = false;
                TextBoxGroupID.ReadOnly = false;
                TextBoxGroupName.ReadOnly = true;
                TextBoxNameLng1.ReadOnly = false;
                TextBoxNameLng2.ReadOnly = false;
                RadioBtnNotGroup.Checked = true;

                ButtonNew.Enabled = true;
                ButtonEdit.Enabled = false;
                ButtonSave.Enabled = true;
                ButtonDelete.Enabled = false;
                ButtonPrint.Enabled = false;
                ButtonSearch.Enabled = false;
                ButtonCancel.Enabled = true;
                ButtonExit.Enabled = false;
                RadioBtnGroup.Enabled = true;
                RadioBtnNotGroup.Enabled = true;
                buttonGroupSearch.Enabled = true;

                TreeViewMain.Enabled = false;

                ButtonLast.Enabled = false;
                ButtonNext.Enabled = false;
                ButtonPrevious.Enabled = false;
                ButtonFirst.Enabled = false;

                TextBoxID.Clear();
                TextBoxGroupID.Clear();
                TextBoxGroupName.Clear();
                TextBoxNameLng1.Clear();
                TextBoxNameLng2.Clear();
            }

            else if (_TypeOperation == ClassPublicVar.TypeOperation.Edit)
            {

                TextBoxID.ReadOnly = true;
                TextBoxGroupID.ReadOnly = false;
                TextBoxGroupName.ReadOnly = true;
                TextBoxNameLng1.ReadOnly = false;
                TextBoxNameLng2.ReadOnly = false;

                ButtonNew.Enabled = false;
                ButtonEdit.Enabled = false;
                ButtonSave.Enabled = true;
                ButtonDelete.Enabled = false;
                ButtonPrint.Enabled = false;
                ButtonSearch.Enabled = false;
                ButtonCancel.Enabled = true;
                ButtonExit.Enabled = false;
                RadioBtnGroup.Enabled = true;
                RadioBtnNotGroup.Enabled = true;
                buttonGroupSearch.Enabled = true;

                TreeViewMain.Enabled = false;

                ButtonLast.Enabled = false;
                ButtonNext.Enabled = false;
                ButtonPrevious.Enabled = false;
                ButtonFirst.Enabled = false;


                //TextBoxID.Clear();
                //TextBoxGroupID.Clear();
                //TextBoxGroupName.Clear();
                //TextBoxNameLng1.Clear();
                //TextBoxNameLng2.Clear();
            }
        }




        private void FormDebentures_Load(object sender, EventArgs e)
        {
            try
            {
                _TypeOperation = ClassPublicVar.TypeOperation.Show;

                _ClassFillTree.FillTree(TreeViewMain, _ClassSelect.SelectOpration("TableDebentures"), TableCostCenter.GroupID, TableCostCenter.ID, TableCostCenter.NameLng1, TableCostCenter.IsGroup);

                ToolsStatus();

                // استرجاع اول بيانات أول نود عند النقر على تعديل لتجنب بقاء مربعات النص فارغة 
                TreeViewMain.SelectedNode = TreeViewMain.Nodes[0].FirstNode;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void re_Click(object sender, EventArgs e)
        {
            if (Pan.Height == 448 & Pan.Width == 168)
            {

                Pan.Height = 448;
                Pan.Width = 33;
            }
            else if (Pan.Height == 448 & Pan.Width == 33)
            {
                Pan.Height = 448;
                Pan.Width = 168;
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

            dt = _ClassSelect.SelectOpration("TableDebentures", new string[] { "ID" }, new string[] { NodeID });
            try
            {
                 // عملنا الشرط لنحدد كيفية تعبئة مربعات النص حسب نوع العملية ( عرض و تعديل أو جديد )
                if (_TypeOperation == ClassPublicVar.TypeOperation.Show)
                {
                    TextBoxID.Text = dt.Rows[0][TableDebentures.ID].ToString();

                    TextBoxGroupID.Text = dt.Rows[0][TableDebentures.GroupID].ToString();

                    TextBoxGroupName.Text = dt.Rows[0][TableDebentures.GroupName].ToString();

                    TextBoxNameLng1.Text = dt.Rows[0][TableDebentures.NameLng1].ToString();

                    TextBoxNameLng2.Text = dt.Rows[0][TableDebentures.NameLng2].ToString();

                    if (dt.Rows[0][TableDebentures.IsGroup].ToString() == "0")
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
                    TextBoxGroupID.Text = dt.Rows[0][TableDebentures.ID].ToString();

                    TextBoxGroupName.Text = dt.Rows[0][TableDebentures.NameLng1].ToString();
                    TextBoxNameLng1.Focus();
                }
            }
            catch{}

        }

        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            _ClassTreeViewController.PerviousNode(ref TreeViewMain);
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            _ClassTreeViewController.NextNode(ref TreeViewMain);
        }

        private void ButtonFirst_Click(object sender, EventArgs e)
        {
            _ClassTreeViewController.FirstNode(ref TreeViewMain);
        }

        private void ButtonLast_Click(object sender, EventArgs e)
        {
            _ClassTreeViewController.LastNode(ref TreeViewMain);
        }

        private void TextBoxID_Leave(object sender, EventArgs e)
        {
            if (_TypeOperation == ClassPublicVar.TypeOperation.Add)
            {
                IDDataTable = _ClassSelect.SelectOpration(new string[] { TableDebentures.ID }, "TableDebentures");
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
                    DTGroupID = _ClassSelect.SelectOpration(new string[] { TableDebentures.ID, TableDebentures.GroupName, TableDebentures.NameLng1, TableDebentures.IsGroup }, "TableDebentures");

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


                            if (row[TableDebentures.ID].ToString() == TextBoxGroupID.Text)
                            {


                                if (row[TableDebentures.IsGroup].ToString() == "0")
                                {
                                    MessageBox.Show("لا يمكن الإضافة لفرد");
                                    TextBoxGroupID.Focus();
                                    TextBoxGroupID.Clear();
                                    Exsists = true;
                                }

                                else
                                {
                                    TextBoxGroupID.Text = row[TableDebentures.ID].ToString();
                                    TextBoxGroupName.Text = row[TableDebentures.NameLng1].ToString();
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
                            //buttonMainSearch_Click(sender, e);
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
                _ClassFillTree.FillTree(TreeViewMain, _ClassSelect.SelectOpration("TableDebentures"), TableDebentures.GroupID, TableDebentures.ID, TableDebentures.NameLng1, TableDebentures.IsGroup);
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
                _ClassFillTree.FillTree(TreeViewMain, _ClassSelect.SelectOpration("TableDebentures"), TableDebentures.GroupID, TableDebentures.ID, TableDebentures.NameLng1, TableDebentures.IsGroup);
                _TypeOperation = ClassPublicVar.TypeOperation.Edit;
                ToolsStatus();

                // استرجاع اول بيانات أول نود عند النقر على تعديل لتجنب بقاء مربعات النص فارغة 
               //TreeViewMain.SelectedNode = TreeViewMain.Nodes[0].FirstNode;
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

                if (TextBoxID.Text != "" && TextBoxID.Text != " ")
                {

                    if (_TypeOperation == ClassPublicVar.TypeOperation.Add)
                    {
                        
                            if (TextBoxGroupID.Text != "" && TextBoxGroupID.Text != " ")
                            {

                                if (RadioBtnGroup.Checked)
                                {
                                    _ClassInsert.InsertOpration(new string[] { TableDebentures.ID , TableDebentures.GroupID , TableDebentures.GroupName , TableDebentures.NameLng1
                                                                         ,  TableDebentures.NameLng2 , TableDebentures.IsGroup}
                                                               , new string[] { TextBoxID.Text , TextBoxGroupID.Text , TextBoxGroupName.Text ,
                                                                            TextBoxNameLng1.Text , TextBoxNameLng2.Text , "1"}
                                                               , "TableDebentures"
                                                               , true
                                                               );
                                }

                                else if (RadioBtnNotGroup.Checked)
                                {
                                    _ClassInsert.InsertOpration(new string[] { TableDebentures.ID , TableDebentures.GroupID ,TableDebentures.GroupName , TableDebentures.NameLng1
                                                                         ,  TableDebentures.NameLng2 , TableDebentures.IsGroup}
                                                               , new string[] { TextBoxID.Text , TextBoxGroupID.Text , TextBoxGroupName.Text ,
                                                                            TextBoxNameLng1.Text , TextBoxNameLng2.Text , "0"}
                                                               , "TableDebentures"
                                                               , true
                                                               );
                                }
                            }
                            else if (TextBoxGroupID.Text == "" || TextBoxGroupID.Text == " ")
                            {
                                _ClassInsert.InsertOpration(new string[] { TableDebentures.ID , TableDebentures.GroupID ,TableDebentures.GroupName , TableDebentures.NameLng1
                                                                         ,  TableDebentures.NameLng2 , TableDebentures.IsGroup}
                                                               , new string[] { TextBoxID.Text , "0" , "Root" ,
                                                                            TextBoxNameLng1.Text , TextBoxNameLng2.Text , "0"}
                                                               , "TableDebentures"
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
                                _ClassUpdate.UpdateOpration(new string[] { TableDebentures.ID , TableDebentures.GroupID ,TableDebentures.GroupName , TableDebentures.NameLng1
                                                                             , TableDebentures.NameLng2 , TableDebentures.IsGroup}
                                                           , new string[] { TextBoxID.Text , TextBoxGroupID.Text , TextBoxGroupName.Text ,
                                                                               TextBoxNameLng1.Text , TextBoxNameLng2.Text , "1"}
                                                           , new string[] { TableDebentures.ID }, new string[] { NodeID }
                                                           , "TableDebentures", true);
                            }
                            else if (RadioBtnNotGroup.Checked)
                            {
                                _ClassUpdate.UpdateOpration(new string[] { TableDebentures.ID , TableDebentures.GroupID ,TableDebentures.GroupName , TableDebentures.NameLng1
                                                                         , TableDebentures.NameLng2 , TableDebentures.IsGroup}
                                                           , new string[] { TextBoxID.Text , TextBoxGroupID.Text , TextBoxGroupName.Text ,
                                                                               TextBoxNameLng1.Text , TextBoxNameLng2.Text , "0"}
                                                           , new string[] { TableDebentures.ID }, new string[] { NodeID }
                                                           , "TableDebentures", true);
                            }
                        }

                        else if (TextBoxGroupID.Text == "" || TextBoxGroupID.Text == " ")
                        {
                            _ClassUpdate.UpdateOpration(new string[] { TableDebentures.ID , TableDebentures.GroupID ,TableDebentures.GroupName , TableDebentures.NameLng1
                                                                         , TableDebentures.NameLng2 , TableDebentures.IsGroup}
                                                           , new string[] { TextBoxID.Text , "0" ,"Root" ,
                                                                               TextBoxNameLng1.Text , TextBoxNameLng2.Text , "0"}
                                                           , new string[] { TableDebentures.ID }, new string[] { NodeID }
                                                           , "TableDebentures", true);
                        }
                        
                    }

                    // عرض النود الجديد
                    IDNew = TextBoxID.Text;
                    _TypeOperation = ClassPublicVar.TypeOperation.Show;
                    _ClassFillTree.FillTree(TreeViewMain, _ClassSelect.SelectOpration("TableDebentures"), TableCostCenter.GroupID, TableCostCenter.ID, TableCostCenter.NameLng1, TableCostCenter.IsGroup);
                    ToolsStatus();
                    _ClassTreeViewController.SelectfromTree(ref TreeViewMain, IDNew);
                    
                    //FormDebentures_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("لم يتم إدخال رقم كود", "خطأ في الإدخال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextBoxID.Focus();
                }
                
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
                    _ClassDelete.DeleteOpration(new string[] { TableDebentures.ID }, new string[] { NodeID }, "TableDebentures", true);
                    FormDebentures_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            FormDebentures_Load( sender, e);
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {

        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {

        }

        private void buttonGroupSearch_Click(object sender, EventArgs e)
        {
            TreeSearchForm _TreeSearchForm = new TreeSearchForm("TableDebentures", true);

            _TreeSearchForm.ShowDialog();

            if (_TreeSearchForm.DialogResult == DialogResult.OK)
            {
                _ClassTreeViewController.SelectfromTree(ref TreeViewMain, _TreeSearchForm.NodeID);
                // _CostCenterSearchForm.
            }

            else if (_TreeSearchForm.DialogResult == DialogResult.Ignore)
            {
                MessageBox.Show(" لا يمكنك اختيار مجموعة هنا");
                _TreeSearchForm.ShowDialog();
            }
        }

    }
}
