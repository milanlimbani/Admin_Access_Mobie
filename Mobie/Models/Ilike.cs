using MobileShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sell.Models
{
    public interface Ilike
    {
        bool AddLike(Like likes);

        IEnumerable<Like> GetLikesByUserId(string Uid);
        Like GetLikeById(int lid);
        bool RemoveLike(Like liked);
    }
}
