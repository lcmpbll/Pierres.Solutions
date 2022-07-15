using System;
using PierreBakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
   { 
    Console.WriteLine("Welcome to Pierre's Bakery!");
    //Console.WriteLine("The price for a loaf of bread is $" + Bread.Price);
    //Console.WriteLine("The price for a pastry is $" + Pastry.Price);
    AddItem();

    // static void NewOrder()
    // {
    //   int orderTotal = 0;
    //   return orderTotal;

    // }

    static void AddItem()
    {
        Console.WriteLine("Woudl you like pastry or bread? (pastry/bread)");
        int orderTotal = 0;
        string breadOrPastry = Console.ReadLine();
        if(breadOrPastry.ToLower().Contains("bread"))
        {
          Console.WriteLine("How many loaves would you like? Enter number of loaves or (back) to go back");
          string breadCount = Console.ReadLine();
          if(breadCount.Contains("1234567890"))
          { 
            int breadNumber = int.Parse(breadCount);
            orderTotal += Bread.TotalBreadPrice(breadCount);
          }
          else if(breadCount.ToString().ToLower().Contains() == "back")
          {
            AddItem();
          }
          else
          {
            Console.WriteLine("Please try again");
            AddItem();
          }

          }
      }
    }
  }
}