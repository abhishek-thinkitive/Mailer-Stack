using Newtonsoft.Json;

namespace MailerStackWeb.Models
{
   
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Team
        {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("object")]
            public string Object { get; set; }

            [JsonProperty("teamName")]
            public string TeamName { get; set; }

            [JsonProperty("teamBlockedDate")]
            public DateTime TeamBlockedDate { get; set; }

            [JsonProperty("created")]
            public DateTime Created { get; set; }
        }


    }

