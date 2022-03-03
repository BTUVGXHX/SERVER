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

        [Route ("GETabc")]
        public int GETabc()
        { 
            return 2;
        }
        

    }
}
