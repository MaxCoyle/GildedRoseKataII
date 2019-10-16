using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose
{
    public class DecreasingItemStrategy : ItemStrategy
    {
        public override void Update(Item item)
        {
            if (item.Quality > MinQuality)
            {
                item.DecreaseQuality();
            }

            item.DecreaseSellIn();

            if (item.SellIn < MinSellIn)
            {
                if (item.Quality > MinQuality)
                {
                    item.DecreaseQuality();
                }
            }
        }
    }
}
