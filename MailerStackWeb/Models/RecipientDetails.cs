using System.ComponentModel.DataAnnotations;

namespace MailerStackWeb.Models
{
    public class RecipientDetails
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string To { get; set; }
        [Required]
        public string From { get; set; }
        [Required]
        [MaxLength(100)]
        public string Subject { get; set; }
        [Required]
        [MaxLength(50)]
        public string Message { get; set; }
    }
}