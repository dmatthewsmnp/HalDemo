namespace HalDemo;

public class Order : HalObject
{
	public decimal? total { get; set; }
	public string? currency { get; set; }
	public string? status { get; set; }
}
