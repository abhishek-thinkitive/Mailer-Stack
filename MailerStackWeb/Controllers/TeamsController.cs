using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MailerStackWeb.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/v1")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        public TeamsController()
        {

        }

        [HttpGet]
        [Route("{teamId}")]
        public ActionResult GetAllMembersOfTeam(int teamId)
        {
            return Ok();
        }
    }
}
