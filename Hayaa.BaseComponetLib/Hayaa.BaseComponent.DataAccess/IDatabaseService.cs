using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace Hayaa.BaseComponent.DataAccess
{
     public interface IDatabaseService
    {
        T GetData<T>(string connectionString,string cmdText,  CommandType cmdType = CommandType.Text);
        List<T> GetList<T>(string connectionString, string cmdText,  CommandType cmdType = CommandType.Text);
        int GetPrimarykey(string connectionString, string cmdText, CommandType cmdType= CommandType.Text);
        int ExecuteNonQuery(string connectionString, string cmdText, CommandType cmdType = CommandType.Text);
    }
}
