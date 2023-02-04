using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MailerStackWeb.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class PushesController : ControllerBase
    {
        [Route("pushes/create")]
        [HttpPost]
        public async Task<ActionResult> CreatePushes()
        {
            return Ok();
        }
        [Route("pushes/delete")]
        [HttpPost]
        public async Task<ActionResult> DeletePushes()
        {
            return Ok();
        }
    }
}
