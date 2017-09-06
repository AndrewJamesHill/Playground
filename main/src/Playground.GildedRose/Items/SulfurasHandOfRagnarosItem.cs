using Playground.GildedRose.Common;
using Playground.GildedRose.Items.Base;

namespace Playground.GildedRose.Items
{
    public class SulfurasHandOfRagnarosItem : BaseItem
    {
        public SulfurasHandOfRagnarosItem()
        {
            Name = Constants.SulfurasHandOfRagnaros;
        }

        public override void UpdateItem()
        {
            if (Quality < 50)
            {
                Quality++;
            }
        }
    }
}
