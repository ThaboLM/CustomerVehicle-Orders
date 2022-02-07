// See https://aka.ms/new-console-template for more information
using CVO.ConsoleApp.Data;
using CVO.ConsoleApp.Enums;
using CVO.ConsoleApp.Logic;

var order = new Order();
var verifyOrder = new VerifyOrder();

Console.WriteLine("Rush Order? (yes / no)");
var isRushOrder = Console.ReadLine();

Console.WriteLine("Order Type? (repair / hire)");
var orderType = Console.ReadLine();

Console.WriteLine("new customer? (yes / no)");
var customerType = Console.ReadLine();

Console.WriteLine("large order? (yes / no)");
var orderSize = Console.ReadLine();

if(isRushOrder == "yes")
	order.IsRushOrder = true;
if(isRushOrder == "no")
	order.IsRushOrder = false;

if(isRushOrder == "repair")
	order.OrderType = OrderType.Repair;
if(orderType == "hire")
	order.OrderType = OrderType.Hire;

if(customerType == "yes")
	order.IsNewCustomer = true;
if(customerType == "no")
	order.IsNewCustomer = false;

if(orderSize == "yes")
	order.IsLargeOrder = true;
if(orderSize == "no")
	order.IsLargeOrder = false;

var result = verifyOrder.Check(order);

Console.WriteLine($"Order Status : {result}.");
Console.ReadKey();