using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void TestUpdateQuality()
        {
            //Arrange
            IList<Item> items = new List<Item> { new Item { Name = "Item", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(items);

            //Act
            app.UpdateQuality();

            //Assert
            Assert.AreEqual("Item", items[0].Name);
            Assert.AreEqual(9, items[0].SellIn);
            Assert.AreEqual(9, items[0].Quality);
        }
    }
}
