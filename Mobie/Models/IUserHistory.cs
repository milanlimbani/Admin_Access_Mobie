using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
   public interface IUserHistory
    {
        bool AddHistory(UserHistory hist);

        IEnumerable<UserHistory> GetHistoryByUserId(string Uid);
        UserHistory GetHistoryById(int hid);
        bool RemoveHistory(UserHistory hist);
    }
}
