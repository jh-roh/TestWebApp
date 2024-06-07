using TestWepApp.BlazorApp.Data.PizzaPlace;

namespace TestWepApp.BlazorApp.Data
{
    public class HardCodedMenuService : IMenuService
    {
        public ValueTask<Menu> GetMenu()
         => new ValueTask<Menu>(
         new Menu
         {
             Pizzas = new List<Pizza> {
             new Pizza(1, "Pepperoni", 8.99M, Spiciness.Spicy),
             new Pizza(2, "Margarita", 7.99M, Spiciness.None),
             new Pizza(3, "Diabolo", 9.99M, Spiciness.Hot),
             new Pizza(4, "Hawaiian", 10.99M, Spiciness.None),
             new Pizza(5, "BBQ Chicken", 11.99M, Spiciness.Mild),
             new Pizza(6, "Vegetarian", 9.99M, Spiciness.None),
             new Pizza(7, "Supreme", 12.99M, Spiciness.Medium),
             new Pizza(8, "Meat Lovers", 13.99M, Spiciness.Hot),
             new Pizza(9, "Seafood", 14.99M, Spiciness.Mild),
             new Pizza(10, "Buffalo Chicken", 11.99M, Spiciness.Spicy)
         }
         });
    }
}
