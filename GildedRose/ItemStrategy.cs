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

    public class VestItemStrategy : ItemStrategy
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

    public class CheeseItemStrategy : ItemStrategy
    {
        public override void Update(Item item)
        {
            if (item.Name != ItemNames.Cheese && item.Name != ItemNames.BackStagePass)
            {
                if (item.Quality > MinQuality)
                {
                    if (item.Name != ItemNames.Sulfuras)
                    {
                        item.DecreaseQuality();
                    }
                }
            }
            else
            {
                if (item.Quality < MaxQuality)
                {
                    item.IncreaseQuality();

                    if (item.Name == ItemNames.BackStagePass)
                    {
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
                }
            }

            item.DecreaseSellIn();

            if (item.SellIn < MinSellIn)
            {
                if (item.Name != ItemNames.Cheese)
                {
                    if (item.Name != ItemNames.BackStagePass)
                    {
                        if (item.Quality > MinQuality)
                        {
                            if (item.Name != ItemNames.Sulfuras)
                            {
                                item.DecreaseQuality();
                            }
                        }
                    }
                    else
                    {
                        item.Quality = item.Quality - item.Quality;
                    }
                }
                else
                {
                    if (item.Quality < MaxQuality)
                    {
                        item.IncreaseQuality();
                    }
                }
            }
        }
    }

    public class ElixirItemStrategy : ItemStrategy
    {
        public override void Update(Item item)
        {
            if (item.Name != ItemNames.Cheese && item.Name != ItemNames.BackStagePass)
            {
                if (item.Quality > MinQuality)
                {
                    if (item.Name != ItemNames.Sulfuras)
                    {
                        item.DecreaseQuality();
                    }
                }
            }
            else
            {
                if (item.Quality < MaxQuality)
                {
                    item.IncreaseQuality();

                    if (item.Name == ItemNames.BackStagePass)
                    {
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
                }
            }

            item.DecreaseSellIn();

            if (item.SellIn < MinSellIn)
            {
                if (item.Name != ItemNames.Cheese)
                {
                    if (item.Name != ItemNames.BackStagePass)
                    {
                        if (item.Quality > MinQuality)
                        {
                            if (item.Name != ItemNames.Sulfuras)
                            {
                                item.DecreaseQuality();
                            }
                        }
                    }
                    else
                    {
                        item.Quality = item.Quality - item.Quality;
                    }
                }
                else
                {
                    if (item.Quality < MaxQuality)
                    {
                        item.IncreaseQuality();
                    }
                }
            }
        }
    }

    public class SulfurasItemStrategy : ItemStrategy
    {
        public override void Update(Item item)
        {
            if (item.Name != ItemNames.Cheese && item.Name != ItemNames.BackStagePass)
            {
                if (item.Quality > MinQuality)
                {
                    if (item.Name != ItemNames.Sulfuras)
                    {
                        item.DecreaseQuality();
                    }
                }
            }
            else
            {
                if (item.Quality < MaxQuality)
                {
                    item.IncreaseQuality();

                    if (item.Name == ItemNames.BackStagePass)
                    {
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
                }
            }

            item.DecreaseSellIn();

            if (item.SellIn < MinSellIn)
            {
                if (item.Name != ItemNames.Cheese)
                {
                    if (item.Name != ItemNames.BackStagePass)
                    {
                        if (item.Quality > MinQuality)
                        {
                            if (item.Name != ItemNames.Sulfuras)
                            {
                                item.DecreaseQuality();
                            }
                        }
                    }
                    else
                    {
                        item.Quality = item.Quality - item.Quality;
                    }
                }
                else
                {
                    if (item.Quality < MaxQuality)
                    {
                        item.IncreaseQuality();
                    }
                }
            }
        }
    }

    public class BackStageItemStrategy : ItemStrategy
    {
        public override void Update(Item item)
        {
            if (item.Name != ItemNames.Cheese && item.Name != ItemNames.BackStagePass)
            {
                if (item.Quality > MinQuality)
                {
                    if (item.Name != ItemNames.Sulfuras)
                    {
                        item.DecreaseQuality();
                    }
                }
            }
            else
            {
                if (item.Quality < MaxQuality)
                {
                    item.IncreaseQuality();

                    if (item.Name == ItemNames.BackStagePass)
                    {
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
                }
            }

            item.DecreaseSellIn();

            if (item.SellIn < MinSellIn)
            {
                if (item.Name != ItemNames.Cheese)
                {
                    if (item.Name != ItemNames.BackStagePass)
                    {
                        if (item.Quality > MinQuality)
                        {
                            if (item.Name != ItemNames.Sulfuras)
                            {
                                item.DecreaseQuality();
                            }
                        }
                    }
                    else
                    {
                        item.Quality = item.Quality - item.Quality;
                    }
                }
                else
                {
                    if (item.Quality < MaxQuality)
                    {
                        item.IncreaseQuality();
                    }
                }
            }
        }
    }

    public class CakeItemStrategy : ItemStrategy
    {
        public override void Update(Item item)
        {
            if (item.Name != ItemNames.Cheese && item.Name != ItemNames.BackStagePass)
            {
                if (item.Quality > MinQuality)
                {
                    if (item.Name != ItemNames.Sulfuras)
                    {
                        item.DecreaseQuality();
                    }
                }
            }
            else
            {
                if (item.Quality < MaxQuality)
                {
                    item.IncreaseQuality();

                    if (item.Name == ItemNames.BackStagePass)
                    {
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
                }
            }

            item.DecreaseSellIn();

            if (item.SellIn < MinSellIn)
            {
                if (item.Name != ItemNames.Cheese)
                {
                    if (item.Name != ItemNames.BackStagePass)
                    {
                        if (item.Quality > MinQuality)
                        {
                            if (item.Name != ItemNames.Sulfuras)
                            {
                                item.DecreaseQuality();
                            }
                        }
                    }
                    else
                    {
                        item.Quality = item.Quality - item.Quality;
                    }
                }
                else
                {
                    if (item.Quality < MaxQuality)
                    {
                        item.IncreaseQuality();
                    }
                }
            }
        }
    }
}
