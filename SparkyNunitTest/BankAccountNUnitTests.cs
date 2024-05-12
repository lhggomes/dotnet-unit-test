using Moq;
using NUnit.Framework;
using Sparky;

namespace SparkyNunitTest;

[TestFixture]
public class BankAccountNUnitTests
{

    private BankAccount _bankAccount;
    
    [SetUp]
    public void SetUp()
    {
        _bankAccount = new BankAccount(new LogBook());
    }

    [Test]
    public void BankDeposit_Add100_ReturnTrue()
    {
        var logMock = new Mock<ILogBook>();
        logMock.Setup(x => x.Message("Test"));
        BankAccount bankAccount = new BankAccount(logMock.Object);
        bool result = _bankAccount.Deposit(100);
        Assert.IsTrue(result);
        
    }

}