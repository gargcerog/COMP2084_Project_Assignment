using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMP2084_Project_Assignment.Models
{
    public class Employee
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(100), MinLength(1)]
        public string Name { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage ="Username Cannot be longer than 20 chars"), MinLength(1)]
        public string UserName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        [Range(18, 100)]
        public int Age { get; set; }

        [NotMapped]
        public string CompositeDetail 
        {
            get { return $"{Name}-{UserName}-{PhoneNumber}-{Age}"; }
        }

        [ForeignKey("Department")]
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }




    }
}
