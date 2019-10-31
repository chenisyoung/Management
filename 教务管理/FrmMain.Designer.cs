namespace 教务管理
{
    partial class FrmMain
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
            this.buttonInfo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonChaxun = new System.Windows.Forms.Button();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.labelLogout = new System.Windows.Forms.Label();
            this.buttonAlter = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(30, 59);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(160, 61);
            this.buttonInfo.TabIndex = 0;
            this.buttonInfo.Text = "个人信息";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(345, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // buttonChaxun
            // 
            this.buttonChaxun.Location = new System.Drawing.Point(30, 184);
            this.buttonChaxun.Name = "buttonChaxun";
            this.buttonChaxun.Size = new System.Drawing.Size(160, 61);
            this.buttonChaxun.TabIndex = 0;
            this.buttonChaxun.Text = "查询";
            this.buttonChaxun.UseVisualStyleBackColor = true;
            this.buttonChaxun.Click += new System.EventHandler(this.buttonCourseInfo_Click);
            // 
            // labelCurrent
            // 
            this.labelCurrent.AutoSize = true;
            this.labelCurrent.Location = new System.Drawing.Point(27, 687);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(83, 15);
            this.labelCurrent.TabIndex = 0;
            this.labelCurrent.Text = "当前用户: ";
            this.labelCurrent.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelLogout
            // 
            this.labelLogout.AutoSize = true;
            this.labelLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLogout.Location = new System.Drawing.Point(285, 687);
            this.labelLogout.Name = "labelLogout";
            this.labelLogout.Size = new System.Drawing.Size(67, 15);
            this.labelLogout.TabIndex = 0;
            this.labelLogout.Text = "退出登录";
            this.labelLogout.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonAlter
            // 
            this.buttonAlter.Location = new System.Drawing.Point(30, 304);
            this.buttonAlter.Name = "buttonAlter";
            this.buttonAlter.Size = new System.Drawing.Size(160, 61);
            this.buttonAlter.TabIndex = 0;
            this.buttonAlter.Text = "修改";
            this.buttonAlter.UseVisualStyleBackColor = true;
            this.buttonAlter.Click += new System.EventHandler(this.buttonCourseInfo_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(30, 428);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(160, 61);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "添加";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonCourseInfo_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 711);
            this.Controls.Add(this.labelLogout);
            this.Controls.Add(this.labelCurrent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonAlter);
            this.Controls.Add(this.buttonChaxun);
            this.Controls.Add(this.buttonInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmMain";
            this.Text = "管理系统1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonChaxun;
        private System.Windows.Forms.Label labelCurrent;
        private System.Windows.Forms.Label labelLogout;
        private System.Windows.Forms.Button buttonAlter;
        private System.Windows.Forms.Button buttonAdd;
    }
}