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
using DAL.Services;

namespace 教务管理
{
    public partial class frmTeacherInfo : Form
    {
        TeacherInfo teacher;
        public frmTeacherInfo(TeacherInfo teacher)
        {
            InitializeComponent();
            this.teacher = teacher;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeacherInfo_Load(object sender, EventArgs e)
        {
            InitModel();
        }
        void InitModel()
        {
            this.textBoxNum.Text = this.teacher.teacherNumber;
            this.textBoxName.Text = this.teacher.teacherName;
            this.textBoxAge.Text = this.teacher.teacherAge.ToString();
            this.textBoxCollege.Text = this.teacher.teacherCollege;
            this.textBoxMajor.Text = this.teacher.teacherMajor;
            this.textBoxOfficeAddr.Text = this.teacher.teacherOffice;
            this.textBoxPhoneNumber.Text = this.teacher.teacherPhoneNumber;
            this.textBoxShenfenzheng.Text = this.teacher.shenfenzheng;

            this.comboBox1.SelectedIndex = Gender2Number(this.teacher.teacherGender);

            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Enabled = false;
                }
            }
            this.comboBox1.Enabled = false;
        }

        int Gender2Number(string gender)
        {
            switch (gender)
            {
                case "男":
                    return 0;
                case "女":
                    return 1;
                case "不详":
                    return 2;
                default:
                    return -1;
            }
        }
        string Number2Gender(int number)
        {
            switch (number)
            {
                case 0:
                    return "男";
                case 1:
                    return "女";
                default:
                    return "不详";
            }
        }

        private void textBoxShenfenzheng_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((TextBox)sender).Text.Length < 17)
            // 前17位是数字
            {
                NumberOnly(sender, e);
            }
            if (((TextBox)sender).Text.Length == 17)
            {
                if (e.KeyChar == 'x' || e.KeyChar == 'X')
                {
                    e.KeyChar = 'X';
                    return;
                }
                NumberOnly(sender, e);
            }
            if (((TextBox)sender).Text.Length >= 18)
            //xianzhichangdu
            {
                if (e.KeyChar == (char)8)
                {
                    return;
                }
                else
                {
                    e.KeyChar = (char)0;
                }
            }
        }
                KeyPressEventArgs NumberOnly(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 0x20)
            {
                e.KeyChar = (char)0;
            }
            if ((e.KeyChar == 0x2D) && ((((TextBox)sender).Text.Length == 0)))
            {
                return null;
            }
            if (e.KeyChar >= 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch (Exception)
                {
                    e.KeyChar = (char)0;
                }

            }
            return e;
        }

        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(sender, e);
        }

        private void buttonXiugai_Click(object sender, EventArgs e)
        {
            if (0 == string.Compare("修改信息", this.buttonXiugai.Text))
            {
                foreach (var item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).Enabled = true;
                    }
                }
                this.comboBox1.Enabled = true;
                this.buttonXiugai.Text = "确认修改";
            }
            else
            {
                TeacherInfo teacher = GetTeacherFromForm();
                int a = BLL.Update.UpdateTeacher(teacher);
                this.teacher = (new LoginService()).TeacherLogin(teacher);
                InitModel();
                this.buttonXiugai.Text = "修改信息";
            }
        }

        private TeacherInfo GetTeacherFromForm()
        {
            return new TeacherInfo()
            {
                shenfenzheng = this.textBoxShenfenzheng.Text,
                teacherGender = Number2Gender(this.comboBox1.SelectedIndex),
                teacherAge = Int32.Parse(this.textBoxAge.Text),
                teacherNumber = this.textBoxNum.Text,
                teacherName = this.textBoxName.Text,
                teacherCollege = textBoxCollege.Text,
                teacherMajor = textBoxMajor.Text,
                teacherOffice = textBoxOfficeAddr.Text,
                teacherPhoneNumber = textBoxPhoneNumber.Text,
                t_pwd = this.teacher.t_pwd,
                ID = this.teacher.ID
            };
        }
    }
}
