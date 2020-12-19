using System.Collections.Generic;

namespace Tracker.Models
{
    public class Vendor
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; }
        private static List<Vendor> _vendors = new List<Vendor> {};
        public List<Order> Orders { get; set; }

        public Vendor(string name, string description)
        {
            Name = name;
            Description = description;
            _vendors.Add(this);
            Id = _vendors.Count;
            Orders = new List<Order>{};
        }

        public static List<Vendor> GetAll()
        {
            return _vendors;
        }

        public static void ClearAll()
        {
            _vendors.Clear();
        }

        public static Vendor Find(int id)
        {
            return _vendors[id - 1];
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

    }
}