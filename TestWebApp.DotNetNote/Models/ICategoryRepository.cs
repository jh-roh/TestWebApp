using System.Collections.Generic;

namespace TestWebApp.DotNetNote.Models
{
    public interface ICategoryRepository
    {
        List<Category> GetCategories();
    }
}