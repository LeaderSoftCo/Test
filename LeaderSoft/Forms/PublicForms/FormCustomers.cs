using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibraryPublic;
using LibraryConnection;
using LibraryPublic.PublicClass;
using LibraryPublic.Table;
using LeaderSoft.Forms.PublicForms.SearchForm;

namespace LeaderSoft.Forms.PublicForms
{
    public partial class FormCustomers : Form
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

        public FormCustomers()
        {
            InitializeComponent();
        }

        public void SearchID(DataTable DtID)
        {

            foreach (DataRow row in DtID.Rows)
            {

                if (row[TableCustomer.ID].ToString() == TextBoxID.Text)
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
                TextBoxAddress.ReadOnly = true;
                TextBoxCity.ReadOnly = true;
                TextBoxEmail.ReadOnly = true;
                TextBoxTelephone1.ReadOnly = true;
                TextBoxTelephone2.ReadOnly = true;
                TextBoxFax.ReadOnly = true;
                TextBoxMobile.ReadOnly = true;
                TextBoxCreditLimit.ReadOnly = true;
                TextBoxDebitTrans.ReadOnly = true;
                TextBoxCreditTrans.ReadOnly = true;
                TextBoxBalance.ReadOnly = true;


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

                ButtonExit.Enabled = true;
                ButtonLast.Enabled = true;
                ButtonNext.Enabled = true;
                ButtonPrevious.Enabled = true;
                ButtonFirst.Enabled = true;

                TextBoxID.Clear();
                TextBoxGroupID.Clear();
                TextBoxGroupName.Clear();
                TextBoxNameLng1.Clear();
                TextBoxNameLng2.Clear();
                TextBoxAddress.Clear();
                TextBoxCity.Clear();
                TextBoxEmail.Clear();
                TextBoxTelephone1.Clear();
                TextBoxTelephone2.Clear();
                TextBoxFax.Clear();
                TextBoxMobile.Clear();
                TextBoxCreditLimit.Clear();
                TextBoxDebitTrans.Clear();
                TextBoxCreditTrans.Clear();
                TextBoxBalance.Clear();
            }

            else if (_TypeOperation == ClassPublicVar.TypeOperation.Add)
            {
                TextBoxID.ReadOnly = false;
                TextBoxGroupID.ReadOnly = false;
                TextBoxGroupName.ReadOnly = true;
                TextBoxNameLng1.ReadOnly = false;
                TextBoxNameLng2.ReadOnly = false;
                TextBoxAddress.ReadOnly = false;
                TextBoxCity.ReadOnly = false;
                TextBoxEmail.ReadOnly = false;
                TextBoxTelephone1.ReadOnly = false;
                TextBoxTelephone2.ReadOnly = false;
                TextBoxFax.ReadOnly = false;
                TextBoxMobile.ReadOnly = false;
                TextBoxCreditLimit.ReadOnly = false;
                TextBoxDebitTrans.ReadOnly = false;
                TextBoxCreditTrans.ReadOnly = false;
                TextBoxBalance.ReadOnly = false;


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

                ButtonExit.Enabled = false;
                ButtonLast.Enabled = false;
                ButtonNext.Enabled = false;
                ButtonPrevious.Enabled = false;
                ButtonFirst.Enabled = false;

                TextBoxID.Clear();
                TextBoxGroupID.Clear();
                TextBoxGroupName.Clear();
                TextBoxNameLng1.Clear();
                TextBoxNameLng2.Clear();
                TextBoxAddress.Clear();
                TextBoxCity.Clear();
                TextBoxEmail.Clear();
                TextBoxTelephone1.Clear();
                TextBoxTelephone2.Clear();
                TextBoxFax.Clear();
                TextBoxMobile.Clear();
                TextBoxCreditLimit.Clear();
                TextBoxDebitTrans.Clear();
                TextBoxCreditTrans.Clear();
                TextBoxBalance.Clear();
            }

            else if (_TypeOperation == ClassPublicVar.TypeOperation.Edit)
            {
                TextBoxID.ReadOnly = true;
                TextBoxGroupID.ReadOnly = false;
                TextBoxGroupName.ReadOnly = true;
                TextBoxNameLng1.ReadOnly = false;
                TextBoxNameLng2.ReadOnly = false;
                TextBoxAddress.ReadOnly = false;
                TextBoxCity.ReadOnly = false;
                TextBoxEmail.ReadOnly = false;
                TextBoxTelephone1.ReadOnly = false;
                TextBoxTelephone2.ReadOnly = false;
                TextBoxFax.ReadOnly = false;
                TextBoxMobile.ReadOnly = false;
                TextBoxCreditLimit.ReadOnly = false;
                TextBoxDebitTrans.ReadOnly = false;
                TextBoxCreditTrans.ReadOnly = false;
                TextBoxBalance.ReadOnly = false;


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

                //TextBoxID.Clear();
                //TextBoxGroupID.Clear();
                //TextBoxGroupName.Clear();
                //TextBoxNameLng1.Clear();
                //TextBoxNameLng2.Clear();
                //TextBoxAddress.Clear();
                //TextBoxCity.Clear();
                //TextBoxEmail.Clear();
                //TextBoxTelephone1.Clear();
                //TextBoxTelephone2.Clear();
                //TextBoxFax.Clear();
                //TextBoxMobile.Clear();
                //TextBoxCreditLimit.Clear();
                //TextBoxDebitTrans.Clear();
                //TextBoxCreditTrans.Clear();
                //TextBoxBalance.Clear();
            }
        }


