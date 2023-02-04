using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace MailerStackWeb.Models
{
    [Keyless]
    public class AddRecipientRequest
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("invalidEmails")]
            public List<string> InvalidEmails { get; set; }

            [JsonProperty("isEmpty")]
            public bool IsEmpty { get; set; }

            [JsonProperty("checkStatusID")]
            public int CheckStatusID { get; set; }
        


    }
}
