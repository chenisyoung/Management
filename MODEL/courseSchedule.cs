using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class CourseSchedule
    {
        public int ID { get; set; }
        public string coursenumber { get; set; }
        public string classnumber{ get; set; }
        public string tnumber{ get; set; }
        public string stuclass {get; set; }
        public string coursetime { get; set; } // 上课时间
    }
}
