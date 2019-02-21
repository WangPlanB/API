using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
namespace DAL
{
    public class UsersDal
    {
        PetStoreEntities1 db = new PetStoreEntities1();
        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Add(DAL.Users model)
        {
            db.Users.Add(model);
            return db.SaveChanges();
        }
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Users Login(Users model)
        {
            var jie= db.Users.Where(m => m.UsersName == model.UsersName && m.UsersPwd == model.UsersPwd).FirstOrDefault();
            if (jie != null)
            {
                return model;
            }
            else
            {
                return null;
            }
        }
    }
}
