using Microsoft.EntityFrameworkCore;
using Web.Data.Entity;

namespace Web.Data
{
    public class ProjectContext:DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {

        }
        public DbSet<Project> Project { get; set; }
        public DbSet<Person> Person { get; set; }
    }
}
