
namespace MAS_WinFormsApp.DTO
{
    public class OrderLineDTO
    {
        public int Id { get; set; }
        public ItemDTO Item { get; set; }
        public OrderDTO Order { get; set; }
        public int ItemQuantity { get; set; }
        public double Price => Math.Round(ItemQuantity * Item.UnitPrice, 2);

        public string ItemPreview => Item.ItemPreview;
        public double ItemPrice => Item.UnitPrice;
    }
}
