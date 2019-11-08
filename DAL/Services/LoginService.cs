using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class LoginService
    {
        /// <summary>
        /// 查询单个学生数据, 传入的学生对象应该有学号与密码
        /// </summary>
        /// <param name="stu">null或填充好数据的学生对象</param>
        /// <returns></returns>
        public StuBasicinfo StuLogin(StuBasicinfo stu)
        {
            string sql = "select top 1 * from Student_Basic_Info where [Student ID] = @StudentID";  //带参数的语句
            SqlParameter para1 = new SqlParameter("StudentID", System.Data.SqlDbType.VarChar)
            {
                Value = stu.StudentID
            };//参数
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = para1;
            SqlDataReader sdr = SqlHelper.GetAllResult(sql, paras); // 得到reader对象
            StuBasicinfo newStu = new StuBasicinfo();
            if (sdr.Read())
            {
                newStu.ID = (int)sdr["ID"];
                newStu.IDNumber = (string)sdr["ID Number"];
                newStu.StudentID = (string)sdr["Student ID"];
                newStu.stuName = (string)sdr["Full name"];
                newStu.stuClass = (string)sdr["Class"];
                newStu.stuGender = (string)sdr["Gender"];
                newStu.stuAge = (string)sdr["Age"];
                newStu.BiogenicLand = sdr.GetString(7);
                newStu.stuCollege = sdr.GetString(8);
                newStu.stuMajor = sdr.GetString(9);
                newStu.GKchengji = sdr.GetString(10);
                newStu.phoneNumber = sdr.GetString(11);
                newStu.stuGuardian1 = sdr.GetString(12);
                newStu.stuGuardian2 = sdr.GetString(13);
                newStu.Guar1PhoneNumber= sdr.GetString(14);
                newStu.Guar2PhoneNumber= sdr.GetString(15);
                newStu.stu_pwd = sdr.GetString(16);
            }
            else
            {
                // 读取不到记录, 说明账号不存在
                return null;
            }
            sdr.Close();
             //如果md5对不上
            if (!IsMd5Same(stu.stu_pwd, newStu.stu_pwd))
            {
                return null;
            }

            return newStu;
        }
        public TeacherInfo TeacherLogin(TeacherInfo teacher)
        {
            string sql = "select top 1 * from Teacher_Info where [Job number] = @tNum";  //带参数的语句
            SqlParameter para1 = new SqlParameter("tNum", System.Data.SqlDbType.VarChar)
            {
                Value = teacher.JobNumber
            };//参数
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = para1;
            SqlDataReader sdr = SqlHelper.GetAllResult(sql, paras); // 得到reader对象
            TeacherInfo newTeacher = new TeacherInfo();
            if (sdr.Read())
            {
                newTeacher.ID = (int)sdr["ID"];
                newTeacher.shenfenzheng = (string)sdr["ID Number"];
                newTeacher.teacherGender = (string)sdr["Gender"];
                newTeacher.teacherAge = (string)sdr["Age"];
                newTeacher.JobNumber= (string)sdr["Job number"];
                newTeacher.teacherName = (string)sdr["Full Name"];
                newTeacher.teacherCollege = (string)sdr["College"];
                newTeacher.teacherMajor = (string)sdr["Major"];
                newTeacher.teacherOffice = (string)sdr["Office Location"];
                newTeacher.teacherPhoneNumber = (string)sdr["Phone Number"];
                newTeacher.t_pwd = (string)sdr["password"];
            }
            else
            {
                // 读取不到记录, 说明账号不存在
                return null;
            }
            sdr.Close();
             //如果md5对不上
            if (!IsMd5Same(teacher.t_pwd, newTeacher.t_pwd))
            {
                return null;
            }

            return newTeacher;
        }
        bool IsMd5Same(string source, string verify)
        {
             using (MD5 md5Hash = MD5.Create())
            {
                string hash1 = GetMd5Hash(md5Hash, source);
                string hash2 = GetMd5Hash(md5Hash, verify);

                if (0 == String.Compare(hash1, hash2))
                {
                    return true;                
                }
                else
                {
                    return false;               
                }
            }

        }
        // https://docs.microsoft.com/zh-cn/dotnet/api/system.security.cryptography.md5?redirectedfrom=MSDN&view=netframework-4.8
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}
