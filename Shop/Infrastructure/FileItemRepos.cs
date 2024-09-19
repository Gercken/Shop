using Shop.Domain;
using Shop.InterfaceAdapter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure
{
    internal class FileItemRepos : IItemsRepos
    {

        public List<Item> GetAllItems()
        {
            List<Item> items = new List<Item>();
            var TextFiles = Directory.EnumerateFiles("C:\\Users\\AlexG\\source\\repos\\Shop\\Shop\\ShopTxtFiles\\");
            
            foreach (var TextFile in TextFiles)
            {
                StreamReader streamReader = new StreamReader(TextFile);
                String line = streamReader.ReadLine();

                string[] lineArr = line.Split(",");

                items.Add(new Item(lineArr[0], lineArr[1], double.Parse(lineArr[2])));
            }

            return items;
        }

        public void CreateItem(string id, string description, double price)
        {
            throw new NotImplementedException();
        }
    }
}
