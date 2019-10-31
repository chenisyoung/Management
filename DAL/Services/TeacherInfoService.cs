using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL.Services
{
    public class TeacherInfoService
    {
        public List<TeacherInfo> GetTeacherInfoByNumber(string number)
        {
            string sql = $"select * from teacher_info where t_number={number}";
            SqlDataReader sdr = SqlHelper.GetAllResult(sql);
            List<TeacherInfo> teacherInfos = new List<TeacherInfo>();
            if (sdr.Read())
            {
                teacherInfos.Add(new TeacherInfo()
                {
                    ID = (int)sdr["ID"],
                    shenfenzheng = (string)sdr["shenfenzheng"],
                    teacherGender = (string)sdr["t_gender"],
                    teacherAge = (int)sdr["t_age"],
                    teacherNumber = (string)sdr["t_number"],
                    teacherName = (string)sdr["t_name"],
                    teacherCollege = (string)sdr["t_collage"],
                    teacherMajor = (string)sdr["t_major"],
                    teacherOffice = (string)sdr["t_office"],
                    teacherPhoneNumber = (string)sdr["t_phonenumber"],
                    t_pwd = (string)sdr["t_pwd"]
                });
            }
            return teacherInfos;
        }
    }
}
