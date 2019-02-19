using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderMessageDAL
    {
        PetStoreEntities Pet = new PetStoreEntities();
        public int Create(OrderMassage model)
        {
            Pet.OrderMassage.Add(model);
            return Pet.SaveChanges();
        }
        public int Delete(int Id)
        {
            var Del = (from s in Pet.OrderMassage where s.Id == Id select s).FirstOrDefault();
            Pet.OrderMassage.Remove(Del);
            return Pet.SaveChanges();
        }
        public List<OrderMassage> Index()
        {
            var list = from s in Pet.OrderMassage select s;
            return list.ToList();
        }
        public OrderMassage FanTian(int Id)
        {
            var list = (from s in Pet.OrderMassage where s.Id == Id select s).FirstOrDefault();
            return list;
        }
        public int Update(OrderMassage model)
        {
            Pet.Entry(model).State = System.Data.Entity.EntityState.Modified;
            return Pet.SaveChanges();
        }
    }
}
