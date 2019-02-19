using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using DAL;

namespace Pet.Controllers
{
    public class OrderController : ApiController
    {
        OrderBLL bll = new OrderBLL();
        [HttpPost]
        public int Create(Orders model)
        {
            return bll.Create(model);
        }
        [HttpDelete]
        public int Delete(int Id)
        {
            return bll.Delete(Id);
        }
        [HttpGet]
        public List<Orders> Index()
        {
            return bll.Index();
        }
        [HttpGet]
        public Orders FanTian(int Id)
        {
            return bll.FanTian(Id);
            
        }
        [HttpPut]
        public int Update(Orders model)
        {
            return bll.Update(model);
        }
    }
}
