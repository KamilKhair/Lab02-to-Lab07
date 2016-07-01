using System;

namespace customersApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var customersArray = new Customer[6];
            customersArray[0] = new Customer("Kamil", 301522637, "Maghar");
            customersArray[1] = new Customer("kamil", 225456874, "Haifa");
            customersArray[2] = new Customer("Yair", 125445687, "Tel-Aviv");
            customersArray[3] = new Customer("yair", 125445687, "Haifa");
            customersArray[4] = new Customer("amir", 125445687, "Tel-Aviv");
            customersArray[5] = new Customer("Amir", 125445687, "Maghar");

            Displayarray(customersArray);

            Array.Sort(customersArray);

            Displayarray(customersArray);

            var comparer = new AnotherCustomerComparer();

            Array.Sort(customersArray, comparer);

            Displayarray(customersArray);
        }

        public static void Displayarray(Customer[] arr)
        {
            foreach (var customer in arr)
            {
                Console.WriteLine($"{customer.Name} {customer.Id} {customer.Address}");
            }
            Console.WriteLine();
        }
    }
}
