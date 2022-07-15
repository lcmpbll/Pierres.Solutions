using System;

namespace PierreBakery.Models
{
  public class Bread
  { 
    
    public int Price { get; set; } 
    public int Quantity {get; }
    

    public Bread(int _price, int _quantity)
    {
      Price = _price;
      Quantity = _quantity;
    }

    public int GetBreadPrice()
    {
      return Price;
    }
    
  // private static void SetBreadPrice()
  // {
  //   Price = 5;
  // }

    public static int TotalBreadPrice(int _price, int _quantity)
    { 
      int totalPrice = 0;
      for(int i = 0; i <= _quantity; i ++)
      {
        if(i % 3 != 0)
        {
          totalPrice = totalPrice + _price;
          Console.WriteLine(_price);
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