using Microsoft.AspNetCore.Mvc;
using S4_BmBackend.Logic;
using S4_BmBackend.Data;

namespace S4_BmBackend.Controllers
{
    [ApiController]
    [Route("goal/[action]")]

    public class GoalController : ControllerBase
    {
        Goal goal = new();
        private readonly ILogger<GoalController> _logger;
        public GoalController(ILogger<GoalController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Retrieve(int id)
        {
            return Ok(goal.Get(id));
        }

        [HttpGet]
        public ActionResult Calculate(double fat, double fluid, double mass)
        {
            WeightLogic weightLogic = new();
            return Ok("fat = " + weightLogic.CalculatePercentage(mass, fat) + "% & fluid = " + weightLogic.CalculatePercentage(mass, fluid) + "%");
        }

        [HttpPost]
        public ActionResult Create(int bones, int muscle, int fat, int fatPercentage, int mass, int bMR, int fluid, int fluidPercentage)
        {
            return Ok();
        }

        [HttpPatch]
        public ActionResult Edit(int bones, int muscle, int fat, int fatPercentage, int mass, int bMR, int fluid, int fluidPercentage)
        {
            return Ok();
        }
    }
}
