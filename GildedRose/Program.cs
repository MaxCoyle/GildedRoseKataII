using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace GildedRose
{
    public class Program
    {
        public static string ConsoleOutputString { get; set; }
        private IList<Item> _items;

        private static void Main(string[] args)
        {
            BuildConsoleOutput();
            System.Console.Write(ConsoleOutputString);
            System.Console.ReadKey();
        }

        public static void BuildConsoleOutput()
        {
            AppendToOutputString("OMGHAI!");

            var app = new Program()
            {
                _items = new List<Item>
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
                    // this conjured item does not work properly yet
                    new Item {Name = ItemNames.Cake, SellIn = 3, Quality = 6}
                }

            };

            for (var i = 0; i < 31; i++)
            {
                AppendToOutputString("-------- day " + i + " --------");
                AppendToOutputString("name, sellIn, quality");
                for (var j = 0; j < app._items.Count; j++)
                {
                    AppendToOutputString(
                        app._items[j].Name + ", " + app._items[j].SellIn + ", " + app._items[j].Quality);
                }

                AppendToOutputString("");
                app.UpdateQuality();
            }

        }

        private void UpdateQuality()
        {
            foreach (var item in _items)
            {
                ApplyUpdateRulesToItem(item);
            }
        }

        private static void ApplyUpdateRulesToItem(Item item)
        {
            var itemStrategies = GetItemStrategies();
            ItemStrategy matchingItemStrategy = null;

            foreach (var itemStrategy in itemStrategies)
            {
                if (item.Name.ToLower().Contains(itemStrategy.Key.ToLower()))
                {
                    matchingItemStrategy = itemStrategy.Value;
                }
            }

            matchingItemStrategy?.Update(item);
        }

        private static Dictionary<string, ItemStrategy> GetItemStrategies()
        {
            var itemStrategies = new Dictionary<string, ItemStrategy>
            {
                { ItemNames.Vest, new VestItemStrategy() },
                { ItemNames.Cheese, new CheeseItemStrategy() },
                { ItemNames.Elixir, new ElixirItemStrategy() },
                { ItemNames.Sulfuras, new SulfurasItemStrategy() },
                { ItemNames.BackStagePass, new BackStageItemStrategy() },
                { ItemNames.Cake, new CakeItemStrategy() }
            };

            return itemStrategies;
        }   

        private static void AppendToOutputString(string line)
        {
            ConsoleOutputString += line;
            ConsoleOutputString += "\r\n";
        }
    };

}
