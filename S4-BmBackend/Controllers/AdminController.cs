using Microsoft.AspNetCore.Mvc;
using S4_BmBackend.Logic;
using S4_BmBackend.DTO;
using S4_BmBackend.Data;

namespace S4_BmBackend.Controllers
{
    [ApiController]
    [Route("admin/[action]")]
    public class AdminController : ControllerBase
    {
        AdminLogic adminLogic = new();
        private readonly ILogger<AdminController> _logger;
        public AdminController(ILogger<AdminController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult GetTopData()
        {
            return Ok(adminLogic.GetData());
        }
    }
}
