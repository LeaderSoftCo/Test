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
    public partial class FormChatOfAccount : Form
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


        public FormChatOfAccount()
        {
            InitializeComponent();
        }

        public void SearchID(DataTable DtID)
        {

            foreach (DataRow row in DtID.Rows)
            {

                if (row[TableChatOfAccount.ID].ToString() == TextBoxID.Text)
                {
                    MessageBox.Show("موجود مسبقا");
                    TextBoxID.Focus();
                    TextBoxID.Clear();
                    break;
                }
            }

        }


        private void ComboBox_Fill () 
        {
             // تعبئة قائمة التصنيف
                ComboBoxClass.DataSource= _ClassSelect.SelectOpration("TableComboboxClass");
                ComboBoxClass.DisplayMember = "ClassName";
                ComboBoxClass.ValueMember = "ID";

                // تعبئة قائمة طبيعة الحساب
                CompBoxAccNaut.DataSource = _ClassSelect.SelectOpration("TableComboboxAccNaut");
                CompBoxAccNaut.DisplayMember = "AccNaut";
                CompBoxAccNaut.ValueMember = "ID";

                // تعبئة قائمة طبيعة الحساب
                CompBoxStatus.DataSource = _ClassSelect.SelectOpration("TableComboboxStatus");
                CompBoxStatus.DisplayMember = "AccStatus";
                CompBoxStatus.ValueMember = "ID";

                // تعبئة قائمة طبيعة الحساب
                CompBoxPosting.DataSource = _ClassSelect.SelectOpration("TableComboboxPosting");
                CompBoxPosting.DisplayMember = "Positing";
                CompBoxPosting.ValueMember = "ID";
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
                TextBoxTotalCredit.ReadOnly = true;
                TextBoxeTotalDebit.ReadOnly = true;
                TextBoxBalacne.ReadOnly = true;
                TextBoxCreditLimit.ReadOnly = true;
                
                
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

                ComboBoxClass.Enabled = false;
                CompBoxAccNaut.Enabled = false;
                CompBoxStatus.Enabled = false;
                CompBoxPosting.Enabled = false;

                TextBoxID.Clear();
                TextBoxGroupID.Clear();
                TextBoxGroupName.Clear();
                TextBoxNameLng1.Clear();
                TextBoxNameLng2.Clear();
                TextBoxTotalCredit.Clear();
                TextBoxeTotalDebit.Clear();
                TextBoxBalacne.Clear();
                TextBoxCreditLimit.Clear();
            }

            else if (_TypeOperation == ClassPublicVar.TypeOperation.Add)
            {
                TextBoxID.ReadOnly = false;
                TextBoxGroupID.ReadOnly = false;
                TextBoxGroupName.ReadOnly = true;
                TextBoxNameLng1.ReadOnly = false;
                TextBoxNameLng2.ReadOnly = false;
                TextBoxTotalCredit.ReadOnly = false;
                TextBoxeTotalDebit.ReadOnly = false;
                TextBoxBalacne.ReadOnly = false;
                TextBoxCreditLimit.ReadOnly = false;
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

                ComboBoxClass.Enabled = true;
                CompBoxAccNaut.Enabled = true;
                CompBoxStatus.Enabled = true;
                CompBoxPosting.Enabled = true;

                TextBoxID.Clear();
                TextBoxGroupID.Clear();
                TextBoxGroupName.Clear();
                TextBoxNameLng1.Clear();
                TextBoxNameLng2.Clear();
                TextBoxTotalCredit.Clear();
                TextBoxeTotalDebit.Clear();
                TextBoxBalacne.Clear();
                TextBoxCreditLimit.Clear();
            }

            else if (_TypeOperation == ClassPublicVar.TypeOperation.Edit)
            {

                TextBoxID.ReadOnly = true;
                TextBoxGroupID.ReadOnly = false;
                TextBoxGroupName.ReadOnly = true;
                TextBoxNameLng1.ReadOnly = false;
                TextBoxNameLng2.ReadOnly = false;
                TextBoxTotalCredit.ReadOnly = false;
                TextBoxeTotalDebit.ReadOnly = false;
                TextBoxBalacne.ReadOnly = false;
                TextBoxCreditLimit.ReadOnly = false;


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

                ComboBoxClass.Enabled = true;
                CompBoxAccNaut.Enabled = true;
                CompBoxStatus.Enabled = true;
                CompBoxPosting.Enabled = true;

                //TextBoxID.Clear();
                //TextBoxGroupID.Clear();
                //TextBoxGroupName.Clear();
                //TextBoxNameLng1.Clear();
                //TextBoxNameLng2.Clear();
                //TextBoxTotalCredit.Clear();
                //TextBoxeTotalDebit.Clear();
                //TextBoxBalacne.Clear();
                //TextBoxCreditLimit.Clear();
            }
        }




        private void FormChatOfAccount_Load(object sender, EventArgs e)
        {
            try
            {

                _TypeOperation = ClassPublicVar.TypeOperation.Show;

                _ClassFillTree.FillTree(TreeViewMain, _ClassSelect.SelectOpration("TableChatOfAccount"), TableChatOfAccount.GroupID, TableChatOfAccount.ID, TableChatOfAccount.NameLng1, TableChatOfAccount.IsGroup);

                
                // تعبئة الداتا قريد
                //DataTable dt1 = _ClassSelect.SelectOpration(
                //                              new string[] { TableChatOfAccount.ID, TableChatOfAccount.GroupID, TableChatOfAccount.GroupName, TableChatOfAccount.NameLng1, TableChatOfAccount.NameLng2
                //                                           , TableChatOfAccount.TotalCredit , TableChatOfAccount.TotalDebit , TableChatOfAccount.Balacne , TableChatOfAccount.CreditLimit}
                //                            , new string[] { "الرقم", "رقم المجموعة", "إسم المجموعة", "الإسم العربي", "الإسم الانجليزي" 
                //                                           , "إجمالي الدائن" , "إجمالي المدين" , "الرصيد" , "الحد الإنتمائي" }
                //                                           , "TableChatOfAccount");

                //DataGridViweShow.DataSource = dt1;

                ToolsStatus();

                // استرجاع اول بيانات أول تود عند النقر على تعديل لتجنب بقاء مربعات النص فارغة 
                TreeViewMain.SelectedNode = TreeViewMain.Nodes[0].FirstNode;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void re_Click(object sender, EventArgs e)
        {
            
            if (Pan.Height == 582 & Pan.Width == 168)
            {

                Pan.Height = 582;
                Pan.Width = 33;
            }
            else if (Pan.Height == 582 & Pan.Width == 33)
            {
                Pan.Height = 582;
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

                dt = _ClassSelect.SelectOpration("TableChatOfAccount", new string[] { TableChatOfAccount.ID }, new string[] { NodeID });

                if (_TypeOperation == ClassPublicVar.TypeOperation.Show)
                {
                    // TexBoxs
                    TextBoxID.Text = dt.Rows[0][TableChatOfAccount.ID].ToString();

                    TextBoxGroupID.Text = dt.Rows[0][TableChatOfAccount.GroupID].ToString();

                    TextBoxGroupName.Text = dt.Rows[0][TableChatOfAccount.GroupName].ToString();

                    TextBoxNameLng1.Text = dt.Rows[0][TableChatOfAccount.NameLng1].ToString();

                    TextBoxNameLng2.Text = dt.Rows[0][TableChatOfAccount.NameLng2].ToString();

                    TextBoxTotalCredit.Text = dt.Rows[0][TableChatOfAccount.TotalCredit].ToString();

                    TextBoxeTotalDebit.Text = dt.Rows[0][TableChatOfAccount.TotalDebit].ToString();

                    TextBoxBalacne.Text = dt.Rows[0][TableChatOfAccount.Balacne].ToString();

                    TextBoxCreditLimit.Text = dt.Rows[0][TableChatOfAccount.CreditLimit].ToString();

                    if (dt.Rows[0][TableChatOfAccount.IsGroup].ToString() == "0")
                    {
                        RadioBtnNotGroup.Checked = true;
                    }
                    else
                    {
                        RadioBtnGroup.Checked = true;
                    }

                    // comboboxs
                    ComboBoxClass.Text = dt.Rows[0][TableChatOfAccount.Class].ToString();
                    CompBoxAccNaut.Text = dt.Rows[0][TableChatOfAccount.AccNaut].ToString();
                    CompBoxStatus.Text = dt.Rows[0][TableChatOfAccount.Status].ToString();
                    CompBoxPosting.Text = dt.Rows[0][TableChatOfAccount.Posting].ToString();
                }
                // عملنا الشرط لنحدد كيفية تعبئة مربعات النص حسب نوع العملية ( عرض و تعديل أو جديد )
                else if (_TypeOperation == ClassPublicVar.TypeOperation.Add)
                {
                    TextBoxGroupID.Text = dt.Rows[0][TableCostCenter.ID].ToString();

                    TextBoxGroupName.Text = dt.Rows[0][TableCostCenter.NameLng1].ToString();
                    TextBoxNameLng1.Focus();
                }
            }
            catch
            {
            }

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
                IDDataTable = _ClassSelect.SelectOpration(new string[] { TableChatOfAccount.ID }, "TableChatOfAccount");
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
                    DTGroupID = _ClassSelect.SelectOpration(new string[] { TableChatOfAccount.ID, TableChatOfAccount.GroupName, TableChatOfAccount.NameLng1, TableChatOfAccount.IsGroup }, "TableChatOfAccount");

                    if (TextBoxGroupID.Text == "")
                    {
                    }
                    else if (TextBoxGroupID.Text == "0" )
                    {
                        TextBoxGroupID.Text = "0";
                        TextBoxGroupName.Text = "Root";
                    }
                    else
                    {
                        foreach (DataRow row in DTGroupID.Rows)
                        {


                            if (row[TableChatOfAccount.ID].ToString() == TextBoxGroupID.Text)
                            {


                                if (row[TableChatOfAccount.IsGroup].ToString() == "0")
                                {
                                    MessageBox.Show("لا يمكن الإضافة لفرد");
                                    TextBoxGroupID.Focus();
                                    TextBoxGroupID.Clear();
                                    Exsists = true;
                                }

                                else
                                {
                                    TextBoxGroupID.Text = row[TableChatOfAccount.ID].ToString();
                                    TextBoxGroupName.Text = row[TableChatOfAccount.NameLng1].ToString();
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
                _TypeOperation = ClassPublicVar.TypeOperation.Add;
                
                //  تغيير حالة الادوات
                ToolsStatus();

                // تعبئة الكمبوبوكس
                ComboBox_Fill();
                TextBoxID.Focus();
                _ClassFillTree.FillTree(TreeViewMain, _ClassSelect.SelectOpration("TableChatOfAccount"), TableChatOfAccount.GroupID, TableChatOfAccount.ID, TableChatOfAccount.NameLng1, TableChatOfAccount.IsGroup);
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
                // تغيير حالة الادوات
                ToolsStatus();
                
                // تعبئة الكمبوبوكس
                ComboBox_Fill();
                
                _ClassFillTree.FillTree(TreeViewMain, _ClassSelect.SelectOpration("TableChatOfAccount"), TableChatOfAccount.GroupID, TableChatOfAccount.ID, TableChatOfAccount.NameLng1, TableChatOfAccount.IsGroup);

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
                        if (TextBoxGroupID.Text != "" && TextBoxGroupID.Text != " ")
                        {

                            if (RadioBtnGroup.Checked)
                            {
                                _ClassInsert.InsertOpration(new string[] { TableChatOfAccount.ID , TableChatOfAccount.GroupID ,TableChatOfAccount.GroupName , TableChatOfAccount.NameLng1
                                                                 , TableChatOfAccount.NameLng2 , TableChatOfAccount.Class, TableChatOfAccount.AccNaut 
                                                                 , TableChatOfAccount.Status , TableChatOfAccount.TotalCredit , TableChatOfAccount.TotalDebit
                                                                 , TableChatOfAccount.Balacne , TableChatOfAccount.CreditLimit, TableChatOfAccount.Posting
                                                                 , TableChatOfAccount.IsGroup }

                                                           , new string[] { TextBoxID.Text , TextBoxGroupID.Text , TextBoxGroupName.Text ,TextBoxNameLng1.Text , TextBoxNameLng2.Text 
                                                                  , ComboBoxClass.Text , CompBoxAccNaut.Text , CompBoxStatus.Text , TextBoxTotalCredit.Text
                                                                  , TextBoxeTotalDebit.Text , TextBoxBalacne.Text , TextBoxCreditLimit.Text , CompBoxPosting.Text 
                                                                  ,"1"}
                                                           , "TableChatOfAccount"
                                                           , true
                                                           );
                            }

                            else if (RadioBtnNotGroup.Checked)
                            {
                                _ClassInsert.InsertOpration(new string[] { TableChatOfAccount.ID , TableChatOfAccount.GroupID , TableChatOfAccount.GroupName , TableChatOfAccount.NameLng1
                                                                  , TableChatOfAccount.NameLng2 , TableChatOfAccount.Class, TableChatOfAccount.AccNaut 
                                                                  , TableChatOfAccount.Status , TableChatOfAccount.TotalCredit , TableChatOfAccount.TotalDebit
                                                                  , TableChatOfAccount.Balacne , TableChatOfAccount.CreditLimit, TableChatOfAccount.Posting
                                                                  , TableChatOfAccount.IsGroup }

                                                           , new string[] { TextBoxID.Text , TextBoxGroupID.Text , TextBoxGroupName.Text ,TextBoxNameLng1.Text , TextBoxNameLng2.Text 
                                                                  , ComboBoxClass.Text , CompBoxAccNaut.Text , CompBoxStatus.Text , TextBoxTotalCredit.Text
                                                                  , TextBoxeTotalDebit.Text , TextBoxBalacne.Text , TextBoxCreditLimit.Text , CompBoxPosting.Text 
                                                                  ,"0"}
                                                           , "TableChatOfAccount"
                                                           , true
                                                           );
                            }
                        }
                        else if (TextBoxGroupID.Text == "" || TextBoxGroupID.Text == " ")
                        {
                            _ClassInsert.InsertOpration(new string[] { TableChatOfAccount.ID , TableChatOfAccount.GroupID , TableChatOfAccount.GroupName , TableChatOfAccount.NameLng1
                                                                  , TableChatOfAccount.NameLng2 , TableChatOfAccount.Class, TableChatOfAccount.AccNaut 
                                                                  , TableChatOfAccount.Status , TableChatOfAccount.TotalCredit , TableChatOfAccount.TotalDebit
                                                                  , TableChatOfAccount.Balacne , TableChatOfAccount.CreditLimit, TableChatOfAccount.Posting
                                                                  , TableChatOfAccount.IsGroup }

                                                           , new string[] { TextBoxID.Text , "0" , "Root" ,TextBoxNameLng1.Text , TextBoxNameLng2.Text 
                                                                  , ComboBoxClass.Text , CompBoxAccNaut.Text , CompBoxStatus.Text , TextBoxTotalCredit.Text
                                                                  , TextBoxeTotalDebit.Text , TextBoxBalacne.Text , TextBoxCreditLimit.Text , CompBoxPosting.Text 
                                                                  ,"0"}
                                                           , "TableChatOfAccount"
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
                                _ClassUpdate.UpdateOpration(new string[]  { TableChatOfAccount.ID , TableChatOfAccount.GroupID ,TableChatOfAccount.GroupName , TableChatOfAccount.NameLng1
                                                                 , TableChatOfAccount.NameLng2 , TableChatOfAccount.Class, TableChatOfAccount.AccNaut 
                                                                 , TableChatOfAccount.Status , TableChatOfAccount.TotalCredit , TableChatOfAccount.TotalDebit
                                                                 , TableChatOfAccount.Balacne , TableChatOfAccount.CreditLimit, TableChatOfAccount.Posting
                                                                 , TableChatOfAccount.IsGroup }
                                                           , new string[] {TextBoxID.Text , TextBoxGroupID.Text , TextBoxGroupName.Text ,TextBoxNameLng1.Text , TextBoxNameLng2.Text 
                                                                  , ComboBoxClass.Text , CompBoxAccNaut.Text , CompBoxStatus.Text , TextBoxTotalCredit.Text
                                                                  , TextBoxeTotalDebit.Text , TextBoxBalacne.Text , TextBoxCreditLimit.Text , CompBoxPosting.Text 
                                                                  ,"1"}
                                                           , new string[] { TableChatOfAccount.ID }, new string[] { NodeID }
                                                           , "TableChatOfAccount", true);
                            }
                            else if (RadioBtnNotGroup.Checked)
                            {
                                _ClassUpdate.UpdateOpration(new string[] { TableChatOfAccount.ID , TableChatOfAccount.GroupID ,TableChatOfAccount.GroupName , TableChatOfAccount.NameLng1
                                                                 , TableChatOfAccount.NameLng2 , TableChatOfAccount.Class, TableChatOfAccount.AccNaut 
                                                                 , TableChatOfAccount.Status , TableChatOfAccount.TotalCredit , TableChatOfAccount.TotalDebit
                                                                 , TableChatOfAccount.Balacne , TableChatOfAccount.CreditLimit, TableChatOfAccount.Posting
                                                                 , TableChatOfAccount.IsGroup }
                                                           , new string[] {TextBoxID.Text , TextBoxGroupID.Text , TextBoxGroupName.Text ,TextBoxNameLng1.Text , TextBoxNameLng2.Text 
                                                                  , ComboBoxClass.Text , CompBoxAccNaut.Text , CompBoxStatus.Text , TextBoxTotalCredit.Text
                                                                  , TextBoxeTotalDebit.Text , TextBoxBalacne.Text , TextBoxCreditLimit.Text , CompBoxPosting.Text 
                                                                  ,"0"}
                                                           , new string[] { TableChatOfAccount.ID }, new string[] { NodeID }
                                                           , "TableChatOfAccount", true);
                            }


                        }

                        else if (TextBoxGroupID.Text == "" || TextBoxGroupID.Text == " ")
                        {
                            _ClassUpdate.UpdateOpration(new string[] { TableChatOfAccount.ID , TableChatOfAccount.GroupID ,TableChatOfAccount.GroupName , TableChatOfAccount.NameLng1
                                                                 , TableChatOfAccount.NameLng2 , TableChatOfAccount.Class, TableChatOfAccount.AccNaut 
                                                                 , TableChatOfAccount.Status , TableChatOfAccount.TotalCredit , TableChatOfAccount.TotalDebit
                                                                 , TableChatOfAccount.Balacne , TableChatOfAccount.CreditLimit, TableChatOfAccount.Posting
                                                                 , TableChatOfAccount.IsGroup }
                                                          , new string[] {TextBoxID.Text , "0", "Root" ,TextBoxNameLng1.Text , TextBoxNameLng2.Text 
                                                                  , ComboBoxClass.Text , CompBoxAccNaut.Text , CompBoxStatus.Text , TextBoxTotalCredit.Text
                                                                  , TextBoxeTotalDebit.Text , TextBoxBalacne.Text , TextBoxCreditLimit.Text , CompBoxPosting.Text 
                                                                  ,"0"}
                                                          , new string[] { TableChatOfAccount.ID }, new string[] { NodeID }
                                                          , "TableChatOfAccount", true);
                        }

                    }

                    // عرض النود الجديد
                    IDNew = TextBoxID.Text;
                    _TypeOperation = ClassPublicVar.TypeOperation.Show;
                    _ClassFillTree.FillTree(TreeViewMain, _ClassSelect.SelectOpration("TableChatOfAccount"), TableChatOfAccount.GroupID, TableChatOfAccount.ID, TableChatOfAccount.NameLng1, TableChatOfAccount.IsGroup);
                    ToolsStatus();
                    _ClassTreeViewController.SelectfromTree(ref TreeViewMain, IDNew);

                    //FormChatOfAccount_Load(sender, e);
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
                    _ClassDelete.DeleteOpration(new string[] { TableChatOfAccount.ID }, new string[] { NodeID }, "TableChatOfAccount", true);
                    FormChatOfAccount_Load(sender, e);
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
            // نعيد تحميل الفورم من جديد ليتم عرض الاضافة الجديده وتطيبق عملية العرض
            FormChatOfAccount_Load(sender, e);
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGroupSearch_Click(object sender, EventArgs e)
        {
            TreeSearchForm _TreeSearchForm = new TreeSearchForm("TableChatOfAccount", true);

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
