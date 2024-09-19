using Shop.Application;
using Shop.Domain;
using Shop.Infrastructure;
using Shop.InterfaceAdapter;

namespace Shop.Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("start\n");


            Console.WriteLine("----------Use Case 1----------");
            LoadItemsUseCase loadItemsUseCase = new LoadItemsUseCase(new FileItemRepos());
            loadItemsUseCase.LoadAllItems();
            Console.WriteLine();

            Console.WriteLine("----------Use Case 2----------");
            Order order = loadItemsUseCase.PickRandomItem();
            Console.WriteLine();

            Console.WriteLine("----------Use Case 3----------");
            order = new GiftWrapping(order);
            Console.WriteLine(order.Description() + " " + order.Cost());
            Console.WriteLine();

            Console.WriteLine("----------Use Case 4----------");
            order = new Shipment(order);
            Console.WriteLine(order.Description() + " " + order.Cost());
            Console.WriteLine();

            Console.WriteLine("----------Use Case 5----------");
            Console.WriteLine(order.Description() + " " + order.Cost());



            Console.Read();
        }
    }
}
