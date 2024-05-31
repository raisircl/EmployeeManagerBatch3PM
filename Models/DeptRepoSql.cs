
namespace EmployeeManager.Models
{
    public class DeptRepoSql : IDeptRepo
    {
        private readonly MyDbContext context;

        public DeptRepoSql(MyDbContext context)
        {
            this.context = context; //DI
        }
        public Department Add(Department department)
        {
           context.Add(department);
           context.SaveChanges();  
           return department;
        }

        public void Delete(int id)
        {
           var dept= context.Departments.FirstOrDefault(dept => dept.DepartmentId == id);
            if (dept != null) { 
               context.Departments.Remove(dept);
               context.SaveChanges();
            }
           
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
            //var dept = context.Departments.FirstOrDefault(dept => dept.DepartmentId == department.DepartmentId);
            //if (dept != null)
            //{
            //    dept.DeptName = department.DeptName;
            //    dept.Loc=department.Loc;
                
            //    context.SaveChanges();
            //}
            var dept2 = context.Departments.Attach(department);
            dept2.State=Microsoft.EntityFrameworkCore.EntityState.Modified; 
            context.SaveChanges();
            return department;  

        }
    }
}
