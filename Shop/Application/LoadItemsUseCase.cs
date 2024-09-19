using Shop.Domain;
using Shop.InterfaceAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application
{
    internal class LoadItemsUseCase
    {
        private readonly IItemsRepos itemsRepos;
        private List<Item> items;
        private Item randomItem;

        public LoadItemsUseCase( IItemsRepos itemsRepos)
        {
            this.itemsRepos = itemsRepos;
        }

        public void LoadAllItems() 
        {
            items = itemsRepos.GetAllItems();
            foreach (Item item in items)
            {
                Console.WriteLine(item.id + " " + item.description + " " + item.price);
            }

        }

        public Item PickRandomItem() 
        { 
        
            Random random = new Random();
            randomItem = items[random.Next(items.Count)];

            Console.WriteLine(randomItem.id + " " + randomItem.description + " " + randomItem.price);

            return randomItem;
        }

    }
}
