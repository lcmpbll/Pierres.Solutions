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
      return totalPrice;
    }
  }
}