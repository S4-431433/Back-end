using Microsoft.AspNetCore.Mvc;
using S4_BmBackend.Data;

namespace S4_BmBackend.Controllers
{
    [ApiController]
    [Route("product/[action]")]
    public class ProductController : ControllerBase
    {
        private readonly Product product = new();
        private readonly ILogger<ProductController> _logger;
        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult GetProduct(int id)
        {
            return Ok(product.Get(id));
        }

        [HttpGet]
        public ActionResult GetAllProduct()
        {
            return Ok(product.GetAll());
        }
    }
}
