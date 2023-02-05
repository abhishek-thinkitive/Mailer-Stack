using MailerStackWeb.Data;
using MailerStackWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace MailerStackWeb.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class RecipientsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public RecipientsController(ApplicationDbContext context)
        {
            _context= context;
        }

        //[Route("recipients")]
        [HttpPost]
        public async Task<ActionResult<Recipient>> AddRecipients([FromBody] Recipient recipient)
        {
            if (recipient == null)
            {
                return BadRequest();
            }

            try
            {
                recipient.CreatedAt= DateTime.UtcNow;
                _context.Recipient.Add(recipient);
                _context.SaveChanges();

                return CreatedAtRoute(HttpStatusCode.Created, recipient.Id);
            }
            catch(Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error creating new employee record");
            }
        
        }

        [Route("status")]
        [HttpPost]
        public async Task<ActionResult> AddRecipientsStatus()
        {
            return Ok();
        }

        //[Route("recipients")]
        [HttpGet]
        public async Task<ActionResult> GetListRecipients()
        {
            var recipients = _context.Recipient.Include(r => r.Fields).ToList();
            if (recipients == null)
            {
                return NotFound();
            }
            return Ok(recipients);
        }

        [Route("{recipientId}")]
        [HttpGet]
        public async Task<ActionResult> GetRecipientsById(int recipientId)
        {
            var recipient = _context.Recipient.Include(r => r.Fields).FirstOrDefault(r => r.Id == recipientId);

            if(recipient == null)
            {
                return NotFound();
            }
            return Ok(recipient);
        }

        [Route("pause")]
        [HttpPatch]
        public async Task<ActionResult> PauseRecipients(int recipientId)
        {
            var recipient = _context.Recipient.FirstOrDefault(r => r.Id == recipientId);
            if(recipient!= null)
            {
                recipient.IsPaused = true;
                recipient.UpdatedAt= DateTime.UtcNow;
                _context.SaveChanges();
                return Ok(recipient.Id);
            }
            else
                return NotFound();
        }

        [Route("unpause")]
        [HttpPatch]
        public async Task<ActionResult> UnpauseRecipients(int recipientId)
        {
            var recipient = _context.Recipient.FirstOrDefault(r => r.Id == recipientId);
            if (recipient != null)
            {
                recipient.IsPaused = false;
                recipient.UpdatedAt= DateTime.UtcNow;
                _context.SaveChanges();
                return Ok(recipient.Id);
            }
            else
                return NotFound();
        }

        [Route("unsubscribe")]
        [HttpPost]
        public async Task<ActionResult> UnsubscribeRecipients()
        {
            return Ok();
        }


    }
}