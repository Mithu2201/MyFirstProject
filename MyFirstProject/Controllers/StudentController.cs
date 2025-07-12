using Microsoft.AspNetCore.Mvc;
using MyFirstProject.Data;
using MyFirstProject.Models;

namespace MyFirstProject.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDBContext dbContext;

        public StudentController(ApplicationDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
