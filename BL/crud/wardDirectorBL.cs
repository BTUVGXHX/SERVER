using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class wardDirectorBL
    {
        public static void addWardDirector(wardDirectorDTO wardDirector)
        {
            using(VolunteerPlacementSystemDBEntities1 db = new VolunteerPlacementSystemDBEntities1())
            {
                db.wardDirectors.Add(converts.wardDirectorConverts.wardDirectorConvertToDAL(wardDirector));
                db.SaveChanges();
            }
        }

        public static void deleteWardDirector(wardDirectorDTO wardDirector)
        {
            using (VolunteerPlacementSystemDBEntities1 db = new VolunteerPlacementSystemDBEntities1())
            {
                db.wardDirectors.Remove(converts.wardDirectorConverts.wardDirectorConvertToDAL(wardDirector));
                db.SaveChanges();
            }
        }

        public static void getWardDirector(string id)
        {
            using (VolunteerPlacementSystemDBEntities1 db = new VolunteerPlacementSystemDBEntities1())
            {
                wardDirector wardDirector = db.wardDirectors.Where(w => w.wardDirectorID == id).First();
                //wardDirectorDTO ward = converts.wardConverts.convertWardToDAL( wardDirector);
                db.SaveChanges();
            }
        }
    }
}
