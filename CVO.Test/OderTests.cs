using System;
using NUnit.Framework;
using CVO.ConsoleApp.Data;
using CVO.ConsoleApp.Enums;
using CVO.ConsoleApp.Logic;

namespace CVO.Tests;

[TestFixture]
public class OderTests
{
    private readonly VerifyOrder _verifyOrder;

    public OderTests()
    {
        _verifyOrder = new VerifyOrder();
    }

    [SetUp]
    public void Setup()
    {  
    }

    [Test]
    public void LargeRepairForNewCustomerShouldReturnClosed()
    {   // arrange
        var myOrder = new Order{
            IsLargeOrder = true,
            OrderType = OrderType.Repair,
            IsNewCustomer = true
        };

        //act
        var result = _verifyOrder.Check(myOrder);

        // assert
        Assert.AreEqual(OrderStatus.Closed, result);
    }

    [Test]
    public void LargeRushHireShouldAlwaysReturnClosed()
    {
        // arrange
        var myOrder = new Order
        {
            IsLargeOrder = true,
            OrderType = OrderType.Hire,
            IsRushOrder = true
        };

        //act
        var result = _verifyOrder.Check(myOrder);

        // assert
        Assert.AreEqual(OrderStatus.Closed, result);
    }

    [Test]
    public void LargeRepairOrdersShouldAlwaysRequireAuth()
    {
        // arrange
        var myOrder = new Order{
            IsLargeOrder = true,
            OrderType = OrderType.Repair,
        };

        //act
        var result = _verifyOrder.Check(myOrder);

        // assert
        Assert.AreEqual(OrderStatus.AuthorisationRequired, result);
    }

    [Test]
    public void AllRushOrdersForNewCustomerShouldAlwaysRequireAuth()
    {
        // arrange
        var myOrder = new Order{
            IsNewCustomer = true,
            IsRushOrder = true
        };

        //act
        var result = _verifyOrder.Check(myOrder);

        // assert
        Assert.AreEqual(OrderStatus.AuthorisationRequired, result);
    }

    [Test]
    public void AllOtherOrdersShouldBeConfirmed()
    {
        // arrange
        var myOrder1 = new Order{
            OrderType = OrderType.Repair,
        };

        var myOrder2 = new Order{
            OrderType = OrderType.Hire,
        };

        // act
        var result1 = _verifyOrder.Check(myOrder1);
        _verifyOrder.Check(myOrder2);

        Assert.AreEqual(OrderStatus.Confirmed, result1);
    }
}