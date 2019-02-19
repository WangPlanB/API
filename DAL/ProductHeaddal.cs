using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductHeaddal
    {
        PetStoreEntities petstore = new PetStoreEntities();
        /// <summary>
        /// 添加宠物
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int AddProductHead(ProductHead model)
        {
            petstore.ProductHead.Add(model);
            return petstore.SaveChanges();
        }
        //显示宠物
        public List<ProductHead> ShowProductHead()
        {
            return petstore.ProductHead.ToList();
        }
        //删除宠物
        public int DelProductHead(int Id)
        {
            List<ProductHead> a = petstore.ProductHead.Where(ss => ss.ProductHeadId == Id).ToList();
            petstore.ProductHead.Remove(a.FirstOrDefault());
            return petstore.SaveChanges();
        }
        //修改宠物
        public int UpdProductHead(ProductHead mo)
        {
            petstore.Entry(mo).State = System.Data.Entity.EntityState.Modified;
            return petstore.SaveChanges();
        }
    }
}
