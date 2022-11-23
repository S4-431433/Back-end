using Microsoft.AspNetCore.Mvc;
using S4_BmBackend.DTO;
using S4_BmBackend.Logic;

namespace S4_BmBackend.Controllers
{
    [ApiController]
    [Route("test2/[controller]")]
    public class Test2Controller : ControllerBase
    {
        private readonly ILogger<TestController> _logger;
        public Test2Controller(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Test2()
        {
            TestLogic testLogic = new();
            testLogic.Data(1, 1, -0.42773437500000, -0.3346755542, 0.9826375428);

            return Ok(testLogic.testdata[0]);
        }
    }
}
