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
        public List<VolunteerinForWardLogicData> VolunteerinForWardLogicData { get; set; }

        //אתחול נתוני המחלקה
        public WardLogicData(ward ward)
        {
            CurWard = ward;
            CurWard.volunteeringForWards = CurWard.volunteeringForWards.OrderBy(v => v.beginningTime).ToList();
            VolunteerinForWardLogicData = new List<VolunteerinForWardLogicData>();
            foreach (volunteeringForWard role in CurWard.volunteeringForWards)
            {
                VolunteerinForWardLogicData.Add(new  VolunteerinForWardLogicData(role));
            }

        }

    }
}
