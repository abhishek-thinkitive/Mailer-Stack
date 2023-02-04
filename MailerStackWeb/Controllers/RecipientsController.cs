using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MailerStackWeb.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/v1/")]
    [ApiController]
    public class RecipientsController : ControllerBase
    {
        [Route("recipients")]
        [HttpPost]
        public async Task<ActionResult> AddRecipients()
        {
            return Ok();
        }

        [Route("recipients/status")]
        [HttpPost]
        public async Task<ActionResult> AddRecipientsStatus()
        {
            return Ok();
        }

        [Route("recipients")]
        [HttpGet]
        public async Task<ActionResult> GetListRecipients()
        {
            return Ok();
        }

        [Route("recipients/{recipients-id}")]
        [HttpGet]
        public async Task<ActionResult> GetRecipientsById(int RecipientId)
        {
            return Ok();
        }

        [Route("recipients/pause")]
        [HttpPost]
        public async Task<ActionResult> PauseRecipients()
        {
            return Ok();
        }

        [Route("recipients/unpause")]
        [HttpPost]
        public async Task<ActionResult> UnpauseRecipients()
        {
            return Ok();
        }

        [Route("recipients/unsubscribe")]
        [HttpPost]
        public async Task<ActionResult> UnsubscribeRecipients()
        {
            return Ok();
        }


    }
}
