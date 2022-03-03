using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.converts
{
   public class embeddedVolunteerConverts
    {
        public static embeddedVolunteer embeddedVolunteerToDAL(embeddedVolunteerDTO embeddedVolunteer)
        {
            return new embeddedVolunteer
            {
                embeddedVolunteersCode = embeddedVolunteer.embeddedVolunteersCode,
                volunteerCode = embeddedVolunteer.volunteerCode,
                volunteeringDate = embeddedVolunteer.volunteeringDate,
                wardCode = embeddedVolunteer.wardCode,
                roleCode = embeddedVolunteer.roleCode,
                beginningTime = embeddedVolunteer.beginningTime,
                endTime = embeddedVolunteer.endTime

            };
        } 
      
    }
}
