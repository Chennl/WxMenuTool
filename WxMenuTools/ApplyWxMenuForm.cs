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
    public partial class ApplyWxMenuForm : Form
    {
        public ApplyWxMenuForm()
        {
            InitializeComponent();
        }

        private void btnApplyMenu_Click(object sender, EventArgs e)
        {
            WxAppInfo wxAppInfo = WxchatHelper.GetWxAppInfo();
            if (wxAppInfo.AppID.Trim().Length == 0 || wxAppInfo.AppSecret.Trim().Length == 0)
            {
                MessageBox.Show(this, "请先在公众号管理中设置公众号信息！");
                return;
            }
            if (MessageBox.Show(this, "原公众号菜单将会被覆盖成当前设置菜单，确定在更新吗？", "自定义菜单更新", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                string menu = WxMenuHelper.GenerateMenuJson();
                tbResponse.Text = WxchatHelper.CreateWxMenuOnline(menu);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
