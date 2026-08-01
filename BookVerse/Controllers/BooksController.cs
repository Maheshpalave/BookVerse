using Microsoft.AspNetCore.Mvc;

namespace BookVerse.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
