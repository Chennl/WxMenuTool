namespace WxMenuTools
{
    partial class ApplyWxMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyWxMenuForm));
            this.tbResponse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSeparator1 = new System.Windows.Forms.Label();
            this.btnApplyMenu = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbResponse
            // 
            this.tbResponse.Location = new System.Drawing.Point(26, 86);
            this.tbResponse.MaxLength = 1024;
            this.tbResponse.Multiline = true;
            this.tbResponse.Name = "tbResponse";
            this.tbResponse.Size = new System.Drawing.Size(533, 223);
            this.tbResponse.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(23, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "返回结果";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "微信公众号自定义菜单";
            // 
            // labelSeparator1
            // 
            this.labelSeparator1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelSeparator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSeparator1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelSeparator1.Location = new System.Drawing.Point(26, 51);
            this.labelSeparator1.Name = "labelSeparator1";
            this.labelSeparator1.Size = new System.Drawing.Size(433, 2);
            this.labelSeparator1.TabIndex = 50;
            this.labelSeparator1.Text = "label1";
            // 
            // btnApplyMenu
            // 
            this.btnApplyMenu.Location = new System.Drawing.Point(444, 17);
            this.btnApplyMenu.Name = "btnApplyMenu";
            this.btnApplyMenu.Size = new System.Drawing.Size(105, 36);
            this.btnApplyMenu.TabIndex = 54;
            this.btnApplyMenu.Text = "上传自定义菜单";
            this.btnApplyMenu.UseVisualStyleBackColor = true;
            this.btnApplyMenu.Click += new System.EventHandler(this.btnApplyMenu_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(208, 329);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 55;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ApplyWxMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 373);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnApplyMenu);
            this.Controls.Add(this.tbResponse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSeparator1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApplyWxMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "上传公众号自定义菜单";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbResponse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSeparator1;
        private System.Windows.Forms.Button btnApplyMenu;
        private System.Windows.Forms.Button btnClose;
    }
}