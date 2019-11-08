using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Model;
using DAL;

namespace BLL
{
    public static class Update
    {
        public static int UpdateStudent(StuBasicinfo student)
        {
            string sql = "update Student_Basic_Info set Age=@Age,[Student ID]=@StudentID, [ID Number]=@IDNumber, " +
                "[Full name]=@Fullname, Class=@Class,Gender=@Gender," +
                "[Biogenic Land]=@BiogenicLand,College=@College,Major=@Major,[NCEE Score]=@NCEEScore," +
                "[Phone Number]=@PhoneNumber,[Name of Guardian 1]=@NameofGuardian1,[Name of Guardian 2]=@NameofGuardian2,"+
                "[Phone Number of Guardian 1]=@PhoneNumberofGuardian1,[Phone Number of Guardian 2]=@PhoneNumberofGuardian2 where ID=@ID";
            // 添加参数
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("IDNumber", student.IDNumber));
            parameters.Add(new SqlParameter("StudentID", student.StudentID));
            parameters.Add(new SqlParameter("Fullname", student.stuName));
            parameters.Add(new SqlParameter("Class", student.stuClass));//
            parameters.Add(new SqlParameter("Gender", student.stuGender));
            parameters.Add(new SqlParameter("Age", student.stuAge));
            parameters.Add(new SqlParameter("BiogenicLand", student.BiogenicLand));
            parameters.Add(new SqlParameter("College", student.stuCollege));
            parameters.Add(new SqlParameter("Major", student.stuMajor));
            parameters.Add(new SqlParameter("NCEEScore", student.GKchengji));
            parameters.Add(new SqlParameter("PhoneNumber", student.phoneNumber));
            parameters.Add(new SqlParameter("NameofGuardian1", student.stuGuardian1));
            parameters.Add(new SqlParameter("NameofGuardian2", student.stuGuardian2));
            parameters.Add(new SqlParameter("PhoneNumberofGuardian1", student.Guar1PhoneNumber));
            parameters.Add(new SqlParameter("PhoneNumberofGuardian2", student.Guar2PhoneNumber));
            parameters.Add(new SqlParameter("ID", student.ID));

            return DAL.Services.UpdateService.Update(sql, parameters.ToArray());
            
        }
        public static int InsertStudent(StuBasicinfo student)
        {
            //string sql = "insert into Student_Basic_Info values (@shenfenzheng, @stu_num, @stu_name, @stu_class, " +
               // "@stu_gender, @stu_age, @shengyuandi, @stu_college, @stu_major, @GK, @stu_phone, @stu_g1, @stu_g2, @stu_pwd)";
            string sql = "insert [dbo].[Student_Basic_Info] ([ID Number],[Student ID],"+
                "[Full name],[Class],[Gender],[Age],[Biogenic Land],[Major],[NCEE Score],"+
                "[Phone Number],[Name of Guardian 1],[Name of Guardian 2],[Phone Number of"+
                " Guardian 1],[Phone Number of Guardian 2],[password]) values "+
                "(@IDNumber, @StudentID, @Fullname, @Class, @Gender, @Age, @BIogenicLand,"+
                " @Major, @NCEEScore, @NameofGuardian1,@NameofGuardian2, @PhoneNumberofGuardian1,"+
                " @PhoneNumberofGuardian2, @password)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("IDNumber", student.IDNumber));
            parameters.Add(new SqlParameter("StudentID", student.StudentID));
            parameters.Add(new SqlParameter("Fullname", student.stuName));
            parameters.Add(new SqlParameter("Class", student.stuClass));//
            parameters.Add(new SqlParameter("Gender", student.stuGender));
            parameters.Add(new SqlParameter("Age", student.stuAge));
            parameters.Add(new SqlParameter("BiogenicLand", student.BiogenicLand));
            parameters.Add(new SqlParameter("College", student.stuCollege));
            parameters.Add(new SqlParameter("Major", student.stuMajor));
            parameters.Add(new SqlParameter("NCEEScore", student.GKchengji));
            parameters.Add(new SqlParameter("PhoneNumber", student.phoneNumber));
            parameters.Add(new SqlParameter("NameofGuardian1", student.stuGuardian1));
            parameters.Add(new SqlParameter("NameofGuardian2", student.stuGuardian2));
            parameters.Add(new SqlParameter("PhoneNumberofGuardian1", student.stuGuardian2));
            parameters.Add(new SqlParameter("PhoneNumberofGuardian2", student.stuGuardian2));
            parameters.Add(new SqlParameter("password", student.stu_pwd));
            
            return DAL.Services.UpdateService.Update(sql, parameters.ToArray());
        }
        /// <summary>
        /// 更新老师信息参数
        /// </summary>
        /// <param name="teacher">老师对象，根据ID来更新老师信息</param>
        /// <returns>int 受影响的行数</returns>
        public static int UpdateTeacher(TeacherInfo teacher)
        {
            string sql = "update teacher_info set "+
                "[ID Number]=@sfz, Gender=@tg, Age=@ta, [Job number]=@tnum, "+
                "[Full Name]=@tname, College=@tc, Major=@tm, [Office Location]=@to, "+
                "[Phone Number]=@tp where ID=@ID";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("sfz", teacher.shenfenzheng));
            parameters.Add(new SqlParameter("tg", teacher.teacherGender));
            parameters.Add(new SqlParameter("ta", teacher.teacherAge));
            parameters.Add(new SqlParameter("tnum", teacher.JobNumber));
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
