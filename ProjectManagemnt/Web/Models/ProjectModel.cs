namespace Web.Models
{
    public class ProjectModel
    {
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public DateTime ProjectStartDate { get; set; }
        public DateTime ProjectDeliveryDate { get; set; }
        public string ProjectManagerName { get; set; }
        public string DepartmentName { get; set; }

        public static List<ProjectModel> GetData()
        {
            var data = new List<ProjectModel>();
            data.Add(new ProjectModel
            {
                ProjectId = "24Do",
                ProjectName = "HR implementation",
                DepartmentName = "HR",
                ProjectDeliveryDate = DateTime.Now.AddMonths(5),
                ProjectStartDate = DateTime.Now,
                ProjectManagerName = "David Johnson"
            });
            return data;
        }
    }
}
