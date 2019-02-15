namespace WxMenuTools
{
    partial class MenuSettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuSettingForm));
            this.menuStripSystem = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemInitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.参数设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_LoadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WxAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AppInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ApplyMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.DownloadWxMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTreeView = new System.Windows.Forms.TreeView();
            this.btnAddChildNode = new System.Windows.Forms.Button();
            this.labelSeparator1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMenuName = new System.Windows.Forms.Label();
            this.tbMenuName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbView = new System.Windows.Forms.RadioButton();
            this.rbClick = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbMenu = new System.Windows.Forms.RadioButton();
            this.btnEdit = new System.Windows.Forms.Button();
            this.linkLabelUrl = new System.Windows.Forms.LinkLabel();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripSystem
            // 
            this.menuStripSystem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.toolStripMenuItem_LoadMenu,
            this.WxAccountToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStripSystem.Location = new System.Drawing.Point(0, 0);
            this.menuStripSystem.Name = "menuStripSystem";
            this.menuStripSystem.Size = new System.Drawing.Size(714, 24);
            this.menuStripSystem.TabIndex = 1;
            this.menuStripSystem.Text = "menuStrip2";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemInitToolStripMenuItem,
            this.参数设置ToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.系统ToolStripMenuItem.Text = "选项";
            // 
            // SystemInitToolStripMenuItem
            // 
            this.SystemInitToolStripMenuItem.Name = "SystemInitToolStripMenuItem";
            this.SystemInitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.SystemInitToolStripMenuItem.Text = "系统初始化";
            this.SystemInitToolStripMenuItem.Click += new System.EventHandler(this.SystemInitToolStripMenuItem_Click);
            // 
            // 参数设置ToolStripMenuItem
            // 
            this.参数设置ToolStripMenuItem.Name = "参数设置ToolStripMenuItem";
            this.参数设置ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.参数设置ToolStripMenuItem.Text = "参数设置";
            this.参数设置ToolStripMenuItem.Visible = false;
            this.参数设置ToolStripMenuItem.Click += new System.EventHandler(this.SysToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.ExitToolStripMenuItem.Text = "退出";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem_LoadMenu
            // 
            this.toolStripMenuItem_LoadMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadHistoryToolStripMenuItem,
            this.LoadOnlineToolStripMenuItem,
            this.toolStripMenuItem3,
            this.MenuOrderToolStripMenuItem});
            this.toolStripMenuItem_LoadMenu.Name = "toolStripMenuItem_LoadMenu";
            this.toolStripMenuItem_LoadMenu.Size = new System.Drawing.Size(84, 20);
            this.toolStripMenuItem_LoadMenu.Text = "自定义菜单";
            // 
            // LoadHistoryToolStripMenuItem
            // 
            this.LoadHistoryToolStripMenuItem.Name = "LoadHistoryToolStripMenuItem";
            this.LoadHistoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.LoadHistoryToolStripMenuItem.Text = "加载模板菜单";
            this.LoadHistoryToolStripMenuItem.Visible = false;
            this.LoadHistoryToolStripMenuItem.Click += new System.EventHandler(this.LoadHistoryToolStripMenuItem_Click);
            // 
            // LoadOnlineToolStripMenuItem
            // 
            this.LoadOnlineToolStripMenuItem.Name = "LoadOnlineToolStripMenuItem";
            this.LoadOnlineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.LoadOnlineToolStripMenuItem.Text = "下载在线菜单";
            this.LoadOnlineToolStripMenuItem.Click += new System.EventHandler(this.LoadOnlineToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // MenuOrderToolStripMenuItem
            // 
            this.MenuOrderToolStripMenuItem.Name = "MenuOrderToolStripMenuItem";
            this.MenuOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.MenuOrderToolStripMenuItem.Text = "调整菜单顺序";
            this.MenuOrderToolStripMenuItem.Click += new System.EventHandler(this.MenuOrderToolStripMenuItem_Click);
            // 
            // WxAccountToolStripMenuItem
            // 
            this.WxAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AppInfoToolStripMenuItem,
            this.toolStripMenuItem2,
            this.ApplyMenuToolStripMenuItem,
            this.toolStripMenuItem1,
            this.DownloadWxMenuToolStripMenuItem});
            this.WxAccountToolStripMenuItem.Name = "WxAccountToolStripMenuItem";
            this.WxAccountToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.WxAccountToolStripMenuItem.Text = "公众号管理";
            // 
            // AppInfoToolStripMenuItem
            // 
            this.AppInfoToolStripMenuItem.Name = "AppInfoToolStripMenuItem";
            this.AppInfoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.AppInfoToolStripMenuItem.Text = "公众号参数设置";
            this.AppInfoToolStripMenuItem.Click += new System.EventHandler(this.AppInfoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(162, 6);
            // 
            // ApplyMenuToolStripMenuItem
            // 
            this.ApplyMenuToolStripMenuItem.Name = "ApplyMenuToolStripMenuItem";
            this.ApplyMenuToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ApplyMenuToolStripMenuItem.Text = "上传公众号菜单";
            this.ApplyMenuToolStripMenuItem.Click += new System.EventHandler(this.ApplyMenuToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(162, 6);
            this.toolStripMenuItem1.Visible = false;
            // 
            // DownloadWxMenuToolStripMenuItem
            // 
            this.DownloadWxMenuToolStripMenuItem.Name = "DownloadWxMenuToolStripMenuItem";
            this.DownloadWxMenuToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.DownloadWxMenuToolStripMenuItem.Text = "下载公众号菜单";
            this.DownloadWxMenuToolStripMenuItem.Visible = false;
            this.DownloadWxMenuToolStripMenuItem.Click += new System.EventHandler(this.DownloadWxMenuToolStripMenuItem_Click);
            // 
            // menuTreeView
            // 
            this.menuTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuTreeView.HideSelection = false;
            this.menuTreeView.Location = new System.Drawing.Point(4, 27);
            this.menuTreeView.Name = "menuTreeView";
            this.menuTreeView.Size = new System.Drawing.Size(199, 467);
            this.menuTreeView.TabIndex = 2;
            this.menuTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.menuTreeView_AfterSelect);
            this.menuTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.menuTreeView_NodeMouseClick);
            // 
            // btnAddChildNode
            // 
            this.btnAddChildNode.Location = new System.Drawing.Point(564, 417);
            this.btnAddChildNode.Name = "btnAddChildNode";
            this.btnAddChildNode.Size = new System.Drawing.Size(75, 23);
            this.btnAddChildNode.TabIndex = 3;
            this.btnAddChildNode.Text = "添加子菜单";
            this.btnAddChildNode.UseVisualStyleBackColor = true;
            this.btnAddChildNode.Click += new System.EventHandler(this.btnAddChildNode_Click);
            // 
            // labelSeparator1
            // 
            this.labelSeparator1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelSeparator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSeparator1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelSeparator1.Location = new System.Drawing.Point(209, 67);
            this.labelSeparator1.Name = "labelSeparator1";
            this.labelSeparator1.Size = new System.Drawing.Size(433, 2);
            this.labelSeparator1.TabIndex = 4;
            this.labelSeparator1.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "微信公众号自定义菜单";
            // 
            // lbMenuName
            // 
            this.lbMenuName.AutoSize = true;
            this.lbMenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbMenuName.Location = new System.Drawing.Point(221, 99);
            this.lbMenuName.Name = "lbMenuName";
            this.lbMenuName.Size = new System.Drawing.Size(55, 13);
            this.lbMenuName.TabIndex = 6;
            this.lbMenuName.Text = "菜单标题";
            // 
            // tbMenuName
            // 
            this.tbMenuName.Enabled = false;
            this.tbMenuName.Location = new System.Drawing.Point(314, 95);
            this.tbMenuName.MaxLength = 32;
            this.tbMenuName.Name = "tbMenuName";
            this.tbMenuName.Size = new System.Drawing.Size(342, 20);
            this.tbMenuName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(315, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "字数不超过8个汉字或16个字母";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(220, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "菜单类型";
            // 
            // rbView
            // 
            this.rbView.AutoSize = true;
            this.rbView.Location = new System.Drawing.Point(317, 152);
            this.rbView.Name = "rbView";
            this.rbView.Size = new System.Drawing.Size(73, 17);
            this.rbView.TabIndex = 10;
            this.rbView.TabStop = true;
            this.rbView.Text = "网页跳转";
            this.rbView.UseVisualStyleBackColor = true;
            // 
            // rbClick
            // 
            this.rbClick.AutoSize = true;
            this.rbClick.Location = new System.Drawing.Point(496, 152);
            this.rbClick.Name = "rbClick";
            this.rbClick.Size = new System.Drawing.Size(73, 17);
            this.rbClick.TabIndex = 11;
            this.rbClick.TabStop = true;
            this.rbClick.Text = "点击事件";
            this.rbClick.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(220, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "链接地址";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(314, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(336, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "网页跳转必须，用户点击菜单可打开链接，不超过1024字节。";
            // 
            // tbKey
            // 
            this.tbKey.Enabled = false;
            this.tbKey.Location = new System.Drawing.Point(313, 335);
            this.tbKey.MaxLength = 128;
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(342, 20);
            this.tbKey.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(220, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "菜单KEY值";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(314, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(281, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "点击事件必须，用于消息接口推送，不超过128字节";
            // 
            // rbMenu
            // 
            this.rbMenu.AutoSize = true;
            this.rbMenu.Location = new System.Drawing.Point(414, 152);
            this.rbMenu.Name = "rbMenu";
            this.rbMenu.Size = new System.Drawing.Size(61, 17);
            this.rbMenu.TabIndex = 19;
            this.rbMenu.TabStop = true;
            this.rbMenu.Text = "主菜单";
            this.rbMenu.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(483, 417);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "编 辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // linkLabelUrl
            // 
            this.linkLabelUrl.AutoSize = true;
            this.linkLabelUrl.Location = new System.Drawing.Point(310, 192);
            this.linkLabelUrl.Name = "linkLabelUrl";
            this.linkLabelUrl.Size = new System.Drawing.Size(0, 13);
            this.linkLabelUrl.TabIndex = 22;
            // 
            // tbUrl
            // 
            this.tbUrl.Enabled = false;
            this.tbUrl.Location = new System.Drawing.Point(313, 188);
            this.tbUrl.MaxLength = 1024;
            this.tbUrl.Multiline = true;
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(337, 100);
            this.tbUrl.TabIndex = 49;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(400, 417);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 50;
            this.btnDelete.Text = "删 除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(564, 36);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 51;
            this.btnApply.Text = "保存并应用";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Visible = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // MenuSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 499);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.linkLabelUrl);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.rbMenu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbClick);
            this.Controls.Add(this.rbView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMenuName);
            this.Controls.Add(this.lbMenuName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSeparator1);
            this.Controls.Add(this.btnAddChildNode);
            this.Controls.Add(this.menuTreeView);
            this.Controls.Add(this.menuStripSystem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuSettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "微信公众号管理助手";
            this.Load += new System.EventHandler(this.MenuSettingForm_Load);
            this.menuStripSystem.ResumeLayout(false);
            this.menuStripSystem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripSystem;
        private System.Windows.Forms.TreeView menuTreeView;
        private System.Windows.Forms.Button btnAddChildNode;
        private System.Windows.Forms.Label labelSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMenuName;
        private System.Windows.Forms.TextBox tbMenuName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbView;
        private System.Windows.Forms.RadioButton rbClick;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_LoadMenu;
        private System.Windows.Forms.ToolStripMenuItem LoadHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 参数设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WxAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SystemInitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadOnlineToolStripMenuItem;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.LinkLabel linkLabelUrl;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ToolStripMenuItem AppInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ApplyMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem DownloadWxMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem MenuOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
    }
}

