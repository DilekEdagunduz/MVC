using Microsoft.AspNetCore.Mvc;
using MVCContext.Models.ORM;

namespace MVCContext.Controllers
{
    public class HomeController : Controller
    {
        SiemensContext siemensContext = new SiemensContext();
        [HttpGet]
        public IActionResult Index()
        {
           List<Suppliers> suppliers = siemensContext.Suppliers.ToList();


            return View(suppliers);
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {

            var idSup = siemensContext.Suppliers.FirstOrDefault(q => q.Id == id);

            return View(idSup);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Suppliers suppliers)
        {
            siemensContext.Add(suppliers);
            siemensContext.SaveChanges();
            return View();
        }
     
        public IActionResult Products()
        {
            var productlist=siemensContext.Products.ToList();
            return View(productlist);
        }

        [HttpGet]
        public IActionResult AddProducts()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProducts(Products product)
        {
            siemensContext.Add(product);
            siemensContext.SaveChanges();
            return View();
        }
        [HttpPost]
        public IActionResult UpdateProduct(Products product)
        {
            siemensContext.Update(product);
            siemensContext.SaveChanges();
            return View();
        }

    }
}
