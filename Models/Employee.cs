using System.ComponentModel.DataAnnotations;

namespace EmployeeManager.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Department { get; set; }
    }
}
