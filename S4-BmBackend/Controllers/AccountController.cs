using Microsoft.AspNetCore.Mvc;
using S4_BmBackend.Logic;
using S4_BmBackend.DTO;
using S4_BmBackend.Data;

namespace S4_BmBackend.Controllers
{
    [ApiController]
    [Route("account/[action]")]
    public class AccountController : ControllerBase
    {
        Account account = new();
        Goal goal = new();
        private readonly ILogger<AccountController> _logger;
        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult GetUser(int id)
        {
            return Ok(account.Get(id));
        }

        [HttpGet]
        public ActionResult GetAllUsers()
        {
            return Ok(account.GetAll());
        }


        [HttpPost]
        public ActionResult CreateUser(string forename, string lastname, string email, string password, string adress, int age, int length, DateTime birthday, string active)
        {
            User _user = new(forename, lastname, email, password, adress, age, length, birthday, active);
            return Ok(account.Create(_user));
        }

        [HttpPatch]
        public ActionResult EditUser(int id, string forename, string lastname, string email, string password, string adress, int age, int length, DateTime birthday, string active)
        {
            User _user = new(forename, lastname, email, password, adress, age, length, birthday, active);
            return Ok(account.Edit(id, _user));
        }

        [HttpDelete]
        public ActionResult DeleteUser(int id)
        {
            return Ok(account.Delete(id));
        }

        [HttpGet]
        public ActionResult GetSubsriptions()
        {
            return Ok();
        }

        [HttpGet]
        public ActionResult GetActiveUsers()
        {
            return Ok(account.GetActive());
        }
    }
}
