using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class UsersBll
    {
        UsersDal dal = new UsersDal();
        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Add(Users model)

        {
            return dal.Add(model);
        }
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Users Login(Users model)
        {
            return dal.Login(model);
        }
    }
}
