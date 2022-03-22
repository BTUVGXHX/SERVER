using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BL
{
  public  class roleBL
    {
        public static void addRole(roleDTO roleDTO)
        {
            using(VolunteerPlacementSystemDBEntities1 db = new VolunteerPlacementSystemDBEntities1())
            {
                db.roles.Add(converts.roleConverts.roleConvertToDAL(roleDTO));
                db.SaveChanges();
            }
        }

        public static void deleteRole(roleDTO roleDTO)
        {
            using (VolunteerPlacementSystemDBEntities1 db = new VolunteerPlacementSystemDBEntities1())
            {
                db.roles.Remove(converts.roleConverts.roleConvertToDAL(roleDTO));
                db.SaveChanges();
            }
        }

        public static List<role> getAllRoles()
        {
            using (VolunteerPlacementSystemDBEntities1 db = new VolunteerPlacementSystemDBEntities1())
            {
                return db.roles.Include(e => e.roleForVolunteers).ToList();
            }
        }

    }
}
