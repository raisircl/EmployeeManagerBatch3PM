using System.ComponentModel.DataAnnotations;

namespace EmployeeManager.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
       
        [Required(ErrorMessage ="Enter Employee Name")]
        public string? Name { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}
