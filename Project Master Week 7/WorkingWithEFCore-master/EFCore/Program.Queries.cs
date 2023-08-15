using EFCore;
using Microsoft.EntityFrameworkCore;
namespace ProgramEFCore;

partial class Program
{
    static void QueryingCategories()
    {
        using (Northwind db = new())
        {
            SectionTitle("Querying Categories and Products");

            IQueryable<Category>? categories = db.Categories?
                .Include(c => c.Products);

            if ((categories == null) || (!categories.Any()))
            {
                Fail("No Categories Found");
                return;
            }
            Info($"ToQueryString: {categories.ToQueryString()}"); //Print SQL command
            foreach (Category? c in categories)
            {
                Printer($"Category: {c.CategoryName} has {c.Products.Count} products.");
            }
        }
    }

    static void FilteredIncludes()
    {
        using (Northwind db = new())
        {
            SectionTitle("Filtered Includes");
            string? input;
            int stock;

            do
            {
                Printer("Enter a product stock level: ");
                input = GetInput();
            } while (!int.TryParse(input, out stock));

            IQueryable<Category>? categories = db.Categories?
                .Include(c => c.Products.Where(p => p.Stock >= stock));

            if ((categories == null) || (!categories.Any()))
            {
                Fail("No Categories Found");
                return;
            }
            Info($"ToQueryString: {categories.ToQueryString()}");
            foreach (Category? c in categories)
            {
                Info($"Category: {c.CategoryName} has {c.Products.Count} products with minimum {stock}.");

                foreach (Product? p in c.Products)
                {
                    Printer($"\t{p.ProductName} has {p.Stock} in stock.");
                }
            }
        }
    }

    static void QueryingProducts()
    {
        using (Northwind db = new())
        {
            SectionTitle("Products that cost more than a price, highest at top.");

            string? input;
            decimal price;
            do
            {
                Printer("Enter a product price: ");
                input = GetInput();
            } while (!decimal.TryParse(input, out price));

            IQueryable<Product>? products = db.Products?
                .Where(product => product.Cost > price)
                .OrderByDescending(product => product.Cost);

            if ((products is null) || (!products.Any()))
            {
                Fail("No products found.");
                return;
            }
            Info($"ToQueryString: {products.ToQueryString()}");
            foreach (Product p in products)
            {
                Printer($"{p.ProductId}: {p.ProductName} costs {p.Cost:$#,##0.00} and has {p.Stock} in stock.");
            }
        }
    }
}
