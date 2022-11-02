using MAS_WinFormsApp.Models.Additional;
using MAS_WinFormsApp.Models.Persons.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_WinFormsApp.DTO
{
    public class CustomerDTO : ICustomerDTO
    {
        public int CustomerId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public CustomerStatus Status { get; set; }
        public AddressDTO DeliveryAddress { get; set; }
        public string CustomerName { get; set; }
        public ISet<OrderDTO> CustomerOrders { get; set; }
    }
}
