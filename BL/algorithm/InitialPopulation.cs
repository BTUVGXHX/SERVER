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
        //
        public List<VolunteerLogicData> volunteers { get; set; } = new List<VolunteerLogicData>();
        public InitialPopulation()
        {
            //מאתחל לכל מתנדב את השעות והתפקידים האפשריים 
            volunteers = volunteerBL.getAllVolunteers().Select(v => new VolunteerLogicData(v)).ToList();



        }

      
    }
}
   

