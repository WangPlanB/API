using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class OrderMessageBLL
    {
        OrderMessageDAL dal = new OrderMessageDAL();

        public int Create(OrderMassage model)
        {
            return dal.Create(model);
        }
        public int Delete(int Id)
        {
            return dal.Delete(Id);
        }
        public List<OrderMassage> Index()
        {
            return dal.Index();
        }
        public OrderMassage FanTian(int Id)
        {
            return dal.FanTian(Id);
        }
        public int Update(OrderMassage model)
        {
            return dal.Update(model);
        }
    }
}
