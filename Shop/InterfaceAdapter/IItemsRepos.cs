using Shop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.InterfaceAdapter
{
    internal interface IItemsRepos
    {

        List<Item> GetAllItems();

        void CreateItem(String id, String description, double price);

    }
}
