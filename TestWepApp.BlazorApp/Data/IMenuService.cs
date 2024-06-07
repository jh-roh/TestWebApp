using TestWepApp.BlazorApp.Data.PizzaPlace;

namespace TestWepApp.BlazorApp.Data
{
    public interface IMenuService
    {
        ValueTask<Menu> GetMenu();
    }
}
