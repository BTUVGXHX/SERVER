using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.converts
{
  public class volunteeringForWardConverts
    {
        public static volunteeringForWard volunteeringForWardConvertsToDAL(volunteeringForWardDTO volunteeringForWard)
        {
            return new volunteeringForWard
            {
                volunteeringForWardCode = volunteeringForWard.volunteeringForWardCode,
                wardCode = volunteeringForWard.wardCode,
                roleCode = volunteeringForWard.roleCode,
                numberVolunteersForWard = volunteeringForWard.numberVolunteersForWard,
                beginningTime = volunteeringForWard.beginningTime,
                endTime = volunteeringForWard.endTime
            };
        }
    }
}
