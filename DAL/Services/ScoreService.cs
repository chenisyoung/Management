using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL.Services
{
    public class ScoreService
    {
        public List<Score> GetScores()
        {
            List<Score> scores = new List<Score>();
            string sql = "select * from score";
            SqlDataReader sdr = SqlHelper.GetAllResult(sql);
            while (sdr.Read())
            {
                Score score = new Score()
                {
                    ID = (int)sdr["ID"],
                    stuNumber = (string)sdr["stu_number"],
                    courseNumber = (string)sdr["course_number"],
                    tNumber = (string)sdr["t_number"],
                    scoreNumber = (decimal)sdr["score"]
                };
                scores.Add(score);
            }
            sdr.Close();
            return scores;
        }

        public List<Score> GetScoreByStuNumber(string stuNumber)
        {
            List<Score> scores = new List<Score>();
            string sql = $"select * from score where stu_number={stuNumber}";
            SqlDataReader sdr = SqlHelper.GetAllResult(sql);
            while (sdr.Read())
            {
                Score score = new Score()
                {
                    ID = (int)sdr["ID"],
                    stuNumber = (string)sdr["stu_number"],
                    courseNumber = (string)sdr["course_number"],
                    tNumber = (string)sdr["t_number"],
                    scoreNumber = (decimal)sdr["score"]
                };
                scores.Add(score);
            }
            sdr.Close();
            return scores;
        }

        public List<Score> GetScoreByTeacherNumber(string teacherNumber)
        {
            List<Score> scores = new List<Score>();
            string sql = $"select * from score where t_number={teacherNumber}";
            SqlDataReader sdr = SqlHelper.GetAllResult(sql);
            while (sdr.Read())
            {
                Score score = new Score()
                {
                    ID = (int)sdr["ID"],
                    stuNumber = (string)sdr["stu_number"],
                    courseNumber = (string)sdr["course_number"],
                    tNumber = (string)sdr["t_number"],
                    scoreNumber = (decimal)sdr["score"]
                };
                scores.Add(score);
            }
            sdr.Close();
            return scores;
        }

        public List<Score> GetScoreByCourseNumber(string courseNumber)
        {
            List<Score> scores = new List<Score>();
            string sql = $"select * from score where course_number={courseNumber}";
            SqlDataReader sdr = SqlHelper.GetAllResult(sql);
            while (sdr.Read())
            {
                Score score = new Score()
                {
                    ID = (int)sdr["ID"],
                    stuNumber = (string)sdr["stu_number"],
                    courseNumber = (string)sdr["course_number"],
                    tNumber = (string)sdr["t_number"],
                    scoreNumber = (decimal)sdr["score"]
                };
                scores.Add(score);
            }
            sdr.Close();
            return scores;
        }
    }
}
