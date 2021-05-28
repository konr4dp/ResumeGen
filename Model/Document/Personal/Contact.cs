using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Model.Document.Personal
{
    public class Contact
    {
        [JsonPropertyName("phone_numbers")] public List<string> PhoneNumbers { get; set; }
        [JsonPropertyName("emails")] public List<string> Emails { get; set; }
    }
}