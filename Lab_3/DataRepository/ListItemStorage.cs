using System;
using System.Collections.Generic;
using Storehouse.API;

namespace Storehouse.DataRepository
{
    public class ListItemStorage : IStorage
    {
        private static ListItemStorage listItemStorage;
        private static Dictionary<string, Item> items;
        private event Action UpdateUI;
        private ListItemStorage()
        {
            items = new Dictionary<string, Item>();
        }

        public static ListItemStorage GetInstance()
        {
            if(null == listItemStorage)
            {
                listItemStorage = new ListItemStorage();
            }
            return listItemStorage;
        }

        public void SubscribeUIUpdate(Action handleDataUpdate)
        {
            UpdateUI += handleDataUpdate;
        }

        public void AddItem(Item item)
        {
            if(items.ContainsKey(item.Name))
            {
                items.Remove(item.Name);
                items.Add(item.Name, item);
            }
            else
            {
                items.Add(item.Name, item);
            }
            UpdateUI?.Invoke();
        }

        public void DeleteItem(string name)
        {
            items.Remove(name);
            Console.WriteLine(name);
            UpdateUI?.Invoke();
        }

        public void EditItem(string name, Item item)
        {
            throw new NotImplementedException();
        }

        public Item GetItem(string name)
        {
            return items[name];
        }

        public List<Item> GetItemList()
        {
            var itemList = new List<Item>();
            foreach(string name in items.Keys)
            {
                itemList.Add(items[name]);
            }
            return itemList;
        }

        public void ClearItemList()
        {
            items.Clear();
        }
    }
}
