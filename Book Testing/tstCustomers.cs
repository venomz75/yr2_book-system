using System;
using BookClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Book_Testing
{
    [TestClass]
    public class tstCustomers
    {
        public object ACustomer { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign data to the property
            ACustomer.PremiumMember = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.PremiumMember, TestData);

        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DateAdded, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //Create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //Create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACustomer.CustomerID = TestData;
            //test to see tha the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            //Create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //Create some test data to aaign to the property
            string TestData = "33, Some Street, Some City, Some Postcode";
            //assign the data to the property
            ACustomer.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Address, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //Create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //Create some test data to aaign to the property
            string TestData = "test@gmail.com";
            //assign the data to the property
            ACustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Email, TestData);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            //Create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //Create some test data to aaign to the property
            string TestData = "A Name";
            //assign the data to the property
            ACustomer.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Name, TestData);


        }
    }
}
