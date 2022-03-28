using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.algorithm
{
    public class VolunteerinForWardLogicData
    {
        public List<VolunteerLogicData> VolunteerLogicData { get; set; } = new List<VolunteerLogicData>();
        public List<int> VolunteersIndexesPerHours { get; set; } = new List<int>();
        public volunteeringForWard VolunteeringForWard { get; set; }
        public List<VolunteeringHour> VolunteeringHours { get; set; }

        
        public List<int> AllVolunteersForRole
        {
            get
            {
                var volunteers = new List<int>();
                VolunteeringHours.ForEach(h => volunteers.AddRange(h.Volunteers));
                return volunteers.Distinct().ToList();
            }
        }


        public VolunteerinForWardLogicData(volunteeringForWard VoluForWard)
        {
            
            VolunteerLogicData = volunteerBL.getAllVolunteers().Select(v => new VolunteerLogicData(v)).ToList();

            VolunteeringForWard = VoluForWard;
            VolunteeringHours = new List<VolunteeringHour>();
          
            for (int day = 1; day <= 6; day++)
            {
                for (int hour = 0; hour < 24; hour++)
                {
                   
                    int[] volunteers = GenerateVolunteers(VoluForWard.numberVolunteersForWard);
                    VolunteeringHours.Add(new VolunteeringHour() { Day = day, Hour = hour, Volunteers = volunteers });
                }
            }


        }

        private int[] GenerateVolunteers(int numberVolunteersForWard)
        {
            var volunteers = new int[numberVolunteersForWard];
            int m;
            Random rnd = new Random();
            for (int i = 0; i < numberVolunteersForWard; i++)
            {
                m = rnd.Next(0, VolunteerLogicData.Count);
                volunteers[i] = VolunteerLogicData.ElementAt(m).Volunteer.VolunteerCode;
            }
            return volunteers;
        }

      
    }

}
