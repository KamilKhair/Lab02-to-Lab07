using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customersApp
{
    public class Customer : IComparable<Customer>, IEquatable<Customer>
    {
        public string Name { get; }
        public int Id { get; }
        public string Address { get; }

        public Customer(string name, int id, string address)
        {
            Name = name;
            Id = id;
            Address = address;
        }

        public int CompareTo(Customer other)
        {
            // If other is not a valid object reference, this instance is greater, else the names are compared.
            return other == null ? 1 : Name.ToLower().CompareTo(other.Name.ToLower());
        }

        public bool Equals(Customer other)
        {
            if (other == null)
                return false;

            return Name == other.Name && Id == other.Id;
        }
    }

    public class AnotherCustomerComparer : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Id.CompareTo(y.Id) != 0 ? x.Id.CompareTo(y.Id) : 0;
        }
    }
}
