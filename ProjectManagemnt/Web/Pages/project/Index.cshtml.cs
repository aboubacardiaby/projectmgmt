using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web.Data;
using Web.Models;

namespace Web.Pages.project
{
    public class IndexModel : PageModel
    {
         private readonly IRepository _repository;
       // private readonly ProjectContext _repository;
        public IndexModel(IRepository repository)
        {
            this._repository = repository;
        }
        List<ProjectModel> projectmodelss  =new List<ProjectModel>();
        //public ActionResult OnGetAsync()
        //{
        //    _repository.Database.EnsureCreated();

        //    var projects = _repository.Project.ToList();

        //    foreach (var item in projects)
        //    {
        //        projectmodelss.Add(new ProjectModel()
        //        {
        //            DepartmentName = item.DepartmentName,
        //            ProjectDeliveryDate = item.ProjectDeliveryDate,
        //            ProjectId = item.ProjectId,
        //            ProjectManagerName = item.ProjectManagerName,
        //            ProjectName = item.ProjectName,
        //            ProjectStartDate = item.ProjectStartDate,
        //        });
        //    }
        //    return Page();
        //}
        public async Task<IActionResult> OnGetAsync()
        {
            
            var projects = await _repository.GetAll();

            foreach (var item in projects)
            {
                projectmodelss.Add(new ProjectModel()
                {
                    DepartmentName = item.DepartmentName,
                    ProjectDeliveryDate = item.ProjectDeliveryDate,
                    ProjectId = item.ProjectId,
                    ProjectManagerName = item.ProjectManagerName,
                    ProjectName = item.ProjectName,
                    ProjectStartDate = item.ProjectStartDate,
                });
            }
            return Page();
        }
    }
}
