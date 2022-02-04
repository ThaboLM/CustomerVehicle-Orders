namespace CVO.ConsoleApp;


public class Order
{
	public bool IsRushOrder { get; set; }
	public OrderType OrderType { get; set; }
	public bool IsNewCustomer { get; set; }
	public bool IsLargeOrder { get; set; }
}
