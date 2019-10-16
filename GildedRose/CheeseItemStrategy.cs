namespace GildedRose
{
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
}