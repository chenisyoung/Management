using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace DAL
{
    /// <summary>
    /// 通用数据访问类
    /// </summary>
    class SqlHelper
    {
        private static readonly string connString = ConfigurationManager.ConnectionStrings["connString"].ToString(); // 通过配置文件获取连接字符串
        /// <summary>
        /// 更新方法
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>受影响的行数</returns>
        #region 不带参数的方法
        public static int Update(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand command = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("更新出现错误! " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 返回单一行列的SQL查询
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>查询到的对象, 强制转换为所需要类型</returns>
        public static object GetSingleResult(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand command = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet set = new DataSet();
                adapter.Fill(set);
                
                return set.Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("出现错误! " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 获取所有数据,返回SQL reader
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetAllResult(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand command = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                conn.Close();
                throw new Exception("出现错误! " + ex.Message);
            }
        }
        #endregion
        #region 带参数的方法
        public static int Update(string sql, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddRange(param);
            try
            {
                conn.Open();
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("更新出现错误! " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
       }

        /// <summary>
        /// 返回第一行第一列的SQL查询
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>查询到的对象, 强制转换为所需要类型</returns>
        public static object GetSingleResult(string sql, SqlParameter[] paras)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand command = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                command.Parameters.AddRange(paras);//添加参数
                return command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("出现错误! " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 获取所有数据,返回SQL reader
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetAllResult(string sql, SqlParameter[] paras)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand command = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                command.Parameters.AddRange(paras);//添加参数
                return command.ExecuteReader(CommandBehavior.CloseConnection);//传入枚举类型,在reader方关闭连接
            }
            catch (Exception ex)
            {
                conn.Close();
                throw new Exception("出现错误! " + ex.Message);
            }
        }
        #endregion
    }
}
