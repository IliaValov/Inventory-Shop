using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using InventoryShop.Data.Entities.BaseEntity;

namespace InventoryShop.Data.Entities
{
    public class Inventory : BaseEntity<Guid>
    {
        public Inventory()
        {
            this.Items = new HashSet<Item>();
        }

        [ForeignKey("Wallet")]
        public Guid WalletId { get; set; }
        public Wallet Wallet { get; set; }

        public ICollection<Item> Items { get; set; }

    }
}
