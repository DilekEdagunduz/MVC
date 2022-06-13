using Microsoft.AspNetCore.Mvc;
using MVCContext.Models.ORM;
namespace MVCContext.Controllers
{
    public class BookController : Controller
    {
        SiemensContext siemensContext = new SiemensContext();   
        public IActionResult Index()
        {
            //Listeleme işlemi
            List<Book> books = siemensContext.Books.ToList();
            return View(books);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Book book)
        {
            siemensContext.Add(book);
            siemensContext.SaveChanges();
            return View();
        }

    }
}
