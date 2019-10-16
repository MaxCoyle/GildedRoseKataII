namespace GildedRose
{
    public abstract class ItemStrategy
    {
        public const int MaxQuality = 50;
        public const int MinQuality = 0;
        public const int MinSellIn = 0;
        public const int FirstSellInThreshold = 11;
        public const int SecondSellInThreshold = 6;
        public abstract void Update(Item item);
    }

    public class CheeseItemStrategy : ItemStrategy
    {
        public override void Update(Item item)
        {
            if (item.Quality < MaxQuality)
            {
                item.IncreaseQuality();
            }

            item.DecreaseSellIn();

            if (item.SellIn < MinSellIn)
            {
                if (item.Quality < MaxQuality)
                {
                    item.IncreaseQuality();
                }
            }
        }
    }

    public class SulfurasItemStrategy : ItemStrategy
    {
        public override void Update(Item item)
        {
            if (item.Quality > MinQuality)
            {
                if (item.Name != ItemNames.Sulfuras)
                {
                    item.DecreaseQuality();
                }
            }

            item.DecreaseSellIn();
        }
    }

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
