using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Productbll
    {
        Productdal productdal = new Productdal();
        //添加商品
        public int AddProduct(Product model)
        {
            return productdal.AddProduct(model);
        }
        //显示商品
        public List<Product> ShowProduct()
        {
            return productdal.ShowProduct();
        }
        //删除商品
        public int DelProduct(int Id)
        {
            return productdal.DelProduct(Id);
        }
        //修改商品
        public int UpdProduct(Product mo)
        {
            return productdal.UpdProduct(mo);
        }
    }
}
