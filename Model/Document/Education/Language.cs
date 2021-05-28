using System.Text.Json.Serialization;

namespace Model.Document.Education
{
    public class Language
    {
        [JsonPropertyName("name")] public string Name { get; set; }
        [JsonPropertyName("level")] public string Level { get; set; }
    }
}