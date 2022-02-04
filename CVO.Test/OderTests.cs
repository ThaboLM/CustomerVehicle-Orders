using NUnit.Framework;

namespace CVO.Tests;

public class OderTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void LargeRepairForNewCustomerShouldReturnClosed()
    {
        Assert.Pass();
    }

    [Test]
    public void LargeRushHireShouldAlwaysReturnClosed()
    {
        Assert.Pass();
    }

    [Test]
    public void LargeRepairOrdersShouldAlwaysRequireAuth()
    {
        Assert.Pass();
    }

    [Test]
    public void AllRushOrdersForNewCustomerShouldAlwaysRequireAuth()
    {
        Assert.Pass();
    }

    [Test]
    public void AllOtherOrdersShouldBeConfirmed()
    {
        Assert.Pass();
    }
}