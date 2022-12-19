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
        private readonly ILogger<AccountController> _logger;
        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult GetUser()
        {
            return Ok(account.testDatabase());
        }


        [HttpPost]
        public ActionResult CreateUser(string forename, string lastname, string email, string password, string adress, int age, int length, DateTime birthday)
        {
            User _user = new(forename, lastname, email, password, adress, age, length, birthday);
            return Ok(account.CreateUser(_user));
        }

        [HttpPatch]
        public ActionResult EditUser(int id)
        {
            return Ok("successfully edited user: " + id);
        }

        [HttpDelete]
        public ActionResult DeleteUser()
        {
            return Ok("succes");
        }

        [HttpGet]
        public ActionResult GetSubsriptions()
        {
            return Ok();
        }
    }
}
