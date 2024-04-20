using System.ComponentModel.DataAnnotations;

namespace TestWepApp.BlazorApp.Data.PizzaPlace
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please provide a name")]
        public string Name { get; set; } = default!;

        [Required(ErrorMessage = "Please provide a street with house number.")]
        public string Street { get; set; } = default!;

        [Required(ErrorMessage = "Please provide a city")]

        public string City { get; set; } = default!;
    }
}
