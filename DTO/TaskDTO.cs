using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class TaskDTO
    {
        public int TaskCode { get; set; }
        public string TaskName { get; set; }
        public int EventCode { get; set; }
        public int EventTypeCode { get; set; }
        public System.DateTime DeadLine { get; set; }
        public int ProfessionalCode { get; set; }
        public int TaskStatus { get; set; }
        public System.DateTime BeginingTime { get; set; }

    }
}
