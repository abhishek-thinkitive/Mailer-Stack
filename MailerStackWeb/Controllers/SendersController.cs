using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MailerStackWeb.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class SendersController : ControllerBase
    {
        [Route("senders")]
        [HttpGet]
        public async Task<ActionResult> GetListSenders()
        {
            return Ok();
        }
    }
}
