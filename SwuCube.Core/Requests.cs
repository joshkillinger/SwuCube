using System.Text;
using System.Text.Json;
using SwuCube.Core.Models;

namespace SwuCube.Core;

public static class Requests
{
    private const string SWUDB = "https://swudb.com/";
    private const string API = $"{SWUDB}api/card/";
    private const string GET_KEYWORDS = $"{API}getKeywords";
    private const string GET_TRAITS = $"{API}getTraits";
    private const string GET_SET_LIST = $"{API}getSetList";
    private const string GET_CARD_DATA = $"{API}getPrintingInfo";
    
    private static HttpClient client = new HttpClient();

    public static async Task<IEnumerable<ExpansionData>> GetExpansions()
    {
        var body = new StringContent("{}", Encoding.UTF8, "application/json");
        var response = await client.PostAsync(GET_SET_LIST, body);
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();
        return ParseExpansions(responseBody);
    }

    public static List<ExpansionData> ParseExpansions(string json)
    {
        var expansions = JsonSerializer.Deserialize<List<ExpansionData>>(json) ?? [];
        return expansions.OrderBy(x => x.ReleaseDate).ToList();
    }
}