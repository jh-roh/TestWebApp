using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestWebApp.Website.Models
{
    [Table("Blogs")]
    public class Blog
    {
        public int Id { get; set; }

        [DisplayName("이름")]
        public string Name { get; set; }

        public ICollection<Post> Posts { get; set; }

    }

}
