using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  { 
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void GetPrice_ReturnsThePriceOfOneLoaf_Int()
    {
      //Arrange
      int price = 5;
      Bread newBread = new Bread(price);
      //Act
      int breadPrice = newBread.Price;
      //Assert
      Assert.AreEqual(price, breadPrice);
    }
    [TestMethod]
    public void SetPrice_ReturnsPriceForTwoLoaves_Int()
    {
      //Arrange
      int price = 5;
      int quantity = 2;
      Bread newBread = new Bread(price, quantity);
      //Act
      int breadPrice = newBread.Price * newBread.Quantity;
      //Assert
      Assert.AreEqual(10, breadPrice);
    }


//     [TestMethod]
// public void GetDescription_ReturnsDescription_String()
// {
//   //Arrange
//   string description = "Walk the dog.";
//   Item newItem = new Item(description);

//   //Act
//   string result = newItem.Description;

//   //Assert
//   Assert.AreEqual(description, result);
// }

  }
}