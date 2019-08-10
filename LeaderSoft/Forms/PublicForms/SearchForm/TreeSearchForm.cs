using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibraryPublic.PublicClass;
using LeaderSoft.Forms;
using LibraryConnection;
using LibraryPublic.Table;

namespace LeaderSoft.Forms.PublicForms.SearchForm
{
    public partial class TreeSearchForm : Form
    {
        ClassSelect _ClassSelect = new ClassSelect();
        ClassFillTree _ClassFillTree = new ClassFillTree();
        ClassTreeViewController _ClassTreeViewController = new ClassTreeViewController();
        //FormCostCenter _FormCostCenter = new FormCostCenter();

        public string NodeID = "";
        int NodeImage;
        string _TableName ;
        bool _IsGroup;
        
        public TreeSearchForm(string TableName,bool IsGroup)
        {
            InitializeComponent();
            
            _TableName=TableName;
            _IsGroup = IsGroup;
        }

        private void CostCenterSearchForm_Load(object sender, EventArgs e)
        {
           // _ClassFillTree.FillTree(TreeViewMain, _ClassSelect.SelectOpration(_TableName , new string[] { TableCostCenter.IsGroup }, new string[] { _IsGroupVal }), TableCostCenter.GroupID, TableCostCenter.ID, TableCostCenter.NameLng1, TableCostCenter.IsGroup);
             _ClassFillTree.FillTree(TreeViewMain, (_IsGroup == true ? _ClassSelect.SelectOpration(_TableName , new string[] { "IsGroup" } , new string[] {"1"} ):_ClassSelect.SelectOpration(_TableName )) ,"GroupID", "ID", "NameLng1", "IsGroup");
        }

        private void TreeViewMain_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
            for (int i = 0; i < e.Node.Text.Length; i++)
            {
                if (e.Node.Text[i] == '>')
                {
                    i += 2;
                    // لتحديد رقم النود المختارة
                    NodeID = e.Node.Text.Substring(i, e.Node.Text.Length - i);
                    // لتحديد نوع النود المختارة 
                    NodeImage = e.Node.ImageIndex;
                }
            }
            //DataTable dt = new DataTable() ;
            // dt = _ClassSelect.SelectOpration("TableCostCenter", new string[] { "ID" }, new string[] { NodeID });
            // //_FormCostCenter.TextBoxGroupID.Text = dt.Rows[0][TableCostCenter.ID].ToString();
            // try
            // {
            //     _FormCostCenter.TextBoxGroupID.Text = dt.Rows[0][TableCostCenter.GroupID].ToString();

            //     _FormCostCenter.TextBoxGroupName.Text = dt.Rows[0][TableCostCenter.GroupName].ToString();
            // }
            // catch { }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //dt = _ClassSelect.SelectOpration("TableCostCenter", new string[] { "ID" }, new string[] { NodeID });
            ////_FormCostCenter.TextBoxGroupID.Text = dt.Rows[0][TableCostCenter.ID].ToString();
            //try
            //{
            //    FormCostCenter.TextBoxGroupID.Text = dt.Rows[0][TableCostCenter.GroupID].ToString();

            //    FormCostCenter.TextBoxGroupName.Text = dt.Rows[0][TableCostCenter.GroupName].ToString();

            //    FormCostCenter.ShowInTaskbar = false;
            //    this.Close();
            //   // _FormCostCenter;
            //}
            //catch { }
            //_ClassTreeViewController.SelectfromTree(ref _FormCostCenter.TreeViewMain, NodeID);

            if (_IsGroup == true || (_IsGroup == false && NodeImage == 3))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.Ignore;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
