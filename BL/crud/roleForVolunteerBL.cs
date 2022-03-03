using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class roleForVolunteerBL
    {
        //add
        public static void addRoleForVolunteer(roleForVolunteerDTO roleForVolunteer)
        {
            using (VolunteerPlacementSystemDBEntities1 db = new VolunteerPlacementSystemDBEntities1())
            {
                db.roleForVolunteers.Add(converts.roleForVolunteerConverts.convertRoleForVolunteerToDAL(roleForVolunteer));
                db.SaveChanges();
            }
        }

        //מחיקה
        public static void deleteRoleForVolunteer(roleForVolunteerDTO roleForVolunteer)
        {
            using (VolunteerPlacementSystemDBEntities1 db = new VolunteerPlacementSystemDBEntities1())
            {
                db.roleForVolunteers.Remove(converts.roleForVolunteerConverts.convertRoleForVolunteerToDAL(roleForVolunteer));
                db.SaveChanges();
            }
        }
    }
}
