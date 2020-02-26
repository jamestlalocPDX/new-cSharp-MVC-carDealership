namespace Dealership.Models
{
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private string _message;
    private string _shade;

    public Car(string makeModel, int price, int miles, string message, string shade)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
      _message = message;
      _shade = shade;
    }

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }
    public string GetMakeModel()
    {
      return _makeModel;
    }
    public string GetMessage()
    {
      return _message;
    }
    public int GetPrice()
    {
      return _price;
    }
    public int GetMiles()
    {
      return _miles;
    }
    public string GetShade()
    {
      return _shade;
    }
    public bool WorthBuying(int maxPrice)
    {
      return (_price < maxPrice);
    }
    public bool ShadeMatch(string userShade)
    {
      return (_shade.StartsWith(userShade));
    }

    public bool LowMileage(int maxMileage)
    {
      return (_miles < maxMileage);
    }
  }
}

