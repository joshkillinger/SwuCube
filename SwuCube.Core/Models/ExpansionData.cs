using System.Text.Json.Serialization;

namespace SwuCube.Core.Models;

public class ExpansionData
{
    [JsonPropertyName("expansionId")]
    public int Id { get; set; }
    [JsonPropertyName("expansionAbbreviation")]
    public string Code { get; set; }
    [JsonPropertyName("expansionName")]
    public string Name { get; set; }
    [JsonPropertyName("releaseDate")]
    public DateTime ReleaseDate { get; set; }
}
