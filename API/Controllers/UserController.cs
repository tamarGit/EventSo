using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL;


namespace API.Controllers
{
    public class UserController : ApiController
    {
        public BL.UserBL userBL = new BL.UserBL();
        [Route("api/User/Get")]
        [HttpGet]
        public Event Get(string userName, int code)
        {
            return userBL.
        }
    }
}
