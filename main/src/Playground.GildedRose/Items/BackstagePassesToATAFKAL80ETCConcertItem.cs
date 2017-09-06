using Playground.GildedRose.Common;
using Playground.GildedRose.Items.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.GildedRose.Items
{
    public class BackstagePassesToATAFKAL80ETCConcertItem : BaseItem
    {
        public BackstagePassesToATAFKAL80ETCConcertItem()
        {
            Name = Constants.BackstagePassesToATAFKAL80ETCConcert;
        }

        public override void UpdateItem()
        {
            if (Quality < 50)
            {
                Quality++;


                if (SellIn < 11)
                {
                    if (Quality < 50)
                    {
                        Quality++;
                    }
                }

                if (SellIn < 6)
                {
                    if (Quality < 50)
                    {
                        Quality++;
                    }
                }
            }

            SellIn--;
            if (SellIn < 0)
            {
                Quality = Quality - Quality;
            }
        }
    }
}
