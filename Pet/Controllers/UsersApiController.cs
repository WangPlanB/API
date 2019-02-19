using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using MODEL;
using DAL;
namespace Pet.Controllers
{
    public class UsersApiController : ApiController
    {
        UsersBll bll = new UsersBll();
        [HttpPost]
        public int Add(Users model)
        {
            return bll.Add(model);
        }
        [HttpGet]
        public Users Login(Users model)
        {
            return bll.Login(model);
        }
    }
}
