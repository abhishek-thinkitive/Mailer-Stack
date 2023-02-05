using MailerStackWeb.Data;
using MailerStackWeb.Models;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using RestSharp.Authenticators;

namespace MailerStackWeb.Controllers
{
    public class MailGunController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MailGunController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

                var result = _context.recipientDetails.ToList(); // to show thw details on view
                return View(result);
        }
        public IActionResult  SendSimpleMessage()
        {
            var details = new RecipientDetails();
            var baseUri = new Uri("https://api.mailgun.net/v3");
            RestClient client = new RestClient(baseUri);
            client.Authenticator = new HttpBasicAuthenticator("api", "e304dfd0fd3c9978dfb7afc0251c5475-69210cfc-40b84ef0");
            RestRequest request = new RestRequest();
            request.AddParameter("domain", "mg.cs2ksoftware.com", ParameterType.UrlSegment);
            request.Resource = "{domain}/messages";
            request.AddParameter("from", "User <no-reply@mg.cs2ksoftware.com>");
            foreach (var i in details.To)
                request.AddParameter("to", i);
            // request.AddParameter("to", "haridas.dhulgande@thinkitive.com");
            request.AddParameter("subject", "Introducing Our New Product Line!");
            request.AddParameter("text", "Testing some Mailgun awesomness!");
         
            //var res=  request.AddParameter("o:tracking", false);
            // Console.WriteLine(res.ToString());
            request.Method = Method.Post;
            return (IActionResult)client.Execute(request);
        }
    }
}