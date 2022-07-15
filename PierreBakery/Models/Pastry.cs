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

    
  }
}