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

        [Test]
        public void QualityDegradesTwiceAsFastAfterSellByDate()
        {
            // Arrange
            IList<Item> items = new List<Item> { new Item { Name = "Item", SellIn = 0, Quality = 10 } };
            GildedRose app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(8, items[0].Quality);
        }

        [Test]
        public void QualityIsNeverNegative()
        {
            // Arrange
            IList<Item> items = new List<Item> { new Item { Name = "Item", SellIn = 10, Quality = 0 } };
            GildedRose app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(0, items[0].Quality);
        }

        [Test]
        public void AgedBrieIncreasesInQuality()
        {
            // Arrange
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(11, items[0].Quality);
        }

        [Test]
        public void QualityIsNeverMoreThan50()
        {
            // Arrange
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 50 } };
            GildedRose app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(50, items[0].Quality);
        }

        [Test]
        public void SulfurasNeverChanges()
        {
            // Arrange
            IList<Item> items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(10, items[0].SellIn);
            Assert.AreEqual(10, items[0].Quality);
        }

        [Test]
        public void BackstagePassesQualityIncreasesBy2When10DaysOrLess()
        {
            // Arrange
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(12, items[0].Quality);
        }

        [Test]
        public void BackstagePassesQualityIncreasesBy3When5DaysOrLess()
        {
            // Arrange
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 10 } };
            GildedRose app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(13, items[0].Quality);
        }

        [Test]
        public void BackstagePassesQualityDropsToZeroAfterConcert()
        {
            // Arrange
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 10 } };
            GildedRose app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(0, items[0].Quality);
        }
    }
}
