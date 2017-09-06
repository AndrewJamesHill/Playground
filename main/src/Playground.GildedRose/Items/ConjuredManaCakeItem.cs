using Playground.GildedRose.Common;
using Playground.GildedRose.Items.Base;

namespace Playground.GildedRose.Items
{
    public class ConjuredManaCakeItem : BaseItem
    {
        public ConjuredManaCakeItem()
        {
            Name = Constants.ConjuredManaCake;
        }

        public override void UpdateItem()
        {
            if (Quality > 0)
            {
                Quality--;
            }

            SellIn--;
            if (SellIn < 0)
            {
                if (Quality > 0)
                {
                    Quality--;
                }
            }
        }
    }
}
