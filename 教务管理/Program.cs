using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;//引入项目内其他类库
using DAL;
using DAL.Services;

namespace 教务管理
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Test();

            Application.Run(new Login());
        }
        // 测试方法
        static void Test()
        {
            StuBasicinfo stu = new StuBasicinfo();
            stu.StudentID= "1702110527";
            stu.stu_pwd = "123456";
            LoginService ls = new LoginService();
            stu = ls.StuLogin(stu);
            TeacherInfo teacher = new TeacherInfo()
            {
                JobNumber = "1702110527",
                t_pwd = "123456"
            };
            teacher = ls.TeacherLogin(teacher);
        }
    }
}
