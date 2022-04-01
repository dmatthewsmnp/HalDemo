using System.Text.Json;

namespace HalDemo;

public class HalObject
{
	public Dictionary<string, Dictionary<string, JsonElement>>? _links { get; set; }
	public Dictionary<string, IEnumerable<JsonElement>>? _embedded { get; set; }
}
