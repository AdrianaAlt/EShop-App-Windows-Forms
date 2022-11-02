using MAS_WinFormsApp.Models.Additional;
using MAS_WinFormsApp.Models.Order;
using MAS_WinFormsApp.Models.Persons.Customers;
using MAS_WinFormsApp.Models.Persons.Employees;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MAS_WinFormsApp.Models.Persons.Customers
{
    public abstract class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
        [Required(ErrorMessage ="Email is required"), MaxLength(30)]
        [Index(IsUnique = true)]
        public string Email { get; private set; }
        [Required(ErrorMessage = "Password is required"), MaxLength(15)]
        public string Password { get; private set; }
        [ForeignKey("AddressId")]
        public virtual Address DeliveryAddress { get; private set; }

        public abstract string CustomerName { get; }

        public virtual CustomerStatus CurrentCustomerStatus { get; private set; }
        public virtual ICollection<CustomerOrder> Orders => _orders;


        private ICollection<CustomerOrder> _orders = new HashSet<CustomerOrder>();

        protected Customer() { }
        public Customer(string email, string password, Address deliveryAddress)
        {
            Email = email;
            Password = password;
            DeliveryAddress = deliveryAddress;
            CurrentCustomerStatus = CustomerStatus.Active;
        }

        public bool IsBlocked()
        {
            return CurrentCustomerStatus == CustomerStatus.Blocked;
        }
        public bool IsActive()
        {
            return CurrentCustomerStatus == CustomerStatus.Active;
        }

        public static string GetCustomerInfo(Customer customer)
        {
            if (customer == null) throw new ArgumentNullException("[Error]: customer info can not be returned, because customer object is null.");
            if (customer is IndividualCustomer)
            {
                var individual = customer as IndividualCustomer;
                return $"Customer: {individual.Person.FullName}";
            }
            else if (customer is CorporateCustomer)
            {
                var corporate = customer as CorporateCustomer;
                return $"Customer: {corporate.ContactName}";
            }
            return null;
        }

        public CustomerOrder? FindOrderById(int idOrder)
        {
            if (!IsActive()) return null;
            return Orders.SingleOrDefault(el => idOrder == el.Id);
        }

        public void AddOrder(CustomerOrder order)
        {
            if (!IsActive()) return;
            if (Orders.Any(el => order.Id == order.Id)) return;
            Orders.Add(order);
            order.Customer = this;
        }

        public static void BlockCustomer(Employee emp, Customer customer)
        {
            if (emp == null || customer == null || customer.CurrentCustomerStatus == CustomerStatus.Blocked) return;

            customer.CurrentCustomerStatus = CustomerStatus.Blocked;
        }
        public static void UnblockCustomer(Employee emp, Customer customer)
        {
            if (emp == null || customer == null || customer.CurrentCustomerStatus == CustomerStatus.Active) return;

            customer.CurrentCustomerStatus = CustomerStatus.Active;
        }

        public override string ToString()
        {
            return $"{Email}";
        }
    }
}
