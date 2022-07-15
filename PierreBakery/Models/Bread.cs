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

    public static int TotalBreadPrice(int _price, int _quantity)
    {
      int totalPrice = 0;
      for(int i = 1; i <= _quantity; i ++)
      {
        if(i % 3 != 0)
        {
          totalPrice += _price;
        }
        else
        {
          totalPrice += 0;
        }
      }
      return totalPrice;
    }

  }
}