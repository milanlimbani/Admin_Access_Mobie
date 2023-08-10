using sell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
    public class SQLLikes : Ilike
    {
        private AppDbContext _likes;
        public SQLLikes(AppDbContext context)
        {
            _likes = context;
        }
        public bool AddLike(Like like)
        {
            Like isDuplicate = _likes.like.FirstOrDefault(each => each.ProId == like.ProId && each.UserId == like.UserId);
            if (isDuplicate == null)
            {
                _likes.Add(like);
                _likes.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<Like> GetLikesByUserId(string Uid)
        {
            List<Like> like = _likes.like.Where(s => s.UserId == Uid).ToList();
            return like;
        }

        public bool RemoveLike(Like liked)
        {
            Like isDuplicate = _likes.like.FirstOrDefault(each => each.Id == liked.Id);
            if (isDuplicate != null)
            {
                _likes.Remove(liked);
                _likes.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Like GetLikeById(int Lid)
        {
            return _likes.like.SingleOrDefault(each => each.Id == Lid);
        }
    }
}
