
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hayaa.BaseComponent.DataAccess.Config;

namespace Hayaa.BaseComponent.DataAccess
{
    public class DataAccessService
    {
        private EnumDatabaseType _config;
        private IDatabaseService _service;
        public DataAccessService(EnumDatabaseType config) {
             _config= config;
        }
        /// <summary>
        /// 创建数据服务对象，非单例
        /// </summary>
        /// <returns></returns>
        public IDatabaseService CreateDataService() {
            switch (_config)
            {
                case EnumDatabaseType.MySql:
                    return new MysqlService();
                case EnumDatabaseType.SqlServer:
                    return new MSSqlService();
                default:
                    return null;
            }            
        }
        /// <summary>
        /// 创建单例对象
        /// </summary>
        /// <returns></returns>
        public IDatabaseService CreateIntance()
        {
            if (_service == null) _service = CreateDataService();
            return _service;
        }
    }
}
