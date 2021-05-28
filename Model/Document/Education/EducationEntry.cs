using System;
using System.Text.Json.Serialization;

namespace Model.Document.Education
{
    public class EducationEntry
    {
        [JsonPropertyName("name")] public string Name { get; set; }
        [JsonPropertyName("faculty")] public string Faculty { get; set; }
        [JsonPropertyName("specialisation")] public string Specialisation{ get; set; }
        [JsonPropertyName("title")] public string Title { get; set; }
        [JsonPropertyName("start_date")] public DateTime StartDate { get; set; }
        [JsonPropertyName("end_date")] public DateTime EndDate { get; set; }
    }
}