using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.converts
{
  public  class volunteersConvert
    {
        public static Volunteer convertVolunteerToDAL(volunteerDTO volunteer)
        {
            return new Volunteer
            {
                VolunteerCode = volunteer.VolunteerCode,
                VolunteerID = volunteer.VolunteerID,
                VolunteerFirstName = volunteer.VolunteerFirstName,
                VolunteerLastName = volunteer.VolunteerLastName,
                VolunteerDateOfBirth = volunteer.VolunteerDateOfBirth,
                VolunteerPhone = volunteer.VolunteerPhone,
                VolunteerAddress = volunteer.VolunteerAddress,
                VolunteerGmail=volunteer.VolunteerGmail,
                VolunteerPassword=volunteer.VolunteerPassword,
                volunteerUsername=volunteer.volunteerUsername
            };
        }
    }
}
