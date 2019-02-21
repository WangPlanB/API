using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
namespace DAL
{
    
    public class OrderDAL
    {
        PetStoreEntities1 Pet = new PetStoreEntities1();
        public int Create(Orders model)
        {
            Pet.Orders.Add(model);
            return Pet.SaveChanges();
        }
        public int Delete(int Id)
        {
            var Del = (from s in Pet.Orders where s.OrdersId == Id select s).FirstOrDefault();
            Pet.Orders.Remove(Del);
            return Pet.SaveChanges();
        }
        public List<Orders> Index()
        {
            var list = from s in Pet.Orders select s;
            return list.ToList();
        }
        public Orders FanTian(int Id)
        {
            var list = (from s in Pet.Orders where s.OrdersId == Id select s).FirstOrDefault();
            return list;
        }
        public int Update(Orders model)
        {
            Pet.Entry(model).State = System.Data.Entity.EntityState.Modified;
            return Pet.SaveChanges();
        }
    }
}
