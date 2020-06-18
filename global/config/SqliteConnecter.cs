using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopAssistant.bases.constants;
using Microsoft.Data.Sqlite;

namespace DesktopAssistant.global.config
{
    public class SqliteConnecter
    {
        //sql cmd
        public SqliteCommand command;

        //数据库连接对象
        private SqliteConnection connection; 

        //系统引用
        private AppConstants appConstants;

        //数据库位置
        private string DBpath;

        //数据库连接对象
        private static SqliteConnecter connecter = new SqliteConnecter();

        private SqliteConnecter()
        {
            appConstants = AppConstants.getInstance();
            command = new SqliteCommand();
            DBpath = appConstants.dataBasePath;
            connection = new SqliteConnection("data source=" + DBpath);
            connection.Open();
            command.Connection = connection;

        }

        //获取数据库操作实例
        public static SqliteCommand getSqliteCommand()
        {
            return connecter.command;
        }

       

    }
}
