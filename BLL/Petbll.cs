using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Petbll
    {
        Petdal petdal = new Petdal();
        //添加宠物
        public int AddPet(Pet model)
        {
            return petdal.AddPet(model);
        }
        //显示宠物
        public List<Pet> ShowPet()
        {
            return petdal.ShowPet();
        }
        //删除宠物
        public int DelPet(int Id)
        {
            return petdal.DelPet(Id);
        }
        //修改宠物
        public int UpdPet(Pet mo)
        {
            return petdal.UpdPet(mo);
        }
    }
}
