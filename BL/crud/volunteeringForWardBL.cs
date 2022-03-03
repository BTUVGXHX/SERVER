using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
  public  class volunteeringForWardBL
    {
        public static void addVolunteeringForWar(volunteeringForWardDTO volunteeringForWard)
        {
            using(VolunteerPlacementSystemDBEntities1 db =new VolunteerPlacementSystemDBEntities1())
            {
                db.volunteeringForWards.Add(converts.volunteeringForWardConverts.volunteeringForWardConvertsToDAL(volunteeringForWard));
                db.SaveChanges();
            }
        }


        public static void deleteVolunteeringForWar(volunteeringForWardDTO volunteeringForWard)
        {
            using (VolunteerPlacementSystemDBEntities1 db = new VolunteerPlacementSystemDBEntities1())
            {
                db.volunteeringForWards.Remove(converts.volunteeringForWardConverts.volunteeringForWardConvertsToDAL(volunteeringForWard));
                db.SaveChanges();
            }
        }
    }
}
