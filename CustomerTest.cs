using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Test
{
    /// <summary>
    /// Questa classe di test permette di verificare 
    /// che la classe customer si comporti correttamente.
    /// </summary>
    [TestClass]
    public class CustomerTest
    {
        /// <summary>
        /// Verifica se il nome completo viene composto correttamente 
        /// </summary>
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";
            //Act
            string actual = customer.FullName;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };
            string expected = customer.FullName;
            //Act
            string actual = customer.FirstName;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //Arrange
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };
            string expected = customer.FullName;
            //Act
            string actual = customer.LastName;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test per verificare che il numero di istanze corrisponda correttamente con il contatore statico di un oggetto
        /// </summary>
        [TestMethod]
        public void StaticTest()
        {
            var customer1 = new Customer();
            customer1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var customer2 = new Customer();
            customer2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var customer3 = new Customer();
            customer3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            //Act
            var expected = 3;
            //Assert
            Assert.AreEqual(expected, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //--Arrange
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "fbaggins@hobbiton.me"
            };
            var expected = true;
            //--act
            var actual = customer.Validate();
            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] 
        public void ValidateMissingLastName()
        {
            //--Arrange
            var customer = new Customer
            {
                EmailAddress = "fbaggins@hobbiton.me"
            };
            var expected = false;
            //--act
            var actual = customer.Validate();
            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingEmailAddress()
        {
            //--Arrange
            var customer = new Customer
            {
                LastName = "Baggins"
            };
            var expected = false;
            //--act
            var actual = customer.Validate();
            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
