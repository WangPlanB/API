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
    public class PetsController : ApiController
    {
        Petbll petbll = new Petbll();
        //添加宠物
        public int AddPet(DAL.Pet model)
        {
            return petbll.AddPet(model);
        }
        //显示宠物
        public List<DAL.Pet> ShowPet()
        {
            return petbll.ShowPet();
        }
        //删除宠物
        public int DelPet(int Id)
        {
            return petbll.DelPet(Id);
        }
        //修改宠物
        public int UpdPet(DAL.Pet mo)
        {
            return petbll.UpdPet(mo);
        }
    }
}
