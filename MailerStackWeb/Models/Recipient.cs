using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MailerStackWeb.Models
{
   
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Fields
        {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("favorite_color")]
            public string FavoriteColor { get; set; }
        }

        public class Recipient
        {
            [JsonProperty("object")]
        
            public string Object { get; set; }

            [JsonProperty("id")]
            [Key]
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

            [JsonProperty("isPaused")]
            public bool IsPaused { get; set; }

            [JsonProperty("fields")]
            public Fields Fields { get; set; }


        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }


    }

