using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SimpeStoreTest;
using SimpleStore.Models;
using SimpleStore.Controllers;

namespace SimpeStoreTest
{
    [TestClass]
    public class TestSimpleProducyController
    {
        [TestMethod]
        public void GetAllProducts_ShouldReturnAllProducts()
        {

            var testProducts = GetTestProducts();
            var controller = new SimpleProductController(testProducts);


            var result = controller.GetAllProducts() as List<SimpleProduct>;
            Assert.AreEqual(testProducts.Count, result.Count);

        }
        [TestMethod]
        public async Task GetAllProductsAsync_ShouldReturnAllProducts()
        {
            var testProducts = GetTestProducts();
            var controller = new SimpleProductController(testProducts);

            var result = await controller.GetAllProductsAsync() as List<SimpleProduct>;
            Assert.AreEqual(testProducts.Count, result.Count);
        }

    }
}
