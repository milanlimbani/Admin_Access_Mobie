using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
   public interface IProduct
    {
        public Product GetProductById(int id);
        public IEnumerable<Product> GetAllProduct();
        public bool AddProduct(Product e);
        public bool UpdateProduct(Product e);
        bool RemoveProduct(Product prod);
        Product GetProductbyCatId(int id);
        IEnumerable<Product> GetProductBySubCatId(int Sid);
        public bool CheckUpdateUnique(string name, int catId, int prodId);
        public bool CheckInsertUnique(string name, int catId);
    }
}
