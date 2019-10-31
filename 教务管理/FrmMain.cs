using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace 教务管理
{
    public partial class FrmMain : Form
    {
        Form stuInfo = null;
        Form frmTeacherInfo = null;
        Form frmStuChaxun = null;
        Form frmTeacherChaxun = null;

        bool isTeacher = false;
        StuBasicinfo student;
        TeacherInfo teacher;
        string userName;

        public FrmMain(object user)
        {
            InitializeComponent();
            if (user is TeacherInfo)
            {
                this.teacher = (TeacherInfo)user;
                isTeacher = true;
                userName = this.teacher.teacherName;
            }
            else
            {
                student = (StuBasicinfo)user;
                isTeacher = false;
                userName = student.stuName;
            }
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            string shenfen = isTeacher ? "老师" : "学生";
            // 显示在下方, label中
            // this.Text += $"     -- 当前用户 : {userName}, 身份 :  {shenfen}";
            this.labelCurrent.Text += $"{userName}, 身份 :  {shenfen}";
            if (!isTeacher)
            {
                this.buttonAdd.Enabled = false;
                this.buttonAlter.Enabled = false;
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出系统?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                return;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 主窗体关闭即退出程序
            Application.Exit();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            // 可先定义变量, 每次点击判断是否为null, 再决定是否创建对象
            // this.IsMdiContainer = true;
            if (!isTeacher)
            {
                if (null == this.stuInfo)
                {
                    this.stuInfo = new frmStuInfo(this.student);
                    stuInfo.TopLevel = false;
                    stuInfo.Parent = this.panel1;
                }
                // frmInfo.MdiParent = this;  mdi 文档式, 不好看
                // 隐藏其他窗体
                foreach (var item in panel1.Controls)
                {
                    if (item is Form)
                    {
                        if (item != this.stuInfo)
                        {
                            //((Form)item).Dispose();
                            //this.stuInfo = null;
                            ((Form)item).Hide();
                        }
                    }
                }
                stuInfo.Show();
            }
            else
            {
                if (null == this.frmTeacherInfo)
                {
                    this.frmTeacherInfo = new frmTeacherInfo(this.teacher);
                    frmTeacherInfo.TopLevel = false;
                    frmTeacherInfo.Parent = this.panel1;
                }
                // 关闭其他窗体
                foreach (var item in panel1.Controls)
                {
                    if (item is Form)
                    {
                        if (item != this.frmTeacherInfo)
                        {
                            ((Form)item).Hide();
                            // this.frmTeacherInfo = null;
                        }
                    }
                }
                frmTeacherInfo.Show();


                //if (null == this.stuInfo)
                //{
                //    this.stuInfo = new frmStuInfo();
                //    stuInfo.TopLevel = false;
                //    stuInfo.Parent = this.panel1;
                //}
                //// 隐藏其他窗体
                //foreach (var item in panel1.Controls)
                //{
                //    if (item is Form)
                //    {
                //        if (item != this.stuInfo)
                //        {
                //            ((Form)item).Dispose();
                //        }
                //    }
                //}
            }
                // this.stuInfo.Show();
        }

        private void buttonCourseInfo_Click(object sender, EventArgs e)
        {
            if (! isTeacher)
                //学生查询窗口
            {
                if (null == this.frmStuChaxun)
                {
                    this.frmStuChaxun = new FormStuChaxun(this.student);
                    frmStuChaxun.TopLevel = false;
                    frmStuChaxun.Parent = this.panel1;
                }
                foreach (var item in panel1.Controls)
                {
                    if (item is Form)
                    {
                        if (item != this.frmStuChaxun)
                        {
                            ((Form)item).Hide();
                        }
                    }
                }
                frmStuChaxun.Show();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            // 退出登录
            foreach (var item in  Application.OpenForms)
            {
                if (item is Login)
                {
                    ((Form)item).Show();
                }
            }
            this.Dispose(true);
        }
    }
}
