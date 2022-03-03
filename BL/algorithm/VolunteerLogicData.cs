using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.algorithm
{
  public class VolunteerLogicData
    {
        public Volunteer Volunteer { get; set; }
        //שעות התנדבות אפשריות למתנדב
        public int[,] OptinalHours { get; set; } = new int[6, 24];
        //תפקידים אפשריים למתנדב
        public Dictionary<int, bool> OptinalRolrs { get; set; } = new Dictionary<int, bool>();

        public VolunteerLogicData(Volunteer volunteer)
        {
            Volunteer = volunteer;

        }
      
    }
}
