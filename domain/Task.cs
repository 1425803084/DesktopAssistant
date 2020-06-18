using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAssistant.domain
{
    class Task
    {

        public int Id { get; set; }

        public int StartTime { get; set; }

        public int EndTime { get; set; }

        public int Progress { get; set; }

        public string Describe { get; set; }

        public string Detail { get; set; }

        public int TagId { get; set; }

    }
}
