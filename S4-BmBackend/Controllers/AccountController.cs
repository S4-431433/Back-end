using Microsoft.AspNetCore.Mvc;
using S4_BmBackend.Logic;
using S4_BmBackend.DTO;

namespace S4_BmBackend.Controllers
{
    [ApiController]
    [Route("account/[action]")]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;
        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult GetData()
        {
            WeightProfile weightProfile = new();
            DateTime birthday = new DateTime(2002, 8, 27);
            weightProfile.CreateUser(1, "Jenson", "Jensonvangeel@gmail.com", "********", "Langstraat 59, Venlo", 20, 185, birthday);
            weightProfile.AddData(new DTO.Weight((int)3.4, (int)65.5, (int)5.6, (int)7.5, (int)74.5, 2027, (int)47.3, (int)63.5), new DTO.Goal((int)3.4, (int)65.0, (int)5.0, (int)6.8, (int)73.9, 2000, (int)49.5, (int)65.0), new DTO.PersonalTrainer(1, "Piet", 24, "Weight gain"), 1);
            return Ok(weightProfile.users[0]);
        }


        [HttpPost]
        public ActionResult Create()
        {
            WeightProfile weightProfile = new();
            DateTime birthday = new DateTime(2002, 8, 27);
            weightProfile.CreateUser(1, "Jenson", "Jensonvangeel@gmail.com", "********", "Langstraat 59, Venlo", 20, 185, birthday);
            weightProfile.AddData(new DTO.Weight((int)3.4, (int)65.5, (int)5.6, (int)7.5, (int)74.5, 2027, (int)47.3, (int)63.5), new DTO.Goal((int)3.4, (int)65.0, (int)5.0, (int)6.8, (int)73.9, 2000, (int)49.5, (int)65.0), new DTO.PersonalTrainer(1, "Piet", 24, "Weight gain"), 1);
            return Ok(weightProfile.users[0]);
        }

        [HttpPatch]
        public ActionResult Edit(int id)
        {
            return Ok("successfully edited user: " + id);
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            return Ok("succes");
        }
    }
}
