using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Model;
using DAL.Services;

namespace 教务管理
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //设置窗体默认居中显示
            this.TextAccount.Focus(); // 将输入定位到账号框
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出?", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private const int VM_NCLBUTTONDOWN = 0XA1;//定义鼠标左键按下
        private const int HTCAPTION = 2;

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
             //为当前应用程序释放鼠标捕获
            ReleaseCapture();
           //发送消息 让系统误以为在标题栏上按下鼠标
            SendMessage((IntPtr)this.Handle, VM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // 老师登录逻辑
            LoginService login = new LoginService();
            // 获取输入框数据
            string accu = this.TextAccount.Text.Trim();
            string pwd = this.TextPwd.Text.Trim();
            if (this.RadioButtonTeacher.Checked)
            {
                TeacherInfo teacher = new TeacherInfo()
                {
                    teacherNumber = accu,
                    t_pwd = pwd
                };
                try
                {
                    teacher = login.TeacherLogin(teacher);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("数据库连接失败! " + ex.Message);
                    return;
                }
                if (null == teacher)
                {
                    MessageBox.Show("账号或密码错误!", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    // 测试用
                    // MessageBox.Show("欢迎你! " + teacher.teacherName, "登录成功", MessageBoxButtons.OK);
                    Form frmMain = new FrmMain(teacher); // 传入当前用户
                    this.Hide();
                    frmMain.Show();
                }

            }
            // 学生登录逻辑
            else
            {
                StuBasicinfo student = new StuBasicinfo()
                {
                    stuNum = accu,
                    stu_pwd = pwd
                };
                try
                {
                    student = login.StuLogin(student);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("数据库连接失败! " + ex.Message);
                    return;
                }
                if (null == student)
                {
                    MessageBox.Show("账号或密码错误!", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    // 测试用 
                    // MessageBox.Show("欢迎你! " + student.stuName, "登录成功", MessageBoxButtons.OK);
                    Form frmMain = new FrmMain(student); // 传入当前用户
                    this.Hide();
                    frmMain.Show();
                }
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            // this.button1.ForeColor = Color.FromArgb(200, 2, 2);
            // this.button1.BackColor = Color.FromArgb(150, 200, 2, 2);
            //this.button1.Enabled = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            // this.button1.BackColor = Color.FromArgb(0, 0, 0, 0);
            //this.button1.Enabled = false;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            // this.button1.Enabled = true;
        }

        private void Login_MouseLeave(object sender, EventArgs e)
        {
            // this.button1.Enabled = false;
        }
    }
}
