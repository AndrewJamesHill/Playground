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

        public override void Update()
        {
            IncreaseQuality();

            SellIn--;
            if (SellIn < 0)
            {
                IncreaseQuality();
            }
        }
    }
}
