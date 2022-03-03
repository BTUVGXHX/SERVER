using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.converts
{
    public class volunteerOfferConverts
    {  
            public static VolunteerOffer convertVolunteerOfferToDAL(VolunteerOfferDTO volunteerOffer)
            {
                return new VolunteerOffer
                {
                    VolunteerOffersCode = volunteerOffer.VolunteerOffersCode,
                    VolunteerCode = volunteerOffer.VolunteerCode,
                    TotalNumberOfHoursPerWeek = volunteerOffer.TotalNumberOfHoursPerWeek,
                    flexible=volunteerOffer.flexible

                };
            }
        }
    }

