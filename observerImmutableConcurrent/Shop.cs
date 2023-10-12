using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerImmutableConcurrent
{
    internal class Shop
    {
        public ObservableCollection<Item> items { get; }

        public Shop()
        {
            items = new ObservableCollection<Item>();
        }

        public void Add(Item item)
        {
            items.Add(item);
        }

        public void Remove(int itemId) 
        {
            var itemToRemove = items.First(item => item.Id == itemId);
            if (itemToRemove != null)
            {
                items.Remove(itemToRemove);
            }
        }
    }
}
