using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerImmutableConcurrent
{
    internal class Customer
    {
        public void OnItemChanged(object? sendler, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (Item newItem in e.NewItems)
                    {
                        Console.WriteLine($"Добавлен товар: {newItem.Name} (Id: {newItem.Id})");
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (Item oldItem in e.OldItems)
                    {
                        Console.WriteLine($"удален товар: {oldItem.Name} (Id: {oldItem.Id})");
                    }
                    break;
            }
        }
    }
}
