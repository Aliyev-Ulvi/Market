using Market.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Abstract
{
    internal interface IUserService
    {
        void AddProduct(Product product, List<Product> products);

        void Update(int id, List<Product> products);

        void Delete(int id, List<Product> products);

        void GetAllProducts(List<Product> products);

        void GetById(int id, List<Product> products);

        void GetByCategory(int categoryId, List<Product> products);
    }
}
