using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership 
{
  public class Program
  {
    public static void Main()
    {
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, "A Good Ol' Betty");
      Car yugo = new Car("1980 Yugo Koral", 700, 56000, "It will go whereever yugo.");
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001, "You won't get bored when you drive this Ford.");
      Car amc = new Car("1976 AMC Pacer", 400, 198000, "We don't know what this is, but we suspect it's not a movie.");

      List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };
      
      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);
      Console.WriteLine("Enter maximum mileage:");
      string stringMaxMileage = Console.ReadLine();
      int maxMileage = int.Parse(stringMaxMileage);

      List<Car> CarsMatchingSearch = new List<Car>(0);

      int NumberWorthBuying = 0;
      foreach (Car automobile in Cars)
      {
        if(automobile.WorthBuying(maxPrice))
        {
          NumberWorthBuying++;
          if(automobile.LowMileage(maxMileage))
          {
            CarsMatchingSearch.Add(automobile);
          }
        }          
      }
      
      if (NumberWorthBuying == 0)
      {
        Console.WriteLine("Sorry, all of our vehicles don't meet your budget requirements.");
      }
      else 
      {
        foreach(Car automobile in CarsMatchingSearch)
        {                                              
          Console.WriteLine(automobile.GetMakeModel() + automobile.GetMessage());
        }
      }


    }
  }





}