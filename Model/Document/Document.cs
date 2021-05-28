using System.Collections.Generic;
using System.Text.Json.Serialization;
using Model.Document.Certification;
using Model.Document.Personal;

namespace Model.Document
{
    public class Document
    {
        [JsonPropertyName("personal_information")]
        public PersonalInformation PersonalInformation { get; set; }
        [JsonPropertyName("education")] public List<Education.Education> Education { get; set; }
        [JsonPropertyName("experience")] public List<Experience.Experience> Experiences { get; set; }
        [JsonPropertyName("certification")]  public List<CertificationEntry> CertificationEntries { get; set; }
    }
}