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
      Pastry newPastry = new Pastry(2 , 1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod] //2
    public void GetPrice_ReturnsThePriceOfOnePastry_Int()
    {
      //Arrange
      int price = 2;
      Pastry newPastry = new Pastry(price, 1);
      //Act
      int pastryPrice = newPastry.Price;
      //Assert
      Assert.AreEqual(price, pastryPrice);
    }
     [TestMethod] //3
    public void SetPrice_ReturnsPriceForTwoPastries_Int()
    {
      //Arrange
      int price = 2;
      int quantity = 2;
      Pastry newPastry = new Pastry(price, quantity);
      //Act
      int pastryPrice = newPastry.Price * newPastry.Quantity;
      //Assert
      Assert.AreEqual(price * quantity, pastryPrice);
    }
     [TestMethod] //4
     public void TotalPastryPrice_ReturnsPriceForThreePastries_Int()
     {
      //Arrange
      int price = 2;
      int quantity = 3;
      Pastry newPastry = new Pastry(price, quantity);
      //Act
      int pastryPrice = Pastry.TotalPastryPrice(price, quantity);
      //Assert
      Assert.AreEqual(5, pastryPrice);
     }
         [TestMethod] //5
     public void GetPastryPrice_ReturnsPriceForOnePastry_Int()
     {
      //Arrange
  
      Pastry newPastry = new Pastry(2, 1);
      //Act
      int pastryPrice = newPastry.GetPastryPrice();
      //Assert
      Assert.AreEqual(2, pastryPrice);
    }
  }
}