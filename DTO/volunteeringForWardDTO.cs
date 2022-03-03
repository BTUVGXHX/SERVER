using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class volunteeringForWardDTO
    {
        public int volunteeringForWardCode { get; set; }
        public int wardCode { get; set; }
        public int roleCode { get; set; }
        public int numberVolunteersForWard { get; set; }
        public System.TimeSpan beginningTime { get; set; }
        public System.TimeSpan endTime { get; set; }
    }
}
