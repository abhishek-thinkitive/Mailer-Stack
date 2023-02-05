using MailerStackWeb.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MailerStackWeb.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TeamsController(ApplicationDbContext context)
        {
            _context= context;
        }

        [HttpGet]
        [Route("{teamId}")]
        public ActionResult GetAllMembersOfTeam(int teamId)
        {
            var team = _context.Team.FirstOrDefault(t => t.Id== teamId);
            return Ok(team);
        }
    }
}
