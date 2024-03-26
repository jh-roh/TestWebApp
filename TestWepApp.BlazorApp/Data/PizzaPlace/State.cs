namespace TestWepApp.BlazorApp.Data.PizzaPlace
{
    public class State
    {
        public Menu Menu { get; set; } = new Menu();

        public ShoppingBasket Basket { get; } = new ShoppingBasket();
        public UI UI { get; set; } = new UI();
    }
}
