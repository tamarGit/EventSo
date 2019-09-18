using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProfessionalDTO
    {
        public int ProfessionalCode { get; set; }
        public string ProfessionalName { get; set; }
        public int ProfessionalTypeCode { get; set; }
        public string ProfessionalTypeName { get; set; }
        public string ProfessionalPhone { get; set; }
        public int SeveralTimesInvited { get; set; }
        public string LivingArea { get; set; }
        public int TotalRatings { get; set; }
    }
}
