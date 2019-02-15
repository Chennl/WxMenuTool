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
    public partial class WxMenuEditForm : Form
    {
        public WxMenuEditForm()
        {
            InitializeComponent();
        }

        private TreeNode _currentTreeNode = null;
        public TreeNode CurrentTreeNode
        {
            get
            {
                return _currentTreeNode;
            }
            set
            {
                _currentTreeNode = value;
            }
        }

        private void WxMenuEditForm_Load(object sender, EventArgs e)
        {
            if (_currentTreeNode != null)
            {
                WxMenuItem wxMenuItem = (WxMenuItem)_currentTreeNode.Tag;
                tbName.Text = wxMenuItem.Name;
                tbKey.Text = wxMenuItem.Key;
                tbUrl.Text = wxMenuItem.Url;
                if (wxMenuItem.Type.Equals("view"))
                {
                    rbView.Checked = true;
                }
                else if (wxMenuItem.Type.Equals("click"))
                {
                    rbClick.Checked = true;
                }
                else if (wxMenuItem.Type.Equals("menu"))
                {
                    rbMenu.Checked = true;
                }
            }
        }

        private void btSaveTreeNode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text.Trim()))
            {
                MessageBox.Show(this, "请自定义菜单标题不能为空！", "数据校验", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            WxMenuItem wxMenuItem =   (WxMenuItem)_currentTreeNode.Tag;

            wxMenuItem.Name = tbName.Text.Trim(); ;
            wxMenuItem.Key = tbKey.Text.Trim();
            wxMenuItem.Url = tbUrl.Text.Trim();
            wxMenuItem.Level = _currentTreeNode.Level;
            wxMenuItem.Index =  _currentTreeNode.Index;
            wxMenuItem.UpdateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff");

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
         
            _currentTreeNode.Tag = wxMenuItem;
            _currentTreeNode.Text = wxMenuItem.Name;

            if (WxMenuHelper.UpdateWxMenuItemToDatabase(wxMenuItem) > 0)
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
