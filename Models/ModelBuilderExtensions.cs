using Microsoft.EntityFrameworkCore;

namespace EmployeeManager.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<Employee>().HasData(
                   new Employee()
                   { EmployeeId = 1001, Name = "Ram", DepartmentId = 1 }
                   );
        }
    }
}
