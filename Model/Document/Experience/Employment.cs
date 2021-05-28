using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Model.Document.Experience
{
    public class Employment
    {
        [JsonPropertyName("employer")] public string Employer { get; set; }
        [JsonPropertyName("position")] public string Position { get; set; }
        [JsonPropertyName("start_date")] public DateTime StartDate { get; set; }
        [JsonPropertyName("end_date")] public DateTime EndDate { get; set; }
        [JsonPropertyName("description")] public string Description { get; set; }
        [JsonPropertyName("responsibilities")] public List<string> Responsibilities { get; set; }
        [JsonPropertyName("tools")] public List<string> Tools { get; set; }
        [JsonPropertyName("skills")] public List<string> Skills { get; set; }
    }
}