        private void FormCustomers_Load(object sender, EventArgs e)
        {
            try
            {

                _TypeOperation = ClassPublicVar.TypeOperation.Show;

                _ClassFillTree.FillTree(TreeViewMain, _ClassSelect.SelectOpration("TableCustomer"), TableCustomer.GroupID
                    , TableCustomer.ID, TableCustomer.NameLng1, TableCustomer.IsGroup);

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


            dt = _ClassSelect.SelectOpration("TableCustomer", new string[] { TableCustomer.ID }, new string[] { NodeID });

            try
            {
                if (_TypeOperation == ClassPublicVar.TypeOperation.Show)
                {
                    TextBoxMainID.Text = dt.Rows[0][TableCustomer.IDMain].ToString();

                    TextBoxID.Text = dt.Rows[0][TableCustomer.ID].ToString();

                    TextBoxGroupID.Text = dt.Rows[0][TableCustomer.GroupID].ToString();

                    TextBoxGroupName.Text = dt.Rows[0][TableCustomer.GroupName].ToString();

                    TextBoxNameLng1.Text = dt.Rows[0][TableCustomer.NameLng1].ToString();

                    TextBoxNameLng2.Text = dt.Rows[0][TableCustomer.NameLng2].ToString();

                    TextBoxAddress.Text = dt.Rows[0][TableCustomer.Address].ToString();

                    TextBoxCity.Text = dt.Rows[0][TableCustomer.City].ToString();

                    TextBoxEmail.Text = dt.Rows[0][TableCustomer.Email].ToString();

                    TextBoxTelephone1.Text = dt.Rows[0][TableCustomer.Telephone1].ToString();

                    TextBoxTelephone2.Text = dt.Rows[0][TableCustomer.Telephone2].ToString();

                    TextBoxFax.Text = dt.Rows[0][TableCustomer.Fax].ToString();

                    TextBoxMobile.Text = dt.Rows[0][TableCustomer.Mobile].ToString();

                    TextBoxCreditLimit.Text = dt.Rows[0][TableCustomer.CreditLimit].ToString();

                    TextBoxDebitTrans.Text = dt.Rows[0][TableCustomer.DebitTrans].ToString();

                    TextBoxCreditTrans.Text = dt.Rows[0][TableCustomer.CreditTrans].ToString();

                    TextBoxBalance.Text = dt.Rows[0][TableCustomer.Balance].ToString();

                    if (dt.Rows[0][TableCustomer.IsGroup].ToString() == "0")
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
                    TextBoxGroupID.Text = dt.Rows[0][Tablecurency.ID].ToString();

                    TextBoxGroupName.Text = dt.Rows[0][Tablecurency.NameLng1].ToString();
                    TextBoxNameLng1.Focus();
                }
            }
            catch
            { }

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
                IDDataTable = _ClassSelect.SelectOpration(new string[] { TableCustomer.ID }, "TableCustomer");
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
                    DTGroupID = _ClassSelect.SelectOpration(new string[] { TableCustomer.ID, TableCustomer.GroupName, TableCustomer.NameLng1, TableCustomer.IsGroup }, "TableCustomer");

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


                            if (row[TableCustomer.ID].ToString() == TextBoxGroupID.Text)
                            {


                                if (row[TableCustomer.IsGroup].ToString() == "0")
                                {
                                    MessageBox.Show("لا يمكن الإضافة لفرد");
                                    TextBoxGroupID.Focus();
                                    TextBoxGroupID.Clear();
                                    Exsists = true;
                                }

                                else
                                {
                                    TextBoxGroupID.Text = row[TableCustomer.ID].ToString();
                                    TextBoxGroupName.Text = row[TableCustomer.NameLng1].ToString();
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
            _ClassFillTree.FillTree(TreeViewMain, _ClassSelect.SelectOpration("TableCustomer"), TableCustomer.GroupID, TableCustomer.ID, TableCustomer.NameLng1, TableCustomer.IsGroup);
            _TypeOperation = ClassPublicVar.TypeOperation.Add;
            ToolsStatus();
            TextBoxID.Focus();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            _ClassFillTree.FillTree(TreeViewMain, _ClassSelect.SelectOpration("TableCustomer"), TableCustomer.GroupID, TableCustomer.ID, TableCustomer.NameLng1, TableCustomer.IsGroup);

            _TypeOperation = ClassPublicVar.TypeOperation.Edit;
            ToolsStatus();

            // استرجاع اول بيانات أول تود عند النقر على تعديل لتجنب بقاء مربعات النص فارغة 
           // TreeViewMain.SelectedNode = TreeViewMain.Nodes[0].FirstNode;
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
                                _ClassInsert.InsertOpration(new string[] { TableCustomer.IDMain , TableCustomer.ID , TableCustomer.GroupID , TableCustomer.GroupName ,  TableCustomer.NameLng1 , TableCustomer.NameLng2 , TableCustomer.IsGroup ,
                                                                   TableCustomer.Address , TableCustomer.City , TableCustomer.Email ,
                                                                   TableCustomer.Telephone1 , TableCustomer.Telephone2 , TableCustomer.Fax , TableCustomer.Mobile ,
                                                                   TableCustomer.CreditLimit , TableCustomer.DebitTrans , TableCustomer.CreditTrans , TableCustomer.Balance}
                                                           , new string[] { TextBoxMainID.Text , TextBoxID.Text , TextBoxGroupID.Text , TextBoxGroupName.Text , TextBoxNameLng1.Text , TextBoxNameLng2.Text , "1" ,
                                                                    TextBoxAddress.Text , TextBoxCity.Text , TextBoxEmail.Text ,
                                                                    TextBoxTelephone1.Text , TextBoxTelephone2.Text , TextBoxFax.Text , TextBoxMobile.Text ,
                                                                    TextBoxCreditLimit.Text , TextBoxDebitTrans.Text , TextBoxCreditTrans.Text , TextBoxBalance.Text}

                                                           , "TableCustomer"
                                                           , true
                                                           );
                            }

                            else if (RadioBtnNotGroup.Checked)
                            {
                                _ClassInsert.InsertOpration(new string[] { TableCustomer.IDMain , TableCustomer.ID , TableCustomer.GroupID , TableCustomer.GroupName, TableCustomer.NameLng1 , TableCustomer.NameLng2 , TableCustomer.IsGroup ,
                                                                   TableCustomer.Address , TableCustomer.City , TableCustomer.Email ,
                                                                   TableCustomer.Telephone1 , TableCustomer.Telephone2 , TableCustomer.Fax , TableCustomer.Mobile ,
                                                                   TableCustomer.CreditLimit , TableCustomer.DebitTrans , TableCustomer.CreditTrans , TableCustomer.Balance}
                                                           , new string[] { TextBoxMainID.Text , TextBoxID.Text , TextBoxGroupID.Text , TextBoxGroupName.Text , TextBoxNameLng1.Text , TextBoxNameLng2.Text , "0" ,
                                                                    TextBoxAddress.Text , TextBoxCity.Text , TextBoxEmail.Text ,
                                                                    TextBoxTelephone1.Text , TextBoxTelephone2.Text , TextBoxFax.Text , TextBoxMobile.Text ,
                                                                    TextBoxCreditLimit.Text , TextBoxDebitTrans.Text , TextBoxCreditTrans.Text , TextBoxBalance.Text}
                                                           , "TableCustomer"
                                                           , true
                                                           );
                            }
                        }

                        else if (TextBoxGroupID.Text == "" || TextBoxGroupID.Text == " ")
                        {
                            _ClassInsert.InsertOpration(new string[] { TableCustomer.IDMain , TableCustomer.ID , TableCustomer.GroupID , TableCustomer.GroupName, TableCustomer.NameLng1 , TableCustomer.NameLng2 , TableCustomer.IsGroup ,
                                                                   TableCustomer.Address , TableCustomer.City , TableCustomer.Email ,
                                                                   TableCustomer.Telephone1 , TableCustomer.Telephone2 , TableCustomer.Fax , TableCustomer.Mobile ,
                                                                   TableCustomer.CreditLimit , TableCustomer.DebitTrans , TableCustomer.CreditTrans , TableCustomer.Balance}
                                                      , new string[] { TextBoxMainID.Text , TextBoxID.Text , "0" , "Root" , TextBoxNameLng1.Text , TextBoxNameLng2.Text , "0" ,
                                                                   TextBoxAddress.Text , TextBoxCity.Text , TextBoxEmail.Text ,
                                                                   TextBoxTelephone1.Text , TextBoxTelephone2.Text , TextBoxFax.Text , TextBoxMobile.Text ,
                                                                   TextBoxCreditLimit.Text , TextBoxDebitTrans.Text , TextBoxCreditTrans.Text , TextBoxBalance.Text}
                                                      , "TableCustomer"
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
                                _ClassUpdate.UpdateOpration(new string[] {  TableCustomer.IDMain ,TableCustomer.ID , TableCustomer.GroupID , TableCustomer.GroupName, TableCustomer.NameLng1 , TableCustomer.NameLng2 , TableCustomer.IsGroup ,
                                                                   TableCustomer.Address , TableCustomer.City , TableCustomer.Email ,
                                                                   TableCustomer.Telephone1 , TableCustomer.Telephone2 , TableCustomer.Fax , TableCustomer.Mobile ,
                                                                   TableCustomer.CreditLimit , TableCustomer.DebitTrans , TableCustomer.CreditTrans , TableCustomer.Balance}
                                                           , new string[] { TextBoxMainID.Text , TextBoxID.Text , TextBoxGroupID.Text , TextBoxGroupName.Text , TextBoxNameLng1.Text , TextBoxNameLng2.Text , "1" ,
                                                                    TextBoxAddress.Text , TextBoxCity.Text , TextBoxEmail.Text ,
                                                                    TextBoxTelephone1.Text , TextBoxTelephone2.Text , TextBoxFax.Text , TextBoxMobile.Text ,
                                                                    TextBoxCreditLimit.Text , TextBoxDebitTrans.Text , TextBoxCreditTrans.Text , TextBoxBalance.Text}
                                                           , new string[] { TableCustomer.ID }, new string[] { NodeID }
                                                           , "TableCustomer", true);
                            }
                            else if (RadioBtnNotGroup.Checked)
                            {
                                _ClassUpdate.UpdateOpration(new string[] {  TableCustomer.ID , TableCustomer.GroupID , TableCustomer.GroupName , TableCustomer.NameLng1 , TableCustomer.NameLng2 , TableCustomer.IsGroup ,
                                                                   TableCustomer.Address , TableCustomer.City , TableCustomer.Email ,
                                                                   TableCustomer.Telephone1 , TableCustomer.Telephone2 , TableCustomer.Fax , TableCustomer.Mobile ,
                                                                   TableCustomer.CreditLimit , TableCustomer.DebitTrans , TableCustomer.CreditTrans , TableCustomer.Balance}
                                                           , new string[] { TextBoxMainID.Text , TextBoxID.Text , TextBoxGroupID.Text , TextBoxGroupName.Text , TextBoxNameLng1.Text , TextBoxNameLng2.Text , "0" ,
                                                                    TextBoxAddress.Text , TextBoxCity.Text , TextBoxEmail.Text ,
                                                                    TextBoxTelephone1.Text , TextBoxTelephone2.Text , TextBoxFax.Text , TextBoxMobile.Text ,
                                                                    TextBoxCreditLimit.Text , TextBoxDebitTrans.Text , TextBoxCreditTrans.Text , TextBoxBalance.Text}
                                                           , new string[] { TableCustomer.ID }, new string[] { NodeID }
                                                           , "TableCustomer", true);
                            }
                        }

                        else if (TextBoxGroupID.Text == "" || TextBoxGroupID.Text == " ")
                        {
                            _ClassUpdate.UpdateOpration(new string[] {  TableCustomer.ID , TableCustomer.GroupID , TableCustomer.GroupName , TableCustomer.NameLng1 , TableCustomer.NameLng2 , TableCustomer.IsGroup ,
                                                                   TableCustomer.Address , TableCustomer.City , TableCustomer.Email ,
                                                                   TableCustomer.Telephone1 , TableCustomer.Telephone2 , TableCustomer.Fax , TableCustomer.Mobile ,
                                                                   TableCustomer.CreditLimit , TableCustomer.DebitTrans , TableCustomer.CreditTrans , TableCustomer.Balance}
                                                           , new string[] { TextBoxMainID.Text , TextBoxID.Text , "0" , "Root" , TextBoxNameLng1.Text , TextBoxNameLng2.Text , "0" ,
                                                                    TextBoxAddress.Text , TextBoxCity.Text , TextBoxEmail.Text ,
                                                                    TextBoxTelephone1.Text , TextBoxTelephone2.Text , TextBoxFax.Text , TextBoxMobile.Text ,
                                                                    TextBoxCreditLimit.Text , TextBoxDebitTrans.Text , TextBoxCreditTrans.Text , TextBoxBalance.Text}
                                                           , new string[] { TableCustomer.ID }, new string[] { NodeID }
                                                           , "TableCustomer", true);

                        }

                    }
                    // عرض النود الجديد
                    IDNew = TextBoxID.Text;
                    _TypeOperation = ClassPublicVar.TypeOperation.Show;

                    _ClassFillTree.FillTree(TreeViewMain, _ClassSelect.SelectOpration("TableCustomer"), TableCustomer.GroupID
                        , TableCustomer.ID, TableCustomer.NameLng1, TableCustomer.IsGroup);

                    ToolsStatus();
                    _ClassTreeViewController.SelectfromTree(ref TreeViewMain, IDNew);
                    //FormCustomers_Load( sender, e);
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
            if (MessageBox.Show("هل تريد الحذف بالفعل ؟", "تأكيد الحذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _ClassDelete.DeleteOpration(new string[] { TableCustomer.ID }, new string[] { NodeID }, "TableCustomer", true);
                FormCustomers_Load(sender, e);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            FormCustomers_Load(sender, e);
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {

        }

        private void buttonGroupSearch_Click(object sender, EventArgs e)
        {
            TreeSearchForm _TreeSearchForm = new TreeSearchForm("TableCustomer", true);

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
