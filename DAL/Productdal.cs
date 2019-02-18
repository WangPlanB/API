using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Productdal
    {
        PetStoreEntities petstore = new PetStoreEntities();
        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int AddProduct(Product model)
        {
            petstore.Product.Add(model);
            return petstore.SaveChanges();
        }
        //显示商品
        public List<Product> ShowProduct()
        {
            return petstore.Product.ToList();
        }
        //删除商品
        public int DelProduct(int Id)
        {
            List<Product> a = petstore.Product.Where(ss => ss.ProductId == Id).ToList();
            petstore.Product.Remove(a.FirstOrDefault());
            return petstore.SaveChanges();
        }
        //修改商品
        public int UpdProduct(Product mo)
        {
            petstore.Entry(mo).State = System.Data.Entity.EntityState.Modified;
            return petstore.SaveChanges();
        }
    }
}
