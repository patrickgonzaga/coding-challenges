using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperMarketKata;

namespace UnitTestSuperMarketKata
{
    [TestClass]
    public class ProductItemTestcs
    {
        [TestMethod]
        public void GetAmount()
        {
            ItemInventory myDB = new ItemInventory();

            ProductItem item = new ProductItem("A", myDB);

            Assert.AreEqual(50, item.GetAmount());

            item.Quantity = 5;
            Assert.AreEqual(230, item.GetAmount());

            item.Quantity = 7;
            Assert.AreEqual(310, item.GetAmount());

        }
    }
}
