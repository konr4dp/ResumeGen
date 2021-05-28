using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Model.Document.Education
{
    public class Education
    {
        [JsonPropertyName("schools")] public List<EducationEntry> EducationEntries { get; set; }
        [JsonPropertyName("languages")] public List<Language> Languages;
    }
}