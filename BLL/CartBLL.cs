using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class CartBLL
    {
        CartDAL dal = new CartDAL();
        //显示所有购物车信息
        public List<Cart> ShowCart()
        {
            return dal.ShowCart();
        }
        //添加购物车信息
        public int AddCart(Cart mo)
        {
            return dal.AddCart(mo);
        }
        //删除购物车信息
        public int DelCart(int Id)
        {
            return dal.DelCart(Id);
        }
        //修改购物车存储量
        public int UpdCart(Cart mo)
        {
            return dal.UpdCart(mo);
        }
    }
}
