using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Playground.GildedRose.Test
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void Plus5DexterityVestTest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("fixme", Items[0].Name);
        }
    }
}
