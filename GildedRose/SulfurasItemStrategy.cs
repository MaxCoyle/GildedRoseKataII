namespace GildedRose
{
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
}