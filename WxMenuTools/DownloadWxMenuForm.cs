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
    public partial class DownloadWxMenuForm : Form
    {
        public DownloadWxMenuForm()
        {
            InitializeComponent();
        }

        private void btnDownloadMenu_Click(object sender, EventArgs e)
        {
           tbResponse.Text =  WxchatHelper.GetWxMenuOnline();
          // rtbResponse.Text = tbResponse.Text;
        }

        private void btnSaveAsTemplate_Click(object sender, EventArgs e)
        {
            string dir = System.AppDomain.CurrentDomain.BaseDirectory + @"data";
            if (!System.IO.Directory.Exists(dir))
            {
                System.IO.Directory.CreateDirectory(dir);
            }
            string fileName = @"\menu.json";
            String filePath = dir + fileName;
            //文件覆盖方式添加内容
            System.IO.StreamWriter file = new System.IO.StreamWriter(filePath, false);
            //保存数据到文件
            string data = tbResponse.Text.Trim();
            file.Write(data);
            //关闭文件
            file.Close();
            //释放对象
            file.Dispose();

        }
    }
}
