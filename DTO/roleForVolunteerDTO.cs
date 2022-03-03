using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class roleForVolunteerDTO
    {
        public int roleForVolunteerCode { get; set; }
        public int volunteerCode { get; set; }
        public int roleCode { get; set; }
        public int priorityLevelRoleForVolunteer { get; set; }
        public int volunteerPriorityLevel { get; set; }
    }
}
