using TestWepApp.BlazorApp.Data.PizzaPlace;

namespace TestWepApp.BlazorApp.Data
{
    public interface IOrderService
    {
        ValueTask PlaceOrder(ShoppingBasket basket);
    }
}
