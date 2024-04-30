
namespace EmployeeManager.Models
{
    public class DeptRepoSql : IDeptRepo
    {
        private readonly MyDbContext context;

        public DeptRepoSql(MyDbContext context)
        {
            this.context = context;
        }
        public Department Add(Department department)
        {
           context.Add(department);
           context.SaveChanges();  
           return department;
        }

        public Department Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Department GetDepartment(int id)
        {
            return context.Departments.FirstOrDefault(dept => dept.DepartmentId == id);
        }

        public List<Department> GetDepartments()
        {
            return context.Departments.ToList();    
        }

        public Department Update(Department department)
        {
            throw new NotImplementedException();
        }
    }
}
