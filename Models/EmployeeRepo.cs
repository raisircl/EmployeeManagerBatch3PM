namespace EmployeeManager.Models
{
    public class EmployeeRepo : IEmployeeRepo
    {
        List<Employee> _employees;  
        public EmployeeRepo() { 
            _employees = new List<Employee>()
            {

                new Employee() { EmployeeId = 100, Name = "Ram", Department = new Department(){ DepartmentId=1, DeptName="SW", Loc="SW" } },
                new Employee() { EmployeeId = 101, Name = "Abhi", Department = new Department() },
                new Employee() { EmployeeId = 102, Name = "Iqbal", Department = new Department() },
                new Employee() { EmployeeId = 103, Name = "Mohit", Department =new Department() }
            };
            

        }
        public void Add(Employee employee)
        {
           _employees.Add(employee);
        }

        public void Delete(int id)
        {
            Employee? emp = _employees.FirstOrDefault(e => e.EmployeeId == id);
            if(emp != null)
            {
                _employees.Remove(emp); 
            }
        }

        public Employee? Get(int id)
        {
            //LINQ
            Employee? emp = _employees.FirstOrDefault(e => e.EmployeeId == id);
            return emp;
        }

        public List<Employee> GetAll()
        {
           return _employees;
        }

        public void Update( Employee employee)
        {
            Employee? emp = _employees.FirstOrDefault(e => e.EmployeeId == employee.EmployeeId);
            if( emp != null ) 
            { 
                emp.Name = employee.Name;   
                emp.Department=employee.Department;
            }
        }
    }
}
