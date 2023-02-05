using System.ComponentModel.DataAnnotations;

namespace MailerStackWeb.Dto
{
    public class Login
    {
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
