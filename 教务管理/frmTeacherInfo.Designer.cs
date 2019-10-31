namespace 教务管理
{
    partial class frmTeacherInfo
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
            this.labelnumber = new System.Windows.Forms.Label();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxShenfenzheng = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCollege = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMajor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxOfficeAddr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonXiugai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelnumber
            // 
            this.labelnumber.AutoSize = true;
            this.labelnumber.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelnumber.Location = new System.Drawing.Point(53, 60);
            this.labelnumber.Name = "labelnumber";
            this.labelnumber.Size = new System.Drawing.Size(55, 25);
            this.labelnumber.TabIndex = 0;
            this.labelnumber.Text = "工号:";
            // 
            // textBoxNum
            // 
            this.textBoxNum.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxNum.Location = new System.Drawing.Point(115, 59);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(148, 31);
            this.textBoxNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(406, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名:";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxName.Location = new System.Drawing.Point(468, 59);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 31);
            this.textBoxName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "身份证号:";
            // 
            // textBoxShenfenzheng
            // 
            this.textBoxShenfenzheng.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxShenfenzheng.Location = new System.Drawing.Point(115, 137);
            this.textBoxShenfenzheng.Name = "textBoxShenfenzheng";
            this.textBoxShenfenzheng.Size = new System.Drawing.Size(346, 31);
            this.textBoxShenfenzheng.TabIndex = 1;
            this.textBoxShenfenzheng.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxShenfenzheng_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(53, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "年龄:";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxAge.Location = new System.Drawing.Point(115, 210);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 31);
            this.textBoxAge.TabIndex = 1;
            this.textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAge_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(406, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "性别:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(53, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "学院:";
            // 
            // textBoxCollege
            // 
            this.textBoxCollege.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxCollege.Location = new System.Drawing.Point(115, 284);
            this.textBoxCollege.Name = "textBoxCollege";
            this.textBoxCollege.Size = new System.Drawing.Size(100, 31);
            this.textBoxCollege.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(407, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "专业:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxMajor
            // 
            this.textBoxMajor.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxMajor.Location = new System.Drawing.Point(468, 285);
            this.textBoxMajor.Name = "textBoxMajor";
            this.textBoxMajor.Size = new System.Drawing.Size(100, 31);
            this.textBoxMajor.TabIndex = 1;
            this.textBoxMajor.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(12, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "办公地点:";
            // 
            // textBoxOfficeAddr
            // 
            this.textBoxOfficeAddr.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxOfficeAddr.Location = new System.Drawing.Point(115, 370);
            this.textBoxOfficeAddr.Name = "textBoxOfficeAddr";
            this.textBoxOfficeAddr.Size = new System.Drawing.Size(163, 31);
            this.textBoxOfficeAddr.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(369, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "电话号码:";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(468, 370);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(143, 31);
            this.textBoxPhoneNumber.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "男",
            "女",
            "不详"});
            this.comboBox1.Location = new System.Drawing.Point(468, 211);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 32);
            this.comboBox1.TabIndex = 2;
            // 
            // buttonXiugai
            // 
            this.buttonXiugai.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonXiugai.Location = new System.Drawing.Point(666, 398);
            this.buttonXiugai.Name = "buttonXiugai";
            this.buttonXiugai.Size = new System.Drawing.Size(122, 40);
            this.buttonXiugai.TabIndex = 3;
            this.buttonXiugai.Text = "修改信息";
            this.buttonXiugai.UseVisualStyleBackColor = true;
            this.buttonXiugai.Click += new System.EventHandler(this.buttonXiugai_Click);
            // 
            // frmTeacherInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonXiugai);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxShenfenzheng);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxOfficeAddr);
            this.Controls.Add(this.textBoxMajor);
            this.Controls.Add(this.textBoxCollege);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelnumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTeacherInfo";
            this.Text = "TeacherInfo";
            this.Load += new System.EventHandler(this.TeacherInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnumber;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxShenfenzheng;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCollege;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMajor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxOfficeAddr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonXiugai;
    }
}