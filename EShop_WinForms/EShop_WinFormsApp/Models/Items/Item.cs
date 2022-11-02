using MAS_WinFormsApp.Models.Order;
using MAS_WinFormsApp.Models.Warehouses;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MAS_WinFormsApp.Models.Items
{
    public abstract partial class Item
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage="UPC code is required")]
        [Index(IsUnique =true)]
        [MaxLength(12), MinLength(12)]
        [RegularExpression(@"^([0-9]{12,12})$")]
        public string UpcCode { get; set; }
        [Required(ErrorMessage="Item name is required"), MaxLength(40)]
        public string ItemName { get; set; }
        [MaxLength(250)]
        public string? Description { get; set; }
        [Range(0.01, double.PositiveInfinity)]
        public double UnitPrice { get; set; }
        [Required]
        public virtual ItemType Type { get; }
        [NotMapped]
        public abstract string SpecificInfo { get; }
        [NotMapped]
        public int TotalQuantity => WarehouseItems.Sum(wi => wi.ItemQuantity);
        public ICollection<WarehouseItem> WarehouseItems => _warehouseItems;
        public ICollection<OrderLine> OrderLines => _orderLines;


        private ICollection<WarehouseItem> _warehouseItems = new SortedSet<WarehouseItem>(new WarehouseItemQuantityComparer());
        private ICollection<OrderLine> _orderLines = new List<OrderLine>();

        protected Item() { }
        public Item(string upcCode, string itemName, double unitPrice, string? description = null)
        {
            UpcCode = upcCode;
            ItemName = itemName;
            Description = description;
            UnitPrice = unitPrice;
        }

        public void AddOrderLine(OrderLine orderLine)
        {
            if (orderLine == null) return;
            if (OrderLines.Contains(orderLine)) return;
            if (orderLine.Item == null) throw new Exception("Order line " + orderLine + " was removed");
            if (orderLine.Item != this) throw new Exception("Can not reassign order line item");
            OrderLines.Add(orderLine);
            orderLine.Item = this;
        }
        public void RemoveOrderLine(OrderLine orderLine)
        {
            if (orderLine == null) throw new NullReferenceException("Order line can not be null");
            if (!OrderLines.Contains(orderLine)) return;
            OrderLines.Remove(orderLine);
            orderLine.Remove();
        }

        public bool ReduceQuantity(int quantity)
        {
            if (quantity < 0 || quantity > TotalQuantity) return false;
            int quantityToReserve = quantity;
            foreach( var warehouseItem in WarehouseItems)
            {
                int reductionNumber = (quantityToReserve > warehouseItem.ItemQuantity) ? warehouseItem.ItemQuantity : quantityToReserve;
                warehouseItem.ReduceItemUnitsNumber(reductionNumber);
                quantityToReserve -= reductionNumber;
                if (quantityToReserve == 0) return true;
            }
            return false;
        }

        public WarehouseItem? FindWarehouseItem(Warehouse warehouse)
        {
            return WarehouseItems
                    .Where(el => el.WarehouseStorage == warehouse)
                    .FirstOrDefault();
        }
        public void AddWarehouseItem(WarehouseItem warehouseItem)
        {
            if (warehouseItem == null) throw new ArgumentNullException("Warehouse item can not be null");
            if (warehouseItem.StoredItem != this) throw new ArgumentException("Can not add warehouse item with another item to selected one");
            if (WarehouseItems.Contains(warehouseItem)) return;

            WarehouseItems.Add(warehouseItem);
        }
        public void RemoveWarehouseItem(WarehouseItem warehouseItem)
        {
            if (warehouseItem == null) return;
            if (!WarehouseItems.Contains(warehouseItem)) return;

            _warehouseItems.Remove(warehouseItem);
            warehouseItem.Remove();
        }
        public void RemoveWarehouseItem(Warehouse warehouse)
        {
            if (warehouse == null) return;

            WarehouseItem? warehouseItem = WarehouseItems.Where(wi => wi.WarehouseStorage == warehouse).FirstOrDefault();
            if (warehouseItem == null) throw new Exception("There is no items " + ItemName + " in warehouse nr." + warehouse.Id);
            _warehouseItems.Remove(warehouseItem);
            warehouseItem.Remove();
        }


        public override string ToString()
        {
            return $"Item Details: code={UpcCode}, name={ItemName}, description={Description}, unit price={UnitPrice}. ";
        }
    }
}
