using Microsoft.AspNetCore.Mvc;
using MVCContext.Models.ORM;

namespace MVCContext.Controllers
{
    public class PostController : Controller
    {
        SiemensContext siemensContext = new SiemensContext();
        [HttpGet]
        public IActionResult Add()
        {
         
            return View();
        }

        [HttpGet]
        public IActionResult PostList()
        {
            List<Post> posts = siemensContext.Posts.ToList();

            return View(posts);
        }
        [HttpPost]
        public IActionResult Add (Post post)
        {
            siemensContext.Add(post);
            siemensContext.SaveChanges();
            return View(); 
        }
    }
}
