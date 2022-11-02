using MAS_WinFormsApp.Models.Additional;
using MAS_WinFormsApp.Models.Persons.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_WinFormsApp.DTO
{
    public class CorporateCustomerDTO : CustomerDTO
    {
        public string ContactName { get; set; }
        public double CreditLimit { get; set; }
        public new string CustomerName => ContactName;
    }
}
