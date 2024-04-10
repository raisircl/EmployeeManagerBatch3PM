using Microsoft.AspNetCore.Mvc;

namespace EmployeeManager.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string List() { return "List() of DepartmentsController"; }
        [Route("uma")]
        public string Details() { return "Details() of DepartmentsController"; }
    }
}
