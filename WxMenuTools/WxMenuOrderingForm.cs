using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WxMenuTools
{
    public partial class WxMenuOrderingForm : Form
    {
        public WxMenuOrderingForm()
        {
            InitializeComponent();
        }

        private void WxMenuOrderingForm_Load(object sender, EventArgs e)
        {
            WxMenuHelper.BuildTreeView(this.menuTreeView);

            
            //WxMenuItem wxMenuItem = WxMenuHelper.GetWxMenuItem("root");
            //WxMenuListView.ListViewItem.
            //ListViewItem[] p = new ListViewItem[2];
            //p[0] = new ListViewItem(new string[] { "", "aaaa", "bbbb" });
            //p[1] = new ListViewItem(new string[] { "", "cccc", "ggggg" });
            // WxMenuListView.a
        }

        private void menuTreeView_DragDrop(object sender, DragEventArgs e)
        {
            TreeView tv = sender as TreeView;
            //取得被拖拽的节点
            TreeNode dragNode = e.Data.GetData(typeof(TreeNode)) as TreeNode;
            if (dragNode.Equals(tv.SelectedNode))
                return;
            if (tv.SelectedNode ==null)
                return;
            if (dragNode.Parent != tv.SelectedNode.Parent)
                return;

            if (e.Effect == DragDropEffects.Move)
            {
                if (tv.SelectedNode == null)
                {
                    
                    tv.Nodes.Add(dragNode.Clone() as TreeNode);
                    dragNode.Remove();
                    return;
                }
                dragNode.Remove();
                
            
          //      tv.SelectedNode.Nodes.Add(dragNode);
                tv.SelectedNode.Parent.Nodes.Insert( tv.SelectedNode.Index, dragNode);
            }
            dragNode.Expand();
        }

        private void menuTreeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            TreeNode dragNode = e.Item as TreeNode;
            DoDragDrop(dragNode, DragDropEffects.Move);
        }

        private void menuTreeView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TreeNode)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void menuTreeView_DragOver(object sender, DragEventArgs e)
        {
            TreeView tv = sender as TreeView;
            tv.SelectedNode = tv.GetNodeAt(tv.PointToClient(new Point(e.X, e.Y)));
        }

        private void menuTreeView_MouseClick(object sender, MouseEventArgs e)
        {
           // TreeNode clickNode = e.Node;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            WxMenuHelper.SaveTreeViewToDatabase(menuTreeView);
           // string menu = WxMenuHelper.GenerateMenuJson();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
