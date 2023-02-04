using Newtonsoft.Json;

namespace MailerStackWeb.Models
{
  
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class ClickCampaign
        {
            [JsonProperty("object")]
            public string Object { get; set; }

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("created")]
            public DateTime Created { get; set; }
        }

        public class ClickFields
        {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("favorite_color")]
            public string FavoriteColor { get; set; }
        }

        public class ClickMessage
        {

            [JsonProperty("object")]
            public string Object { get; set; }

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("subject")]
            public string Subject { get; set; }
        }

        public class ClickParent
        {
            [JsonProperty("object")]
            public string Object { get; set; }

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("message")]
            public ClickMessage Message { get; set; }
        }

        public class ClickRecipient
        {
            [JsonProperty("object")]
            public string Object { get; set; }

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("emailAddress")]
            public string EmailAddress { get; set; }

            [JsonProperty("fullName")]
            public string FullName { get; set; }

            [JsonProperty("first")]
            public string First { get; set; }

            [JsonProperty("last")]
            public string Last { get; set; }

            [JsonProperty("created")]
            public DateTime Created { get; set; }

            [JsonProperty("fields")]
            public ClickFields Fields { get; set; }
        }

        public class Click
        {
            [JsonProperty("object")]
            public string Object { get; set; }

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("link")]
            public string Link { get; set; }

            [JsonProperty("actionDate")]
            public DateTime ActionDate { get; set; }

            [JsonProperty("isDuplicate")]
            public bool IsDuplicate { get; set; }

            [JsonProperty("recipient")]
            public ClickRecipient Recipient { get; set; }

            [JsonProperty("campaign")]
            public ClickCampaign Campaign { get; set; }

            [JsonProperty("parent")]
            public ClickParent Parent { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }


    }

