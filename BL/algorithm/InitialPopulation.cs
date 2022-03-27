using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using DAL;

namespace BL.algorithm
{
    public class InitialPopulation
    {

        public List<VolunteerLogicData> VolunteerLogicData { get; set; } = new List<VolunteerLogicData>();
        public List<WardLogicData> WardLogicData { get; set; } = new List<WardLogicData>();

        public InitialPopulation()
        {

            //מאתחל לכל מתנדב את השעות והתפקידים האפשריים 
            //  VolunteerLogicData = volunteerBL.getAllVolunteers().Select(v => new VolunteerLogicData(v)).ToList();

            //מאתחל לכל מחלקה מערך כגודל מספר המתנדבים הרצוי לשעה
            WardLogicData = wardBL.getAllWards().Select(w => new WardLogicData(w)).ToList();

            int m;
            Random rnd = new Random();
            for (int i = 0; i < WardLogicData.Count; i++)
            {
                for (int j = 0; j < WardLogicData[i].VolunteersForTheWard.Length; j++)
                {
                    var current = WardLogicData[i].VolunteersForTheWard;
                    for (int k = 0; k < 6; k++)
                    {
                        for (int t = 0; t < 24; t++)
                        {
                            foreach (var item in current[k, t])
                            {
                                for (int o = 0; o < item.NumOfVolunteerPerWard.Length; o++)
                                {
                                    m = rnd.Next(0, VolunteerLogicData.Count);
                                    item.NumOfVolunteerPerWard[o] = VolunteerLogicData.ElementAt(m).Volunteer.VolunteerCode;
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}




