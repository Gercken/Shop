using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Domain;
using Shop.Infrastructure;

namespace Shop.Domain
{
    internal class GiftWrapping : OrderDecorator
    {

        public GiftWrapping(Order o) : base(o)
        {
        }

        public override double Cost()
        {
            FileGiftWrappingRepos fileGiftWrappingRepos = new FileGiftWrappingRepos();

            return order.Cost() + fileGiftWrappingRepos.GetGiftWrappingPrice();
        }

        public override string Description()
        {
            FileGiftWrappingRepos fileGiftWrappingRepos = new FileGiftWrappingRepos();

            return order.Description() + ", Plus Gift Wrapping";
        }
    }
}
