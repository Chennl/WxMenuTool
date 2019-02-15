using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json.Linq;
using System.Data.SQLite;
using System.IO;

namespace WxMenuTools
{
    public partial class MenuSettingForm : Form
    {
        SQLiteConnection m_dbConnection;
        bool isupdate;

        public MenuSettingForm()
        {
            InitializeComponent();
           
        }


 
        private void MenuSettingForm_Load(object sender, EventArgs e)
        {
          
          //  SqliteHelper.CreateAllTablesToDatabase();
          //  m_dbConnection = new SQLiteConnection("Data Source=wxdb.sqlite;Version=3;");
           // m_dbConnection.Open();
            isupdate = false;
            WxMenuHelper.BuildTreeView(this.menuTreeView);
        }
  
 
 

    

        private void menuTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = this.menuTreeView.SelectedNode;

            if (selectedNode == null) return;
            if (selectedNode.Level == 0)
            {
                tbMenuName.Text = "";
                tbKey.Text = "";
                tbUrl.Text = "";
                btnAddChildNode.Enabled = true;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
            }
            else
            {
                WxMenuItem wxMenuItem = (WxMenuItem)selectedNode.Tag;
                tbMenuName.Text = wxMenuItem.Name;
                tbKey.Text = wxMenuItem.Key;
                tbUrl.Text = wxMenuItem.Url;
                if (wxMenuItem.Type.Equals("view"))
                {
                    rbView.Checked = true;
                    //链接不能有子菜单
                    btnAddChildNode.Enabled = false;
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
                else if (wxMenuItem.Type.Equals("click"))
                {
                    rbClick.Checked = true;
                    //消息事件不能有子菜单
                    btnAddChildNode.Enabled = false;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
                else if (wxMenuItem.Type.Equals("menu"))
                {
                    btnAddChildNode.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;

                    rbMenu.Checked = true;
                }
            }
        }

        private void SystemInitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(this, "系统初始化会清空所有历史数据，是否确定要继续？", "系统初始化", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {

               
                ////判断表是否存在，不存在则生成
                //int result = SqliteHelper.ExecuteScalar("SELECT COUNT(*) FROM sqlite_master where type='table' and name='tb_wxbuttons'");
                //if (result == 0)
                //{
                //    string sql = " CREATE TABLE `tb_wxbuttons` ( `id` integer PRIMARY KEY autoincrement,  `name` varchar(45) NOT NULL,  `type` varchar(20) DEFAULT NULL,  `url` varchar(120) DEFAULT NULL, `key` varchar(45) DEFAULT NULL,  `selfcode` varchar(45) NOT NULL,  `parentcode` varchar(45) NOT NULL,[createdate] datetime default (datetime('now', 'localtime')),[updatedate] datetime default (datetime('now', 'localtime')))";
                //    //创建表
                //    SqliteHelper.ExecuteSql(sql);
                //}
                //else
                //{
                string sql = " drop table tb_wxbuttons";
                SqliteHelper.ExecuteSql(sql);
                sql = @" CREATE TABLE tb_wxbuttons (
                            id         INTEGER       PRIMARY KEY AUTOINCREMENT,
                            name       VARCHAR (45)  NOT NULL,
                            type       VARCHAR (20)  DEFAULT NULL,
                            url        VARCHAR (120) DEFAULT NULL,
                            [key]      VARCHAR (45)  DEFAULT NULL,
                            selfcode   VARCHAR (45)  NOT NULL,
                            parentcode VARCHAR (45)  NOT NULL,
                            createdate VARCHAR (30),
                            updatedate VARCHAR (30),
                            level      INTEGER,
                            [index]    INTEGER
                        )";
                 SqliteHelper.ExecuteSql(sql);

                 sql = " drop table tb_wxappinfo";
                 SqliteHelper.ExecuteSql(sql);

                 sql = @"CREATE TABLE tb_wxappinfo (
                            id         INTEGER       PRIMARY KEY AUTOINCREMENT,
                            wxname     VARCHAR (50),
                            appid      VARCHAR (120),
                            appsecret  VARCHAR (120),
                            flag       INTEGER       DEFAULT (1),
                            createdate DATETIME      DEFAULT (datetime('now', 'localtime') ) 
                        )";
                 SqliteHelper.ExecuteSql(sql);
                 sql = " drop table tb_wxaccesstoken";
                 SqliteHelper.ExecuteSql(sql);
                 sql = @"CREATE TABLE tb_wxaccesstoken (
                            id           INTEGER       PRIMARY KEY AUTOINCREMENT,
                            access_token VARCHAR (120) NOT NULL,
                            expires_in   VARCHAR (30)  NOT NULL
                        )";
                 SqliteHelper.ExecuteSql(sql);

