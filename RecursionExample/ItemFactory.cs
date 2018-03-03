using System;
using System.Collections.Generic;

namespace RecursionExample
{
    public static class ItemFactory
    {
        // Можешь поменять эту штуку, если хочешь больше слоев
        private static int workingLimit = 5;
        private static Random r = new Random();

        public static List<Item> CreateItems()
        {
            if (workingLimit <= 0)
                return new List<Item>();

            int count = r.Next(1, 4);
            var items = new List<Item>();

            for (int i = 0; i < count; i++)
                items.Add(new Item());

            workingLimit--;

            return items;
        }

        public static Item CreateHead()
        {
            return new Item();
        }
    }
}