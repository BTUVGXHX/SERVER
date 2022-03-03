using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
namespace BL
{
   public class daysForAVolunteerBL
    {
        public static void addDaysForAVolunteer(daysForAVolunteerDTO daysFor)
        {
            using (VolunteerPlacementSystemDBEntities1 db = new VolunteerPlacementSystemDBEntities1())
            {
                db.daysForAVolunteers.Add(converts.daysForAVolunteerConverts.daysForAVolunteerConvertsToDal(daysFor));
                db.SaveChanges();
            }
        }

        public static void deleteDaysForAVolunteer(daysForAVolunteerDTO daysFor)
        {
            using (VolunteerPlacementSystemDBEntities1 db = new VolunteerPlacementSystemDBEntities1())
            {
                db.daysForAVolunteers.Remove(converts.daysForAVolunteerConverts.daysForAVolunteerConvertsToDal(daysFor));
                db.SaveChanges();
            }
        }

        public static void updateDaysForAVolunteer(daysForAVolunteerDTO daysFor)
        {
            using (VolunteerPlacementSystemDBEntities1 db = new VolunteerPlacementSystemDBEntities1())
            {
                daysForAVolunteer  d = db.daysForAVolunteers.First( f => f.daysForAVolunteerCode == daysFor.daysForAVolunteerCode);
               
                db.SaveChanges();
            }
        }
    }
}
