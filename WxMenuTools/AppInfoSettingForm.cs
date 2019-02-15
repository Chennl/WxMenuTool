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
    public partial class AppInfoSettingForm : Form
    {
        public AppInfoSettingForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string appID = tbAppID.Text.Trim();
            string appsecrect = tbAppSecrect.Text.Trim();
            string wxName = tbWxName.Text.Trim();
            if (string.IsNullOrEmpty(wxName))
            {
                MessageBox.Show(this, "公账号名称不能为空！", "数据校验", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(appID))
            {
                MessageBox.Show(this, "appID不能为空！", "数据校验", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(appsecrect))
            {

                MessageBox.Show(this, "appSecrect不能为空！", "数据校验", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (WxchatHelper.SaveWxAppInfo(wxName, appID, appsecrect) > 0)
            {
                MessageBox.Show(this, "保存成功！", "数据保存");
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "保存失败！", "数据保存",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void AppInfoSettingForm_Load(object sender, EventArgs e)
        {
            WxAppInfo wxAppInfo =WxchatHelper.GetWxAppInfo();
            tbWxName.Text = wxAppInfo.WxName;
            tbAppID.Text = wxAppInfo.AppID;
            tbAppSecrect.Text = wxAppInfo.AppSecret;
        }
    }
}
