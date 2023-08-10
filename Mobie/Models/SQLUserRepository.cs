using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
    public class SQLUserRepository : IRegistration
    {
        private AppDbContext _registration;
        public SQLUserRepository(AppDbContext context)
        {
            _registration = context;
        }
        public bool AddUser(Registration User)
        {
            Registration isDuplicate = _registration.Registrations.FirstOrDefault(each => each.Email.ToLower() == User.Email.ToLower());
            if (isDuplicate == null)
            {
                _registration.Add(User);
                _registration.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Registration GetUserByEmail(string email)
        {
        
     
            Registration user = _registration.Registrations.FirstOrDefault(u => u.Email == email);

       
            return user;
        }

        public Registration GetUserById(int id)
        {
            Registration user = _registration.Registrations.FirstOrDefault(u => u.Id == id);
            return user;
        }

        public Registration GetUserByUserName(string Username)
        {
            throw new NotImplementedException();
        }

        public bool VerifyUser(Registration User)
        {
            Registration user = _registration.Registrations.FirstOrDefault(c => c.Email == User.Email && c.Password == User.Password);

            if (user == null)
            {
                return false;
            }

            return true;
        }

        public Registration CheckUser(Registration User)
        {
            Registration user = _registration.Registrations.FirstOrDefault(c => c.Email == User.Email && c.Password == User.Password);

            return user;
        }
        public IEnumerable<Registration> GetAllUser()
        {
            return _registration.Registrations;
        }


    }
}
