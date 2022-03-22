using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL.algorithm
{
    public class WardLogicData
    {
        //public List<ward> allWards { get; set; }
        public ward CurWard { get; set; }
        //מתנדבים לכל מחלקה
        public List<VolunteerinForWardLogicData>[,] VolunteersForTheWard { get; set; }
            = new List<VolunteerinForWardLogicData>[6, 24];

        //אתחול נתוני המחלקה
        public WardLogicData(ward ward)
        {
            CurWard = ward;
            CurWard.volunteeringForWards = CurWard.volunteeringForWards.OrderBy(v => v.beginningTime).ToList();

            for (int i = 0; i < 6; i++)
            {
                foreach (var item in CurWard.volunteeringForWards)
                {
                    for (int j = item.beginningTime; j < item.endTime; j++)
                    {
                        VolunteersForTheWard[i, j] = new List<VolunteerinForWardLogicData>();
                        VolunteersForTheWard[i, j].Add(new VolunteerinForWardLogicData(item));
                    }
                }
            }

        }

    }
}
