using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BL.algorithm
{
    public class VolunteerLogicData
    {
        public Volunteer Volunteer { get; set; }

        //שעות התנדבות אפשריות למתנדב
        public bool[,] OptinalHours { get; set; } = new bool[6, 24];

        //תפקידים אפשריים למתנדב
        public Dictionary<int, bool> OptinalRoles { get; set; } = new Dictionary<int, bool>();


        public VolunteerLogicData(Volunteer volunteer)
        {
            Volunteer = volunteer;

            OptinalRoles = roleBL.getAllRoles().ToDictionary
                 (r => r.roleCode, vol => Volunteer.roleForVolunteers.
                 Any(u => vol.roleCode == u.roleCode));

            var lastOffer = Volunteer.VolunteerOffers.OrderByDescending
                (o => o.offersDate).FirstOrDefault();

            //???  האם לאתחל כל פעם מחדש
            //int? j = lastOffer?.TotalNumberOfHoursPerWeek;//Number Of Hours Per Week
            if (lastOffer != null)
            {
                foreach (var item in lastOffer?.daysForAVolunteers)
                {
                    for (int i = item.beginningTime; i < item.endTime; i++)
                    {
                        OptinalHours[item.dayInTheWeek, i] = true;
                    }
                }
            }

        }

    }
}
