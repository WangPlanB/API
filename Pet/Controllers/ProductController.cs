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
    public class ProductController : ApiController
    {
        Productbll productbll = new Productbll();
        //添加商品
        public int AddProduct(Product model)
        {
            return productbll.AddProduct(model);
        }
        //显示商品
        public List<Product> ShowProduct()
        {
            return productbll.ShowProduct();
        }
        //删除商品
        public int DelProduct(int Id)
        {
            return productbll.DelProduct(Id);
        }
        //修改商品
        public int UpdProduct(Product mo)
        {
            return productbll.UpdProduct(mo);
        }
    }
}
