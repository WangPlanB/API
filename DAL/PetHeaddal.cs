using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PetHeaddal
    {
        PetStoreEntities1 petstore = new PetStoreEntities1();
        /// <summary>
        /// 添加宠物
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int AddPetHead(PetHead model)
        {
            petstore.PetHead.Add(model);
            return petstore.SaveChanges();
        }
        //显示宠物
        public List<PetHead> ShowPetHead()
        {
            return petstore.PetHead.ToList();
        }
        //删除宠物
        public int DelPetHead(int Id)
        {
            List<PetHead> a = petstore.PetHead.Where(ss => ss.PetHeadId == Id).ToList();
            petstore.PetHead.Remove(a.FirstOrDefault());
            return petstore.SaveChanges();
        }
        //修改宠物
        public int UpdPetHead(PetHead mo)
        {
            petstore.Entry(mo).State = System.Data.Entity.EntityState.Modified;
            return petstore.SaveChanges();
        }
    }
}
