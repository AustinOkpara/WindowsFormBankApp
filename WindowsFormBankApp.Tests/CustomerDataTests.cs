using BankApp.Data;
using BankApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormBankApp.Tests
{
    [TestFixture]
    public class CustomerDataTest
    {
        [Test]
       public void AddCustomer()
        {
            //Arrange
            var result = new CustomerData();

            //Act

            CustomerModel model = new CustomerModel();
            model.UserId = 1234;
            model.Name = "Austin Okpara";
            model.Password = "@abc123";
            model.Email = "stinzy94@gmail.com";

            var output = result.AddCustomer(model);

            //Assert
           Assert.AreEqual(output,false);
        
        }
        [Test]

        public void GetAllCustomers()
        {
            //Arrange

            var result = new CustomerData();

            //Act

            var output = result.GetAllCustomer();

            //Assert

            Assert.That(output, Is.Not.Null);
        }
        [Test]
         public void LastId()
         {
            var result = new CustomerData();
            int expected = 1234;

            //Act
            var output = result.LastId();

            //Assert
            Assert.That(output, Is.EqualTo(expected));
        }
        [Test]

        public void GetCustomerByEmail()
        {
            var customerData = new CustomerData();

            string expectedEmail = "stinzy94@gmail.com";

            var result = customerData.GetCustomerByEmail(expectedEmail);

            Assert.That("stinzy94@gmail.com", Is.EquivalentTo(expectedEmail)); 
        }
        
            
        
    }
}
