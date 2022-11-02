using MAS_WinFormsApp.Models.Items;
using MAS_WinFormsApp.Models.Persons.Customers;
using MAS_WinFormsApp.Models.Persons.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_WinFormsApp.Models.Order
{
    [Table("CustomerOrders")]
    public class CustomerOrder
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? OrderDate { get; private set; }
        public virtual OrderStatus Status { get; private set; }
        public double TotalPrice => OrderLines.Select(order => order.Price).Sum();


        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer
        {
            get { return _customer; }
            set
            {
                if (value == null) throw new NullReferenceException("Customer can not be null");
                if (_customer == value) return;
                if (_customer != null) throw new ArgumentException("The order's client can not be changed");
                _customer = value;
                _customer.AddOrder(this);
            }
        }
        public virtual ICollection<OrderLine> OrderLines => _orderLines;

        private ICollection<OrderLine> _orderLines = new HashSet<OrderLine>();
        private Customer _customer;


        protected CustomerOrder() { }
        public CustomerOrder(Customer customer)
        {
            OrderDate = DateTime.Now;
            Customer = customer;
            Status = OrderStatus.InProcess;
        }
        public bool PlaceOrder()
        {
            if (Status != OrderStatus.InProcess) return false;

            foreach (OrderLine orderLine in OrderLines)
            {
                var res = OrderLine.PlaceOrderLine(orderLine);
                if (!res) return false;
            }
            Status = OrderStatus.Placed;
            return true;
        }
        public bool CancelOrder()
        {
            if (Status == OrderStatus.Cancelled || Status == OrderStatus.Shipped) return false;
            Status = OrderStatus.Cancelled;
            return true;
        }
        public void ShipOrder(Deliveryman deliveryman)
        {
            if (deliveryman == null) throw new NullReferenceException("Deliveryman can not be null");
            if (Status != OrderStatus.Placed) throw new NullReferenceException("Order should be placed before it will be shipped");
            Status = OrderStatus.Shipped;
        }


        public void AddOrderLine(OrderLine orderLine)
        {
            if (orderLine.Order == null) throw new Exception("This order line not connected with orders");
            if (orderLine.Order != this) throw new Exception("Can not reassign an order in order line");
            OrderLines.Add(orderLine);
        }
        public void RemoveOrderLine(OrderLine orderLine)
        {
            if (orderLine == null) throw new Exception("Order line can not be null");
            if (!OrderLines.Contains(orderLine)) return;
            if (orderLine.Order != this) return;
            if (Status != OrderStatus.InProcess) return;

            OrderLines.Remove(orderLine);
            orderLine.Remove();
        }

        public override string ToString()
        {
            return $"Order Details: id={Id}, date={OrderDate}, customer={Customer}, address={Customer.DeliveryAddress}, total price={TotalPrice}";
        }
    }
}
