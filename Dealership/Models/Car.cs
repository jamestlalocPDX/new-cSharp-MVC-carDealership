using System.Collections.Generic;

namespace Dealership.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    public string Message { get; set; }
    public string Shade { get; set; }

    private static List<Car> Cars = new List<Car>() {};

    public Car(string makeModel, int price, int miles, string message, string shade)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Message = message;
      Shade = shade;
      Cars.Add(this);
    }

    public static List<Car> GetAll()
    {
      return Cars;
    }

    public static void ClearAll()
    {
      Cars.Clear();
    }
  }
}

