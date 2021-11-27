using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using InventoryShop.Data.Entities.BaseEntity;

namespace InventoryShop.Data.Entities
{
    public class Shop : BaseEntity<Guid>
    {
        public Shop()
        {
            this.Items = new HashSet<ShopItemPrice>();
        }

        public string Name { get; set; }

        [ForeignKey("Wallet")]
        public Guid WalletId { get; set; }
        public Wallet Wallet { get; set; }

        public ICollection<ShopItemPrice> Items { get; set; }
    }
}
