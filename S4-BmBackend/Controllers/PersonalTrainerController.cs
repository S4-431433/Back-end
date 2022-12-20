using Microsoft.AspNetCore.Mvc;
using S4_BmBackend.Logic;
using S4_BmBackend.Data;
using S4_BmBackend.DTO;

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
        Trainer trainer = new();

        [HttpGet]
        public ActionResult Get(int id)
        {
            return Ok(trainer.Get(id));
        }

        [HttpPost]
        public ActionResult Create(string name, int age, string department, string email, string number)
        {
            PersonalTrainer _trainer = new(name, age, department, email, number);
            return Ok(trainer.Create(_trainer));
        }

        [HttpPatch]
        public ActionResult Update(int id, string name, int age, string department, string email, string number)
        {
            PersonalTrainer _trainer = new(name, age, department, email, number);
            return Ok(trainer.Update(id, _trainer));
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            return Ok(trainer.Delete(id));
        }
    }
}
