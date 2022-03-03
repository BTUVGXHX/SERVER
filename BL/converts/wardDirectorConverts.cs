using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.converts
{
   public class wardDirectorConverts
    {
        public static wardDirector wardDirectorConvertToDAL(wardDirectorDTO wardDirector)
        {
            return new wardDirector
            {
                 wardDirectorCode= wardDirector.wardDirectorCode,
                 wardDirectorID= wardDirector.wardDirectorID,
                 wardDirectorFirstName= wardDirector.wardDirectorFirstName,
                 wardDirectorLastName= wardDirector.wardDirectorLastName,
                 wardDirectorPassword= wardDirector.wardDirectorPassword,
                 wardDirectorUsername= wardDirector.wardDirectorUsername,
                 wardCode= wardDirector.wardCode

            };
        }
    }
}
