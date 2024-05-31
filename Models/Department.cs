using System.ComponentModel.DataAnnotations;

namespace EmployeeManager.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        [Required(ErrorMessage="Department is required")]
        public string? DeptName { get; set; }
        public string? Loc { get; set; }
        public DateTime Addon { get; set; } = DateTime.Now;
    }
}
