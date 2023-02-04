using Newtonsoft.Json;

namespace MailerStackWeb.Models
{
    
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class CampaignExport
        {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("isFinished")]
            public bool IsFinished { get; set; }

            [JsonProperty("csvDownloadUrl")]
            public string CsvDownloadUrl { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }


    }

