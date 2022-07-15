using System;
using PierreBakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
   { 
      
    
    Console.WriteLine("Welcome to Pierre's Bakery!");
    Console.WriteLine("The price for a loaf of bread is $5");
    Console.WriteLine("The price for a pastry is $2");
    OrderBread();

    static void OrderBread()
    { 
      int pastryNumber = 0;
      int loafNumber = 0;
      Console.WriteLine("Would you like Bread or Pastry today? (bread/pastry)");
      string breadOrPastry = Console.ReadLine();
      if(breadOrPastry.ToLower().Contains("bread"))
      {
        Console.WriteLine("How Many Loaves?");
        string loafCount = Console.ReadLine();
        loafNumber = int.Parse(loafCount);
        Console.WriteLine(loafNumber + "Loafs. Would you like pastries as well? (yes/no)");
        string orderMore = Console.ReadLine();
        if (orderMore.ToLower() == "yes")
        {
          Console.WriteLine("How many pastries would tou like?");
          string pastryCount = Console.ReadLine();
          pastryNumber = int.Parse(pastryCount);
          Console.WriteLine(pastryNumber + "Pastries");
          
        }
      }
      else
      {
        Console.WriteLine("How many pastries would tou like?");
          string pastryCount = Console.ReadLine();
           pastryNumber = int.Parse(pastryCount);
          Console.WriteLine(pastryNumber + "Pastries");
      }
      AddTotal(loafNumber, pastryNumber);
      
    }


    static void AddTotal(int loafNumber, int pastryNumber)
    {
      Pastry danish = new Pastry(2, 0);
      Bread ciabbatta = new Bread(5, 0); 
      int loafPrice = ciabbatta.GetBreadPrice();
      int breadPrice = Bread.TotalBreadPrice(loafPrice, loafNumber);
      int danishPrice = danish.GetPastryPrice();
      int pastryPrice = Pastry.TotalPastryPrice(danishPrice, pastryNumber);
      int total = breadPrice + pastryPrice;
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