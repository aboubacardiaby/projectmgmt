using System.ComponentModel.DataAnnotations;

namespace Web.Data.Entity
{
    public class Person
    {
        [Key]
        public long  Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Title { get; set; }
    }
}
