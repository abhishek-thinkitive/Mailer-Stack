using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MailerStackWeb.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        public ActivityController()
        {

        }

        [HttpPost]
        [Route("sent")]
        public ActionResult Sent()
        {
            return Ok();
        }

        [HttpPost]
        [Route("opens")]
        public ActionResult Opens()
        {
            return Ok();
        }

        [HttpPost]
        [Route("replies")]
        public ActionResult Replies()
        {
            return Ok();
        }

        [HttpPost]
        [Route("clicks")]
        public ActionResult Clicks()
        {
            return Ok();
        }

        [HttpPost]
        [Route("created-leads")]
        public ActionResult CreatedLeads()
        {
            return Ok();
        }

        [HttpPost]
        [Route("lead-status-change")]
        public ActionResult LeadStatusChanges()
        {
            return Ok();
        }

    }
}
