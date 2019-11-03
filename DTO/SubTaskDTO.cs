using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SubTaskDTO
    {
        public int SubTaskCode { get; set; }
        public string SubTaskName { get; set; }
        public int TaskCode { get; set; }
        public System.DateTime SubTaskDate { get; set; }
        public System.TimeSpan BeginingTime { get; set; }
        public double duration { get; set; }
        public int status { get; set; }
        public string details { get; set; }

    }
}
