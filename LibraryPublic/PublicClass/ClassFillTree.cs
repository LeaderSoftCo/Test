using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace LibraryPublic.PublicClass
{
   public  class ClassFillTree
    {

        #region Fuction of TreeView

       public static ImageList imageTree()
       {
           ImageList imageList = new ImageList();
           imageList.Images.Add(Properties.Resources._true);
           imageList.Images.Add(Properties.Resources.tree);
           imageList.Images.Add(Properties.Resources.file_blue);
           imageList.Images.Add(Properties.Resources.sheet_blue);
           return imageList;
       }
       public void FillTree(TreeView _TreeView, DataTable DataTree, string ParantColumName, string GuidColumName, string NameColumName, string IsGroup)
        {
            _TreeView.ImageList = imageTree();
            try
            {
                _TreeView.BeginUpdate();
                _TreeView.Nodes.Clear();
                TreeNode rootNode = _TreeView.Nodes.Add("Root", "Root", 1, 1);
                rootNode.Tag = "RootDB";
                int Tag = 1;
                PopulatingTreeView(rootNode, "0", DataTree, ref Tag, ParantColumName, GuidColumName, NameColumName, IsGroup);
                _TreeView.Select();
                _TreeView.EndUpdate();
                _TreeView.ExpandAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       private void PopulatingTreeView(TreeNode parentNode, string _GroupGUN, DataTable _DataTree, ref int _Tag, string ParantColumName, string GuidColumName, string NameColumName, string IsGroup)
        {
            foreach (var item in _DataTree.Select(ParantColumName + " = '" + _GroupGUN + "'"))
            {
                TreeNode ChildNode = new TreeNode();
                ChildNode.Tag = _Tag.ToString();
                ChildNode.Name = item[GuidColumName].ToString();
                ChildNode.Text = item[NameColumName].ToString() + ">>" + item[GuidColumName].ToString();
                ChildNode.ImageIndex = (item[IsGroup].ToString() == "0" ? 3 : 2);
                ChildNode.SelectedImageIndex = 0;
                parentNode.Nodes.Add(ChildNode);
                _Tag++;
                PopulatingTreeView(ChildNode, item[GuidColumName].ToString(), _DataTree, ref _Tag,  ParantColumName,  GuidColumName,  NameColumName,  IsGroup);
            }

        }


        #endregion

       #region Functions of Find and Color node
       public void findnode(TreeView treeView, TreeNode tr, string NodesText)
       {
           foreach (TreeNode nodes in tr.Nodes)
           {
               if (nodes.Text == NodesText)
               {


                   treeView.SelectedNode = nodes;
                   nodes.BackColor = Color.LightSkyBlue;

                   break;
               }
               if (tr.GetNodeCount(false) > 0)
               {
                   findnode(treeView, nodes, NodesText);
               }
           }


           //------------------دالة تلوين النود المختاره
       }
       public void ColorTreeNode(TreeNode tr)
       {
           foreach (TreeNode nodes in tr.Nodes)
           {
               nodes.BackColor = Color.Transparent;
               if (tr.GetNodeCount(false) > 0)
               {
                   ColorTreeNode(nodes);
               }
           }
       }

       #endregion

    }
}
