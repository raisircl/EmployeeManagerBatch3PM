using EmployeeManager.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmployeeManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeRepo repo;

        public HomeController(ILogger<HomeController> logger, IEmployeeRepo repo)
        {
            _logger = logger;
            this.repo = repo; // di
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Employees List";
            ViewBag.No = 1001;
            List<Employee> employees=repo.GetAll();
            return View(employees);
        }
        public ViewResult Details(int id)
        {
            Employee emp = repo.Get(id);
            return View(emp);
        }
        public ViewResult Detail(int id)
        {
            Employee emp = repo.Get(id);
            return View(emp);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();  
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                repo.Add(emp);
               return  RedirectToAction("Index");
            }

            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}