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
    public partial class WxMenuAddForm : Form
    {
        private TreeNode _parentTreeNode = null;
        public TreeNode ParentTreeNode
        {
            get
            {
                return _parentTreeNode;
            }
            set
            {
                _parentTreeNode = value;
            }
        }
        public WxMenuAddForm()
        {
            InitializeComponent();
        }

        private void WxMenuAddForm_Load(object sender, EventArgs e)
        {
            if (_parentTreeNode != null) {
                if(_parentTreeNode.Level ==1)
                    labelMenuPath.Text += " ---> " + _parentTreeNode.Text; 
                if(_parentTreeNode.Level ==2)
                    labelMenuPath.Text += " ---> " + _parentTreeNode.Parent.Text + " ---> " + _parentTreeNode.Text; 
            }
        }

        private void btSaveTreeNode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text.Trim()))
            {

                MessageBox.Show(this, "请自定义菜单标题不能为空！", "数据校验", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            WxMenuItem wxMenuItem = new WxMenuItem();


            if (rbView.Checked)
            {
                wxMenuItem.Type = "view";
                if (string.IsNullOrEmpty(tbUrl.Text.Trim()))
                {
                    MessageBox.Show(this, "网页跳转类型，网页链接不能为空！", "数据校验", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
            }
            else if (rbClick.Checked)
            {
                wxMenuItem.Type = "click";
                if (string.IsNullOrEmpty(tbKey.Text.Trim()))
                {
                    MessageBox.Show(this, "点击事件类型，菜单KEY值不能为空！", "数据校验", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
            }
            else if (rbMenu.Checked)
            {
                wxMenuItem.Type = "menu";
            }

            if (string.IsNullOrEmpty(wxMenuItem.Type))
            {
                MessageBox.Show(this, "请选择自定义菜单类型！", "数据校验", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

    
            wxMenuItem.ParentCode = ((WxMenuItem)(_parentTreeNode.Tag)).SelfCode;
            wxMenuItem.SelfCode = Guid.NewGuid().ToString("N");
            wxMenuItem.Name = tbName.Text.Trim(); 
            wxMenuItem.Key = tbKey.Text.Trim();
            wxMenuItem.Url = tbUrl.Text.Trim();
            wxMenuItem.Level = _parentTreeNode.Level +1;
            wxMenuItem.Index = _parentTreeNode.Nodes.Count;
            wxMenuItem.UpdateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff");
            wxMenuItem.CreateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff");

            if (rbView.Checked)
            {
                wxMenuItem.Type = "view";
            }
            else if (rbClick.Checked)
            {
                wxMenuItem.Type = "click";
            }
            else if (rbMenu.Checked)
            {
                wxMenuItem.Type = "menu";
            }

         
            TreeNode newNode = new TreeNode();
            newNode.Tag = wxMenuItem;
            newNode.Text = wxMenuItem.Name;
            _parentTreeNode.Nodes.Add(newNode);
            this.DialogResult = DialogResult.OK;

            if( WxMenuHelper.UpdateWxMenuItemToDatabase(wxMenuItem) > 0)
            {
                MessageBox.Show(this, "自定义菜单保存成功！", "菜单保存");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(this, "自定义菜单保存失败！", "菜单保存");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
