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
}
