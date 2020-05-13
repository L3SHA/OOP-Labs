using PluginsInterface;
using System;
using System.Collections.Generic;

namespace Plugins
{
    public class SortPlugin : IPlugin
    {
        private class ItemComparator : IComparer<Item>
        {
            public int Compare(Item x, Item y)
            {
                int res = Compare(x, y);
                if (res > 0)
                    return 1;
                else if (res < 0)
                    return -1;
                else
                    return 0;
            }

        }
        public void SortItemList(List<Item> items, string sortName)
        {
            //List<Item>.Sort(items, new ItemComparator());
            items.Sort(new ItemComparator());
        }
    }
}
