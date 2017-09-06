using Playground.GildedRose.Common;
using Playground.GildedRose.Items.Base;
using System.Collections.Generic;

namespace Playground.GildedRose
{
    public static class GildedRose
    {
        public static IList<Item> Items;
        public static void UpdateQuality()
        {
            foreach(BaseItem item in Items)            
            {
                item.Update();
            }
        }
    }
}
