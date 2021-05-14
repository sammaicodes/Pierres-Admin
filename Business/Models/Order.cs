using System.Collections.Generic;

namespace Business.Models
{
  public class Order
  {
      private static List<Order> _instances = new List<Order> {};
      public string Name { get; set; }
      public string Description { get; set; }
      public string Date { get; set; }
      public string Price { get; set; }   //Might need to be an integer
      public int Id { get; }
    public Order(string name, string description, string date, string price)
    {
      Name = name;
      Description = description;
      Date = date;
      Price = price;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}