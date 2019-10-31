using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public static class UpdateService
    {
        public static int Update(string sql, SqlParameter[] parameters)
        {
            return SqlHelper.Update(sql, parameters);
        }
    }
}
