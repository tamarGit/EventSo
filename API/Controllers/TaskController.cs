using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;
using BL;

namespace API.Controllers
{
    public class TaskController : ApiController
    {
        public BL.TaskBL taskBL = new BL.TaskBL();
        [Route("api/Task/AddTask")]
        [HttpGet]
        public IHttpActionResult CreateEvent(TaskDTO taskDTO)
        {
            return Ok(taskBL.CreateEvent(taskDTO));
        }
    }
}
