using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
  public  class volunteerOfferBL
    {
        public static void addVolunteerOffer(VolunteerOfferDTO volunteerOffer)
        {
            using (VolunteerPlacementSystemDBEntities1 db = new VolunteerPlacementSystemDBEntities1())
            {
                db.VolunteerOffers.Add(converts.volunteerOfferConverts.convertVolunteerOfferToDAL(volunteerOffer));
                db.SaveChanges();
            }
        }

        public static void deleteVolunteerOffer(VolunteerOfferDTO volunteerOffer)
        {
            using (VolunteerPlacementSystemDBEntities1 db = new VolunteerPlacementSystemDBEntities1())
            {
                db.VolunteerOffers.Remove(converts.volunteerOfferConverts.convertVolunteerOfferToDAL(volunteerOffer));
                db.SaveChanges();
            }
        }
    }
}
