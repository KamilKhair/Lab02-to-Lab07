using System;
using customersApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerTester
{
    [TestClass]
    public class CustomerUnitTest
    {
        [TestMethod]
        public void Test_Create_Customer_Object()
        {
            var customer = new Customer(1, "Name", "Address");
            Assert.AreEqual(1, customer.Id);
            Assert.AreEqual("Name", customer.Name);
            Assert.AreEqual("Address", customer.Address);
        }

        [TestMethod]
        public void Test_Create_Sorting_Array_Of_Customers_Case_Insensitive()
        {
            //customersArray and customersArray2 are initialized with same values
            var customersArray = new[]
            {
                new Customer(301522637, "Kamil", "Maghar"),
                new Customer(225456874, "kamil", "Haifa"),
                new Customer(545665789, "Yair", "Tel-Aviv"),
                new Customer(856214521, "yair", "Haifa"),
                new Customer(614587542, "amir", "Tel-Aviv"),
                new Customer(456547545, "Amir", "Maghar")
            };
            var customersArray2 = new[]
            {
                new Customer(301522637, "Kamil", "Maghar"),
                new Customer(225456874, "kamil", "Haifa"),
                new Customer(545665789, "Yair", "Tel-Aviv"),
                new Customer(856214521, "yair", "Haifa"),
                new Customer(614587542, "amir", "Tel-Aviv"),
                new Customer(456547545, "Amir", "Maghar")
            };

            //Sorting customersArray
            Array.Sort(customersArray);

            Assert.AreEqual(true, customersArray[0].Equals(customersArray2[4]));
            Assert.AreEqual(true, customersArray[1].Equals(customersArray2[5]));
            Assert.AreEqual(true, customersArray[2].Equals(customersArray2[0]));
            Assert.AreEqual(true, customersArray[3].Equals(customersArray2[1]));
            Assert.AreEqual(true, customersArray[4].Equals(customersArray2[2]));
            Assert.AreEqual(true, customersArray[5].Equals(customersArray2[3]));
        }

        [TestMethod]
        public void Test_Create_Sorting_Array_Of_Customers_AnotherCustomerComparer()
        {
            //customersArray and customersArray2 are initialized with same values
            var customersArray = new[]
            {
                new Customer(301522637, "Kamil", "Maghar"),
                new Customer(225456874, "kamil", "Haifa"),
                new Customer(545665789, "Yair", "Tel-Aviv"),
                new Customer(856214521, "yair", "Haifa"),
                new Customer(614587542, "amir", "Tel-Aviv"),
                new Customer(456547545, "Amir", "Maghar")
            };
            var customersArray2 = new[]
            {
                new Customer(301522637, "Kamil", "Maghar"),
                new Customer(225456874, "kamil", "Haifa"),
                new Customer(545665789, "Yair", "Tel-Aviv"),
                new Customer(856214521, "yair", "Haifa"),
                new Customer(614587542, "amir", "Tel-Aviv"),
                new Customer(456547545, "Amir", "Maghar")
            };

            //Sorting customersArray using a comparer
            var comparer = new AnotherCustomerComparer();
            Array.Sort(customersArray, comparer);

            Assert.AreEqual(true, customersArray[0].Equals(customersArray2[1]));
            Assert.AreEqual(true, customersArray[1].Equals(customersArray2[0]));
            Assert.AreEqual(true, customersArray[2].Equals(customersArray2[5]));
            Assert.AreEqual(true, customersArray[3].Equals(customersArray2[2]));
            Assert.AreEqual(true, customersArray[4].Equals(customersArray2[4]));
            Assert.AreEqual(true, customersArray[5].Equals(customersArray2[3]));
        }

        [TestMethod]
        public void Test_Equals_Success()
        {
            var customer1 = new Customer(1, "Kamil", "Maghar");
            var customer2 = new Customer(1, "Kamil", "Maghar");
            Assert.AreEqual(true, customer1.Equals(customer2));
            Assert.AreEqual(true, customer2.Equals(customer1));
            Assert.AreEqual(true, customer1.Equals(customer1));
        }

        [TestMethod]
        public void Test_Equals_Failure()
        {
            var customer1 = new Customer(1, "Amir", "Maghar");
            var customer2 = new Customer(1, "Kamil", "Maghar");
            Assert.AreEqual(false, customer1.Equals(customer2));

            customer1 = new Customer(1, "Amir", "Maghar");
            customer2 = new Customer(2, "Amir", "Maghar");
            Assert.AreEqual(false, customer2.Equals(customer1));

            customer1 = new Customer(2, "Amir", "Maghar");
            customer2 = new Customer(2, "Amir", "Haifa");
            Assert.AreEqual(true, customer1.Equals(customer2)); // The Equals method returns true if the Name and Id are equal.
        }

        [TestMethod]
        public void Test_Equals_To_NULL()
        {
            var customer1 = new Customer(1, "Amir", "Maghar");
            Assert.AreEqual(false, customer1.Equals(null));
        }
    }
}
