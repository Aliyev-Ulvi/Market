using Market.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Abstract
{
    internal class CasierManager : IUserService
    {
        public void AddProduct(Product product, List<Product> products)
        {
            Console.WriteLine($"{product.Name} has been added succesfully.");

            products.Add(product);
        }

        public void Update(int id, List<Product> products)
        {
            foreach (Product product in products)
            {
                if (product.Id == id)
                {
                    Console.WriteLine($"{product.Name} updated succesfullfy");

                    product.Name = "";
                    product.Price = 0;
                    product.CategoryId = 0;

                    break;
                }
            }
        }

        public void Delete(int id, List<Product> products)
        {
            foreach (Product product in products)
            {
                if (product.Id == id)
                {
                    products.Remove(product);

                    Console.WriteLine($"{product.Name} deleted succesfullfy");

                    break;
                }
            }
        }

        public void GetAllProducts(List<Product> products)
        {
            foreach (Product product in products)
            {
                Console.WriteLine($"\n-----------------------\nID: {product.Id} \n-----------------------" +
                    $"\nProduct: {product.Name} " +
                    $"\nPrice: {product.Price} " +
                    $"\nCategory: {product.CategoryId}");
            }
        }

        public void GetByCategory(int categoryId, List<Product> products)
        {
            foreach (Product product in products)
            {
                if (product.CategoryId == categoryId)
                {
                    Console.WriteLine($"\n-----------------------\nID: {product.Id} \n-----------------------" +
                   $"\nProduct: {product.Name} " +
                   $"\nPrice: {product.Price} " +
                   $"\nCategory: {product.CategoryId}");
                }
            }
        }

        public void GetById(int id, List<Product> products)
        {
            foreach (Product product in products)
            {
                if (product.Id == id)
                {
                    Console.WriteLine($"\n-----------------------\nID: {product.Id} \n-----------------------" +
                   $"\nProduct: {product.Name} " +
                   $"\nPrice: {product.Price} " +
                   $"\nCategory: {product.CategoryId}");
                }
            }
        }



        public void CancelSelling(int id, List<Product> selledProducts)
        {
            foreach (Product product in selledProducts)
            { 
                if (product.Id == id)
                {
                    selledProducts.Remove(product);

                    Console.WriteLine($"Selling was cancelled succesfully");
                }
            }
        }
    }
}
