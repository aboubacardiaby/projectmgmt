using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.DotNet.Scaffolding.Shared.ProjectModel;
using Microsoft.EntityFrameworkCore;
using Web.Data;
using Web.Data.Entity;

namespace Web.Pages.worker
{
    public class IndexModel : PageModel
    {
        private readonly Web.Data.ProjectContext _context;

        public IndexModel(Web.Data.ProjectContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            _context.Database.EnsureCreated();
            if (_context.Person != null)
            {
                Person = await _context.Person.ToListAsync();
            }
        }
    }
}
