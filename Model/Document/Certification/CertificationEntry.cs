using System;
using System.Text.Json.Serialization;

namespace Model.Document.Certification
{
    public class CertificationEntry
    {
        [JsonPropertyName("name")] public string Name { get; set; }
        [JsonPropertyName("description")] public string Description { get; set; }
        [JsonPropertyName("achieving_date")] public DateTime AchievingDate { get; set; }
        [JsonPropertyName("prove")] public string Prove { get; set; }
    }
}