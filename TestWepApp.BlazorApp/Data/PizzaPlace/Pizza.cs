using System.Text.Json;

namespace TestWepApp.BlazorApp.Data.PizzaPlace
{
    public class Pizza
    {
        public Pizza(int id, string name, decimal price, Spiciness spiciness) 
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Spiciness = spiciness;
        }

        public int Id { get; } 
        public string Name { get; }
        public decimal Price { get; } 
        public Spiciness Spiciness { get; }
    }

    public static class DebugginExtensions
    {
        private static JsonSerializerOptions options = new JsonSerializerOptions() { WriteIndented = true };

        public static string ToJson(this object obj) => JsonSerializer.Serialize(obj, options);
    }
}
