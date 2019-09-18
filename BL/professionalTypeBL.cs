using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BL.Convert;

namespace BL
{
    class professionalTypeBL
    {
        EventSoDBEntities1 DB = new EventSoDBEntities1();

        public int GetCodeByName(string professionalName)
        {
            return (DB.ProfessionalTypes.FirstOrDefault(p => p.ProfessionalTypeName == professionalName)).ProfessionalTypeCode;
        }
        public string GetNameByCode(int professionalCode)
        {
            return DB.ProfessionalTypes.FirstOrDefault(p => p.ProfessionalTypeCode == professionalCode).ProfessionalTypeName;
        }
    }
}
