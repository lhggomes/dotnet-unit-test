using NUnit.Framework;
using Sparky;

namespace SparkyNunitTest;

[TestFixture]
public class CalculatorNUnitTest
{
    [Test]
    public void AddNumbers_Correct()
    {
        Calculator calculator = new Calculator();
        int result = calculator.AddNumbers(2, 3);
        
        Assert.That(6, Is.EqualTo(result));
    }

    [Test]
    public void CheckIfNumberIsOdd_Correct()
    {
        Calculator calculator = new Calculator();
        bool isOdd = calculator.IsOddNumber(3);
        bool isNotOdd = calculator.IsOddNumber(4);
        
        Assert.That(isOdd, Is.True);
        Assert.That(isNotOdd, Is.False);
    }

    [Test]
    [TestCase(1)]
    [TestCase(3)]
    public void IsOddNumberChecker_AutomaticValue(int a)
    {
        Calculator calculator = new Calculator();
        bool isOdd = calculator.IsOddNumber(a);
        
        Assert.That(isOdd, Is.True);

    }

    [Test]
    [TestCase(10, ExpectedResult = false)]
    [TestCase(11, ExpectedResult = true)]
    public bool IsOddChecker_InputNumber_ReturnTrueIfOdd(int a)
    {
        Calculator calculator = new Calculator();
        return calculator.IsOddNumber(a);
    }
}