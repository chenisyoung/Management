using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL.Services
{
    public class CourseScheduleService
    {
        public List<CourseSchedule> GetCourseSchedules()
        {
            string sql = "select * from course_schedule";
            SqlDataReader sdr = SqlHelper.GetAllResult(sql);
            List<CourseSchedule> courseSchedules = new List<CourseSchedule>();
            while (sdr.Read())
            {
                CourseSchedule courseSchedule = new CourseSchedule()
                {
                    ID = (int)sdr["ID"],
                    coursenumber = (string)sdr["course_number"],
                    classnumber = (string)sdr["class_number"],
                    tnumber = (string)sdr["t_number"],
                    stuclass = (string)sdr["stu_class"],
                    coursetime = (string)sdr["course_time"], // 上课时间
                };
                courseSchedules.Add(courseSchedule);
            }
            sdr.Close();
            return courseSchedules;
        }

        public List<CourseSchedule> GetCourseScheduleByCourseNumber(string courseNumber)
        {
            string sql = $"select * from course_schedule where course_number={courseNumber}";
            SqlDataReader sdr = SqlHelper.GetAllResult(sql);
            List<CourseSchedule> courseSchedules = new List<CourseSchedule>();
            while (sdr.Read())
            {
                CourseSchedule courseSchedule = new CourseSchedule()
                {
                    ID = (int)sdr["ID"],
                    coursenumber = (string)sdr["course_number"],
                    classnumber = (string)sdr["class_number"],
                    tnumber = (string)sdr["t_number"],
                    stuclass = (string)sdr["stu_class"],
                    coursetime = (string)sdr["course_time"], // 上课时间
                };
                courseSchedules.Add(courseSchedule);
            }
            sdr.Close();
            return courseSchedules;
        }

        public List<CourseSchedule> GetCourseScheduleByClassNumber(string classNumber)
        {
            string sql = $"select * from course_schedule where class_number={classNumber}";
            SqlDataReader sdr = SqlHelper.GetAllResult(sql);
            List<CourseSchedule> courseSchedules = new List<CourseSchedule>();
            while (sdr.Read())
            {
                CourseSchedule courseSchedule = new CourseSchedule()
                {
                    ID = (int)sdr["ID"],
                    coursenumber = (string)sdr["course_number"],
                    classnumber = (string)sdr["class_number"],
                    tnumber = (string)sdr["t_number"],
                    stuclass = (string)sdr["stu_class"],
                    coursetime = (string)sdr["course_time"], // 上课时间
                };
                courseSchedules.Add(courseSchedule);
            }
            sdr.Close();
            return courseSchedules;
        }

        public List<CourseSchedule> GetCourseScheduleByTeacherNumber(string teacherNumber)
        {
            string sql = $"select * from course_schedule where t_number={teacherNumber}";
            SqlDataReader sdr = SqlHelper.GetAllResult(sql);
            List<CourseSchedule> courseSchedules = new List<CourseSchedule>();
            while (sdr.Read())
            {
                CourseSchedule courseSchedule = new CourseSchedule()
                {
                    ID = (int)sdr["ID"],
                    coursenumber = (string)sdr["course_number"],
                    classnumber = (string)sdr["class_number"],
                    tnumber = (string)sdr["t_number"],
                    stuclass = (string)sdr["stu_class"],
                    coursetime = (string)sdr["course_time"], // 上课时间
                };
                courseSchedules.Add(courseSchedule);
            }
            sdr.Close();
            return courseSchedules;
        }
        public List<CourseSchedule> GetCourseScheduleByStuClass(string stuClass)
        {
            string sql = $"select * from course_schedule where stu_class={stuClass}";
            SqlDataReader sdr = SqlHelper.GetAllResult(sql);
            List<CourseSchedule> courseSchedules = new List<CourseSchedule>();
            while (sdr.Read())
            {
                CourseSchedule courseSchedule = new CourseSchedule()
                {
                    ID = (int)sdr["ID"],
                    coursenumber = (string)sdr["course_number"],
                    classnumber = (string)sdr["class_number"],
                    tnumber = (string)sdr["t_number"],
                    stuclass = (string)sdr["stu_class"],
                    coursetime = (string)sdr["course_time"], // 上课时间
                };
                courseSchedules.Add(courseSchedule);
            }
            sdr.Close();
            return courseSchedules;
        }
        public List<CourseSchedule> GetCourseScheduleByTime(string time)
        {
            string sql = $"select * from course_schedule where course_time={time}";
            SqlDataReader sdr = SqlHelper.GetAllResult(sql);
            List<CourseSchedule> courseSchedules = new List<CourseSchedule>();
            while (sdr.Read())
            {
                CourseSchedule courseSchedule = new CourseSchedule()
                {
                    ID = (int)sdr["ID"],
                    coursenumber = (string)sdr["course_number"],
                    classnumber = (string)sdr["class_number"],
                    tnumber = (string)sdr["t_number"],
                    stuclass = (string)sdr["stu_class"],
                    coursetime = (string)sdr["course_time"], // 上课时间
                };
                courseSchedules.Add(courseSchedule);
            }
            sdr.Close();
            return courseSchedules;
        }

    }
}
