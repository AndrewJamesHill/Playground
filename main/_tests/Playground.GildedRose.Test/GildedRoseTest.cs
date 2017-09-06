using System.Collections.Generic;
using NUnit.Framework;
using Playground.GildedRose.Common;
using Playground.GildedRose.Items;

namespace Playground.GildedRose.Test
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void Plus5DexterityVestTest()
        {
            GildedRose.Items = new List<Item> { new Plus5DexterityVestItem { SellIn = 10, Quality = 20 } };
            GildedRose.UpdateQuality();

            Assert.AreEqual(Constants.Plus5DexterityVest, GildedRose.Items[0].Name);
            Assert.AreEqual(9, GildedRose.Items[0].SellIn);
            Assert.AreEqual(19, GildedRose.Items[0].Quality);
        }

        [Test]
        public void AgedBrieTest()
        {
            GildedRose.Items = new List<Item> { new AgedBrieItem { SellIn = 2, Quality = 0 } };
            GildedRose.UpdateQuality();

            Assert.AreEqual(Constants.AgedBrie, GildedRose.Items[0].Name);
            Assert.AreEqual(1, GildedRose.Items[0].SellIn);
            Assert.AreEqual(1, GildedRose.Items[0].Quality);
        }

        [Test]
        public void ElixirOfTheMongooseTest()
        {
            GildedRose.Items = new List<Item> { new ElixirOfTheMongooseItem { SellIn = 5, Quality = 7 } };
            GildedRose.UpdateQuality();

            Assert.AreEqual(Constants.ElixirOfTheMongoose, GildedRose.Items[0].Name);
            Assert.AreEqual(4, GildedRose.Items[0].SellIn);
            Assert.AreEqual(6, GildedRose.Items[0].Quality);
        }

        [Test]
        public void SulfurasHandOfRagnarosTest()
        {
            GildedRose.Items = new List<Item> { new SulfurasHandOfRagnarosItem { SellIn = 5, Quality = 7 } };
            GildedRose.UpdateQuality();

            Assert.AreEqual(Constants.SulfurasHandOfRagnaros, GildedRose.Items[0].Name);
            Assert.AreEqual(5, GildedRose.Items[0].SellIn);
            Assert.AreEqual(8, GildedRose.Items[0].Quality);
        }

        [Test]
        public void BackstagePassesToATAFKAL80ETCConcertTest()
        {
            GildedRose.Items = new List<Item> { new BackstagePassesToATAFKAL80ETCConcertItem { SellIn = 5, Quality = 7 } };
            GildedRose.UpdateQuality();

            Assert.AreEqual(Constants.BackstagePassesToATAFKAL80ETCConcert, GildedRose.Items[0].Name);
            Assert.AreEqual(4, GildedRose.Items[0].SellIn);
            Assert.AreEqual(10, GildedRose.Items[0].Quality);
        }

        [Test]
        public void ConjuredManaCakeTest()
        {
            GildedRose.Items = new List<Item> { new ConjuredManaCakeItem { SellIn = 3, Quality = 6 } };
            GildedRose.UpdateQuality();

            Assert.AreEqual(Constants.ConjuredManaCake, GildedRose.Items[0].Name);
            Assert.AreEqual(2, GildedRose.Items[0].SellIn);
            Assert.AreEqual(4, GildedRose.Items[0].Quality);
        }
    }
}
