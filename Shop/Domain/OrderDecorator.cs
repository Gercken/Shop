using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain
{
    public abstract class OrderDecorator : Order
    {
        protected Order order;

        protected OrderDecorator(Order order)
        {
            this.order = order;
        }
    }
}
