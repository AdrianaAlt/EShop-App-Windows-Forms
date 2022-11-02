using MAS_WinFormsApp.Models.Additional;
using MAS_WinFormsApp.Models.Persons.Customers;
using MAS_WinFormsApp.Models.Persons;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MAS_WinFormsApp.Models.Persons.Customers
{
    [Table("IndividualCustomers")]
    public class IndividualCustomer : Customer
    {
        public long CreditCardId { get; private set; }
        [Required(ErrorMessage ="Personal data can not be null")]
        public virtual Person Person
        {
            get { return person; }
            private set
            {
                if (value == null) throw new ArgumentException("Personal data can not be null");
                if (Person == value) return;
                if (Person != null) throw new Exception("Person can not be changed");
                person = value;
            }
        }

        public override string CustomerName => Person.FullName;

        private Person person;

        protected IndividualCustomer() : base() { }
        public IndividualCustomer(Person person, string email, string password, Address deliveryAddress, long creditCardId)
        : base(email, password, deliveryAddress)
        {
            Person = person;
            CreditCardId = creditCardId;
        }

        public static void RemoveCustomer(IndividualCustomer individualCustomer)
        {
            if (individualCustomer == null) return;
            individualCustomer.Person.StopBeingIndividualCustomer();
            individualCustomer.person = null;
        }
    }
}
