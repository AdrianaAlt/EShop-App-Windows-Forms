namespace MAS_WinFormsApp.Models.Warehouses
{
    public class WarehouseItemQuantityComparer : IComparer<WarehouseItem>
    {
        public int Compare(WarehouseItem x, WarehouseItem y)
        {
            return y.ItemQuantity.CompareTo(x.ItemQuantity);
        }
    }
}
