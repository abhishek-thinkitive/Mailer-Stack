using Newtonsoft.Json;

namespace MailerStackWeb.Models
{
   
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class ReplyCampaign
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

        public class ReplyFields
        {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("favorite_color")]
            public string FavoriteColor { get; set; }
        }

        public class ReplyMessage
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

        public class ReplyParent
        {
            [JsonProperty("object")]
            public string Object { get; set; }

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("message")]
            public ReplyMessage Message { get; set; }
        }

        public class ReplyRecipient
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
            public ReplyFields Fields { get; set; }
        }

        public class Reply
        {
            [JsonProperty("object")]
            public string Object { get; set; }

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("actionDate")]
            public DateTime ActionDate { get; set; }

            [JsonProperty("recipient")]
            public ReplyRecipient Recipient { get; set; }

            [JsonProperty("campaign")]
            public ReplyCampaign Campaign { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("parent")]
            public ReplyParent Parent { get; set; }

            [JsonProperty("subject")]
            public string Subject { get; set; }

            [JsonProperty("externalID")]
            public string ExternalID { get; set; }

            [JsonProperty("externalRawMessageID")]
            public string ExternalRawMessageID { get; set; }

            [JsonProperty("externalConversationID")]
            public string ExternalConversationID { get; set; }

            [JsonProperty("rawBody")]
            public string RawBody { get; set; }

            [JsonProperty("body")]
            public string Body { get; set; }

            [JsonProperty("plainTextBody")]
            public string PlainTextBody { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }


    }

