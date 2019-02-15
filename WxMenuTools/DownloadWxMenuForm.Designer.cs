namespace WxMenuTools
{
    partial class DownloadWxMenuForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDownloadMenu = new System.Windows.Forms.Button();
            this.tbResponse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSeparator1 = new System.Windows.Forms.Label();
            this.btnSaveAsTemplate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(480, 320);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 61;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDownloadMenu
            // 
            this.btnDownloadMenu.Location = new System.Drawing.Point(440, 22);
            this.btnDownloadMenu.Name = "btnDownloadMenu";
            this.btnDownloadMenu.Size = new System.Drawing.Size(105, 36);
            this.btnDownloadMenu.TabIndex = 60;
            this.btnDownloadMenu.Text = "下载自定义菜单";
            this.btnDownloadMenu.UseVisualStyleBackColor = true;
            this.btnDownloadMenu.Click += new System.EventHandler(this.btnDownloadMenu_Click);
            // 
            // tbResponse
            // 
            this.tbResponse.Location = new System.Drawing.Point(22, 91);
            this.tbResponse.MaxLength = 1024;
            this.tbResponse.Multiline = true;
            this.tbResponse.Name = "tbResponse";
            this.tbResponse.Size = new System.Drawing.Size(533, 223);
            this.tbResponse.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(19, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "返回结果";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "微信公众号自定义菜单";
            // 
            // labelSeparator1
            // 
            this.labelSeparator1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelSeparator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSeparator1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelSeparator1.Location = new System.Drawing.Point(22, 56);
            this.labelSeparator1.Name = "labelSeparator1";
            this.labelSeparator1.Size = new System.Drawing.Size(433, 2);
            this.labelSeparator1.TabIndex = 56;
            this.labelSeparator1.Text = "label1";
            // 
            // btnSaveAsTemplate
            // 
            this.btnSaveAsTemplate.Location = new System.Drawing.Point(203, 320);
            this.btnSaveAsTemplate.Name = "btnSaveAsTemplate";
            this.btnSaveAsTemplate.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAsTemplate.TabIndex = 62;
            this.btnSaveAsTemplate.Text = "保存为模板";
            this.btnSaveAsTemplate.UseVisualStyleBackColor = true;
            this.btnSaveAsTemplate.Click += new System.EventHandler(this.btnSaveAsTemplate_Click);
            // 
            // DownloadWxMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 378);
            this.Controls.Add(this.btnSaveAsTemplate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDownloadMenu);
            this.Controls.Add(this.tbResponse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSeparator1);
            this.Name = "DownloadWxMenuForm";
            this.Text = "下载自定义菜单";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDownloadMenu;
        private System.Windows.Forms.TextBox tbResponse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSeparator1;
        private System.Windows.Forms.Button btnSaveAsTemplate;
    }
}