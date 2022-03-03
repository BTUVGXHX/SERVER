using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.converts
{
   public class daysForAVolunteerConverts
    {
        public static daysForAVolunteer daysForAVolunteerConvertsToDal(daysForAVolunteerDTO daysForAVolunteer)
        {
            return new daysForAVolunteer
            {
                daysForAVolunteerCode = daysForAVolunteer.daysForAVolunteerCode,
                dayInTheWeek = daysForAVolunteer.dayInTheWeek,
                beginningTime = daysForAVolunteer.beginningTime,
                endTime = daysForAVolunteer.endTime,
                VolunteerOffersCode = daysForAVolunteer.VolunteerOffersCode
            };
        }
    }
}
