using System.Collections.Generic;

namespace GildedRose
{
    public static class ItemList
    {
        public static List<Item> Get()
        {
            return new List<Item>
            {
                new Item {Name = ItemNames.Vest, SellIn = 10, Quality = 20},
                new Item {Name = ItemNames.Cheese, SellIn = 2, Quality = 0},
                new Item {Name = ItemNames.Elixir, SellIn = 5, Quality = 7},
                new Item {Name = ItemNames.Sulfuras, SellIn = 0, Quality = 80},
                new Item {Name = ItemNames.Sulfuras, SellIn = -1, Quality = 80},
                new Item
                {
                    Name = ItemNames.BackStagePass,
                    SellIn = 15,
                    Quality = 20
                },
                new Item
                {
                    Name = ItemNames.BackStagePass,
                    SellIn = 10,
                    Quality = 49
                },
                new Item
                {
                    Name = ItemNames.BackStagePass,
                    SellIn = 5,
                    Quality = 49
                },
                new Item {Name = ItemNames.Cake, SellIn = 3, Quality = 6}
            };
        }
    }
}
