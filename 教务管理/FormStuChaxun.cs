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
using BLL;

namespace 教务管理
{
    public partial class FormStuChaxun : Form
    {
        StuBasicinfo student;
        public FormStuChaxun(StuBasicinfo student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void buttonGerenCourseInfo_Click(object sender, EventArgs e)
        {
            List<StuKebiao> kbs = GetGerenKebiao.GetStuKebiao(this.student.StudentID);
            this.dataGridView.DataSource = kbs;

        }
    }
}
