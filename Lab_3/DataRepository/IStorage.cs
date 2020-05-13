using System.Collections.Generic;
using Storehouse.API;

namespace Storehouse.DataRepository
{
    public interface IStorage
    {
        void AddItem(Item item);
        Item GetItem(string name);
        void DeleteItem(string name);
        void EditItem(string name, Item item);
        List<Item> GetItemList();
    }
}
