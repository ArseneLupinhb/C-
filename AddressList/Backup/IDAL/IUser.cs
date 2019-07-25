using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDAL
{
    public interface IUser
    {
        bool Login(string userName, string userPassword);
        bool Update(Model.User model);
    }
}
