namespace HalDemo;

public class Orders : HalObject
{
	public int? currentlyProcessing { get; set; }
	public int? shippedToday { get; set; }
}
