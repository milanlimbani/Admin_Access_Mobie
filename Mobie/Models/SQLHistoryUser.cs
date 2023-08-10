using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
    public class SQLHistoryUser : IUserHistory
    {
        private AppDbContext _history;
        public SQLHistoryUser(AppDbContext context)
        {
            _history = context;
        }

        public bool AddHistory(UserHistory hist)
        {
            var history = _history.UserHistorie.Any(h=>h.ProductName==hist.ProductName);
            if(history==false)
            {
                var userHistory = _history.UserHistorie.Where(h => h.UserId == hist.UserId).ToList();
                if (userHistory.Count >= 5)
                {
                    var oldestHist = userHistory.OrderBy(h => h.Id).First();
                    _history.Remove(oldestHist);
                }

                _history.Add(hist);
                _history.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<UserHistory> GetHistoryByUserId(string Uid)
        {
            return _history.UserHistorie.Where(s => s.UserId == Uid).ToList();
        }

        public UserHistory GetHistoryById(int hid)
        {
            return _history.UserHistorie.SingleOrDefault(each => each.Id == hid);
        }

        public bool RemoveHistory(UserHistory hist)
        {
            UserHistory isDuplicate = _history.UserHistorie.FirstOrDefault(each => each.Id == hist.Id);
            if (isDuplicate != null)
            {
                _history.Remove(hist);
                _history.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
