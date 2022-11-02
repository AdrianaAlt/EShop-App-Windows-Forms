using MAS_WinFormsApp.Models.Additional;
using MAS_WinFormsApp.Models.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_WinFormsApp.Models.Warehouses
{
    [Table("Warehouses")]
    public class Warehouse
    {
        [Key]
        public int Id { get; private set; }
        public int AddressId { get; set; }
        [MaxLength(30)]
        public string Name { get; private set; }
        [Required]
        [ForeignKey("AddressId")]
        public virtual Address LocationAddress { get; private set; }
        public virtual ICollection<WarehouseItem> WarehouseItems => _warehouseItems;

        private ICollection<WarehouseItem> _warehouseItems = new HashSet<WarehouseItem>();


        protected Warehouse() { }
        public Warehouse(Address address, string? name = null)
        {
            LocationAddress = address;
            Name = name;
        }

        public WarehouseItem FindWarehouseItem(Item item)
        {
            return WarehouseItems.Where(el => el.StoredItem == item).FirstOrDefault();
        }
        public void AddWarehouseItem(WarehouseItem warehouseItem)
        {
            if (warehouseItem == null) throw new ArgumentException("Warehouse item can not be null");
            if (warehouseItem.WarehouseStorage != this) throw new ArgumentException("Can not add warehouse item from another warehouse to selected one");
            if (WarehouseItems.Contains(warehouseItem)) return;

            WarehouseItems.Add(warehouseItem);
        }

        public void RemoveWarehouseItem(WarehouseItem warehouseItem)
        {
            if (warehouseItem == null) return;
            if (!WarehouseItems.Contains(warehouseItem)) return;
            WarehouseItems.Remove(warehouseItem);
            warehouseItem.Remove();
        }
        public void RemoveWarehouseItem(Item item)
        {
            RemoveWarehouseItem(FindWarehouseItem(item));
        }

        private static void RemoveWarehouse(Warehouse warehouse)
        {
            if (warehouse == null) return;
            foreach (WarehouseItem warehouseItem in new HashSet<WarehouseItem>(warehouse.WarehouseItems))
                warehouse.RemoveWarehouseItem(warehouseItem);
        }

        public override string ToString()
        {
            return $"Warehouse nr={Id}, Address={LocationAddress.Postcode}. ";
        }
    }
}
