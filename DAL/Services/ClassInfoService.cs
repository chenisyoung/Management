using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL.Services
{
    public class ClassInfoService
    {
        public List<ClassInfo> GetClassInfos()
        {
            List<ClassInfo> classInfos = new List<ClassInfo>();
            string sql = "select * from class_info";
            SqlDataReader sdr = SqlHelper.GetAllResult(sql);
            while (sdr.Read())
            {
                ClassInfo classInfo = new ClassInfo()
                {
                    ID = (int)sdr["ID"],
                    classnum = (string)sdr["class_num"],
                    classaddress = (string)sdr["class_address"],
                    classCapacity = (int)sdr["class_capacity"],
                    classmutilmedia = (string)sdr["class_mutilmedia"]
                };
                classInfos.Add(classInfo);
            }
            sdr.Close();
            return classInfos;
        }

        public List<ClassInfo> GetClassInfoByClassNumber(string classNumber)
        {
            List<ClassInfo> classInfos = new List<ClassInfo>();
            string sql = $"select * from class_info where class_num={classNumber}";
            SqlDataReader sdr = SqlHelper.GetAllResult(sql);
            while (sdr.Read())
            {
                ClassInfo classInfo = new ClassInfo()
                {
                    ID = (int)sdr["ID"],
                    classnum = (string)sdr["class_num"],
                    classaddress = (string)sdr["class_address"],
                    classCapacity = (int)sdr["class_capacity"],
                    classmutilmedia = (string)sdr["class_mutilmedia"]
                };
                classInfos.Add(classInfo);
            }
            sdr.Close();
            return classInfos;
        }
    }
}
