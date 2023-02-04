using Newtonsoft.Json;

namespace MailerStackWeb.Models
{
    
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class SentMessageCampaign
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

        public class SentMessageFields
        {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("favorite_color")]
            public string FavoriteColor { get; set; }
        }

        public class From
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

        public class SentMessageMessage
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

        public class SentMessageRecipient
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
            public SentMessageFields Fields { get; set; }
        }

        public class SentMessage
        {
            [JsonProperty("object")]
            public string Object { get; set; }

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("actionDate")]
            public DateTime ActionDate { get; set; }

            [JsonProperty("recipient")]
            public SentMessageRecipient Recipient { get; set; }

            [JsonProperty("campaign")]
            public SentMessageCampaign Campaign { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("message")]
            public SentMessageMessage Message { get; set; }

            [JsonProperty("from")]
            public From From { get; set; }

            [JsonProperty("to")]
            public List<To> To { get; set; }

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
        }

        public class To
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

