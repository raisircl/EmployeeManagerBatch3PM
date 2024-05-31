namespace EmployeeManager.Models
{
    public interface IDeptRepo
    {
       List<Department> GetDepartments();
       Department GetDepartment(int id);
       Department Add(Department department);  
       Department Update(Department department);
       void Delete(int id);


    }
}
