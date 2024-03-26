namespace TestWepApp.BlazorApp.Data.PizzaPlace
{
    public class ShoppingBasket
    {
        public Customer Customer { get; set; } = new Customer();
        public List<int> Orders { get; set; } = new List<int>();

        public bool HasPaid { get; set; }
    }
}
