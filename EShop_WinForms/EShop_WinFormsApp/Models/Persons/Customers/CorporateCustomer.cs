using MAS_WinFormsApp.Models.Additional;
using MAS_WinFormsApp.Models.Persons.Customers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MAS_WinFormsApp.Models.Persons.Customers
{
    [Table("CorporateCustomers")]
    public class CorporateCustomer : Customer
    {
        [Required(ErrorMessage="Contact name is required"), MaxLength(100)]
        public string ContactName { get; private set; }
        [Required(ErrorMessage ="Credit limit is required"), Range(0, double.PositiveInfinity)]
        public double CreditLimit { get; private set; }

        public override string CustomerName => ContactName;

        protected CorporateCustomer() : base() { }
        public CorporateCustomer(string email, string password, string contactName, Address address, double creditLimit)
        : base(email, password, address)
        {
            ContactName = contactName;
            CreditLimit = creditLimit;
        }
    }
}
