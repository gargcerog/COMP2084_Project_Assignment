using System.ComponentModel.DataAnnotations;

namespace COMP2084_Project_Assignment.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
    }
}
