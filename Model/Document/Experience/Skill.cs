using System;
using System.Text.Json.Serialization;

namespace Model.Document.Experience
{
    public class Skill
    {
        [JsonPropertyName("name")] public string Name { get; set; }
        [JsonPropertyName("since")] public DateTime UsedSince { get; set; }
        [JsonPropertyName("level")] public int Level { get; set; }
    }
}