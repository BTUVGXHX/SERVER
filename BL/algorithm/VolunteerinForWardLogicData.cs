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
        public volunteeringForWard VolunteeringForWard { get; set; }
        public List<VolunteerLogicData> VolunteerLogicData { get; set; } = new List<VolunteerLogicData>();
        //מערך שיאותחל לגודל המתנדבים לפי מחלקה
        public int[] NumOfVolunteerPerWard { get; set; }

        public VolunteerinForWardLogicData(volunteeringForWard VoluForWard)
        {
            VolunteeringForWard=VoluForWard;
            Random rnd = new Random();
            //אתחול לפי מספר המתנדבים הרצוי
            NumOfVolunteerPerWard = new 
                int[VolunteeringForWard.numberVolunteersForWard];
            for (int i = 0; i < NumOfVolunteerPerWard.Length; i++)
            {

            }
        }

        public VolunteerinForWardLogicData()
        {
        }
    }

}
