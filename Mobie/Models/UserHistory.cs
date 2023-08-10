using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
    public class UserHistory
    {
        public int ProId { get; set; }
        public int Id { get; set; }
        public string UserId { get; set; }

        public string ProductName { get; set; }
    }
}
