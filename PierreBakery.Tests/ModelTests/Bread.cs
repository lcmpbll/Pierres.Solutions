using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  { 
    [TestMethod] //1
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(5, 1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod] //2
    public void GetPrice_ReturnsThePriceOfOneLoaf_Int()
    {
      //Arrange
      int price = 5;
      Bread newBread = new Bread(price, 1);
      //Act
      int breadPrice = newBread.Price;
      //Assert
      Assert.AreEqual(price, breadPrice);
    }
    [TestMethod] //3
    public void SetPrice_ReturnsPriceForTwoLoaves_Int()
    {
      //Arrange
      int price = 5;
      int quantity = 2;
      Bread newBread = new Bread(price, quantity);
      //Act
      int breadPrice = newBread.Price * newBread.Quantity;
      //Assert
      Assert.AreEqual(price * quantity, breadPrice);
    }
    [TestMethod] //4
     public void TotalBreadPrice_ReturnsPriceForTwoLoavesFunction_Int()
     {
      //Arrange
      int price = 5;
      int quantity = 2;
      Bread newBread = new Bread(price, quantity);
      //Act
      int breadPrice = newBread.TotalBreadPrice(price, quantity);
      //Assert
      Assert.AreEqual(10, breadPrice);
    }
    [TestMethod] //5
     public void TotalBreadPrice_ReturnsPriceForThreeLoavesFunction_Int()
     {
      //Arrange
      int price = 5;
      int quantity = 3;
      Bread newBread = new Bread(price, quantity);
      //Act
      int breadPrice = newBread.TotalBreadPrice(price, quantity);
      Console.WriteLine(quantity);
      //Assert
      Assert.AreEqual(10, breadPrice);
    }
     [TestMethod] //5
     public void GetBreadPrice_ReturnsPriceForOneLoaf_Int()
     {
      //Arrange
  
      Bread newBread = new Bread(5, 1);
      //Act
      int breadPrice = newBread.GetBreadPrice();
      //Assert
      Assert.AreEqual(5, breadPrice);
    }
  }
}