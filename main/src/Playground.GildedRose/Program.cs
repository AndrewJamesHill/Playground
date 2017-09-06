using Playground.GildedRose.Common;
using Playground.GildedRose.Items;
using System;
using System.Collections.Generic;

namespace Playground.GildedRose
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<Item> items = new List<Item>()
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

            GildedRose app = new GildedRose(items);

            for (int i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                foreach(Item item in items)
                {
                    Console.WriteLine(item.Name + ", " + item.SellIn + ", " + item.Quality);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}
