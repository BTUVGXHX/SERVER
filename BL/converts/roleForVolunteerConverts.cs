using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.converts
{
  public  class roleForVolunteerConverts
    {
        public static roleForVolunteer convertRoleForVolunteerToDAL(roleForVolunteerDTO roleForVolunteer)
        {
            return new roleForVolunteer
            {
              roleForVolunteerCode=roleForVolunteer.roleForVolunteerCode,
              roleCode=roleForVolunteer.roleCode,
              volunteerCode=roleForVolunteer.volunteerCode,
              priorityLevelRoleForVolunteer=roleForVolunteer.priorityLevelRoleForVolunteer,
              volunteerPriorityLevel=roleForVolunteer.volunteerPriorityLevel
            };
        }
    }
}
