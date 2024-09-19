using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain
{
    public class Item : Order
    {
        public string id { get; set; }
        public string description { get; set; }
        public double price { get; set; }

        public Item(string id, string description, double price)
        {
            this.id = id;
            this.description = description;
            this.price = price;
        }

        public override double Cost()
        {
            return price;
        }

        public override string Description()
        {
            return description;
        }
    }
}
