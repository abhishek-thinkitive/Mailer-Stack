using Newtonsoft.Json;
using System.ComponentModel;

namespace MailerStackWeb.Models
{
    public class User
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        
            [JsonProperty("object")]
            public string Object { get; set; }

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("teamID")]
            public int TeamID { get; set; }
        [DefaultValue("ABC")]
            [JsonProperty("teamName")]
            public string TeamName { get; set; }

            [JsonProperty("isTeamAdmin")]
            public bool IsTeamAdmin { get; set; }

            [JsonProperty("isDisabled")]
            public bool IsDisabled { get; set; }

            [JsonProperty("emailAddress")]
            public string EmailAddress { get; set; }
        [JsonProperty("Password")]
        public string? Password { get; set; }

        [JsonProperty("fullName")]
            public string FullName { get; set; }

            [JsonProperty("first")]
            public string First { get; set; }

            [JsonProperty("last")]
            public string Last { get; set; }

            [JsonProperty("teamBlockedDate")]
            public DateTime TeamBlockedDate { get; set; }
        [JsonProperty("createdAt")]
        public DateTime createdAt { get; set; }
        [JsonProperty("updatedAt")]
        public DateTime updatedAt { get; set; }
    }


    }

