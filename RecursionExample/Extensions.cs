using System;
using System.Text;

namespace RecursionExample
{
    public static class Extensions
    {
        public static void Show(this Item item)
        {
            ShowTree(item, 0);
        }

        private static void ShowTree(Item parent, int level)
        {
            var spaces = new StringBuilder();
            for (int i = 0; i < level * 2; i++)
                spaces.Append(" ");

            string itemName = parent.Childrens.Count == 0 ? "Leave" : "Group";
            string leavesCount = parent.LeavesCount == 0 ? "" : $"({parent.LeavesCount})";

            Console.WriteLine($"{spaces}{itemName} {leavesCount}");

            parent.Childrens.ForEach(item => ShowTree(item, level + 1));
        }
    }
}
