using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMP2084_Project_Assignment.Models
{
    public class Department
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(100), MinLength(1)]
        public string Name { get; set; }
        [Required]
        [MaxLength(200), MinLength(1)]
        public string Address { get; set; }
        [Required]
        [MaxLength(6), MinLength(6)]
        public string PostalCode { get; set; }
        public ICollection<Employee>? Employees { get; set;}
    }
}
