using Playground.GildedRose.Common;
using Playground.GildedRose.Items.Base;
using System.Collections.Generic;

namespace Playground.GildedRose
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> items)
        {
            Items = items;
        }

        public void UpdateQuality()
        {
            foreach(BaseItem item in Items)            
            {
                item.Update();
            }
        }
    }
}
