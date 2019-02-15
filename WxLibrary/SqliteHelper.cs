using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace WxLibrary
{


    public class SqliteHelper
    {
        public SqliteHelper()
        {
            //
            //TODO: 在此处添加构造函数逻辑
            //
        }


        public static void DropAllTablesFromDabase()
        {
            string sql = " drop table tb_wxbuttons;drop table tb_wxappinfo;drop table tb_wxaccesstoken";
            ExecuteSql(sql);
        }
        public static void CreateAllTablesToDatabase()
        {
            string sql = String.Empty;
            int result = ExecuteScalar("SELECT COUNT(*) FROM sqlite_master where type='table' and name='tb_wxbuttons'");
            if (result == 0)
            {
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
                ExecuteSql(sql);
            }
            result = ExecuteScalar("SELECT COUNT(*) FROM sqlite_master where type='table' and name='tb_wxappinfo'");
            if (result == 0)
            {
                sql = @"CREATE TABLE tb_wxappinfo (
                            id         INTEGER       PRIMARY KEY AUTOINCREMENT,
                            wxname     VARCHAR (50),
                            appid      VARCHAR (120),
                            appsecret  VARCHAR (120),
                            flag       INTEGER       DEFAULT (1),
                            createdate DATETIME      DEFAULT (datetime('now', 'localtime') ) 
                        )";
                ExecuteSql(sql);
            }
            result = ExecuteScalar("SELECT COUNT(*) FROM sqlite_master where type='table' and name='tb_wxaccesstoken'");
            if (result == 0)
            {
                sql = @"CREATE TABLE tb_wxaccesstoken (
                            id           INTEGER       PRIMARY KEY AUTOINCREMENT,
                            access_token VARCHAR (120) NOT NULL,
                            expires_in   VARCHAR (30)  NOT NULL
                        )";
                ExecuteSql(sql);
            }
            result = ExecuteScalar("SELECT COUNT(*) FROM sqlite_master where type='table' and name='tb_wxjsapiticket'");
            if (result == 0)
            {
                sql = @"CREATE TABLE tb_wxjsapiticket (
                        id         INTEGER       PRIMARY KEY AUTOINCREMENT,
                        ticket     VARCHAR (120) NOT NULL,
                        expires_in VARCHAR
                    )";
                ExecuteSql(sql);
            }
        }
        //暂时不用
        public static string GetConnectionString()
        {
            string dir = System.IO.Directory.GetCurrentDirectory();
            string strConnectionString = string.Empty,/*SQLite连接字符串，刚开始没有，暂时留空*/
                   strDataSource = dir+"\\wxdb.sqlit3";//SQLite数据库文件存放物理地址
            //用SQLiteConnectionStringBuilder构建SQLite连接字符串
            System.Data.SQLite.SQLiteConnectionStringBuilder scBuilder = new SQLiteConnectionStringBuilder();
            scBuilder.DataSource = strDataSource;//SQLite数据库地址
           // scBuilder.Password = "123456";//密码
            scBuilder.Version = 3;
            strConnectionString = scBuilder.ToString();
            return strConnectionString;
        }
        private static SQLiteConnection GetConnection()
        {
            //using (SQLiteConnection connection = new SQLiteConnection(strConnectionString))
            //{
            //    //验证数据库文件是否存在
            //    if (System.IO.File.Exists(strDataSource) == false)
            //    {
            //        //创建数据库文件
            //        SQLiteConnection.CreateFile(strDataSource);
            //    }
            //    //打开数据连接
            //    connection.Open();
            //    //Command
            //    SQLiteCommand command = new SQLiteCommand(connection);
            //    command.CommandText = "CREATE TABLE tb_User(ID int,UserName varchar(60));INSERT INTO [tb_User](ID,UserName) VALUES(1,'A')";// "CREATE TABLE tb_User(ID int,UserName varchar(60));";
            //    command.CommandType = System.Data.CommandType.Text;
            //    //执行SQL
            //    int iResult = command.ExecuteNonQuery();
            //    //可省略步骤=======关闭连接
            //    connection.Close();
            //}

            
            string connectionString = @"Data Source=C:\workspace\devdb\wxdb.sqlite;Version=3;";
           // connectionString = GetConnectionString();
            SQLiteConnection conn = new SQLiteConnection(connectionString);
            ////验证数据库文件是否存在
            //if (System.IO.File.Exists(strDataSource) == false)
            //{
            //    //创建数据库文件
            //    SQLiteConnection.CreateFile(strDataSource);
            //}
            conn.Open();
            return conn;
        }

        public static int ExecuteSql(string sql)
        {
            using (SQLiteConnection conn = GetConnection())
            {
                var cmd = new SQLiteCommand(sql, conn);
                return cmd.ExecuteNonQuery();
            }
        }

        public static int ExecuteScalar(string sql)
        {
            using (SQLiteConnection conn = GetConnection())
            {
                var cmd = new SQLiteCommand(sql, conn);
                object o = cmd.ExecuteScalar();
                return int.Parse(o.ToString());
            }
        }
        public static SQLiteDataReader ExecuteReader(string sql)
        {
            SQLiteConnection conn = GetConnection();
            var cmd = new SQLiteCommand(sql, conn);
            SQLiteDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return myReader;
        }
        public static DataSet ExecuteDataSet(string sql)
        {
            using (SQLiteConnection conn = GetConnection())
            {
                var cmd = new SQLiteCommand(sql, conn);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }
    }
}
