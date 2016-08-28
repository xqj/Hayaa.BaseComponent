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
        T GetData<T,P>(string connectionString,string cmdText,P paramater,  CommandType cmdType = CommandType.Text);
        List<T> GetList<T, P>(string connectionString, string cmdText, P paramater, CommandType cmdType = CommandType.Text);
         int ExecuteNonQuery<P>(string connectionString, string cmdText, P paramater, CommandType cmdType = CommandType.Text);
    }
}
