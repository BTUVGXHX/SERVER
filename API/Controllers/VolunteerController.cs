using BL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/volunteer")]
    public class volunteerController : ApiController
    {

        [Route("CheckVolunteer"), HttpPost]
        public IHttpActionResult CheckVolunteer([FromBody] string id)
        {
            return Ok(volunteerBL.CheckVolunteer(id));
        }

        [Route("GETa")]

        // IHttpActionResult- החזרת סטטוס הבקשה
        public IHttpActionResult GETa()
        {
            // BadRequest - ססטוס שגיאה
            // QK()- סטטוס של הצלחה
            return BadRequest();
        }



        [Route("GetAllVolunteers")]
        public List<volunteerDTO> GetAllVolunteers()
        {
            return volunteerBL.getAllVolunteers().Select(v => BL.converts.volunteersConvert.convertVolunteerToDTO(v)).ToList(); ;
        }

        [Route("addVolunteer"), HttpPost]
        public IHttpActionResult addVolunteer(volunteerDTO volunteer)
        {
            BL.volunteerBL.addVolunteer(volunteer);
            return Ok(true);
        }

    }
}
