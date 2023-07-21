using System.ComponentModel.DataAnnotations;

namespace TestWepApp.BlazorApp.Models.Buffets
{
    /// <summary>
    /// 국수
    /// </summary>
    public class Noodle
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(25)]
        public string? Name { get; set; }
        
        public int? BrothId { get; set; }   

        public Broth? Broth { get; set; }
    }
}
