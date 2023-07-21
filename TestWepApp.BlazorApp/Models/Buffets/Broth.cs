using System.ComponentModel.DataAnnotations;

namespace TestWepApp.BlazorApp.Models.Buffets
{
    /// <summary>
    /// 국물
    /// </summary>
    public class Broth
    {
        //속성 초기화자
        public int Id { get; set; } = 0;

        [Required]
        [StringLength(25)]
        public string? Name { get; set; }

        public bool IsVegan { get; set; }

        public List<Noodle> Noodles { get; set; } = new List<Noodle>();

    }
}
