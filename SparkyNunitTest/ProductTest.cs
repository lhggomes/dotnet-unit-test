using NUnit.Framework;
using Sparky;

namespace SparkyNunitTest;

[TestFixture]
public class ProductTest
{   
    [Test]
    public void GetProductPrice_PlatiunumCustomer()
    {
        Product product = new Product() { Price = 50 };
        Assert.That(product.Price, Is.EqualTo(50));
    }
}