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

        public List<WardLogicData> WardLogicData { get; set; } = new List<WardLogicData>();

        public InitialPopulation()
        {
            //מאתחל לכל מחלקה מערך כגודל מספר המתנדבים הרצוי לשעה
            WardLogicData = wardBL.getAllWards().Select(w => new WardLogicData(w)).ToList();
       
         
        }
    }
}




