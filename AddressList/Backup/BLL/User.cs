using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class User
    {
        IDAL.IUser user =DALFactory.DataAccess.CreateUser();
        public bool Login(string userName, string userPassword)
        {
            return user.Login(userName, Common.MD5Provider.Hash(userPassword));
        }
        public bool Update(Model.User model)
        {
            model.Password=Common.MD5Provider.Hash(model.Password);
            return user.Update(model);
        }
    }
}
