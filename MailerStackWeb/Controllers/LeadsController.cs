using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MailerStackWeb.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class LeadsController : ControllerBase
    {
        public LeadsController()
        {

        }

        [HttpGet]
        public ActionResult ListAll()
        {
            return Ok();
        }


        [HttpGet]
        [Route("{leadId}")]
        public ActionResult GetById(int leadId) {
            return Ok();
        }

        [HttpPost]
        public ActionResult Create()
        {
            return Ok();
        }

        [HttpPost]
        [Route("ignored")]
        public ActionResult Ignored()
        {
            return Ok();
        }

        [HttpPost]
        [Route("reopen")]
        public ActionResult Reopen()
        {
            return Ok();
        }

    }
}
