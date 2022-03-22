using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.Entity;
namespace BL
{
  public  class wardBL
    {
        public static void addWard(wardDTO ward )
        {
            using (VolunteerPlacementSystemDBEntities1 db = new VolunteerPlacementSystemDBEntities1())
            {
                db.wards.Add(converts.wardConverts.convertWardToDAL(ward));
                db.SaveChanges();
            }
        }

        public static void deleteWard(wardDTO ward)
        {
            using (VolunteerPlacementSystemDBEntities1 db = new VolunteerPlacementSystemDBEntities1())
            {
                db.wards.Remove(converts.wardConverts.convertWardToDAL(ward));
                db.SaveChanges();
            }
        }

       public static List<ward> getAllWards()
        {
            using(VolunteerPlacementSystemDBEntities1 db=new VolunteerPlacementSystemDBEntities1())
            {
                return db.wards.Include(w=>w.volunteeringForWards).ToList();
            }
        }



    }
}
