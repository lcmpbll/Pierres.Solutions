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

  }
}