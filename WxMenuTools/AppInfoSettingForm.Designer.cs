namespace WxMenuTools
{
    partial class AppInfoSettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppInfoSettingForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tbAppID = new System.Windows.Forms.TextBox();
            this.tbAppSecrect = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbWxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "appID:";
            // 
            // tbAppID
            // 
            this.tbAppID.Location = new System.Drawing.Point(105, 69);
            this.tbAppID.Name = "tbAppID";
            this.tbAppID.Size = new System.Drawing.Size(219, 20);
            this.tbAppID.TabIndex = 1;
            // 
            // tbAppSecrect
            // 
            this.tbAppSecrect.Location = new System.Drawing.Point(105, 110);
            this.tbAppSecrect.Name = "tbAppSecrect";
            this.tbAppSecrect.PasswordChar = '*';
            this.tbAppSecrect.Size = new System.Drawing.Size(219, 20);
            this.tbAppSecrect.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "appsecret:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(232, 160);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存设置";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbWxName
            // 
            this.tbWxName.Location = new System.Drawing.Point(105, 31);
            this.tbWxName.Name = "tbWxName";
            this.tbWxName.Size = new System.Drawing.Size(219, 20);
            this.tbWxName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "公众号名称:";
            // 
            // AppInfoSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 233);
            this.Controls.Add(this.tbWxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbAppSecrect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAppID);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppInfoSettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "公众号信息设置";
            this.Load += new System.EventHandler(this.AppInfoSettingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAppID;
        private System.Windows.Forms.TextBox tbAppSecrect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbWxName;
        private System.Windows.Forms.Label label3;
    }
}