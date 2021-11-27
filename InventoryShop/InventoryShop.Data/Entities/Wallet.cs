using System;
using InventoryShop.Data.Entities.BaseEntity;

namespace InventoryShop.Data.Entities
{
    public class Wallet : BaseEntity<Guid>
    {
        public double Copper { get; set; }

        public double Silver { get; set; }

        public double Gold { get; set; }
    }
}
