using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class VolunteerOfferDTO
    {
        public int VolunteerOffersCode { get; set; }
        public int VolunteerCode { get; set; }
        public int TotalNumberOfHoursPerWeek { get; set; }
        public bool flexible { get; set; }
    }
}
