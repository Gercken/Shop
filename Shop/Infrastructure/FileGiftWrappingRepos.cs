using Shop.InterfaceAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure
{
    internal class FileGiftWrappingRepos : IGiftWrapping
    {
        public int GetGiftWrappingPrice()
        {
            int price = 0;

            StreamReader sr = new StreamReader("C:\\Users\\AlexG\\source\\repos\\Shop\\Shop\\GiftWrappingTxt\\GiftWrapping.txt");
            string line = sr.ReadLine();
            price = int.Parse(line);

            return price;
        }
    }
}
