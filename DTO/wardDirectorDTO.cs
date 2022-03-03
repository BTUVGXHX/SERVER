using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class wardDirectorDTO
    {
        public int wardDirectorCode { get; set; }
        public string wardDirectorID { get; set; }
        public string wardDirectorFirstName { get; set; }
        public string wardDirectorLastName { get; set; }
        public string wardDirectorPassword { get; set; }
        public string wardDirectorUsername { get; set; }
        public int wardCode { get; set; }
    }
}
