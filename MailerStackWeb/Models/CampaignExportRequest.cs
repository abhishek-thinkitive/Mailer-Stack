using Newtonsoft.Json;

namespace MailerStackWeb.Models
{
   
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class CampaignExportRequest
        {

        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("isEmpty")]
            public bool IsEmpty { get; set; }

            [JsonProperty("checkStatusID")]
            public int CheckStatusID { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }


    }

