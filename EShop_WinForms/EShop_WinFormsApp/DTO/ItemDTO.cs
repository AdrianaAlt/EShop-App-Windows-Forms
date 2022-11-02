using MAS_WinFormsApp.Models.Items;
using MAS_WinFormsApp.Models.Order;
using MAS_WinFormsApp.Models.Warehouses;

namespace MAS_WinFormsApp.DTO
{
    public class ItemDTO
    {
        public int Id { get; set; }
        public string UpcCode { get; set; }
        public string ItemName { get; set; }
        public ItemType ItemType { get; set; }
        public string? Description { get; set; }
        public double UnitPrice { get; set; }
        public string SpecificInfo { get; set; }
        public ICollection<WarehouseItemDTO> WarehouseItems { get; set; }
        public int CommonQuantity
        {
            get => WarehouseItems != null ? WarehouseItems.Sum(el => el.Quantity) : 0;
        }

        public string ItemPreview => $"{ItemType} {ItemName}";
    }
}
