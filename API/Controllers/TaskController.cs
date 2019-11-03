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
        [Route("api/Task/CreateTask")]
        [HttpGet]
        public IHttpActionResult CreateTask(TaskDTO taskDTO)
        {
            return Ok(taskBL.CreateTask(taskDTO));
        }
        [Route("api/Task/GetTasks")]
        [HttpGet]
        public IHttpActionResult GetTasks(int eventCode)
        {
            return Ok(taskBL.GetTasks(eventCode));
        }
        [Route("api/Task/CreateSubTask")]
        [HttpGet]
        public IHttpActionResult CreateSubTask(SubTaskDTO subTaskDTO)
        {
            return Ok(taskBL.CreateSubTask(subTaskDTO));
        }
        [Route("api/Task/GetSubTasks")]
        [HttpGet]
        public IHttpActionResult GetSubTasks(int taskCode)
        {
            return Ok(taskBL.GetSubTasks(taskCode));
        }
    }
}
