using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Domain;
using Shop.Infrastructure;

namespace Shop.Domain
{
    public class Shipment : OrderDecorator
    {
        public Shipment(Order o) : base(o) 
        { 
        }
       

        public override double Cost()
        {
            FileShipmentRepos fileShipmentRepos = new FileShipmentRepos();

            return order.Cost() + fileShipmentRepos.GetShipmentPrice();

            
        }

        public override string Description()
        {
            FileShipmentRepos fileShipmentRepos = new FileShipmentRepos();

            return order.Description() + ", Plus shipping";
        }
    }
}
