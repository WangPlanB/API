using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class CartDAL
    {
        PetStoreEntities1 context = new PetStoreEntities1();
        //显示所有购物车信息
        public List<Cart> ShowCart()
        {
            return context.Cart.ToList();
        }
        //添加购物车信息
        public int AddCart(Cart mo)
        {
            context.Cart.Add(mo);
            return context.SaveChanges();
        }
        //删除购物车信息
        public int DelCart(int Id)
        {
            List<Cart> a = context.Cart.Where(ss => ss.ProductId == Id).ToList();
            context.Cart.Remove(a.FirstOrDefault());
            return context.SaveChanges();
        }
        //修改购物车存储量
        public int UpdCart(Cart mo)
        {
            context.Entry(mo).State = System.Data.Entity.EntityState.Modified;
            return context.SaveChanges();
        }


    }
}
