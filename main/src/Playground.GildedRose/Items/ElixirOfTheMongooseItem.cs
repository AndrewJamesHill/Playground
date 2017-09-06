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
