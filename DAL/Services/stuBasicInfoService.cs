using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL.Services
{
    public class StuBasicInfoService
    {
        /// <summary>
        /// 获取学生列表, 在其他地方设置为只有权限为老师时才能够获取
        /// </summary>
        /// <param name="stu"></param>
        /// <returns>list<stubasicinfo></stubasicinfo></returns>
        public List<StuBasicinfo> GetStus()
        {
            string sql = "select * from stu_basicinfo";
            SqlDataReader sdr = SqlHelper.GetAllResult(sql); // 得到reader对象
            List<StuBasicinfo> students = new List<StuBasicinfo>();
            while (sdr.Read())
            {
                StuBasicinfo newStu = new StuBasicinfo();
                newStu.ID = (int)sdr["ID"];
                newStu.shenfenzheng = (string)sdr["shenfenzheng"];
                newStu.stuNum = (string)sdr["stu_num"];
                newStu.stuName = (string)sdr["stu_name"];
                newStu.stuClass = (string)sdr["stu_class"];

                newStu.stu_pwd = (string)sdr["stu_pwd"];
                students.Add(newStu);
            }
            sdr.Close();
            return students;
        }
    }
}
