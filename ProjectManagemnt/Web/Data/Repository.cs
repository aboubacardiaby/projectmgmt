using Microsoft.EntityFrameworkCore;

namespace Web.Data
{
    public class Repository : IRepository
    {

        private readonly ProjectContext _projectContext;
       public Repository(ProjectContext projectContext) { 
         _projectContext= projectContext;
        }
        public async Task<IList<Project>> GetAll()
        {
          _projectContext.Database.EnsureCreated();
            return await _projectContext.Project.ToListAsync();
        }

        public void Save(Project project)
        {
           _projectContext.Project.Add(project);
            _projectContext.SaveChanges();
        }
    }
}
