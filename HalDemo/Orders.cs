namespace HalDemo;

public record Orders : HalObject
{
	public int? currentlyProcessing { get; set; }
	public int? shippedToday { get; set; }
}
