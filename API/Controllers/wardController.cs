using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BL;
using BL.algorithm;

namespace API.Controllers
{
    // נוסיף בכל הקונטרולרים
    [EnableCors("*","*","*")]
    [RoutePrefix("api/ward")]

    public class wardController : ApiController
    {
        //     /{}   כשצריכים לקבל פרמטר נוסיף 
        [Route ("GETa")]

        // IHttpActionResult- החזרת סטטוס הבקשה
        public IHttpActionResult GETa()
        {
            // BadRequest - ססטוס שגיאה
            // QK()- סטטוס של הצלחה
            return BadRequest();
        }


        [Route("GETb/{areaID}")]
        public int GETb(int areaID)
        {
            return areaID;
        }

        [Route("addWard") ,HttpPost]
        public void addWard(wardDTO ward) {
            BL.wardBL.addWard(ward);
        }

        [Route("addVolunteer"), HttpPost]
        public IHttpActionResult addVolunteer(volunteerDTO volunteer)
        {
            BL.volunteerBL.addVolunteer(volunteer);
            return Ok(true);
        }

        [Route("GETabc")]
        public int GETabc()
        {
            
            InitialPopulation v = new InitialPopulation();
            return 2;
        }

        [Route("GetAllVolunteers")]
        public List<volunteerDTO> GetAllVolunteers()
        {
         return volunteerBL.getAllVolunteers().Select(v => BL.converts.volunteersConvert.convertVolunteerToDTO(v)).ToList(); ;
        }
    }
}
