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

namespace LeaderSoft
{
    public partial class Formcurency : Form
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


        public Formcurency()
        {
            InitializeComponent();
        }

        //  لفحص القيمة المدخلة هل هي موجوده مسبقا او لا\TextboxID دالة فحص
        public void SearchID(DataTable DtID)
        {

            foreach (DataRow row in DtID.Rows)
            {

                if (row[Tablecurency.ID].ToString() == TextBoxID.Text)
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
                TextBoxCurrencyID.ReadOnly = true;
                TextBoxNameCurrency.ReadOnly = true;
                TextBoxNameLng1.ReadOnly = true;
                TextBoxNameLng2.ReadOnly = true;
                TextBoxNumberParts.ReadOnly = true;
                textBoxRate.ReadOnly = true;

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
                TextBoxCurrencyID.Clear();
                TextBoxNameCurrency.Clear();
                TextBoxNameLng1.Clear();
                TextBoxNameLng2.Clear();
                TextBoxNumberParts.Clear();
                textBoxRate.Clear();
            }

            else if (_TypeOperation == ClassPublicVar.TypeOperation.Add)
            {
                TextBoxID.ReadOnly = false;
                TextBoxCurrencyID.ReadOnly = false;
                TextBoxNameCurrency.ReadOnly = true;
                TextBoxNameLng1.ReadOnly = false;
                TextBoxNameLng2.ReadOnly = false;
                TextBoxNumberParts.ReadOnly = false;
                textBoxRate.ReadOnly = false;
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
                TextBoxCurrencyID.Clear();
                TextBoxNameCurrency.Clear();
                TextBoxNameLng1.Clear();
                TextBoxNameLng2.Clear();
                TextBoxNumberParts.Clear();
                textBoxRate.Clear();
            }

            else if (_TypeOperation == ClassPublicVar.TypeOperation.Edit)
            {

                TextBoxID.ReadOnly = true;
                TextBoxCurrencyID.ReadOnly = false;
                TextBoxNameCurrency.ReadOnly = true;
                TextBoxNameLng1.ReadOnly = false;
                TextBoxNameLng2.ReadOnly = false;
                TextBoxNumberParts.ReadOnly = false;
                textBoxRate.ReadOnly = false;

                ButtonNew.Enabled = false;
                ButtonEdit.Enabled = false;
                ButtonSave.Enabled = true;
                ButtonDelete.Enabled = false;
                ButtonPrint.Enabled = false;
                ButtonSearch.Enabled = false;
                ButtonCancel.Enabled = true;
                ButtonExit.Enabled = false;
                buttonGroupSearch.Enabled = true;

                TreeViewMain.Enabled = false;

                ButtonLast.Enabled = true;
                ButtonNext.Enabled = true;
                ButtonPrevious.Enabled = true;
                ButtonFirst.Enabled = true;


                //TextBoxID.Clear();
                //TextBoxCurrencyID.Clear();
                //TextBoxNameCurrency.Clear();
                //TextBoxNameLng1.Clear();
                //TextBoxNameLng2.Clear();
                //TextBoxNumberParts.Clear();
                //textBoxRate.Clear();
            }
        }


        private void Formcurency_Load(object sender, EventArgs e)
        {
            try
            {

                _TypeOperation = ClassPublicVar.TypeOperation.Show;

                _ClassFillTree.FillTree(TreeViewMain, _ClassSelect.SelectOpration("TableCurency"), Tablecurency.CurrencyID, Tablecurency.ID, Tablecurency.NameLng1, Tablecurency.IsGroup);

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
            try
            {
                if (_TypeOperation == ClassPublicVar.TypeOperation.Show)
                {
                    dt = _ClassSelect.SelectOpration("TableCurency", new string[] { "ID" }, new string[] { NodeID });

                    TextBoxID.Text = dt.Rows[0][Tablecurency.ID].ToString();

                    TextBoxCurrencyID.Text = dt.Rows[0][Tablecurency.CurrencyID].ToString();

                    TextBoxNameCurrency.Text = dt.Rows[0][Tablecurency.CurrencyName].ToString();

                    TextBoxNameLng1.Text = dt.Rows[0][Tablecurency.NameLng1].ToString();

                    TextBoxNameLng2.Text = dt.Rows[0][Tablecurency.NameLng2].ToString();

                    textBoxRate.Text = dt.Rows[0][Tablecurency.Rate].ToString();

                    TextBoxNumberParts.Text = dt.Rows[0][Tablecurency.PartsNumber].ToString();

                    if (dt.Rows[0][Tablecurency.IsGroup].ToString() == "0")
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
                    TextBoxCurrencyID.Text = dt.Rows[0][Tablecurency.ID].ToString();

                    TextBoxNameCurrency.Text = dt.Rows[0][Tablecurency.NameLng1].ToString();
                    TextBoxNameLng1.Focus();
                }
            }
            catch { }
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            _ClassTreeViewController.NextNode(ref TreeViewMain);

        }

        private void ButtonLast_Click(object sender, EventArgs e)
        {
            _ClassTreeViewController.LastNode(ref TreeViewMain);
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
                IDDataTable = _ClassSelect.SelectOpration(new string[] { Tablecurency.ID }, "TableCurency");
                SearchID(IDDataTable);
            }
        }

