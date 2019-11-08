namespace 教务管理
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextAccount = new System.Windows.Forms.TextBox();
            this.TextPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RadioButtonTeacher = new System.Windows.Forms.RadioButton();
            this.RadioButtonStudent = new System.Windows.Forms.RadioButton();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(415, -5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户登录";
            // 
            // TextAccount
            // 
            this.TextAccount.BackColor = System.Drawing.Color.White;
            this.TextAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextAccount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextAccount.Location = new System.Drawing.Point(151, 83);
            this.TextAccount.Name = "TextAccount";
            this.TextAccount.Size = new System.Drawing.Size(188, 27);
            this.TextAccount.TabIndex = 1;
            this.TextAccount.Text = "1702110101";
            // 
            // TextPwd
            // 
            this.TextPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextPwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextPwd.Location = new System.Drawing.Point(150, 129);
            this.TextPwd.Name = "TextPwd";
            this.TextPwd.PasswordChar = '*';
            this.TextPwd.Size = new System.Drawing.Size(189, 27);
            this.TextPwd.TabIndex = 2;
            this.TextPwd.Text = "123456";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "学号/工号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "密码:";
            // 
            // RadioButtonTeacher
            // 
            this.RadioButtonTeacher.AutoSize = true;
            this.RadioButtonTeacher.Checked = true;
            this.RadioButtonTeacher.Location = new System.Drawing.Point(150, 188);
            this.RadioButtonTeacher.Name = "RadioButtonTeacher";
            this.RadioButtonTeacher.Size = new System.Drawing.Size(58, 19);
            this.RadioButtonTeacher.TabIndex = 3;
            this.RadioButtonTeacher.TabStop = true;
            this.RadioButtonTeacher.Text = "老师";
            this.RadioButtonTeacher.UseVisualStyleBackColor = true;
            // 
            // RadioButtonStudent
            // 
            this.RadioButtonStudent.AutoSize = true;
            this.RadioButtonStudent.Location = new System.Drawing.Point(267, 188);
            this.RadioButtonStudent.Name = "RadioButtonStudent";
            this.RadioButtonStudent.Size = new System.Drawing.Size(58, 19);
            this.RadioButtonStudent.TabIndex = 4;
            this.RadioButtonStudent.Text = "学生";
            this.RadioButtonStudent.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLogin.BackColor = System.Drawing.Color.Turquoise;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLogin.Location = new System.Drawing.Point(150, 224);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(189, 46);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "登录";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(458, 301);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.RadioButtonStudent);
            this.Controls.Add(this.RadioButtonTeacher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextPwd);
            this.Controls.Add(this.TextAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(600, 400);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseLeave += new System.EventHandler(this.Login_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextAccount;
        private System.Windows.Forms.TextBox TextPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RadioButtonTeacher;
        private System.Windows.Forms.RadioButton RadioButtonStudent;
        private System.Windows.Forms.Button buttonLogin;
    }
}

