using System.Collections.Generic;

namespace customersApp
{
    public class AnotherCustomerComparer : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            //Why not just 'x.Id.CompareTo(y.Id)' ??
            return x.Id.CompareTo(y.Id) != 0 ? x.Id.CompareTo(y.Id) : 0;
        }
    }
}