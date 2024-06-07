using TestWepApp.BlazorApp.Data.PizzaPlace;

namespace TestWepApp.BlazorApp.Data
{
    public class ConsoleOrderService : IOrderService
    {
        public ValueTask PlaceOrder(ShoppingBasket basket)
        {
            Console.WriteLine($"Placing order for {basket.Customer.Name}");
            return new ValueTask();
        }
    }
}
