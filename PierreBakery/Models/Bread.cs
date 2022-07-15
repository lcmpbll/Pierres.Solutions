namespace PierreBakery.Models
{
  public class Bread
  {
    public int Price { get; set; } 
    public int Quantity {get; }

    public Bread(int price, int quantity)
    {
      Price = price;
      Quantity = quantity;
    }

    public static int TotalBreadPrice(int price, int quantity)
    {
      int totalPrice = 0;
      for(int i = 1; i <= quantity; i ++)
      {
        if(i % 3 != 0)
        {
          totalPrice += price;
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