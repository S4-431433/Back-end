using Microsoft.AspNetCore.Mvc;
using S4_BmBackend.Logic;

namespace S4_BmBackend.Controllers
{
    [ApiController]
    [Route("pt/[action]")]
    public class PersonalTrainerController : ControllerBase
    {
        private readonly ILogger<PersonalTrainerController> _logger;
        public PersonalTrainerController(ILogger<PersonalTrainerController> logger)
        {
            _logger = logger;
        }
        PtLogic ptLogic = new();

        [HttpGet]
        public ActionResult GetTrainer()
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult CreateTrainer(int id, string name, int age, string department, string email, string number)
        {
            ptLogic.CreateTrainer(id, name, age, department, email, number);
            return Ok();
        }

        [HttpPatch]
        public ActionResult UpdateTrainer(int id, string name, int age, string department, string email, string number)
        {
            ptLogic.UpdateTrainer(id, name, age, department, email, number);
            return Ok();
        }

        [HttpDelete]
        public ActionResult DeleteTrainer()
        {
            return Ok("succes");
        }
    }
}
