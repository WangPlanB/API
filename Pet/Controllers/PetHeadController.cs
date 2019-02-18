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
    public class PetHeadController : ApiController
    {
         PetHeadbll petheadbll = new PetHeadbll();
        //添加宠物图片
        public int AddPetHead(PetHead model)
        {
            return petheadbll.AddPetHead(model);
        }
        //显示宠物图片
        public List<PetHead> ShowPetHead()
        {
            return petheadbll.ShowPetHead();
        }
        //删除宠物图片
        public int DelPetHead(int Id)
        {
            return petheadbll.DelPetHead(Id);
        }
        //修改宠物图片
        public int UpdPetHead(PetHead mo)
        {
            return petheadbll.UpdPetHead(mo);
        }
    }
}
