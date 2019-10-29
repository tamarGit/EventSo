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

    }
}
