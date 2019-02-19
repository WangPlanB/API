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
    public class CartController : ApiController
    {
        CartBLL bll = new CartBLL();
        [HttpPost]
        public string Add(Cart mo)
        {
            int result = bll.AddCart(mo);
            if (result > 0)
            {
                return "添加成功！";
            }
            else
            {
                return "添加失败！";
            }
        }
        [HttpDelete]
        public string Delete(int id)
        {
            int result = bll.DelCart(id);
            if (result > 0)
            {
                return "删除成功！";
            }
            else
            {
                return "删除失败！";
            }
        }
        [HttpPut]
        public string Update(Cart mo)
        {
            int result = bll.UpdCart(mo);
            if (result > 0)
            {
                return "修改成功！";
            }
            else
            {
                return "修改失败！";
            }
        }
        [HttpGet]
        public List<Cart> Show()
        {
            return bll.ShowCart();
        }
    }
}
