using MAS_WinFormsApp.Models.Items;
using MAS_WinFormsApp.Models.Persons.Employees;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MAS_WinFormsApp.Models.Warehouses
{
    [Table("WarehouseItems")]
    public class WarehouseItem
    {
        [Key]
        public int Id { get; private set; }
        public int ItemId { get; private set; }
        public int WarehouseId { get; private set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int ItemQuantity { 
            get {
                return _itemQuantity;
            }
            private set {
                _itemQuantity = value;
            } 
        }
        [Required]
        [ForeignKey("ItemId")]
        public virtual Item StoredItem
        {
            get { return _item; }
            private set
            {
                _item = value;
                _item.AddWarehouseItem(this);
            }
        }
        [Required]
        [ForeignKey("WarehouseId")]
        public virtual Warehouse WarehouseStorage
        {
            get { return _warehouse; }
            private set
            {
                _warehouse = value;
                _warehouse.AddWarehouseItem(this);
            }
        }

        private Item _item;
        private Warehouse _warehouse;
        private int _itemQuantity;


        public WarehouseItem() { }
        public WarehouseItem(Warehouse warehouse, Item item, int itemQuantity)
        {
            if (warehouse == null) throw new ArgumentNullException("Warehouse can not be null");
            if (item == null) throw new ArgumentNullException("Item can not be null");
            StoredItem = item;
            WarehouseStorage = warehouse;
            ItemQuantity = itemQuantity;
        }

        public void Remove()
        {
            RemoveItem();
            RemoveWarehouse();
        }
        private void RemoveItem()
        {
            if (_item == null) return;
            _item.RemoveWarehouseItem(this);
            _item = null;
        }
        private void RemoveWarehouse()
        {
            if (_warehouse == null) return;
            _warehouse.RemoveWarehouseItem(this);
            _warehouse = null;
        }

        public void IncreaseItemUnitsNumber(int quantity)
        {
            _itemQuantity += quantity;
        }
        public void ReduceItemUnitsNumber(int quantity)
        {
            if (quantity > _itemQuantity) throw new ArgumentOutOfRangeException($"Can't reduce available items quantity by {quantity}");
            _itemQuantity -= quantity;
            if (_itemQuantity == 0) Remove();
        }

        public static void AddWarehouseItem(Employee employee, Warehouse warehouse, Item item, int quantity)
        {
            if (employee == null || employee.JobType != Job.WarehouseWorker) return;
            new WarehouseItem(warehouse, item, quantity);
        }
        public static void RemoveWarehouseItem(Employee employee, WarehouseItem warehouseItem)
        {
            if (employee == null || employee.JobType != Job.WarehouseWorker) return;
            warehouseItem.Remove();
        }
    }
}
