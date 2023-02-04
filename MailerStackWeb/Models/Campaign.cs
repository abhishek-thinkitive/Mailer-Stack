using Newtonsoft.Json;

namespace MailerStackWeb.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class CampaignMessage
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
        public int? ReplyToID { get; set; }

        [JsonProperty("isPaused")]
        public bool IsPaused { get; set; }
    }

    public class Campaign
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("isArchived")]
        public bool IsArchived { get; set; }

        [JsonProperty("isPaused")]
        public bool IsPaused { get; set; }

        [JsonProperty("messages")]
        public List<CampaignMessage> Messages { get; set; }

        [JsonProperty("sender")]
        public CampaignSender Sender { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("createdAt")]
        public DateTime createdAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime updatedAt { get; set; }
    }

    public class CampaignSender
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
