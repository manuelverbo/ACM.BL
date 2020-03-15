using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Test
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveProductTest()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(1)
            {
                ProductDescription = "A Product",
                ProductName = "Nutella",
                CurrentPrice = 0
            };
            //Act
            var actual = productRepository.Retrieve(1);
            //Assert
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
        }
    }
}
