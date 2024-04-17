using EmployeeManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManager.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly IDeptRepo deptRepo;

        public DepartmentsController(IDeptRepo deptRepo)
        {
            this.deptRepo = deptRepo; //DI
        }
        public IActionResult Index()
        {
            List<Department> departments =  deptRepo.GetDepartments();
            return View(departments);
        }

        public IActionResult Edit(int id) 
        {

            var dept = deptRepo.GetDepartment(id);
            return View(dept);  
        }
        [HttpPost]
        public IActionResult Update(Department department)
        {

            var dept = deptRepo.Update(department);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Add()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Add(Department department)
        {

            var dept = deptRepo.Add(department);
            return RedirectToAction("Index");
        }
        public ViewResult Details(int id) 
        {
            var dept = deptRepo.GetDepartment(id);
            return View(dept);
        }
        public IActionResult Delete(int id)
        {
            var dept = deptRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
