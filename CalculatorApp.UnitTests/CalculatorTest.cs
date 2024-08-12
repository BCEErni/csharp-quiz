using NUnit.Framework;

namespace CalculatorApp.UnitTests;

[TestFixture]
public class CalculatorTest
{

private Calculator _calculator;
    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
    }
    [Test]
    public void MethodUnderTest_Scenario_ExpectedBehavior()
    {
        Assert.Pass();
    }

    [Test]
    public void AddSum()
    {
        var result = _calculator.AddSum(1, 2);

        Assert.That(result, Is.EqualTo(3));
    }

     
    [Test]
    public void Subtract()
    {
        var result = _calculator.Subtract(2, 1);

        Assert.That(result, Is.EqualTo(1));
    }
     
    [Test]
    public void Product()
    {
        var result = _calculator.Product(2, 2);

        Assert.That(result, Is.EqualTo(4));
    }
     
    [Test]
    public void Quotient()
    {
        var result = _calculator.Quotient(2, 2);

        Assert.That(result, Is.EqualTo(1));
    }
}