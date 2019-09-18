using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BL.Convert
{
    class ConvertProfessional
    {
        public static Professional ConvertProfessionalToDAL(ProfessionalDTO professionalDTO1)
        {
            return new Professional
            {
                ProfessionalName = professionalDTO1.ProfessionalName,
                ProfessionalPhone = professionalDTO1.ProfessionalPhone,
                LivingArea = professionalDTO1.LivingArea,
                SeveralTimesInvited = professionalDTO1.SeveralTimesInvited,
                TotalRatings = professionalDTO1.TotalRatings,
                ProfessionalTypeCode = professionalTypeBL.GetCodeByName(professionalDTO1.ProfessionalTypeName)
            };
        }


        public static ProfessionalDTO ConvertProfessionalToDTO(Professional professional)
        {
            return new ProfessionalDTO
            {
                ProfessionalName = professional.ProfessionalName,
                ProfessionalPhone = professional.ProfessionalPhone,
                LivingArea = professional.LivingArea,
                SeveralTimesInvited = professional.SeveralTimesInvited,
                TotalRatings = professional.TotalRatings,
                ProfessionalTypeName = professionalTypeBL.GetNameByCode(professionalDTO1.ProfessionalTypeName)
            };
        }
    }
}
