
namespace EmployeeManager.Models
{
    public class DeptRepo : IDeptRepo
    {
        List<Department> deptList;
        public DeptRepo()
        {
            deptList = new List<Department>()
            {
                new Department() {DepartmentId=101, DeptName="SW", Loc="PKL"},
                new Department() {DepartmentId=102, DeptName="HW", Loc="SRS"}
            };
        }
        public Department Add(Department department)
        {
            deptList.Add(department);
            return department;
        }

        public Department Delete(int id)
        {
            var dept= deptList.FirstOrDefault(x => x.DepartmentId == id);
            if (dept != null)
            {
                deptList.Remove(dept);
                return dept;
            }
            return null;
        }

        public List<Department> GetDepartments()
        {
            return deptList;
        }

        public Department GetDepartment(int id)
        {
          return deptList.FirstOrDefault(x=> x.DepartmentId==id); 
        }

        public Department Update(Department department)
        {
            var dept = deptList.FirstOrDefault(x => x.DepartmentId == department.DepartmentId);
            if (dept != null)
            {
                dept.DeptName=department.DeptName;
                dept.Loc=department.Loc;    
                return dept;
            }
            return null;
        }
    }
}
