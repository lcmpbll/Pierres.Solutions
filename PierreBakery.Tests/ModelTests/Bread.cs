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
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void GetPrice_ReturnsThePriceOfOneLoaf_Int()
    {
      //Arrange
      int price = 5;
      Bread newBread = new Bread(price);
      //Act
      int totalPrice = newBread.Price;
      //Assert
      Assert.AreEqual(price, totalPrice);
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