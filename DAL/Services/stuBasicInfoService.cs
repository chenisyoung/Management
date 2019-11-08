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
            string sql = "select * from Student_Basic_Info";
            SqlDataReader sdr = SqlHelper.GetAllResult(sql); // 得到reader对象
            List<StuBasicinfo> students = new List<StuBasicinfo>();
            while (sdr.Read())
            {
                StuBasicinfo newStu = new StuBasicinfo()
                {
                    ID = (int)sdr["ID"],
                    IDNumber = (string)sdr["ID Number"],
                    StudentID = (string)sdr["Student ID"],
                    stuName = (string)sdr["Full name"],
                    stuClass = (string)sdr["Class"],
                    stuGender = (string)sdr["Gender"],
                    stuAge = (string)sdr["Age"],
                    BiogenicLand = (string)sdr["Biogenic Land"],
                    stuCollege = (string)sdr["College"],
                    stuMajor = (string)sdr["Major"],
                    GKchengji = (string)sdr["NCEE Score"],
                    phoneNumber = (string)sdr["Phone Number"],
                    stuGuardian1 = (string)sdr["Name of Guardian 1"],
                    stuGuardian2 = (string)sdr["Name of Guardian 2"],
                    Guar1PhoneNumber = (string)sdr["Phone Number of Guardian 1"],
                    Guar2PhoneNumber = (string)sdr["Phone Number of Guardian 2"],
                    stu_pwd = (string)sdr["password"]
                };
                students.Add(newStu);
            }
            sdr.Close();
            return students;
        }
    }
}
