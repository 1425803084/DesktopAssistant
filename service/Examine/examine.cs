using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;//引入Process 类
using System.IO;

namespace DesktopAssistant.service.exam
{
    class examine
    {

        //获得进程的运行时长
        public TimeSpan getProcessTimeLong(Process p)
        {
            //当前时间
            DateTime nowTime = DateTime.Now;
            TimeSpan ts = new TimeSpan(0, 0, 0); ;
            Process[] proList = Process.GetProcesses(".");//获得本机的所有进程
            foreach (Process p1 in proList)
            {
                if (p1.ProcessName == p.ProcessName)
                {
                    DateTime processStartTime = p1.StartTime;//获得进程的开始时间
                    TimeSpan ts1 = new TimeSpan(nowTime.Ticks);
                    TimeSpan ts2 = new TimeSpan(processStartTime.Ticks);
                    ts = ts1.Subtract(ts2).Duration();//相减取绝对值
                }
            }
            return ts;
        }
        //比较运行时长与所设的防沉迷时间
        public void TimeCompare(Process p)
        {
            TimeSpan t1 = new TimeSpan(1, 0, 0);//提醒时间1
            TimeSpan t2 = new TimeSpan(2, 0, 0);//超过该时间则强行关闭
            int result1 = TimeSpan.Compare(getProcessTimeLong(p), t1);
            int result2 = TimeSpan.Compare(getProcessTimeLong(p), t2);
            if (result1 >= 0 && result2 < 0)
            {
                MessageBox.Show("您已使用" + p.ProcessName + "一小时，请注意");
            }
            else if (result2 >= 0)
            {
                MessageBox.Show("您已使用" + p.ProcessName + "二小时，请注意");
                p.Kill();//强行关闭              
            }
        }

        //检查游戏运行时长
        public void examineProcess()
        {
            //从文件中提取游戏名单，提供文件路径
            StreamReader sr1 = new StreamReader("D:\\vs练习文件\\word1.txt", Encoding.UTF8);
            string content = sr1.ReadToEnd();
            content = content.Replace("\r", "");
            string[] pname = content.Split('\n');
            //获得本机所有在运行的进程
            Process[] processList = Process.GetProcesses(".");
            for (int i = 0; i < pname.Length; i++)
            {
                foreach (Process p in processList)
                {
                    //如果名单中某游戏在运行，检查其运行时长
                    if (string.Compare(p.ProcessName, pname[i]) == 0)
                    {
                        TimeCompare(p);
                    }
                }
            }

        }
    }
}
