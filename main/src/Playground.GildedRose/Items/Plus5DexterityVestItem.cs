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
            DecreaseQuality();

            SellIn--;
            if (SellIn < 0)
            {
                DecreaseQuality();
            }
        }
    }
}
