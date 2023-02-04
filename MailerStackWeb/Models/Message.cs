using Newtonsoft.Json;

namespace MailerStackWeb.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Message
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("replyToID")]
        public string? ReplyToID { get; set; }

        [JsonProperty("isPaused")]
        public bool IsPaused { get; set; }
    }


}
