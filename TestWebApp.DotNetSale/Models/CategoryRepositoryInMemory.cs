using System.Collections.Generic;

namespace TestWebApp.DotNetSale.Models
{
    public class CategoryRepositoryInMemory : ICategoryRepository
    {
        public List<Category> GetCategories()
        {
            var categories = new List<Category>() {
                new Category{ CategoryID = 1, CategoryName ="책" },
                new Category{ CategoryID = 2, CategoryName ="강의" },
                new Category{ CategoryID = 3, CategoryName ="컴퓨터" },
                new Category{ CategoryID = 4, CategoryName ="가전용품" },
                
            };

            return categories;
        }
    }
}
