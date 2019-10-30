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
            string sql = "select top 1 * from stu_basicinfo where stu_num = @stuNum";  //带参数的语句
            SqlParameter para1 = new SqlParameter("stuNum", System.Data.SqlDbType.VarChar)
            {
                Value = stu.stuNum
            };//参数
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = para1;
            SqlDataReader sdr = SqlHelper.GetAllResult(sql, paras); // 得到reader对象
            StuBasicinfo newStu = new StuBasicinfo();
            if (sdr.Read())
            {
                newStu.ID = (int)sdr["ID"];
                newStu.shenfenzheng = (string)sdr["shenfenzheng"];
                newStu.stuNum = (string)sdr["stu_num"];
                newStu.stuName = (string)sdr["stu_name"];
                newStu.stuClass = (string)sdr["stu_class"];
                newStu.stuGender = (string)sdr["stu_gender"];
                newStu.stuAge = (int)sdr["stu_age"];
                newStu.stuShegnyuandi = (string)sdr["stu_shengyuandi"];
                newStu.stuCollege = (string)sdr["stu_college"];
                newStu.stuMajor = (string)sdr["stu_major"];
                newStu.GKchengji = (decimal)sdr["stu_GKchengji"];
                newStu.phoneNumber = (string)sdr["stu_phoneNumber"];
                newStu.stuGuardian1 = (string)sdr["stu_guardian1"];
                newStu.stuGuardian2 = (string)sdr["stu_guardian2"];
                newStu.stu_pwd = (string)sdr["stu_pwd"];
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
            string sql = "select top 1 * from teacher_info where t_number = @tNum";  //带参数的语句
            SqlParameter para1 = new SqlParameter("tNum", System.Data.SqlDbType.VarChar)
            {
                Value = teacher.teacherNumber
            };//参数
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = para1;
            SqlDataReader sdr = SqlHelper.GetAllResult(sql, paras); // 得到reader对象
            TeacherInfo newTeacher = new TeacherInfo();
            if (sdr.Read())
            {
                newTeacher.ID = (int)sdr["ID"];
                newTeacher.shenfenzheng = (string)sdr["shenfenzheng"];
                newTeacher.teacherGender = (string)sdr["t_gender"];
                newTeacher.teacherAge = (int)sdr["t_age"];
                newTeacher.teacherNumber = (string)sdr["t_number"];
                newTeacher.teacherName = (string)sdr["t_name"];
                newTeacher.teacherCollege = (string)sdr["t_collage"];
                newTeacher.teacherMajor = (string)sdr["t_major"];
                newTeacher.teacherOffice = (string)sdr["t_office"];
                newTeacher.teacherPhoneNumber = (string)sdr["t_phonenumber"];
                newTeacher.t_pwd = (string)sdr["t_pwd"];
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
