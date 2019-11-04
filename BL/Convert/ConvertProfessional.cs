using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BL.Convert
{
   public class ConvertProfessional
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
                ProfessionalTypeCode = professionalDTO1.ProfessionalTypeCode,
                
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
                ProfessionalTypeCode = professional.ProfessionalTypeCode,
                ProfessionalTypeName = professionalTypeBL.GetNameByCode(professionalDTO1.ProfessionalTypeName)
            };
        }
    }
}
