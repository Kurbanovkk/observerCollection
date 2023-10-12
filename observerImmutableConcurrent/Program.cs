namespace observerImmutableConcurrent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();
            var customer = new Customer();
            shop.items.CollectionChanged += customer.OnItemChanged;

            while (true)
            {
                Console.WriteLine("Для добавления товара нажмите 'A', для удаления товара нажмите 'D', для выхода нажмите 'X'.");
                var key = Console.ReadKey().Key;
                Console.WriteLine();
                if (key == ConsoleKey.A)
                {
                    string itemName = $"Товар от {DateTime.Now:yyyy-MM-dd HH:mm:ss}";
                    Item newItem = new Item(DateTime.Now.Second, itemName);
                    shop.Add(newItem);
                }
                if (key == ConsoleKey.D)
                {
                    Console.WriteLine("Введите id товара, который нужно удалить: ");
                    var voolean = int.TryParse(Console.ReadLine(), out int itemId);
                    try
                    {
                        shop.Remove(itemId);
                    }
                    catch (Exception ex) 
                    {
                        Console.WriteLine("Введен неверный Id");
                    }
                }
                if (key == ConsoleKey.X) break;
            }

        }
    }
}