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
    public class OrderMessageController : ApiController
    {
        OrderMessageBLL bll = new OrderMessageBLL();
        [HttpPost]
        public int Create(OrderMassage model)
        {
            return bll.Create(model);
        }
        [HttpDelete]
        public int Delete(int Id)
        {
            return bll.Delete(Id);
        }
        [HttpGet]
        public List<OrderMassage> Index()
        {
            return bll.Index();
        }
        [HttpGet]
        public OrderMassage FanTian(int Id)
        {
            return bll.FanTian(Id);
        }
        [HttpPut]
        public int Update(OrderMassage model)
        {
            return bll.Update(model);
        }
    }
}
