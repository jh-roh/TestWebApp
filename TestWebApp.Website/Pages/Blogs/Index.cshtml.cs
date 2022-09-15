using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TestWebApp.Website.Data;
using TestWebApp.Website.Models;

namespace TestWebApp.Website.Pages.Blogs
{
    public class IndexModel : PageModel
    {
        private readonly TestWebApp.Website.Data.ApplicationDbContext _context;

        public IndexModel(TestWebApp.Website.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Blog> Blog { get;set; }

        public async Task OnGetAsync()
        {
            Blog = await _context.Blog.ToListAsync();
        }
    }
}
