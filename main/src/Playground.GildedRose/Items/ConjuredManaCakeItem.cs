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

        public override void Update()
        {
            DecreaseQuality();
            DecreaseQuality();

            SellIn--;
            if (SellIn < 0)
            {
                DecreaseQuality();
                DecreaseQuality();
            }
        }
    }
}
