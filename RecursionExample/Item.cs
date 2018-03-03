using System.Collections.Generic;

namespace RecursionExample
{
    public class Item
    {
        public List<Item> Childrens { get; set; }
        public int LeavesCount { get; set; }
    }
}
