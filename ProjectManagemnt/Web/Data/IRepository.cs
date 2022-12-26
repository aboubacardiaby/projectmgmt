namespace Web.Data
{
    public interface IRepository
    {
        void Save(Project project);
         Task<IList<Project>> GetAll();
    }
}
