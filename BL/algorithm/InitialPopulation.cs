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

        public List<volunteeringForWard> AllVolunteerings { get; set; }
        public VolunteerLogicData MyProperty { get; set; }
     
        public int Size { get; set; } = 0;
        public ScheduleOption[] ArrayOfChromosomes { get; set; } = new ScheduleOption[1000];

        public InitialPopulation()
        {
            
            AllVolunteerings = wardBL.getAllWards().SelectMany(v => v.volunteeringForWards).ToList();
          
            foreach (var item in AllVolunteerings)
            {
                Size += item.numberVolunteersForWard;
            }

            for (int i = 0; i < ArrayOfChromosomes.Length; i++)
            {
                ArrayOfChromosomes[i] = new ScheduleOption(AllVolunteerings,Size);
            }
        }
    }
}




