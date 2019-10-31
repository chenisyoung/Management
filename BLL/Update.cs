using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public static class Update
    {
        public static int UpdateStudent(StuBasicinfo student)
        {
            string sql = "update stu_basicinfo set shenfenzheng=@shenfenzheng,stu_num=@stu_num," +
                "stu_name=@stu_name, stu_class=@stu_class, stu_gender=@stu_gender, stu_age=@stu_age," +
                "stu_shengyuandi=@shengyuandi, stu_college=@stu_college, stu_major=@stu_major, stu_GKchengji=@GK," +
                "stu_phoneNumber=@stu_phone, stu_guardian1=@stu_g1, stu_guardian2=@stu_g2 where ID=@ID";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("shenfenzheng", student.shenfenzheng));
            parameters.Add(new SqlParameter("stu_num", student.stuNum));
            parameters.Add(new SqlParameter("stu_name", student.stuName));
            parameters.Add(new SqlParameter("stu_class", student.stuClass));//
            parameters.Add(new SqlParameter("stu_gender", student.stuGender));
            parameters.Add(new SqlParameter("stu_age", student.stuAge));
            parameters.Add(new SqlParameter("shengyuandi", student.stuShegnyuandi));
            parameters.Add(new SqlParameter("stu_college", student.stuCollege));
            parameters.Add(new SqlParameter("stu_major", student.stuMajor));
            parameters.Add(new SqlParameter("GK", student.GKchengji));
            parameters.Add(new SqlParameter("stu_phone", student.phoneNumber));
            parameters.Add(new SqlParameter("stu_g1", student.stuGuardian1));
            parameters.Add(new SqlParameter("stu_g2", student.stuGuardian2));
            parameters.Add(new SqlParameter("ID", student.ID));

            return DAL.Services.UpdateService.Update(sql, parameters.ToArray());
            
        }
        public static int InsertStudent(StuBasicinfo student)
        {
            string sql = "insert into stu_basicinfo values (@shenfenzheng, @stu_num, @stu_name, @stu_class, " +
                "@stu_gender, @stu_age, @shengyuandi, @stu_college, @stu_major, @GK, @stu_phone, @stu_g1, @stu_g2, @stu_pwd)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("shenfenzheng", student.shenfenzheng));
            parameters.Add(new SqlParameter("stu_num", student.stuNum));
            parameters.Add(new SqlParameter("stu_name", student.stuName));
            parameters.Add(new SqlParameter("stu_class", student.stuClass));//
            parameters.Add(new SqlParameter("stu_gender", student.stuGender));
            parameters.Add(new SqlParameter("stu_age", student.stuAge));
            parameters.Add(new SqlParameter("shengyuandi", student.stuShegnyuandi));
            parameters.Add(new SqlParameter("stu_college", student.stuCollege));
            parameters.Add(new SqlParameter("stu_major", student.stuMajor));
            parameters.Add(new SqlParameter("GK", student.GKchengji));
            parameters.Add(new SqlParameter("stu_phone", student.phoneNumber));
            parameters.Add(new SqlParameter("stu_g1", student.stuGuardian1));
            parameters.Add(new SqlParameter("stu_g2", student.stuGuardian2));
            parameters.Add(new SqlParameter("stu_pwd", student.stu_pwd));

            return DAL.Services.UpdateService.Update(sql, parameters.ToArray());
        }
        public static int UpdateTeacher(TeacherInfo teacher)
        {
            string sql = "update teacher_info set "+
                "shenfenzheng=@sfz, t_gender=@tg, t_age=@ta, t_number=@tnum, "+
                "t_name=@tname, t_collage=@tc, t_major=@tm, t_office=@to, "+
                "t_phonenumber=@tp where ID=@ID";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("sfz", teacher.shenfenzheng));
            parameters.Add(new SqlParameter("tg", teacher.teacherGender));
            parameters.Add(new SqlParameter("ta", teacher.teacherAge));
            parameters.Add(new SqlParameter("tnum", teacher.teacherNumber));
            parameters.Add(new SqlParameter("tname", teacher.teacherName));
            parameters.Add(new SqlParameter("tc", teacher.teacherCollege));
            parameters.Add(new SqlParameter("tm", teacher.teacherMajor));
            parameters.Add(new SqlParameter("to", teacher.teacherOffice));
            parameters.Add(new SqlParameter("tp", teacher.teacherPhoneNumber));
            parameters.Add(new SqlParameter("ID", teacher.ID));

            return DAL.Services.UpdateService.Update(sql, parameters.ToArray());
        }
    }
}
