using Microsoft.DotNet.Scaffolding.Shared.ProjectModel;

namespace TestWepApp.BlazorApp.Data
{
    public class HardCodedProductsService : IProductService
    {
        public IEnumerable<Product> GetProducts()
        {
            yield return new Product
            {
                Name = "Isabelle's Homemade Marmelade",
                Description = "...",
                Price = 1.99M
            };

            yield return new Product
            {
                Name = "Liesbeth's Applecake",
                Description = "...",
                Price = 3.99M
            };

        }
    }

    public class ProductsService
    {
        private readonly Dependency dep;
        public ProductsService(Dependency dep)
        {
            this.dep = dep;
        }
    }
    
}