        private void TextBoxCurrencyID_Leave(object sender, EventArgs e)
        {
            try
            {
                bool Exsists = false;
                if (_TypeOperation == ClassPublicVar.TypeOperation.Add)
                {
                    DTGroupID = _ClassSelect.SelectOpration(new string[] { Tablecurency.ID, Tablecurency.CurrencyName, Tablecurency.NameLng1, Tablecurency.IsGroup }, "TableCurency");


                    if (TextBoxCurrencyID.Text == "0" || TextBoxCurrencyID.Text == "")
                    {
                        TextBoxCurrencyID.Text = "0";
                        TextBoxNameCurrency.Text = "Root";
                    }
                    else
                    {
                        foreach (DataRow row in DTGroupID.Rows)
                        {


                            if (row[Tablecurency.ID].ToString() == TextBoxCurrencyID.Text)
                            {


                                if (row[Tablecurency.IsGroup].ToString() == "0")
                                {
                                    MessageBox.Show("لا يمكن الإضافة لفرد");
                                    TextBoxCurrencyID.Focus();
                                    TextBoxCurrencyID.Clear();
                                    Exsists = true;
                                }

                                else
                                {
                                    TextBoxCurrencyID.Text = row[Tablecurency.ID].ToString();
                                    TextBoxNameCurrency.Text = row[Tablecurency.NameLng1].ToString();
                                    Exsists = true;
                                    break;
                                }
                            }
                        }


                        if (Exsists == false)
                        {

                            MessageBox.Show("غير موجود");
                            TextBoxCurrencyID.Clear();
                            DTGroupID.Clear();
                            TextBoxCurrencyID.Focus();
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
                _ClassFillTree.FillTree(TreeViewMain, _ClassSelect.SelectOpration("TableCurency"), Tablecurency.CurrencyID, Tablecurency.ID, Tablecurency.NameLng1, Tablecurency.IsGroup);
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

                _TypeOperation = ClassPublicVar.TypeOperation.Edit;
                _ClassFillTree.FillTree(TreeViewMain, _ClassSelect.SelectOpration("TableCurency"), Tablecurency.CurrencyID, Tablecurency.ID, Tablecurency.NameLng1, Tablecurency.IsGroup);
                ToolsStatus();

                // استرجاع اول بيانات أول تود عند النقر على تعديل لتجنب بقاء مربعات النص فارغة 
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

                        if (TextBoxCurrencyID.Text != "" && TextBoxCurrencyID.Text != " ")
                        {

                            if (RadioBtnGroup.Checked)
                            {
                                _ClassInsert.InsertOpration(new string[] { Tablecurency.ID , Tablecurency.CurrencyID ,Tablecurency.CurrencyName , Tablecurency.NameLng1
                                                                     ,  Tablecurency.NameLng2,  Tablecurency.PartsNumber
                                                                     ,  Tablecurency.Rate , Tablecurency.IsGroup}
                                                           , new string[] { TextBoxID.Text , TextBoxCurrencyID.Text , TextBoxNameCurrency.Text ,
                                                                        TextBoxNameLng1.Text , TextBoxNameLng2.Text, TextBoxNumberParts.Text,
                                                                        textBoxRate.Text, "1"}
                                                           , "TableCurency"
                                                           , true
                                                           );
                            }

                            else if (RadioBtnNotGroup.Checked)
                            {
                                _ClassInsert.InsertOpration(new string[] { Tablecurency.ID , Tablecurency.CurrencyID ,Tablecurency.CurrencyName , Tablecurency.NameLng1
                                                                     ,  Tablecurency.NameLng2 ,  Tablecurency.PartsNumber 
                                                                     ,  Tablecurency.Rate , Tablecurency.IsGroup}
                                                           , new string[] { TextBoxID.Text , TextBoxCurrencyID.Text , TextBoxNameCurrency.Text ,
                                                                        TextBoxNameLng1.Text , TextBoxNameLng2.Text ,TextBoxNumberParts.Text,
                                                                        textBoxRate.Text, "0"}
                                                           , "TableCurency"
                                                           , true
                                                           );
                            }
                        }

                        else if (TextBoxCurrencyID.Text == "" || TextBoxCurrencyID.Text == " ")
                        {
                            _ClassInsert.InsertOpration(new string[] { Tablecurency.ID , Tablecurency.CurrencyID ,Tablecurency.CurrencyName , Tablecurency.NameLng1
                                                                 ,  Tablecurency.NameLng2 ,  Tablecurency.PartsNumber 
                                                                 ,  Tablecurency.Rate , Tablecurency.IsGroup}
                                                       , new string[] { TextBoxID.Text , "0" , "Root" ,
                                                                    TextBoxNameLng1.Text , TextBoxNameLng2.Text ,TextBoxNumberParts.Text,
                                                                    textBoxRate.Text, "0"}
                                                       , "TableCurency"
                                                       , true
                                                       );
                        }

                    }
                    else if (_TypeOperation == ClassPublicVar.TypeOperation.Edit)
                    {

                        if (TextBoxCurrencyID.Text != "" && TextBoxCurrencyID.Text != " ")
                        {

                            if (RadioBtnGroup.Checked)
                            {
                                _ClassUpdate.UpdateOpration(new string[] { Tablecurency.ID , Tablecurency.CurrencyID , Tablecurency.CurrencyName ,Tablecurency.NameLng1
                                                                 , Tablecurency.NameLng2 ,  Tablecurency.PartsNumber 
                                                                     ,  Tablecurency.Rate ,Tablecurency.IsGroup}
                                                           , new string[] { TextBoxID.Text , TextBoxCurrencyID.Text ,TextBoxNameCurrency.Text ,
                                                                       TextBoxNameLng1.Text , TextBoxNameLng2.Text ,TextBoxNumberParts.Text,
                                                                        textBoxRate.Text, "1"}
                                                           , new string[] { Tablecurency.ID }, new string[] { NodeID }
                                                           , "TableCurency", true);
                            }
                            else if (RadioBtnNotGroup.Checked)
                            {
                                _ClassUpdate.UpdateOpration(new string[] { Tablecurency.ID , Tablecurency.CurrencyID , Tablecurency.CurrencyName ,Tablecurency.NameLng1
                                                                 , Tablecurency.NameLng2 ,TextBoxNumberParts.Text,
                                                                        textBoxRate.Text, Tablecurency.IsGroup}
                                                           , new string[] { TextBoxID.Text , TextBoxCurrencyID.Text ,TextBoxNameCurrency.Text ,
                                                                       TextBoxNameLng1.Text , TextBoxNameLng2.Text , TextBoxNumberParts.Text,
                                                                        textBoxRate.Text, "0"}
                                                           , new string[] { Tablecurency.ID }, new string[] { NodeID }
                                                           , "TableCurency", true);
                            }
                        }

                        else if (TextBoxCurrencyID.Text == "" || TextBoxCurrencyID.Text == " ")
                        {
                            _ClassUpdate.UpdateOpration(new string[] { Tablecurency.ID , Tablecurency.CurrencyID , Tablecurency.CurrencyName ,Tablecurency.NameLng1
                                                             , Tablecurency.NameLng2 ,TextBoxNumberParts.Text,
                                                              textBoxRate.Text, Tablecurency.IsGroup}
                                                              , new string[] { TextBoxID.Text , "0" , "Root" ,
                                                                       TextBoxNameLng1.Text , TextBoxNameLng2.Text , TextBoxNumberParts.Text,
                                                                        textBoxRate.Text, "0"}
                                                              , new string[] { Tablecurency.ID }, new string[] { NodeID }
                                                              , "TableCurency", true);
                        }


                    }
                    // عرض النود الجديد
                    IDNew = TextBoxID.Text;

                    _TypeOperation = ClassPublicVar.TypeOperation.Show;
                    _ClassFillTree.FillTree(TreeViewMain, _ClassSelect.SelectOpration("TableCurency"), Tablecurency.CurrencyID, Tablecurency.ID, Tablecurency.NameLng1, Tablecurency.IsGroup);
                    ToolsStatus();
                    _ClassTreeViewController.SelectfromTree(ref TreeViewMain, IDNew);
                    //Formcurency_Load(sender, e);
                    //_ClassFillTree.FillTree(TreeViewMain, _ClassSelect.SelectOpration("TableCurency"), Tablecurency.CurrencyID, Tablecurency.ID, Tablecurency.NameLng1, Tablecurency.IsGroup);
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

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Formcurency_Load( sender,  e);
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف بالفعل ؟", "تأكيد الحذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _ClassDelete.DeleteOpration(new string[] { Tablecurency.ID }, new string[] { NodeID }, "TableCurency", true);
                Formcurency_Load(sender, e);
            }
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {

        }

        private void buttonGroupSearch_Click(object sender, EventArgs e)
        {
            TreeSearchForm _TreeSearchForm = new TreeSearchForm("TableCurency", true);

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
