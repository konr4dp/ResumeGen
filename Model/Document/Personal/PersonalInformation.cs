using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Model.Document.Personal
{
    public class PersonalInformation
    {
        [JsonPropertyName("name")] public string Name { get; set; }
        [JsonPropertyName("surname")] public string Surname { get; set; }
        [JsonPropertyName("birth_date")] public DateTime BirthDate { get; set; }
        [JsonPropertyName("contact")] public Contact Contact { get; set; }
        [JsonPropertyName("profiles")] public Dictionary<string, string> Profiles { get; set; }
    }
}