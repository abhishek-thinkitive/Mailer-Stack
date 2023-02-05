using MailerStackWeb.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MailerStackWeb.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class LeadsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LeadsController(ApplicationDbContext context)
        {   
            _context= context;
        }

        [HttpGet]
        public ActionResult ListAll()
        {
            var leads = _context.CreatedLeads.ToList();
            return Ok(leads);
        }


        [HttpGet]
        [Route("{leadId}")]
        public ActionResult GetById(int leadId) {
            var lead = _context.CreatedLeads.FirstOrDefault(l => l.Id== leadId);
            return Ok(lead);
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
