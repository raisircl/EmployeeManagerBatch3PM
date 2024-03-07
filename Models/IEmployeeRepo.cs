namespace EmployeeManager.Models
{
    public interface IEmployeeRepo
    {
        void Add(Employee employee);    
        List<Employee> GetAll();
        Employee? Get(int id);
        void Delete(int id);    
        void Update(Employee employee); 

    }
}
