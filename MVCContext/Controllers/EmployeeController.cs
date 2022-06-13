using Microsoft.AspNetCore.Mvc;
using MVCContext.Models.ORM;
namespace MVCContext.Controllers
{
    public class EmployeeController:Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            return View();
        }
    }
}
