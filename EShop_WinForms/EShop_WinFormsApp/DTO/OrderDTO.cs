using MAS_WinFormsApp.Models.Order;

namespace MAS_WinFormsApp.DTO
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public DateTime? OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public ICustomerDTO Customer { get; set; }
        public ICollection<OrderLineDTO> OrderLines { get; set; }
        public double TotalPrice => Math.Round(OrderLines.Select(order => order.Price).Sum(), 3);
    }
}
