using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.GildedRose.Items.Base
{
    public abstract class BaseItem : Item
    {
        public abstract void Update();

        public void IncreaseQuality()
        {
            if (Quality < 50)
            {
                Quality++;
            }
        }

        public void DecreaseQuality()
        {
            if (Quality > 0)
            {
                Quality--;
            }
        }
    }
}
