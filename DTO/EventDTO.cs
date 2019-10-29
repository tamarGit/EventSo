using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EventDTO
    {
        public int EventCode { get; set; }
        public string EventName { get; set; }
        public int EventTypeCode { get; set; }
        public string EventTypeName { get; set; }
        public System.DateTime EventDate { get; set; }
        public int UserCode { get; set; }
        public int EventStatus { get; set; }
    }
}
