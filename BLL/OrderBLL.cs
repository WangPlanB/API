using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class OrderBLL
    {
        OrderDAL dal = new OrderDAL();
        public int Create(Orders model)
        {
            return dal.Create(model) ;
        }
        public int Delete(int Id)
        {
            return dal.Delete(Id);
        }
        public List<Orders> Index()
        {
            return dal.Index();
        }
        public Orders FanTian(int Id)
        {
            return dal.FanTian(Id);
                ;
        }
        public int Update(Orders model)
        {
            return dal.Update(model);
        }
    }
}
