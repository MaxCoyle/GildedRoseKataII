namespace GildedRose
{
    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public void DecreaseQuality()
        {
            Quality = Quality - 1;
        }

        public void IncreaseQuality()
        {
            Quality = Quality + 1;
        }

        public void DecreaseSellIn()
        {
            if (Name != ItemNames.Sulfuras)
            {
                SellIn = SellIn - 1;
            }
        }
    }
}
