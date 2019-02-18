using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
namespace DAL
{
    public class Petdal
    {
        PetStoreEntities petstore = new PetStoreEntities();
        /// <summary>
        /// 添加宠物
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int AddPet(Pet  model)
        {
            petstore.Pet.Add(model);
            return petstore.SaveChanges();
        }
        //显示宠物
        public List<Pet> ShowPet()
        {
            return petstore.Pet.ToList();
        }
        //删除宠物
        public int DelPet(int Id)
        {
            List<Pet> a = petstore.Pet.Where(ss => ss.PetId == Id).ToList();
            petstore.Pet.Remove(a.FirstOrDefault());
            return petstore.SaveChanges();
        }
        //修改宠物
        public int UpdPet(Pet mo)
        {
            petstore.Entry(mo).State = System.Data.Entity.EntityState.Modified;
            return petstore.SaveChanges();
        }
    }
}
