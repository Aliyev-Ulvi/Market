


using Market.Abstract;
using Market.Concrete;

List<Product> products = new List<Product>();

List<Admin> admins = new List<Admin>();

List<Casier> casiers = new List<Casier>();

List<Seller> sellers = new List<Seller>();

List<Category> categories = new List<Category>();

List<Product> selledProducts = new List<Product>();



// Line 21-57 Default Data
{ 
    Admin admin = new() { Id = 1, FullName = "Ulvi Aliyev", UserName = "ulvi", Password = "ulvi123" };

    admins.Add(admin);
}

{
    Seller seller = new() { Id = 1, FullName = "Ferid Haqverdiyev", UserName = "ferid", Password = "ferid123" };

    sellers.Add(seller);
}

{
    Casier casier = new() { Id = 1, FullName = "Emil Bayramlı", UserName = "emil", Password = "emil123" };

    casiers.Add(casier);
}

{ 
    Category categoryOne = new() { Id = 1, Name = "Drink" };
    Category categoryTwo = new() { Id = 2, Name = "Milk" };
    Category categoryThree = new() { Id = 3, Name = "Cleaning and care" };

    categories.Add(categoryOne);
    categories.Add(categoryTwo);
    categories.Add(categoryThree);
}

{
    Product productOne = new() { Id = 1, Name = "Fanta", Price = 1, CategoryId = 1 };
    Product productTwo = new() { Id = 2, Name = "Colgate", Price = 3.5, CategoryId = 3 };
    Product productThree = new() { Id = 3, Name = "Ayran", Price = 0.9, CategoryId = 2 };

    products.Add(productOne);
    products.Add(productTwo);
    products.Add(productThree);
}



AdminManager adminManager = new();
CasierManager casierManager = new();
SellerManager sellerManager = new();

//sellerManager.SellProduct(1, products, selledProducts);
//sellerManager.SellProduct(2, products, selledProducts);
//sellerManager.SellProduct(3, products, selledProducts);
//Console.Clear();






