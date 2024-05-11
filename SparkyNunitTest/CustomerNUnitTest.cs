using NUnit.Framework;
using Sparky;

namespace SparkyNunitTest;

[TestFixture]
public class CustomerNUnitTest
{
    private Customer _customer;

    [SetUp]
    public void SetUp()
    {
        _customer = new Customer();
    }
    
    [Test]
    public void CombineName_InputFirstNameAndLastName_ReturnFullName()
    {
    
        string fullName = _customer.CombineNames("Lucas", "Gomes");
        
        Assert.That(fullName, Is.EqualTo("Lucas Gomes"));
        Assert.That(fullName, Does.Contain(" "));
    }
    
}