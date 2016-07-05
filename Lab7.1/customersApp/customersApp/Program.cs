using System;

namespace customersApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var customersArray = new[]
            {
                new Customer(301522637, "Kamil", "Maghar"),
                new Customer(225456874, "kamil", "Haifa"),
                new Customer(545665789, "Yair", "Tel-Aviv"),
                new Customer(587956874, "yair", "Haifa"),
                new Customer(123545687, "amir", "Tel-Aviv"),
                new Customer(545687789, "Amir", "Maghar")
            };

            Console.WriteLine("Initial state:");
            Displayarray(customersArray);

            Console.WriteLine("After sorting the array:");
            Array.Sort(customersArray);
            Displayarray(customersArray);

            Console.WriteLine("After sorting the array using the Comparer AnotherCustomerComparer:");
            var comparer = new AnotherCustomerComparer();
            Array.Sort(customersArray, comparer);
            Displayarray(customersArray);

            var customer1 = new Customer(1, "Kamil", "Maghar");
            var customer2 = new Customer(1, "Kamil", "Maghar");

            Console.WriteLine($"Customer1:  {customer1.Name} {customer1.Id} {customer1.Address}");
            Console.WriteLine($"Customer2:  {customer2.Name} {customer2.Id} {customer2.Address}");

            Console.WriteLine(customer1.Equals(customer2)
                ? "Customer1 and Customers2 are equal"
                : "Customer1 and Customers2 are not equal");

            Console.WriteLine();

            customer2 = new Customer(1, "Amir", "Maghar");
            Console.WriteLine($"Customer1:  {customer1.Name} {customer1.Id} {customer1.Address}");
            Console.WriteLine($"Customer2:  {customer2.Name} {customer2.Id} {customer2.Address}");

            Console.WriteLine(customer1.Equals(customer2)
                ? "Customer1 and Customers2 are equal"
                : "Customer1 and Customers2 are not equal");
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
