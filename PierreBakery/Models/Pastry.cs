namespace PierreBakery.Models
{
  public class Pastry
  {
    public int Price { get; set; }
    public int Quantity { get; }
    

    public Pastry(int _price, int _quantity)
    {
      Price = _price;
      Quantity = _quantity;
    }

    public static int TotalPastryPrice(int _price, int _quantity)
    {
      int totalPrice =0;
      for(int i = 1; i <= _quantity; i ++)
      {
        if(i %3 == 0)
        {
          totalPrice += _price/2;
        }
        else
        {
          totalPrice += _price;
        }
      }
      return totalPrice;
    }
  }
}