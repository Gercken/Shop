using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain
{
    public abstract class Order
    {
        public abstract double Cost();

        public abstract string Description();
    }
}
