using Microsoft.AspNetCore.Mvc;
using MVCContext.Models.ORM;

namespace MVCContext.Controllers
{
    public class RestaurantController : Controller
    {
        SiemensContext siemensContext =new SiemensContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Restaurant restaurant)
        {
            siemensContext.Add(restaurant);
            siemensContext.SaveChanges();
            return RedirectToAction("List"); // Yönlendirme yapar kaydettikten sonra listeleme sayfasına gider
        }

        [HttpGet]
        public IActionResult List()
        {
            var reslist= siemensContext.Restaurants.ToList();   
            return View(reslist);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var resupd = siemensContext.Restaurants.FirstOrDefault(x => x.Id == id);
            return View(resupd);
        }

        [HttpPost]
        public IActionResult Update(Restaurant restaurant)
        {
            siemensContext.Update(restaurant);
            siemensContext.SaveChanges();
            return RedirectToAction("List");
        }
   

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var resdel = siemensContext.Restaurants.FirstOrDefault(q => q.Id == id);
            siemensContext.Remove(resdel);
            siemensContext.SaveChanges();

            return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Delete()
        {

            return RedirectToAction("List");
        }
    }
}
