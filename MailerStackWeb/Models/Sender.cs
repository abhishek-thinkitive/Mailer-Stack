using Newtonsoft.Json;

namespace MailerStackWeb.Models
{

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Sender
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("fromName")]
        public string FromName { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }
    }




}

