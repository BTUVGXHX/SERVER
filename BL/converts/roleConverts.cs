using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.converts
{
    public class roleConverts
    {
        public static role roleConvertToDAL(roleDTO roleDTO)
        {
            return new role
            {
                roleCode=roleDTO.roleCode,
                roleDescription=roleDTO.roleDescription,
                roleName=roleDTO.roleName
            };
        }
    }
}
