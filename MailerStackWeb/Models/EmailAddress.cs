using Newtonsoft.Json;

namespace MailerStackWeb.Models
{
    
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class EmailAddress
        {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("object")]
            public string Object { get; set; }

            [JsonProperty("address")]
            public string Address { get; set; }

            [JsonProperty("fullName")]
            public string FullName { get; set; }

            [JsonProperty("first")]
            public string First { get; set; }

            [JsonProperty("last")]
            public string Last { get; set; }
        }


    }

