using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class PetHeadbll
    {
        PetHeaddal pethreddal = new PetHeaddal();
        //添加宠物图片
        public int AddPetHead(PetHead model)
        {
            return pethreddal.AddPetHead(model);
        }
        //显示宠物图片
        public List<PetHead> ShowPetHead()
        {
            return pethreddal.ShowPetHead();
        }
        //删除宠物图片
        public int DelPetHead(int Id)
        {
            return pethreddal.DelPetHead(Id);
        }
        //修改宠物图片
        public int UpdPetHead(PetHead mo)
        {
            return pethreddal.UpdPetHead(mo);
        }
    }
}
