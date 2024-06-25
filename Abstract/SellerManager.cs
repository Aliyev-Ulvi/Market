using Market.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Abstract
{
    internal class SellerManager
    {
        public void SellProduct(int id, List<Product> products, List<Product> selledProducts)
        {
            foreach (Product product in products) 
            { 
                if (product.Id == id) 
                { 
                    selledProducts.Add(product);

                    Console.WriteLine($"{product.Name} selled succesfully");

                    break;
                }
            }
        }
    }
}
