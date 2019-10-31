using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Services;
using Model;

namespace BLL
{
    public static class GetGerenKebiao
    {
        public static List<StuKebiao> GetStuKebiao(string stuClass)
        {
            List<StuKebiao> kbs = new List<StuKebiao>();

            CourseInfoService courseInfoService = new CourseInfoService();
            TeacherInfoService teacherInfoService = new TeacherInfoService();
            CourseScheduleService cs = new CourseScheduleService();
            List<CourseSchedule> courseSchedules = cs.GetCourseScheduleByStuClass(stuClass);

            foreach (var item in courseSchedules)
            {
                string courseName = courseInfoService.GetCourseinfoByCourseNumber(item.coursenumber)[0].coursename;
                string teacherName = teacherInfoService.GetTeacherInfoByNumber(item.tnumber)[0].teacherName;
                StuKebiao kebiao = new StuKebiao()
                {
                    CourseName = courseName,
                    CourseNumber = item.coursenumber,
                    ClassNumber = item.classnumber,
                    Course_shijian = item.coursetime,
                    Teacher_name = teacherName
                };

            }
            return kbs;
        }
        public static void GetTeacherKebiao(string stuNumber)
        {
            
        }
    }
}
