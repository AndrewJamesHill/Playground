using Playground.GildedRose.Common;
using Playground.GildedRose.Items.Base;

namespace Playground.GildedRose.Items
{
    public class AgedBrieItem : BaseItem
    {
        public AgedBrieItem()
        {
            Name = Constants.AgedBrie;
        }

        public override void UpdateItem()
        {
            if (Quality < 50)
            {
                Quality++;                
            }

            SellIn--;
            if (SellIn < 0)
            {
                if (Quality < 50)
                {
                    Quality++;
                }
            }
        }
    }
}
