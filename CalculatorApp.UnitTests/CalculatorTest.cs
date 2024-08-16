using NUnit.Framework;
using Shouldly;

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

    [TestCase(1,2,3)]
    public void AddSum(double num1, double num2, double expectedresult)
    {
        var calculator = new Calculator();

        var sum = calculator.AddSum(num1,num2);

        expectedresult.ShouldBe(sum);
  
    }

     
    [TestCase(3,1,2)]
    public void Subtract(double num1, double num2, double expectedresult)
    {
        var calculator = new Calculator();

        var sub = calculator.Subtract(num1,num2);

        expectedresult.ShouldBe(sub);
    }
     
    [TestCase(4,3,12)]
    public void Product(double num1, double num2, double expectedresult)
    {
       var calculator = new Calculator();

       var prod = calculator.Product(num1,num2);

       expectedresult.ShouldBe(prod);
    }
     
    [TestCase(3,3,1)]
    public void Quotient(double num1, double num2, double expectedresult)
    {
        var calculator = new Calculator();

        var quot = calculator.Quotient(num1,num2);

        expectedresult.ShouldBe(quot);
    }
}