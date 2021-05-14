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
      public List<Order> Orders { get; set; }
    
    public Order(string description)
    {
      Description = description;
    }
  }
}