using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class daysForAVolunteerDTO
    {
        public int daysForAVolunteerCode { get; set; }
        public int dayInTheWeek { get; set; }
        public int beginningTime { get; set; }
        public int endTime { get; set; }
        public int VolunteerOffersCode { get; set; }
    }
}
