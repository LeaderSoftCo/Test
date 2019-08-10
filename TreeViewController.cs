using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryPublicVar.ClassPublic
{
    public class TreeViewController
    {
        public void SelectfromTree(ref TreeView _TreeView, string _GUN)
        {
            if (_TreeView.SelectedNode != null)
            {
                _TreeView.SelectedNode.BackColor = Color.FromArgb(66, 67, 69);

            }

            var _SelectedNode = _TreeView.Nodes.Find(_GUN, true).FirstOrDefault();
            if (_SelectedNode != null)
            {
                _SelectedNode.BackColor = Color.LightSkyBlue;
                _TreeView.SelectedNode = _SelectedNode;
            }
        }

        public void PerviousNode(ref TreeView _TreeView)
        {
            try
            {
                _TreeView.SelectedNode.BackColor = Color.FromArgb(66, 67, 69);
                if (_TreeView.SelectedNode.PrevNode != null && _TreeView.SelectedNode.PrevNode.Nodes.Count > 0)
                    _TreeView.SelectedNode = _TreeView.SelectedNode.PrevNode.LastNode;
                else if (_TreeView.SelectedNode.PrevNode != null)
                {
                    _TreeView.SelectedNode = _TreeView.SelectedNode.PrevNode;
                }
                else if (_TreeView.SelectedNode.Parent != null && _TreeView.SelectedNode.Parent != _TreeView.Nodes[0])
                {
                    _TreeView.SelectedNode = _TreeView.SelectedNode.Parent;
                }
                _TreeView.SelectedNode.BackColor = Color.LightSkyBlue;
            }
            catch { }
        }

        public void NextNode(ref TreeView _TreeView)
        {
            try
            {
                _TreeView.SelectedNode.BackColor = Color.FromArgb(66, 67, 69);
                if (_TreeView.SelectedNode.Nodes.Count > 0)
                    _TreeView.SelectedNode = _TreeView.SelectedNode.Nodes[0];
                else if (_TreeView.SelectedNode.NextNode != null)
                {
                    _TreeView.SelectedNode = _TreeView.SelectedNode.NextNode;
                }
                else if (_TreeView.SelectedNode.Parent != null && _TreeView.SelectedNode.Parent.NextNode != null)
                {
                    _TreeView.SelectedNode = _TreeView.SelectedNode.Parent.NextNode;
                }
                else
                {
                    _TreeView.SelectedNode = _TreeView.SelectedNode.Parent;
                    NextNode(ref _TreeView);
                }
                _TreeView.SelectedNode.BackColor = Color.LightSkyBlue;
            }
            catch { }

        }

        public void LastNode(ref TreeView _TreeView)
        {
            try
            {
                _TreeView.SelectedNode.BackColor = Color.FromArgb(66, 67, 69);
                if (_TreeView.Nodes[0].GetNodeCount(true) > 1)
                {
                    _TreeView.SelectedNode = GetLastNode(_TreeView.Nodes[0].LastNode, ref _TreeView);
                }
                _TreeView.SelectedNode.BackColor = Color.LightSkyBlue;
            }
            catch { }

        }
        public void FirstNode(ref TreeView _TreeView)
        {
            try
            {
                _TreeView.SelectedNode.BackColor = Color.FromArgb(66, 67, 69);
                if (_TreeView.Nodes[0].Nodes.Count > 0)
                {
                    _TreeView.SelectedNode = _TreeView.Nodes[0].Nodes[0];
                }
                _TreeView.SelectedNode.BackColor = Color.LightSkyBlue;
            }
            catch { }
        }

        private TreeNode GetLastNode(TreeNode SubNode, ref TreeView _TreeView)
        {
            if (SubNode.Nodes.Count == 0)
            {
                return SubNode;
            }
            return GetLastNode(SubNode.Nodes[_TreeView.Nodes.Count - 1], ref _TreeView);
        }
    }
}
