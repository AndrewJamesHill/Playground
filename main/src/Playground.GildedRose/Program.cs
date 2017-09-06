using Playground.GildedRose.Items.TestObjects;
using System;

namespace Playground.GildedRose
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");            
            GildedRose.Items = TestItems.Inventory;

            for (int i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                foreach(Item item in GildedRose.Items)
                {
                    Console.WriteLine(item.Name + ", " + item.SellIn + ", " + item.Quality);
                }
                Console.WriteLine("");
                GildedRose.UpdateQuality();
            }
        }
    }
}
