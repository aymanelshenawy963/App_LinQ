using App_LinQ.Data;

namespace App_LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();

            ////Retrieve all categories from the production.categories table.
            //var categories = dbContext.Categories.ToList();
            //foreach (var item in categories)
            //{
            //    Console.WriteLine($"Id: {item.CategoryId}, Name: {item.CategoryName}");
            //}

            ////Retrieve the first product from the production.products table.
            //try
            //{
            //    var products = dbContext.Products.First();
            //    Console.WriteLine($"Id: {products.ProductId}, Name: {products.ProductName}, Model Year: {products.ModelYear}, List Price: {products.ListPrice}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("No items");
            //}

            ////Retrieve a specific product from the production.products table by ID.
            //var product = dbContext.Products.FirstOrDefault(e => e.ProductId == 2);
            // Console.WriteLine($"Id: {product.ProductId}, Name: {product.ProductName}, Model Year: {product.ModelYear}, List Price: {product.ListPrice}");

            ////Retrieve all products from the production.products table with a certain model year.
            //var products = dbContext.Products.Where(p => p.ModelYear == 2016).ToList();
            //foreach (var item in products)
            //{
            //    Console.WriteLine($"Id: {item.ProductId}, Name: {item.ProductName}, Model Year: {item.ModelYear}, List Price: {item.ListPrice}");
            //}

            ////Retrieve a specific customer from the sales.customers table by ID.
            //var customer = dbContext.Customers.FirstOrDefault(p => p.CustomerId == 4);
            //Console.WriteLine($"Id: {customer.CustomerId}, Name: {customer.FirstName} {customer.LastName}, Email: {customer.Email}");

            ////Retrieve a list of product names and their corresponding brand names.
            //var products = dbContext.Products.Include(e => e.Brand).Select(p=> new {p.ProductName,p.ProductId, BrandName = p.Brand.BrandName }).ToList();
            //foreach (var item in products)
            //{
            //    Console.WriteLine($"Id: {item.ProductId}, Name: {item.ProductName}, Brand Name: {item.BrandName}");
            //}

            ////Count the number of products in a specific category.
            // var NumOfProduct = dbContext.Products.Where(e=>e.CategoryId==5).Count();
            //Console.WriteLine(NumOfProduct);

            ////Calculate the total list price of all products in a specific category.
            //var SumOfproduct = dbContext.Products.Where(e=>e.CategoryId==5).Sum(e => e.ListPrice);
            //Console.WriteLine(SumOfproduct);

            ////Calculate the average list price of products.
            //var AverOfproduct = dbContext.Products.Where(e => e.CategoryId == 5).Average(e => e.ListPrice);
            //Console.WriteLine(AverOfproduct);

            //Retrieve orders that are completed.
            var orders = dbContext.Orders.Where(o => o.OrderStatus == 3).ToList();
            foreach (var item in orders)
            {
                Console.WriteLine($"Id: {item.OrderId}, Stause: {item.OrderStatus}, Data: {item.OrderDate}");
            }
        }
    }
}
