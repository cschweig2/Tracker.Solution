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
        private static List<Vendor> _vendors = new List<Vendor> {};

        public Vendor(string name, string description)
        {
            Name = name;
            Description = description;
            _vendors.Add(this);
            Id = _vendors.Count;
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
            return _vendors[id];
        }

    }
}