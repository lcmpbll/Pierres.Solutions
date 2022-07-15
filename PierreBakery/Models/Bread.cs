using System;

namespace PierreBakery.Models
{
  public class Bread
  { 
    
    public int Price { get; set; } 
    public int Quantity {get; set; }
    

    public Bread(int _price, int _quantity)
    {
      Price = _price;
      Quantity = _quantity;
    }

    public int GetBreadPrice()
    {
      return Price;
    }

    public void SetQuantity(int newQuantity)
    {
      Quantity = newQuantity;
    }
  

    public static int TotalBreadPrice(int _price, int _quantity)
    { 
      int totalPrice = 0;
      for(int i = 0; i <= _quantity; i ++)
      {
        if(i % 3 != 0)
        {
          totalPrice = totalPrice + _price;
          
        }
        else
        {
          totalPrice = totalPrice + 0;
        }
      }
      return totalPrice;
    }

  }
}