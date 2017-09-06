using Playground.GildedRose.Common;
using Playground.GildedRose.Items.Base;

namespace Playground.GildedRose.Items
{
    public class Plus5DexterityVestItem : BaseItem
    {
        public Plus5DexterityVestItem()
        {
            Name = Constants.Plus5DexterityVest;
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
