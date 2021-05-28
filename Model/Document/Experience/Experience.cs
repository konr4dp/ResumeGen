using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Model.Document.Experience
{
    public class Experience
    {
        [JsonPropertyName("employment")] public List<Employment> Employments;
        [JsonPropertyName("tools")] public List<Skill> Tools;
        [JsonPropertyName("skills")] public List<Skill> Skills;
        

    }
}