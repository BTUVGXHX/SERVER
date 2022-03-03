using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.converts
{
   public static class wardConverts
    {
        public static ward convertWardToDAL(wardDTO ward)
        {
            return new ward
            {
                wardCode = ward.wardCode,
                wardName = ward.wardName
        };
        }
    }
}
