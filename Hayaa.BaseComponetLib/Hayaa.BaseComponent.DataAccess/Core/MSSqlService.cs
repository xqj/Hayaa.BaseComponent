using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Hayaa.BaseComponent.DataAccess;
using Hayaa.BaseComponent.DataAccess.Config;
using Dapper;

namespace Hayaa.BaseComponent.DataAccess
{
    public class MSSqlService : IDatabaseService
    {
        public int ExecuteNonQuery<P>(string connectionString, string cmdText, P paramater, CommandType cmdType = CommandType.Text)
        {
            IDbConnection con = new SqlConnection(connectionString);
            int r = con.Execute(cmdText, paramater, null, null, cmdType);
            return r;
        }

        public T GetData<T, P>(string connectionString, string cmdText, P paramater, CommandType cmdType = CommandType.Text)
        {
            IDbConnection con = new SqlConnection(connectionString);
            var r = con.QuerySingle<T>(cmdText, paramater, null, null, cmdType);
            return r;
        }

        public List<T> GetList<T, P>(string connectionString, string cmdText, P paramater, CommandType cmdType = CommandType.Text)
        {
            IDbConnection con = new SqlConnection(connectionString);
            var r = con.Query<T>(cmdText, paramater, null, true, null, cmdType).ToList();
            return r;
        }

       
    }
}
