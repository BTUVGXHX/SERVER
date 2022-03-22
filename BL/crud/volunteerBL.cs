using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data.Entity;//כדי שיהיה ניתן להשתמש בנתונים גם אחרי  

namespace BL
{
    public class volunteerBL
    {
        public static void addVolunteer(volunteerDTO volunteer)
        {
            using (VolunteerPlacementSystemDBEntities1 db = new VolunteerPlacementSystemDBEntities1())
            {
                db.Volunteers.Add(converts.volunteersConvert.convertVolunteerToDAL(volunteer));
                db.SaveChanges();
            }
        }

        public static void deleteVolunteer(volunteerDTO volunteer)
        {
            using (VolunteerPlacementSystemDBEntities1 db = new VolunteerPlacementSystemDBEntities1())
            {
                db.Volunteers.Remove(converts.volunteersConvert.convertVolunteerToDAL(volunteer));
                db.SaveChanges();
            }
        }

        public static List<Volunteer> getAllVolunteers()
        {
            using (VolunteerPlacementSystemDBEntities1 db = new VolunteerPlacementSystemDBEntities1())
            {
                return db.Volunteers.Include(v => v.roleForVolunteers).Include(v => v.VolunteerOffers)
                    .Include("VolunteerOffers.daysForAVolunteers").ToList();
            }
        }

    }
}
