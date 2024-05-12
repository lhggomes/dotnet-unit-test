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
        
        Assert.That(5, Is.EqualTo(result));
    }

    [Test]
    [TestCase(3.4, 5, ExpectedResult = 8.4)]
    [TestCase(3.4, 6, ExpectedResult = 9.4)]
    [TestCase(3.4, 7, ExpectedResult = 10.4)]
    [TestCase(3.4, 8, ExpectedResult = 11.4)]
    public double AddNumbers_Double(double a, double b)
    {
        Calculator calculator = new Calculator();
        return calculator.AddNumbers(a, b);
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

    [Test]
    public void OddRanger_InputMinAndMaxRange_ReturnValidOddNumberRange()
    {
        Calculator calc = new Calculator();
        List<int> expectedOddRange = new() { 5, 7, 9 };

        List<int> result = calc.GetOddRange(5, 10);
        
        Assert.That(result, Is.EquivalentTo(expectedOddRange));
        Assert.Contains(7, expectedOddRange);
        Assert.That(result, Is.Not.Empty);
        Assert.That(result, Has.No.Member(6));
        Assert.That(result, Is.Ordered.Ascending);
        Assert.That(result, Is.Unique);
    }
    
}