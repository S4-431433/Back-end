using Microsoft.AspNetCore.Mvc;
using S4_BmBackend.DTO;
using S4_BmBackend.Logic;

namespace S4_BmBackend.Controllers
{
    [ApiController]
    [Route("test/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;
        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Test1()
        {
            TestLogic testLogic = new();
            testLogic.Data(1, 1, -0.42773437500000, 0.89672851562500, 0.58691406250000);

            return Ok(testLogic.testdata[0]);
        }
    }
}
