using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hayaa.BaseComponent.DataAccess.Config;
using System.Data;

namespace Hayaa.BaseComponent.DataAccess
{
    public class MysqlService : IDatabaseService
    {
        public int ExecuteNonQuery(string connectionString, string cmdText, CommandType cmdType = CommandType.Text)
        {
            throw new NotImplementedException();
        }

        public T GetData<T>(string connectionString, string cmdText, CommandType cmdType = CommandType.Text)
        {
            throw new NotImplementedException();
        }

        public List<T> GetList<T>(string connectionString, string cmdText, CommandType cmdType = CommandType.Text)
        {
            throw new NotImplementedException();
        }

        public int GetPrimarykey(string connectionString, string cmdText, CommandType cmdType = CommandType.Text)
        {
            throw new NotImplementedException();
        }
    }
}
