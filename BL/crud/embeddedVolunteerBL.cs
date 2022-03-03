using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class embeddedVolunteerBL
    {
        public static void addEmbeddedVolunteer(embeddedVolunteerDTO embeddedVolunteer)
        {
            using (VolunteerPlacementSystemDBEntities1 db = new VolunteerPlacementSystemDBEntities1())
            {
                db.embeddedVolunteers.Add(converts.embeddedVolunteerConverts.embeddedVolunteerToDAL(embeddedVolunteer));
                db.SaveChanges();
            }
        }

        public static void deleteEmbeddedVolunteer(embeddedVolunteerDTO embeddedVolunteer)
        {
            using (VolunteerPlacementSystemDBEntities1 db = new VolunteerPlacementSystemDBEntities1())
            {
                db.embeddedVolunteers.Remove(converts.embeddedVolunteerConverts.embeddedVolunteerToDAL(embeddedVolunteer));
                db.SaveChanges();
            }
        }

    }
}
