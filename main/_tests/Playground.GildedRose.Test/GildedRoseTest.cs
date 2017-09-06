using System.Collections.Generic;
using NUnit.Framework;
using Playground.GildedRose.Items;
using Playground.GildedRose.Common;

namespace Playground.GildedRose.Test
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void Plus5DexterityVestTest()
        {
            IList<Item> Items = new List<Item> { new Plus5DexterityVestItem { SellIn = 10, Quality = 20 } };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            Assert.AreEqual(Constants.Plus5DexterityVest, Items[0].Name);
            Assert.AreEqual(9, Items[0].SellIn);
            Assert.AreEqual(19, Items[0].Quality);
        }
    }
}
