using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperMarketKata;
using System.Data;

namespace UnitTestSuperMarketKata
{
    [TestClass]
    public class ItemInventoryTest
    {
        [TestMethod]
        public void GetItemInventoryUnitPrice()
        {
            ItemInventory myDB = new ItemInventory();

            DataRow[] found = myDB.GetSKUDetail("A");

            Assert.AreEqual(50, int.Parse(found[0]["UnitPrice"].ToString()));

        }
    }
}
