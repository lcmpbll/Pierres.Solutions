using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  { 
    [TestMethod] //1
    public void PasttryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod] //2
    public void GetPrice_ReturnsThePriceOfOneDanish_Int()
    {
      //Arrange
      int price = 2;
      Pastry newPastry = new Pastry(price);
      //Act
      int pastryPrice = newPastry.Price;
      //Assert
      Assert.AreEqual(price, pastryPrice);
    }
  }
}