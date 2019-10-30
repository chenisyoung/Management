using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL.Services
{
    public class CourseInfoService
    {
        public List<Courseinfo> GetCourseinfos()
        {
            List<Courseinfo> courseinfos = new List<Courseinfo>();
            string sql = "select * from course_info";
            SqlDataReader sdr = SqlHelper.GetAllResult(sql);
            while (sdr.Read())
            {
                Courseinfo courseinfo = new Courseinfo()
                {
                    ID = (int)sdr["ID"],
                    coursename = (string)sdr["course_name"],
                    coursenumber = (string)sdr["course_number"],
                    courescategory = (string)sdr["course_category"],
                    kcfs = (string)sdr["course_kcfs"],
                    hours = (int)sdr["course_hours"]
                };
                courseinfos.Add(courseinfo);
            }
            sdr.Close();
            return courseinfos;
        }

        /// <summary>
        /// 使用课程编号查找
        /// </summary>
        /// <param name="courseNumber"></param>
        /// <returns></returns>
        public List<Courseinfo> GetCourseinfoByCourseNumber(string courseNumber)
        {
            List<Courseinfo> courseinfos = new List<Courseinfo>();
            string sql = $"select * from course_info where class_num={courseNumber}";
            SqlDataReader sdr = SqlHelper.GetAllResult(sql);
            while (sdr.Read())
            {
                Courseinfo courseinfo = new Courseinfo()
                {
                    ID = (int)sdr["ID"],
                    coursename = (string)sdr["course_name"],
                    coursenumber = (string)sdr["course_number"],
                    courescategory = (string)sdr["course_category"],
                    kcfs = (string)sdr["course_kcfs"],
                    hours = (int)sdr["course_hours"]
                };
                courseinfos.Add(courseinfo);
            }
            sdr.Close();
            return courseinfos;
        }
    }
}
