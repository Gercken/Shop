using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Domain;
using Shop.Infrastructure;
using Shop.InterfaceAdapter;

namespace Shop.Domain
{
    internal class GiftWrapping : OrderDecorator
    {

        public GiftWrapping(Order o) : base(o)
        {
        }

        public override double Cost()
        {
            IGiftWrapping fileGiftWrappingRepos = new FileGiftWrappingRepos();

            return order.Cost() + fileGiftWrappingRepos.GetGiftWrappingPrice();
        }

        public override string Description()
        {
            IGiftWrapping fileGiftWrappingRepos = new FileGiftWrappingRepos();

            return order.Description() + ", Plus Gift Wrapping";
        }
    }
}
