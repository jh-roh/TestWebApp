namespace TestWepApp.BlazorApp.Data
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
    }
}
