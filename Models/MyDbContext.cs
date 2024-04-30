using Microsoft.EntityFrameworkCore;
namespace EmployeeManager.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> option):base(option)
        {
            
        }
        public DbSet<Department> Departments { get; set; }
       
    }
}
