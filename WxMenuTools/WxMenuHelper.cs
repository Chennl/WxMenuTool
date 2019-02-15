using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WxMenuTools
{
    class WxMenuHelper
    {
        private static WxMenuItem CreateRootWxMenuItem()
        {
            WxMenuItem rootWxMenuItem = new WxMenuItem();
            rootWxMenuItem = new WxMenuItem();
            rootWxMenuItem.Name = "公众号菜单";
            rootWxMenuItem.Type = "";
            rootWxMenuItem.Url = "";
            rootWxMenuItem.Key ="";
            rootWxMenuItem.ParentCode = "";
            rootWxMenuItem.SelfCode = "root";
            rootWxMenuItem.Level = 0;
            rootWxMenuItem.Index = 0;
            rootWxMenuItem.CreateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff");
            rootWxMenuItem.UpdateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff");
            return rootWxMenuItem;
        }

        public static void LoadWxMenuFromJsonText(string jsonText)
        {
            JToken buttonGroups = null;
            JObject jo = (JObject)JsonConvert.DeserializeObject(jsonText);
            if (jo.ContainsKey("menu"))
            {
                buttonGroups = jo["menu"]["button"];
            }else
            {
                if (jo.ContainsKey("button"))
                    buttonGroups = jo.SelectToken("button");
            }
            //WxMenuItem wxMenu = jo["menu"].ToObject<WxMenuItem>();
            //string ss =JsonConvert.SerializeObject(wxMenu);

            WxMenuItem rootWxMenuItem = new WxMenuItem();
             rootWxMenuItem = new WxMenuItem();
             rootWxMenuItem.SelfCode = "root";
             rootWxMenuItem.Name = "公众号菜单";
            List<WxMenuItem> wxMenuItemList = buttonGroups.ToObject<List<WxMenuItem>>();
            rootWxMenuItem.SunWxMenuItems = wxMenuItemList;
            
             WellFormatWxMenuItemOfJsonText(rootWxMenuItem, 0, 0,"");
            

            //删除历史数据
            SqliteHelper.ExecuteSql("delete from tb_wxbuttons");
            //插入新数据
          
            InsertIntoDatabase(rootWxMenuItem);
        }


        private static  void WellFormatWxMenuItemOfJsonText(WxMenuItem wxMenuItem,int level,int index,String parentCode){
            wxMenuItem.Level = level;
            wxMenuItem.Index = index;
            wxMenuItem.ParentCode = parentCode;
            if (String.IsNullOrEmpty(wxMenuItem.SelfCode))
            {
                wxMenuItem.SelfCode = Guid.NewGuid().ToString("N");
            }
            if (String.IsNullOrEmpty(wxMenuItem.Type))  wxMenuItem.Type = "menu";
            wxMenuItem.CreateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff");
            wxMenuItem.UpdateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff");

            int subIndex=0;
            foreach (WxMenuItem subWxMenuItem in wxMenuItem.SunWxMenuItems)
            {
                WellFormatWxMenuItemOfJsonText(subWxMenuItem, level + 1, subIndex++, wxMenuItem.SelfCode);                
            }

        }
        private static int InsertIntoDatabase(WxMenuItem wxMenuItem)
        {
        //TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
        //Response.Write(Convert.ToInt64(ts.TotalMilliseconds).ToString());


            String sql = "INSERT INTO `tb_wxbuttons`(`name`,`type`,`url`,`key`,`selfcode`,`parentcode`,`level`,`index`,`createdate`,`updatedate`)VALUES(\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",{6},{7},\"{8}\",\"{9}\")";
            string name = wxMenuItem.Name;
            string type = wxMenuItem.Type;
            string url = wxMenuItem.Url;
            string key = wxMenuItem.Key;
            int level = wxMenuItem.Level;
            int index = wxMenuItem.Index;
            string selfcode = wxMenuItem.SelfCode;
            string parentcode = wxMenuItem.ParentCode;
            string createdate = wxMenuItem.CreateDate;
            string updatedate = wxMenuItem.UpdateDate;
            
            sql = String.Format(sql, name, type, url, key, selfcode, parentcode,level,index, createdate, updatedate);
            int row = SqliteHelper.ExecuteSql(sql);
            if (wxMenuItem.SunWxMenuItems != null)
            {
                foreach (WxMenuItem subMenuItem in wxMenuItem.SunWxMenuItems)
                {
                    InsertIntoDatabase(subMenuItem);
                }
            }
            return row;
     
        }


        public static void BuildTreeView(TreeView treeView)
        {
            treeView.Nodes.Clear();
            WxMenuItem wxMenuItem = CreateRootWxMenuItem();
            TreeNode rootTreeNode = treeView.Nodes.Add(wxMenuItem.Name);
            rootTreeNode.Tag = wxMenuItem;
            InitTreeNode(rootTreeNode);
            treeView.ExpandAll();

        }
        public static int UpdateWxMenuItemToDatabase(WxMenuItem wxMenuItem)
        {
            SqliteHelper.ExecuteSql("delete from tb_wxbuttons where selfcode='" + wxMenuItem.SelfCode.Trim()+ "'");
            return InsertIntoDatabase(wxMenuItem);
        }
        private static void InitTreeNode(TreeNode parentTreeNode)
        {
            String parentCode = ((WxMenuItem) (parentTreeNode.Tag)).SelfCode;
            string sql =  "select * from tb_wxbuttons order by id";
            DataSet ds = SqliteHelper.ExecuteDataSet(sql);
            DataTable dt = ds.Tables[0];
            DataView dvTree = new DataView(dt);
            dvTree.RowFilter = "parentCode = '" + parentCode+"'";
            foreach (DataRowView Row in dvTree)
            {
                TreeNode Node = new TreeNode();
                Node.Text = Row["name"].ToString();
                Node.Name = Row["name"].ToString();

                WxMenuItem wxMenuItem = new WxMenuItem();

                wxMenuItem.Name = Row["name"].ToString();
                wxMenuItem.Type = Row["type"].ToString();
                wxMenuItem.Url = Row["url"].ToString();
                wxMenuItem.Key = Row["key"].ToString();
                wxMenuItem.SelfCode = Row["selfcode"].ToString();
                wxMenuItem.ParentCode = Row["parentcode"].ToString();
                wxMenuItem.CreateDate = Row["createdate"].ToString();
                wxMenuItem.UpdateDate = Row["updatedate"].ToString();

                Node.Tag = wxMenuItem;
                Node.ImageIndex = 1;
                parentTreeNode.Nodes.Add(Node);
                InitTreeNode(Node); //再次递归
            }
        }

        public static string GenerateMenuJson()
        {
            WxMenu wxMenu = new WxMenu();
            WxMenuItem wxMenuItem = new WxMenuItem();
            GenerateMenuJsonFromDatabase(wxMenuItem, "root");
            wxMenu.SunWxMenuItems = wxMenuItem.SunWxMenuItems;
            string jsonText = JsonConvert.SerializeObject(wxMenu, Formatting.Indented,
             new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            return jsonText;
            //   jsonText = jsonText.Replace("sub_button", "button");
        }
 
            public static WxMenuItem GetWxMenuItem(string parentCOde)
            {
                WxMenuItem wxMenuItem = new WxMenuItem();
                GenerateMenuJsonFromDatabase(wxMenuItem, parentCOde);
               return wxMenuItem;

        }
    
        public static void GenerateMenuJsonFromDatabase(WxMenuItem parentWxMenuItem,string parentCode)
        {

            string sql = "SELECT * FROM tb_wxbuttons WHERE parentCode = '" + parentCode  + "' ORDER BY [level],[index]";
            DataSet ds = SqliteHelper.ExecuteDataSet(sql);
            DataTable dt = ds.Tables[0];
            DataView dv = new DataView(dt);
  
            foreach (DataRowView Row in dv)
            {
                WxMenuItem wxMenuItem = new WxMenuItem();
                wxMenuItem.Name = Row["name"].ToString();
                wxMenuItem.Type = Row["type"].ToString();
                if (wxMenuItem.Type.Equals("view"))
                {
                    wxMenuItem.Url = Row["url"].ToString();
                    wxMenuItem.Key = null;
                }
                else if (wxMenuItem.Type.Equals("click"))
                {
                    wxMenuItem.Url = null;
                    wxMenuItem.Key = Row["key"].ToString();
                }
                else
                {
                    wxMenuItem.Type = null;
                    wxMenuItem.Url = null;
                    wxMenuItem.Key = null;
                }
                string selfCode = Row["selfcode"].ToString();
                GenerateMenuJsonFromDatabase(wxMenuItem, selfCode);
                if (parentWxMenuItem.SunWxMenuItems == null)
                    parentWxMenuItem.SunWxMenuItems = new List<WxMenuItem>();
                parentWxMenuItem.SunWxMenuItems.Add(wxMenuItem);
            }

        }

        public static void SaveTreeViewToDatabase(TreeView treeView)
        {

            TreeNode treeNode = treeView.Nodes[0];
            UpdateWxMenuItemFromTreeNode(treeNode);

            //删除历史数据
            SqliteHelper.ExecuteSql("delete from tb_wxbuttons");
            InsertIntoDatabaseFromTreeNode(treeNode);
            BuildTreeView(treeView);
        }
        private static void  InsertIntoDatabaseFromTreeNode(TreeNode treeNode){
            WxMenuItem wxMenuItem = (WxMenuItem)treeNode.Tag;
            InsertIntoDatabase(wxMenuItem);
            foreach (TreeNode subTreeNode in treeNode.Nodes)
            {
                InsertIntoDatabaseFromTreeNode(subTreeNode);
            }
        }
        private static void UpdateWxMenuItemFromTreeNode(TreeNode treeNode)
        {
            WxMenuItem wxMenuItem = (WxMenuItem)treeNode.Tag;
            wxMenuItem.Level = treeNode.Level;
            wxMenuItem.Index = treeNode.Index;
            treeNode.Tag = wxMenuItem;
            foreach (TreeNode subTreeNode in treeNode.Nodes)
            {
                UpdateWxMenuItemFromTreeNode(subTreeNode);
            }
        }


        public static int DeleteWxMenuItem(WxMenuItem wxMenuItem)
        {
            return SqliteHelper.ExecuteSql("delete from tb_wxbuttons where selfcode='" + wxMenuItem.SelfCode.Trim() + "'");
        }
        
    }
}
