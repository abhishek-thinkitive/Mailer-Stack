using Newtonsoft.Json;

namespace MailerStackWeb.Models
{
    public class LeadStatus
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

        [JsonProperty("status")]
            public string Status { get; set; }

            [JsonProperty("leadID")]
            public int LeadID { get; set; }
        


    }
}
