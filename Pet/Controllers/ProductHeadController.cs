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
    public class ProductHeadController : ApiController
    {
        ProductHeadbll productHeadbll = new ProductHeadbll();
        //添加商品图片
        public int AddProductHead(ProductHead model)
        {
            return productHeadbll.AddProductHead(model);
        }
        //显示商品图片
        public List<ProductHead> ShowProductHead()
        {
            return productHeadbll.ShowProductHead();
        }
        //删除示商品图片
        public int DelProductHead(int Id)
        {
            return productHeadbll.DelProductHead(Id);
        }
        //修改示商品图片
        public int UpdProductHead(ProductHead mo)
        {
            return productHeadbll.UpdProductHead(mo);
        }
    }
}
