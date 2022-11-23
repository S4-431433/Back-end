using Microsoft.AspNetCore.Mvc;

namespace S4_BmBackend.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
