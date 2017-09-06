using Playground.GildedRose.Common;
using Playground.GildedRose.Items.Base;

namespace Playground.GildedRose.Items
{
    public class ElixirOfTheMongooseItem : BaseItem
    {
        public ElixirOfTheMongooseItem()
        {
            Name = Constants.ElixirOfTheMongoose;
        }

        public override void Update()
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
