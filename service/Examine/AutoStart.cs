using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;//需添加该引用

namespace DesktopAssistant.service.exam
{
    class Class1
    {
        public void setAutoStart(bool onoff)
        {
            try
            {
                if (onoff)
                {
                    RegistryKey r_local = Registry.CurrentUser;
                    //打开注册表
                    RegistryKey run = r_local.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                    if (run == null)
                    {
                        //新建表项
                        run.CreateSubKey("SOFTWARE//Microsoft//Windows//CurrentVersion//Run");
                    }
                    string appName = Process.GetCurrentProcess().MainModule.ModuleName;
                    string appPath = Process.GetCurrentProcess().MainModule.FileName;
                    //写入键值
                    run.SetValue(appName, appPath);
                    run.Close();

                }
                else
                {
                    RegistryKey r_local = Registry.CurrentUser;
                    RegistryKey run = r_local.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                    string appName = Process.GetCurrentProcess().MainModule.ModuleName;
                    //得到该表项下的键值
                    string[] keyNames = run.GetValueNames();
                    foreach (string keyName in keyNames)
                    {   //若存在该键值，则删除           
                        if (keyName == appName)
                        {
                            run.DeleteValue(appName);
                            run.Close();
                        }
                    }

                }
            }
            catch
            {
                MessageBox.Show("错误");
            }

        }
    }
}
