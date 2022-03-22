using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class embeddedVolunteerDTO
    {
        public int embeddedVolunteersCode { get; set; }
        public int volunteerCode { get; set; }
        public System.DateTime volunteeringDate { get; set; }
        public int wardCode { get; set; }
        public int roleCode { get; set; }
        public int beginningTime { get; set; }
        public int endTime { get; set; }

       
    }
}
