
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Hayaa.BaseComponent.DataAccess;
using Hayaa.BaseComponent.DataAccess.Config;

namespace Hayaa.BaseComponent.DataAccess
{
    public class MSSqlService : IDatabaseService
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
