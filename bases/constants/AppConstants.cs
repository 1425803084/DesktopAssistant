using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAssistant.bases.constants
{
    class AppConstants
    {

        //系统跟目录
        public string rootPath;

        //系统数据库绝对路径
        public string dataBasePath;

        //系统数据库相对跟目录位置
        private string dataBasePathRelative = "info.db";
        
        //唯一实例
        private static AppConstants appConstans = new AppConstants();
        
        //私有化构造函数
        private AppConstants()
        {
            rootPath = System.AppDomain.CurrentDomain.BaseDirectory;
            dataBasePath = rootPath + dataBasePathRelative;
        }

        public static AppConstants getInstance()
        {
            return appConstans;
        }

    }
}
