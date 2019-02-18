using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ProductHeadbll
    {
        ProductHeaddal productHeaddal = new ProductHeaddal();
        //添加商品图片
        public int AddProductHead(ProductHead model)
        {
            return productHeaddal.AddProductHead(model);
        }
        //显示商品图片
        public List<ProductHead> ShowProductHead()
        {
            return productHeaddal.ShowProductHead();
        }
        //删除示商品图片
        public int DelProductHead(int Id)
        {
            return productHeaddal.DelProductHead(Id);
        }
        //修改示商品图片
        public int UpdProductHead(ProductHead mo)
        {
            return productHeaddal.UpdProductHead(mo);
        }
    }
}