                int result = SqliteHelper.ExecuteScalar("SELECT COUNT(*) FROM sqlite_master where type='table' and name='tb_wxbuttons'");
                if (result > 0)
                {
                    string msg = "数据库初始化成功!";

                    MessageBox.Show(msg);
                }

            }
        }

        private void LoadHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {


            string jsonText = "{\r\n" +
                        "    \"menu\": {\r\n" +
                        "        \"button\": [\r\n" +
                        "            {\r\n" +
                        "                \"name\": \"往期精彩\", \r\n" +
                        "                \"sub_button\": [\r\n" +
                        "                    {\r\n" +
                        "                        \"type\": \"view\", \r\n" +
                        "                        \"name\": \"孩子感冒专辑\", \r\n" +
                        "                        \"url\": \"https://mp.weixin.qq.com/s/92z-OwehPRFKhKDZ5u4_aQ\", \r\n" +
                        "                        \"sub_button\": [ ]\r\n" +
                        "                    }, \r\n" +
                        "                    {\r\n" +
                        "                        \"type\": \"view\", \r\n" +
                        "                        \"name\": \"精彩推荐\", \r\n" +
                        "                        \"url\": \"https://mp.weixin.qq.com/mp/profile_ext?action=home__biz=MzU3NjAwOTQ4Mg==scene=126bizpsid=0#wechat_redirect\", \r\n" +
                        "                        \"sub_button\": [ ]\r\n" +
                        "                    }\r\n" +
                        "                ]\r\n" +
                        "            }, \r\n" +
                        "            {\r\n" +
                        "                \"type\": \"view\", \r\n" +
                        "                \"name\": \"更多好方\", \r\n" +
                        "                \"url\": \"http://www.0011.com.cn\", \r\n" +
                        "                \"sub_button\": [ ]\r\n" +
                        "            }, \r\n" +
                        "            {\r\n" +
                        "                \"name\": \"法鸿讲堂\", \r\n" +
                        "                \"sub_button\": [\r\n" +
                        "                    {\r\n" +
                        "                        \"type\": \"view\", \r\n" +
                        "                        \"name\": \"课程介绍\", \r\n" +
                        "                        \"url\": \"https://mp.weixin.qq.com/s/lBtrerD-6Qt63CegFnISIQ\", \r\n" +
                        "                        \"sub_button\": [ ]\r\n" +
                        "                    }, \r\n" +
                        "                    {\r\n" +
                        "                        \"type\": \"view\", \r\n" +
                        "                        \"name\": \"音频收听\", \r\n" +
                        "                        \"url\": \"http://xima.tv/0pih9p\", \r\n" +
                        "                        \"sub_button\": [ ]\r\n" +
                        "                    }, \r\n" +
                        "                    {\r\n" +
                        "                        \"type\": \"view\", \r\n" +
                        "                        \"name\": \"报名和课件\", \r\n" +
                        "                        \"url\": \"https://weidian.com/s/1363257909?ifr=shopdetailwfr=csfr=app\", \r\n" +
                        "                        \"sub_button\": [ ]\r\n" +
                        "                    }\r\n" +
                        "                ]\r\n" +
                        "            }\r\n" +
                        "        ]\r\n" +
                        "    }\r\n" +
                        "}";
            if (MessageBox.Show(this, "系统当前数据库中的菜单将会恢复成模板菜单，确定加载模板菜单吗？", "菜单恢复", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                WxMenuHelper.LoadWxMenuFromJsonText(jsonText);
                WxMenuHelper.BuildTreeView(this.menuTreeView);
            }

            //string dir = System.IO.Directory.GetCurrentDirectory();
            //FileStream fs1 = new FileStream(dir + "\\menu.txt", FileMode.Open);
            //StreamReader sr = new StreamReader(fs1, Encoding.GetEncoding("GBK"));
            //string menu = sr.ReadToEnd();
            //sr.Close();
            //fs1.Close();
        }

        private void LoadOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(this, "系统当前数据库中的菜单将会恢复成当前在线公众号菜单，确定下载菜单吗？", "菜单恢复", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                string jsonText = WxchatHelper.GetWxMenuOnline(); 
                WxMenuHelper.LoadWxMenuFromJsonText(jsonText);
                WxMenuHelper.BuildTreeView(this.menuTreeView);
            }
           
          //  MessageBox.Show(this, "功能开发中...", "系统");
        }

       

        private void btnAddChildNode_Click(object sender, EventArgs e)
        {
              TreeNode selectedNode = this.menuTreeView.SelectedNode;
            
              if (selectedNode == null)
              {
                  MessageBox.Show(this,"请先选择父菜单.","填加子菜单");
                  return;
              }
            //自定义菜单最多包括3个一级菜单，每个一级菜单最多包含5个二级菜单。
            if (selectedNode.Level == 0 && selectedNode.Nodes.Count >=3)
            {
                MessageBox.Show(this, "自定义菜单最多包括3个一级菜单.");
                return;
            }
            if (selectedNode.Level > 0 && selectedNode.Nodes.Count >= 5)
            {
                MessageBox.Show(this, "每个自定义菜单一级菜单最多包含5个二级菜单.");
                return;
            }

            WxMenuAddForm wxMenuAddForm = new WxMenuAddForm();
            wxMenuAddForm.ParentTreeNode = selectedNode;
            wxMenuAddForm.ShowDialog(this);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.menuTreeView.SelectedNode;
            if (selectedNode == null || selectedNode.Level==0)
            {
                MessageBox.Show(this, "请选择编辑菜单.", "编辑菜单");
                return;
            }


            WxMenuEditForm wxMenuEditForm = new WxMenuEditForm();
            wxMenuEditForm.CurrentTreeNode = selectedNode;
            wxMenuEditForm.ShowDialog(this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.menuTreeView.SelectedNode;
            if (selectedNode == null || selectedNode.Level == 0)
            {
                MessageBox.Show(this, "请选择要删除的菜单.", "菜单删除");
                return;
            }
            else if (selectedNode.Nodes.Count > 0)
            {
                MessageBox.Show(this, "该菜单包含子菜单不能删除.", "菜单删除");
                return;
            }
            else
            {
                if (MessageBox.Show(this, "你确定要删除 [ " + selectedNode.Text + " ] 菜单? ", "菜单删除", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    WxMenuHelper.DeleteWxMenuItem((WxMenuItem)selectedNode.Tag);
                    this.menuTreeView.Nodes.Remove(selectedNode);
                }
            }

           
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            SqliteHelper.CreateAllTablesToDatabase();

            string ss = SqliteHelper.GetConnectionString();
            
           string   menu= WxMenuHelper.GenerateMenuJson();
           

           string access_token =  WxchatHelper.GetAccessToken();

           string i = WxchatHelper.GetPage("https://api.weixin.qq.com/cgi-bin/menu/create?access_token=" + access_token, menu);
          // Response.Write("创建菜单结果：" + i);
          // Response.End();


          
        }

        private void menuTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode clickNode = e.Node;
          //  MessageBox.Show(clickNode.Index.ToString() + " Level " + clickNode.Level.ToString());
        }

        private void AppInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppInfoSettingForm frm = new AppInfoSettingForm();
            frm.ShowDialog(this);
        }

        private void ApplyMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyWxMenuForm frm = new ApplyWxMenuForm();
            frm.ShowDialog(this);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SysToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DownloadWxMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new DownloadWxMenuForm()).ShowDialog(this);
        }

        private void MenuOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new WxMenuOrderingForm()).ShowDialog(this);
            WxMenuHelper.BuildTreeView(this.menuTreeView);

        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AboutForm()).ShowDialog(this);
        }
    }
}
