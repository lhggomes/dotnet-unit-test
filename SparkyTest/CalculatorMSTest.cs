using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SparkyTest;
using Sparky;

[TestClass]
public class CalculatorMSTest
{
   [TestMethod]
   public void AddNumbers_InputTwoInt_GetCorrectAddition()
   {
      Calculator caculator = new();
      int result = caculator.AddNumbers(2, 4);
      
      Assert.AreEqual(6, result);
   }
}