namespace WebAPI2.Models
{
    public class ProductService
    {
        public static List<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", UnitPrice = 1000, Category = new Category { Id = 1, Name = "Electronics" } },
                new Product { Id = 2, Name = "Mouse", UnitPrice = 20, Category = new Category { Id = 1, Name = "Electronics" } },
                new Product { Id = 3, Name = "Keyboard", UnitPrice = 50, Category = new Category { Id = 1, Name = "Electronics" } },
                new Product { Id = 4, Name = "Monitor", UnitPrice = 300, Category = new Category { Id = 1, Name = "Electronics" } },

            };
            return products;
        }


    }
}
