using Kendo.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kendo.BAL.Abstract
{
    public interface IUserService
    {
        List<User> GetListBl();
        bool UserAddBl(User user);
        bool UserLogin(User user);
    }
}
