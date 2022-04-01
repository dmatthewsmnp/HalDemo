namespace HalDemo;

/// <summary>
/// RFC5988 https://datatracker.ietf.org/doc/html/rfc5988
/// </summary>
public record Link
{
	public Uri? href { get; set; }
	public bool templated { get; set; }
	public string? type { get; set; }
	public string? deprecation { get; set; }
	public string? name { get; set; }
	public string? profile { get; set; }
	public string? hreflang { get; set; }

}
