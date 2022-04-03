using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data.Entity;//כדי שיהיה ניתן להשתמש בנתונים גם אחרי  
using System.Data.Entity.Migrations;

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

        public static void updateVolunteer1(volunteerDTO volunteer)
        {
            using (VolunteerPlacementSystemDBEntities1 db = new VolunteerPlacementSystemDBEntities1())
            {
                var volunteerToUpdate = db.Volunteers.Find(volunteer.VolunteerID);
                if (volunteerToUpdate != null)
                {
                    volunteerToUpdate.VolunteerFirstName = volunteer.VolunteerFirstName;
                    volunteerToUpdate.VolunteerLastName = volunteer.VolunteerLastName;
                    volunteerToUpdate.VolunteerGmail = volunteer.VolunteerGmail;
                    volunteerToUpdate.VolunteerPassword = volunteer.VolunteerPassword;
                    volunteerToUpdate.volunteerUsername = volunteer.volunteerUsername;
                    volunteerToUpdate.VolunteerPhone = volunteer.VolunteerPhone;
                    db.SaveChanges();
                }

            }
        }

        public static void UpdateVolunteer2(volunteerDTO volunteer)
        {
            using (VolunteerPlacementSystemDBEntities1 db = new VolunteerPlacementSystemDBEntities1())
            {
                db.Volunteers.AddOrUpdate(converts.volunteersConvert.convertVolunteerToDAL(volunteer));
                db.SaveChanges();
            }
        }

        public static bool CheckVolunteer(string id)
        {
            List<DAL.Volunteer> volunteer;
            using (VolunteerPlacementSystemDBEntities1 db = new VolunteerPlacementSystemDBEntities1())
            {
                volunteer = (
                    from v in db.Volunteers
                    where v.VolunteerID.Equals(id)
                    select v
                      ).ToList();
            }
            if (volunteer.Count == 1)
                return true;
            return false;
        }
    }
}
