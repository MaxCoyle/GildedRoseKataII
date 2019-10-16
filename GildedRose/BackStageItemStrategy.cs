namespace GildedRose
{
    public class BackStageItemStrategy : ItemStrategy
    {
        public override void Update(Item item)
        {
            if (item.Quality < MaxQuality)
            {
                item.IncreaseQuality();

                if (item.SellIn < FirstSellInThreshold)
                {
                    if (item.Quality < MaxQuality)
                    {
                        item.IncreaseQuality();
                    }
                }

                if (item.SellIn < SecondSellInThreshold)
                {
                    if (item.Quality < MaxQuality)
                    {
                        item.IncreaseQuality();
                    }
                }
            }

            item.DecreaseSellIn();

            if (item.SellIn < MinSellIn)
            {
                item.Quality = item.Quality - item.Quality;
            }
        }
    }
}