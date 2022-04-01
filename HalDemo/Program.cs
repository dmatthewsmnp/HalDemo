using System.Text;
using System.Text.Json;
using HalDemo;

// Deserialize orders object and inspect members:
var orders = JsonSerializer.Deserialize<Orders>(Encoding.UTF8.GetString(File.ReadAllBytes("sample.json"))) ?? throw new Exception("Failed to deserialize orders");
Console.WriteLine($"Shipped {orders.shippedToday} orders, processing {orders.currentlyProcessing}");

// If links are present, output:
if (orders._links?.Count > 0)
{
	foreach (var link in orders._links)
	{
		Console.WriteLine($"Orders link [{link.Key}]: {link.Value.href}");
	}
}

// If embedded orders are present, deserialize them:
if (orders._embedded?.ContainsKey("orders") ?? false)
{
	foreach (var order in orders._embedded["orders"].Select(je => je.Deserialize<Order>() ?? throw new Exception("Failed to deserialize order")))
	{
		Console.WriteLine();
		Console.WriteLine($"Order for {order.total} {order.currency} status {order.status}");
		if (order._links?.ContainsKey("self") ?? false)
		{
			Console.WriteLine($"Order link: {order._links["self"].href}");
		}
	}
}
