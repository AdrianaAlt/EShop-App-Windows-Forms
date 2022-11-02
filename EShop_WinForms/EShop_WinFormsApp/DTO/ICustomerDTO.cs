using MAS_WinFormsApp.Models.Additional;
using MAS_WinFormsApp.Models.Persons.Customers;

namespace MAS_WinFormsApp.DTO
{
    public interface ICustomerDTO
    {
        public int CustomerId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public CustomerStatus Status { get; set; }
        public AddressDTO DeliveryAddress { get; set; }
        public string CustomerName { get; }

        public ISet<OrderDTO> CustomerOrders { get; set; }
    }
}
