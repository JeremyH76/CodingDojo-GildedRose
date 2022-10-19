using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("foo", Items[0].Name);
        }

        [Fact]
        public void StandardTest()
        {
            List<Item> items = new List<Item> { new Item { Name = "apple", SellIn = 5, Quality = 3 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.Equal(4, items[0].SellIn);
            Assert.Equal(2, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(3, items[0].SellIn);
            Assert.Equal(1, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(2, items[0].SellIn);
            Assert.Equal(0, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(1, items[0].SellIn);
            Assert.Equal(0, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(0, items[0].SellIn);
            Assert.Equal(0, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(-1, items[0].SellIn);
            Assert.Equal(0, items[0].Quality);
        }

        [Fact]
        public void TestWith2StandardItems()
        {
            List<Item> items = new List<Item> { new Item { Name = "apple", SellIn = 5, Quality = 3 }, new Item { Name = "water", SellIn = 100, Quality = 40 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.Equal(4, items[0].SellIn);
            Assert.Equal(2, items[0].Quality);
            Assert.Equal(99, items[1].SellIn);
            Assert.Equal(39, items[1].Quality);
        }

        [Fact]
        public void TestAfterSellIn()
        {
            List<Item> items = new List<Item> { new Item { Name = "apple", SellIn = 1, Quality = 8 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.Equal(0, items[0].SellIn);
            Assert.Equal(7, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(-1, items[0].SellIn);
            Assert.Equal(5, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(-2, items[0].SellIn);
            Assert.Equal(3, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(-3, items[0].SellIn);
            Assert.Equal(1, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(-4, items[0].SellIn);
            Assert.Equal(0, items[0].Quality);
        }

        [Fact]
        public void AgedBrieTest()
        {
            List<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 8 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.Equal(1, items[0].SellIn);
            Assert.Equal(9, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(0, items[0].SellIn);
            Assert.Equal(10, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(-1, items[0].SellIn);
            Assert.Equal(12, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(-2, items[0].SellIn);
            Assert.Equal(14, items[0].Quality);
        }

        [Fact]
        public void AgedBrieTestMax50Quality()
        {
            List<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 47 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.Equal(1, items[0].SellIn);
            Assert.Equal(48, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(0, items[0].SellIn);
            Assert.Equal(49, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(-1, items[0].SellIn);
            Assert.Equal(50, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(-2, items[0].SellIn);
            Assert.Equal(50, items[0].Quality);
        }

        [Fact]
        public void SulfurasTest()
        {
            List<Item> items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 2, Quality = 47 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.Equal(2, items[0].SellIn);
            Assert.Equal(47, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(2, items[0].SellIn);
            Assert.Equal(47, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(2, items[0].SellIn);
            Assert.Equal(47, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(2, items[0].SellIn);
            Assert.Equal(47, items[0].Quality);
        }

        [Fact]
        public void BackstageTest()
        {
            List<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 12, Quality = 5 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.Equal(11, items[0].SellIn);
            Assert.Equal(6, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(10, items[0].SellIn);
            Assert.Equal(7, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(9, items[0].SellIn);
            Assert.Equal(9, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(8, items[0].SellIn);
            Assert.Equal(11, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(7, items[0].SellIn);
            Assert.Equal(13, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(6, items[0].SellIn);
            Assert.Equal(15, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(5, items[0].SellIn);
            Assert.Equal(17, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(4, items[0].SellIn);
            Assert.Equal(20, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(3, items[0].SellIn);
            Assert.Equal(23, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(2, items[0].SellIn);
            Assert.Equal(26, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(1, items[0].SellIn);
            Assert.Equal(29, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(0, items[0].SellIn);
            Assert.Equal(32, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(-1, items[0].SellIn);
            Assert.Equal(0, items[0].Quality);
            app.UpdateQuality();
            Assert.Equal(-2, items[0].SellIn);
            Assert.Equal(0, items[0].Quality);
        }

        [Fact]
        public void TestSulfuraWithOtherItem()
        {
            List<Item> items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 2, Quality = 47 }, new Item { Name = "apple", SellIn = 12, Quality = 12 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.Equal(2, items[0].SellIn);
            Assert.Equal(47, items[0].Quality);
            Assert.Equal(11, items[1].SellIn);
            Assert.Equal(11, items[1].Quality);
        }
    }
}
