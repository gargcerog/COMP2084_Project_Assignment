using System.ComponentModel.DataAnnotations;

namespace COMP2084_Project_Assignment.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Employee>? Employees { get; set;}
    }
}
