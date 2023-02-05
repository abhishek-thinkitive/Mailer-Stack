using MailerStackWeb.Models;
using Microsoft.AspNetCore.Mvc;
using RestSharp.Authenticators;
using RestSharp;
using System.Diagnostics;
using MailerStackWeb.Data;

namespace MailerStackWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public static RestResponse SendSimpleMessage()
        {
        List<string> usermails = new List<string>();
        usermails.Add("haridas.dhulgande@thinkitive.com"); // adding elements using add() method
        var baseUri = new Uri("https://api.mailgun.net/v3");
        RestClient client = new RestClient(baseUri);
        client.Authenticator = new HttpBasicAuthenticator("api", "e304dfd0fd3c9978dfb7afc0251c5475-69210cfc-40b84ef0");
        RestRequest request = new RestRequest();
        request.AddParameter("domain", "mg.cs2ksoftware.com", ParameterType.UrlSegment);
        request.Resource = "{domain}/messages";
        request.AddParameter("from", "User <no-reply@mg.cs2ksoftware.com>");
        foreach(var i in usermails)
            request.AddParameter("to", i);
       // request.AddParameter("to", "haridas.dhulgande@thinkitive.com");
        request.AddParameter("subject", "Introducing Our New Product Line!");
        request.AddParameter("text", "Testing some Mailgun awesomness!");
       //var res=  request.AddParameter("o:tracking", false);
       // Console.WriteLine(res.ToString());
        request.Method = Method.Post;
        return client.Execute(request);
    }

    }
}