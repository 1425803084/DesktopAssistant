using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopAssistant.bases.constants;
using System.Data.SQLite;

namespace DesktopAssistant.global.config
{
    public class SqliteConnecter
    {
        //sql cmd
        public SQLiteCommand command;

        //数据库连接对象
        private SQLiteConnection connection; 

        //系统引用
        private AppConstants appConstants;

        //数据库位置
        private string DBpath;

        //数据库连接对象
        private static SqliteConnecter connecter = new SqliteConnecter();

        private SqliteConnecter()
        {
            appConstants = AppConstants.getInstance();
            command = new SQLiteCommand();
            DBpath = appConstants.dataBasePath;
            connection = new SQLiteConnection("data source=" + DBpath);
            connection.Open();
            command.Connection = connection;

        }

        //获取数据库操作实例
        public static SQLiteCommand getSqliteCommand()
        {
            return connecter.command;
        }

       

    }
}
