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
                item.UpdateItem();
                if (item.Name != Constants.AgedBrie && item.Name != Constants.BackstagePassesToATAFKAL80ETCConcert)
                {
                    if (item.Quality > 0)
                    {
                        if (item.Name != Constants.SulfurasHandOfRagnaros)
                        {
                            item.Quality--;
                        }
                    }
                }
                else
                {
                    if (item.Quality < 50)
                    {
                        item.Quality++;

                        if (item.Name == Constants.BackstagePassesToATAFKAL80ETCConcert)
                        {
                            if (item.SellIn < 11)
                            {
                                if (item.Quality < 50)
                                {
                                    item.Quality++;
                                }
                            }

                            if (item.SellIn < 6)
                            {
                                if (item.Quality < 50)
                                {
                                    item.Quality++;
                                }
                            }
                        }
                    }
                }

                if (item.Name != Constants.SulfurasHandOfRagnaros)
                {
                    item.SellIn--;
                }

                if (item.SellIn < 0)
                {
                    if (item.Name != Constants.AgedBrie)
                    {
                        if (item.Name != Constants.BackstagePassesToATAFKAL80ETCConcert)
                        {
                            if (item.Quality > 0)
                            {
                                if (item.Name != Constants.SulfurasHandOfRagnaros)
                                {
                                    item.Quality--;
                                }
                            }
                        }
                        else
                        {
                            item.Quality = item.Quality - item.Quality;
                        }
                    }
                    else
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality++;
                        }
                    }
                }
            }
        }
    }
}
