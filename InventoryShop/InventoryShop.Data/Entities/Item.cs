using System;
using InventoryShop.Data.Entities.BaseEntity;
using InventoryShop.Data.Entities.Enums;

namespace InventoryShop.Data.Entities
{
    public class Item : BaseEntity<Guid>
    {
        public string Name { get; set; }

        public ItemType ItemType { get; set; }

        public ItemQuality ItemQuality { get; set; }

        public double BasePrice { get; set; }
    }
}
