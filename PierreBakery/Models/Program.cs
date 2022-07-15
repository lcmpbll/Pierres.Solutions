using System;
using PierreBakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
   { 
      
    //Pastry danish = new Pastry(2, 0);
    Console.WriteLine("Welcome to Pierre's Bakery!");
    Console.WriteLine("The price for a loaf of bread is $5");
    Order();
    static int Order()
    {
      int loafNumber = 0;
      Console.WriteLine("Would you like Bread or Pastry today? (bread/pastry)");
      string breadOrPastry = Console.ReadLine();
      if(breadOrPastry.ToLower().Contains("bread"))
      {
        Console.WriteLine("How Many Loaves?");
        string loafCount = Console.ReadLine();
        loafNumber = int.Parse(loafCount);
       AddTotal(loafNumber); 
      }
      else
      {
        AddTotal(loafNumber);
      }
      return loafNumber;
    }
    static void AddTotal(int loafNumber)
    {
      Bread ciabbatta = new Bread(5, 0); 
      int price = ciabbatta.GetBreadPrice();
      int total = Bread.TotalBreadPrice(price, loafNumber);
      Console.WriteLine("Your total is $" + total);
     
      
    }
    //Console.WriteLine("The price for a pastry is $" + danish.GetPastryPrice());
   //AddItem();

    // static void NewOrder()
    // {
    //   int orderTotal = 0;
    //   return orderTotal;

    // }

    // static void AddItem()
    // {
    //     Console.WriteLine("Woudl you like pastry or bread? (pastry/bread)");
    //     int orderTotal = 0;
    //     string breadOrPastry = Console.ReadLine();
    //     if(breadOrPastry.ToLower().Contains("bread"))
    //     {
    //       Console.WriteLine("How many loaves would you like? Enter number of loaves or (back) to go back");
    //       string breadCount = Console.ReadLine();
    //       if("123456789".Contains(breadCount))
    //       { 
               
    //         int price = ciabbatta.GetBreadPrice();
    //         int breadNumber = int.Parse(breadCount);
    //         orderTotal += ciabbatta.TotalBreadPrice(price, breadNumber);
    //       }
    //       else if(breadCount.ToString().ToLower().Contains() == "back")
    //       {
    //         AddItem();
    //       }
    //       else
    //       {
    //         Console.WriteLine("Please try again");
    //         AddItem();
    //       }

      //  }
      // }
    }
  }
}