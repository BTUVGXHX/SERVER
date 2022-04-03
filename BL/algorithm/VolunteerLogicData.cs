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
        public Volunteer CurrentVolunteer { get; set; }
        public bool[,] OptinalHours { get; set; } = new bool[6, 24];
        public Dictionary<int, bool> OptinalRoles { get; set; } = new Dictionary<int, bool>();
        public VolunteerOffer LastOffer { get; set; }

        public VolunteerLogicData(Volunteer volunteer)
        {
            CurrentVolunteer = volunteer;

            OptinalRoles = roleBL.getAllRoles().ToDictionary
                 (r => r.roleCode, vol => CurrentVolunteer.roleForVolunteers.
                 Any(u => vol.roleCode == u.roleCode));

            LastOffer = CurrentVolunteer.VolunteerOffers.OrderByDescending
               (o => o.offersDate).FirstOrDefault();

            if (LastOffer != null)
            {
                foreach (var item in LastOffer?.daysForAVolunteers)
                {
                    for (int i = item.beginningTime; i < item.endTime; i++)
                    {
                        OptinalHours[item.dayInTheWeek, i] = true;
                    }
                }
            }

        }

        public bool VolunteerCheck(int role, int beginningTime, int endTime)
        {
            bool flag = true;

            flag = LastOffer.daysForAVolunteers.
                Any(d => d.beginningTime == beginningTime && d.endTime == endTime);

            return OptinalRoles.ContainsKey(role) && flag;
        }

    }
}
