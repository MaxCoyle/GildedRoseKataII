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
        private static Dictionary<string, ItemStrategy> ItemStrategies => new Dictionary<string, ItemStrategy>
        {
            { ItemNames.Vest, new DecreasingItemStrategy() },
            { ItemNames.Cheese, new CheeseItemStrategy() },
            { ItemNames.Elixir, new DecreasingItemStrategy() },
            { ItemNames.Sulfuras, new SulfurasItemStrategy() },
            { ItemNames.BackStagePass, new BackStageItemStrategy() },
            { ItemNames.Cake, new DecreasingItemStrategy() }
        };

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
                _items = ItemList.Get()
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
            ItemStrategy matchingItemStrategy = null;

            foreach (var itemStrategy in ItemStrategies)
            {
                if (item.Name.ToLower().Contains(itemStrategy.Key.ToLower()))
                {
                    matchingItemStrategy = itemStrategy.Value;
                }
            }

            matchingItemStrategy?.Update(item);
        }

        private static void AppendToOutputString(string line)
        {
            ConsoleOutputString += line;
            ConsoleOutputString += "\r\n";
        }
    };
}
