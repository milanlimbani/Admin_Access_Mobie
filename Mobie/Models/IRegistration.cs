using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
    public interface IRegistration
    {
        public Registration GetUserById(int id);
        public Registration GetUserByUserName(string Username);
        Registration CheckUser(Registration User);
        IEnumerable<Registration> GetAllUser();
        public bool AddUser(Registration User);
        public bool VerifyUser(Registration user);
        Registration GetUserByEmail(string email);
    }
}
