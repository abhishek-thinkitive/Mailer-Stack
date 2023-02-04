using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MailerStackWeb.Controllers
{
    [Route("api/v1")]
    //[Route("api/v1/[controller]")]
    [ApiController]
    public class CampaignsController : ControllerBase
    {
        [Route("campaigns")]
        [HttpGet]
        public async Task<ActionResult> GetListCampaigns()
        { 
            return Ok();
        }

        [Route("campaigns/{campaign-id}")]
        [HttpGet]
        public async Task<ActionResult> GetCampaignsById(int CampaignId)
        { 
            return Ok();
        }

        [Route("campaigns")]
        [HttpPost]
        public async Task<ActionResult> CreateCampaigns()
        {
            return Ok();
        }

        [Route("campaigns/pause")]
        [HttpPost]
        public async Task<ActionResult> PauseCampaigns()
        {
            return Ok();
        }

        [Route("campaigns/unpause")]
        [HttpPost]
        public async Task<ActionResult> UnpauseCampaigns()
        {
            return Ok();
        }

        // Below Two Api Status:Pending
        [Route("campaigns/export")]
        [HttpPost]
        public async Task<ActionResult> ExportCampaigns()
        {
            return Ok();
        }

        [Route("campaigns/export/status")]
        [HttpGet]
        public async Task<ActionResult> ExportCampaignsStatus()
        {
            return Ok();
        }


    }
}
