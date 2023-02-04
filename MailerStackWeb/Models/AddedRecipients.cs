using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace MailerStackWeb.Models
{
    [Keyless]
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Problems
        {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("unsubscribedEmails")]
            public List<string> UnsubscribedEmails { get; set; }

            [JsonProperty("alreadyInCampaignEmails")]
            public List<string> AlreadyInCampaignEmails { get; set; }

            [JsonProperty("passedAccountLimitEmails")]
            public List<string> PassedAccountLimitEmails { get; set; }

            [JsonProperty("hasProblems")]
            public bool HasProblems { get; set; }
        }
    [NotMapped]
        public class AddedRecipients
        {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("isFinished")]
            public bool IsFinished { get; set; }

            [JsonProperty("problems")]
            public Problems Problems { get; set; }


            [JsonProperty("createdAt")]
            public DateTime CreatedAt { get; set; }

            [JsonProperty("updatedAt")]
            public DateTime UpdatedAt { get; set; }
        }


    }

