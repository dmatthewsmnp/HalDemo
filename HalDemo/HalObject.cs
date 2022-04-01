using System.Text.Json;

namespace HalDemo;

/// <summary>
/// See https://datatracker.ietf.org/doc/html/draft-kelly-json-hal-06
/// </summary>
public record HalObject
{
	public Dictionary<string, Link>? _links { get; set; }
	public Dictionary<string, IEnumerable<JsonElement>>? _embedded { get; set; }
}
