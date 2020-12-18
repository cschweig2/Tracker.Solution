using System.Collections.Generic;

// vendor class should include properties for the vendor's name, description of the vendor
// a List of Order's belonging to the vendor, and any other properties
namespace Tracker.Models
{
    public class Vendor
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; }
        public static List<Vendor> Orders = new List<Vendor> {};

        public Vendor(string name, string description)
        {
            Name = name;
            Description = description;
            Orders.Add(this);
            Id = Orders.Count;
        }

        public static List<Vendor> GetAll()
        {
            return Orders;
        }

        public static void ClearAll()
        {
            Orders.Clear();
        }

        public static Vendor Find(int id)
        {
            return Orders[id - 1];
        }

    }
}