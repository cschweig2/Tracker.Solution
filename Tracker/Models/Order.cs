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

        public Order(string title, string description, int price, int date)
        {
            Title = title;
            Title = "hello";
            Description = description;
            Price = price;
            Date = date;
        }

    }
}