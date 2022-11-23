using Microsoft.AspNetCore.Mvc;

namespace S4_BmBackend.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
