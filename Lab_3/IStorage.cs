using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_3
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
