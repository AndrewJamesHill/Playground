using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.GildedRose.Items.TestObjects
{
    public static class TestItems
    {
        public static IList<Item> Inventory
        {
            get
            {
                return new List<Item>()
                {
                    new Plus5DexterityVestItem {SellIn = 10, Quality = 20},
                    new AgedBrieItem {SellIn = 2, Quality = 0},
                    new ElixirOfTheMongooseItem {SellIn = 5, Quality = 7},
                    new SulfurasHandOfRagnarosItem {SellIn = 0, Quality = 80},
                    new SulfurasHandOfRagnarosItem {SellIn = -1, Quality = 80},
                    new BackstagePassesToATAFKAL80ETCConcertItem{SellIn = 15, Quality = 20},
                    new BackstagePassesToATAFKAL80ETCConcertItem{SellIn = 10, Quality = 49},
                    new BackstagePassesToATAFKAL80ETCConcertItem{SellIn = 5, Quality = 49},
                    new ConjuredManaCakeItem {SellIn = 3, Quality = 6}
                };
            }
        }
    }
}
