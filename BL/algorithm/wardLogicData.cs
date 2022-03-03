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
        public ward Ward { get; set; }
        public List<VolunteerinFoWardLogicData>[,] Volunteers { get; set; } = new List<VolunteerinFoWardLogicData>[6,24];
       //אתחול נתוני המחלקה
        public WardLogicData()
        {

        }
    }

    public class VolunteerinFoWardLogicData
    {
        public volunteeringForWard VolunteeringForWard { get; set; }
        public int[] Volunteers { get; set; }
        public VolunteerinFoWardLogicData(volunteeringForWard VolunteeringForWard)
        {
            //
        }
    }
}
