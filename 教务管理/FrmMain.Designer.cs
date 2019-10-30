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
            this.buttonCourseInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(30, 23);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(160, 61);
            this.buttonInfo.TabIndex = 0;
            this.buttonInfo.Text = "个人信息";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(241, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 645);
            this.panel1.TabIndex = 1;
            // 
            // buttonCourseInfo
            // 
            this.buttonCourseInfo.Location = new System.Drawing.Point(30, 115);
            this.buttonCourseInfo.Name = "buttonCourseInfo";
            this.buttonCourseInfo.Size = new System.Drawing.Size(160, 61);
            this.buttonCourseInfo.TabIndex = 0;
            this.buttonCourseInfo.Text = "课程信息";
            this.buttonCourseInfo.UseVisualStyleBackColor = true;
            this.buttonCourseInfo.Click += new System.EventHandler(this.buttonCourseInfo_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCourseInfo);
            this.Controls.Add(this.buttonInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmMain";
            this.Text = "管理系统1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCourseInfo;
    }
}