using Newtonsoft.Json;

namespace MailerStackWeb.Models
{
   
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Error
        {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("code")]
            public string Code { get; set; }

            [JsonProperty("error")]
            public string error { get; set; }

            [JsonProperty("time")]
            public DateTime Time { get; set; }
        }


    }

