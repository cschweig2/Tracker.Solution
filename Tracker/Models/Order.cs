using System.Collections.Generic;

// Order class should include properties for the title, description, price, date and any other properties I would like to include
namespace Tracker.Models
{
    public class Order
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Date { get; set; }
        public int Id { get; }
        private static List<Order> _instances = new List<Order> {};
        private static List<Order> testList = new List<Order> {};

        public Order(string title, string description, int price, int date)
        {
            Title = title;
            Description = description;
            Price = price;
            Date = date;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public static List<Order> GetAll()
        {
            return testList;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }


    }
}