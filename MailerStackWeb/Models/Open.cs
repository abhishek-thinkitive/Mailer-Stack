using Newtonsoft.Json;

namespace MailerStackWeb.Models
{
    
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class OpenCampaign
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

        public class OpenFields
        {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("favorite_color")]
            public string FavoriteColor { get; set; }
        }

        public class OpenMessage
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

        public class OpenParent
        {
            [JsonProperty("object")]
            public string Object { get; set; }

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("message")]
            public OpenMessage Message { get; set; }
        }

        public class OpenRecipient
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
            public OpenFields Fields { get; set; }
        }

        public class Open
        {
            [JsonProperty("object")]
            public string Object { get; set; }

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("actionDate")]
            public DateTime ActionDate { get; set; }

            [JsonProperty("isDuplicate")]
            public bool IsDuplicate { get; set; }

            [JsonProperty("recipient")]
            public OpenRecipient Recipient { get; set; }

            [JsonProperty("campaign")]
            public OpenCampaign Campaign { get; set; }

            [JsonProperty("parent")]
            public OpenParent Parent { get; set; }
        }


    }

