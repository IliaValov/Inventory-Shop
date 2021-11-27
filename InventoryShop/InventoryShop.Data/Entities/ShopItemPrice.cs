using System;
using System.ComponentModel.DataAnnotations.Schema;
using InventoryShop.Data.Entities.BaseEntity;

namespace InventoryShop.Data.Entities
{
    public class ShopItemPrice : BaseEntity<Guid>
    {
        [ForeignKey("Item")]
        public Guid ItemId { get; set; }
        public Item Item { get; set; }

        [ForeignKey("Shop")]
        public Guid ShopId { get; set; }
        public Shop Shop { get; set; }

        public double price { get; set; }
    }
}
