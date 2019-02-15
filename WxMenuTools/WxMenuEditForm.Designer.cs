namespace WxMenuTools
{
    partial class WxMenuEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WxMenuEditForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btSaveTreeNode = new System.Windows.Forms.Button();
            this.rbMenu = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbClick = new System.Windows.Forms.RadioButton();
            this.rbView = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbMenuName = new System.Windows.Forms.Label();
            this.labelMenuPath = new System.Windows.Forms.Label();
            this.labelSeparator1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(101, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 55;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btSaveTreeNode
            // 
            this.btSaveTreeNode.Location = new System.Drawing.Point(227, 287);
            this.btSaveTreeNode.Name = "btSaveTreeNode";
            this.btSaveTreeNode.Size = new System.Drawing.Size(75, 23);
            this.btSaveTreeNode.TabIndex = 54;
            this.btSaveTreeNode.Text = "保 存";
            this.btSaveTreeNode.UseVisualStyleBackColor = true;
            this.btSaveTreeNode.Click += new System.EventHandler(this.btSaveTreeNode_Click);
            // 
            // rbMenu
            // 
            this.rbMenu.AutoSize = true;
            this.rbMenu.Location = new System.Drawing.Point(203, 93);
            this.rbMenu.Name = "rbMenu";
            this.rbMenu.Size = new System.Drawing.Size(61, 17);
            this.rbMenu.TabIndex = 53;
            this.rbMenu.TabStop = true;
            this.rbMenu.Text = "主菜单";
            this.rbMenu.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(75, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(281, 17);
            this.label7.TabIndex = 52;
            this.label7.Text = "点击事件必须，用于消息接口推送，不超过128字节";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(101, 234);
            this.tbKey.MaxLength = 128;
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(256, 20);
            this.tbKey.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(38, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "菜单KEY值";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(102, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "网页跳转必须，用户点击菜单可打开链接。";
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(101, 120);
            this.tbUrl.MaxLength = 1024;
            this.tbUrl.Multiline = true;
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(256, 87);
            this.tbUrl.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(42, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "链接地址";
            // 
            // rbClick
            // 
            this.rbClick.AutoSize = true;
            this.rbClick.Location = new System.Drawing.Point(284, 93);
            this.rbClick.Name = "rbClick";
            this.rbClick.Size = new System.Drawing.Size(73, 17);
            this.rbClick.TabIndex = 46;
            this.rbClick.TabStop = true;
            this.rbClick.Text = "点击事件";
            this.rbClick.UseVisualStyleBackColor = true;
            // 
            // rbView
            // 
            this.rbView.AutoSize = true;
            this.rbView.Location = new System.Drawing.Point(105, 93);
            this.rbView.Name = "rbView";
            this.rbView.Size = new System.Drawing.Size(73, 17);
            this.rbView.TabIndex = 45;
            this.rbView.TabStop = true;
            this.rbView.Text = "网页跳转";
            this.rbView.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(42, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "菜单类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(102, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "字数不超过8个汉字或16个字母";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(101, 48);
            this.tbName.MaxLength = 32;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(256, 20);
            this.tbName.TabIndex = 42;
            // 
            // lbMenuName
            // 
            this.lbMenuName.AutoSize = true;
            this.lbMenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbMenuName.Location = new System.Drawing.Point(42, 52);
            this.lbMenuName.Name = "lbMenuName";
            this.lbMenuName.Size = new System.Drawing.Size(55, 13);
            this.lbMenuName.TabIndex = 41;
            this.lbMenuName.Text = "菜单标题";
            // 
            // labelMenuPath
            // 
            this.labelMenuPath.AutoSize = true;
            this.labelMenuPath.Location = new System.Drawing.Point(42, 10);
            this.labelMenuPath.Name = "labelMenuPath";
            this.labelMenuPath.Size = new System.Drawing.Size(157, 13);
            this.labelMenuPath.TabIndex = 40;
            this.labelMenuPath.Text = "菜单路径: 微信公众号主菜单";
            // 
            // labelSeparator1
            // 
            this.labelSeparator1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelSeparator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSeparator1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelSeparator1.Location = new System.Drawing.Point(47, 33);
            this.labelSeparator1.Name = "labelSeparator1";
            this.labelSeparator1.Size = new System.Drawing.Size(309, 2);
            this.labelSeparator1.TabIndex = 39;
            this.labelSeparator1.Text = "label1";
            // 
            // WxMenuEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 321);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btSaveTreeNode);
            this.Controls.Add(this.rbMenu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbClick);
            this.Controls.Add(this.rbView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbMenuName);
            this.Controls.Add(this.labelMenuPath);
            this.Controls.Add(this.labelSeparator1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WxMenuEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "菜单编辑窗体";
            this.Load += new System.EventHandler(this.WxMenuEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btSaveTreeNode;
        private System.Windows.Forms.RadioButton rbMenu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbClick;
        private System.Windows.Forms.RadioButton rbView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbMenuName;
        private System.Windows.Forms.Label labelMenuPath;
        private System.Windows.Forms.Label labelSeparator1;
    }
}