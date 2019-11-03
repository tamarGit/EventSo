using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL;
using DTO;

namespace API.Controllers
{
    public class EventController : ApiController
    {
<<<<<<< HEAD
        public BL.EventBl eventBl= new BL.EventBl();
        [Route("api/Event/GetEvents/{code}/{status}")]
        [HttpGet]
        public IHttpActionResult GetEvents(int code,int status)
        {
            return Ok(eventBl.GetEvents(code,status));
        }
        [Route("api/Event/CreateEvent")]
        [HttpGet]
        public IHttpActionResult CreateEvent(EventDTO eventDTO)
        {           
            return Ok(eventBl.CreateEvent(eventDTO));       
        }
=======
        [HttpGet]
        public void get()
        {
>>>>>>> 7f4f067de578a7d56266091087d1b0305551e3cf

        }
    }
}
