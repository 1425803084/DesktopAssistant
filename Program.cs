using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DesktopAssistant.app.frame;
using DesktopAssistant.app.page;
using DesktopAssistant.bases.constants;
using DesktopAssistant.domain;
using DesktopAssistant.global.config;
using Microsoft.Data.Sqlite;

namespace DesktopAssistant
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //程序初始化
            //1. 获取系统参数
            AppConstants constants = AppConstants.getInstance();

            //2. 连接数据库
            SqliteCommand sqlit = SqliteConnecter.getSqliteCommand();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainFrame());
        }
    }
}
