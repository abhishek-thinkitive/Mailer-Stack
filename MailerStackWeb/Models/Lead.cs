using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace MailerStackWeb.Models
{
   
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Recipients
        {
        
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("recipientID")]
            public int RecipientID { get; set; }

            [JsonProperty("leadID")]
            public int LeadID { get; set; }
        }
       [Keyless]
        public class Lead
        {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("leads")]
            public List<Recipients> Leads { get; set; }

            [JsonProperty("emailsNotFound")]
            public List<string> EmailsNotFound { get; set; }

            [JsonProperty("invalidEmails")]
            public List<string> InvalidEmails { get; set; }

        
        [JsonProperty("recipientIDsNotFound")]
            
            public List<int> RecipientIDsNotFound { get; set; }

            [JsonProperty("isEmpty")]
            public bool IsEmpty { get; set; }

            [JsonProperty("created")]
            public DateTime Created { get; set; }

            

            [JsonProperty("openedDate")]
            public DateTime OpenedDate { get; set; }

            [JsonProperty("lastStatusOpenedDate")]
            public DateTime LastStatusOpenedDate { get; set; }
    }


    }

