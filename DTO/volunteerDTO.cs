using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class volunteerDTO
    {
        public int VolunteerCode { get; set; }
        public string VolunteerID { get; set; }
        public string VolunteerFirstName { get; set; }
        public string VolunteerLastName { get; set; }
        public System.DateTime VolunteerDateOfBirth { get; set; }
        public string VolunteerPhone { get; set; }
        public string VolunteerAddress { get; set; }
        public string VolunteerGmail { get; set; }
        public string VolunteerPassword { get; set; }
        public string volunteerUsername { get; set; }
    }
}
