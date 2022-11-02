using MAS_WinFormsApp.Models.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_WinFormsApp.Models.Order
{
    [Table("OrderLines")]
    public class OrderLine
    {
        [Key]
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int OrderId { get; set; }

        [Required, Range(0, int.MaxValue)]
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value >= MIN_QUANTITY)
                {
                    _quantity = value;

                }
                else throw new ArgumentException($"Quantity must be greater than {MIN_QUANTITY}");
            }
        }
        [NotMapped]
        public double Price => Quantity * Item.UnitPrice;
        [Required]
        [ForeignKey("ItemId")]
        public virtual Item Item
        {
            get => _item;
            set
            {
                if (value == null) throw new ArgumentNullException("The given item doesn't exist!");
                if (value == _item) return;
                _item = value;
                _item.AddOrderLine(this);
            }
        }
        [Required]
        [ForeignKey("OrderId")]
        public virtual CustomerOrder Order { get; private set; }


        private Item _item;
        private int _quantity;
        private const int MIN_QUANTITY = 1;


        protected OrderLine() { }
        private OrderLine(CustomerOrder order, Item item, int quantity)
        {
            if (item.TotalQuantity < quantity) 
                throw new ArgumentOutOfRangeException("Selected item quantity is greater than available qunatity.");
            Quantity = quantity;
            Order = order;
            Item = item;

            order.AddOrderLine(this);
        }

        public static OrderLine CreateOrderLine(CustomerOrder order, Item item, int quantity)
        {
            if (order == null) throw new ArgumentNullException("The given order does not exist!");
            OrderLine orderLine = new OrderLine(order, item, quantity);
            
            return orderLine;
        }

        public void Remove()
        {
            if (Order == null || Order.Status != OrderStatus.InProcess) return;
            Order.RemoveOrderLine(this);
            Order = null;

            if (_item == null) return;
            _item.RemoveOrderLine(this);
            _item = null;
        }

        public static bool PlaceOrderLine(OrderLine orderLine)
        {
            return orderLine.Item.ReduceQuantity(orderLine.Quantity);
        }

        public override string ToString()
        {
            return $"Order Line Details: name={Item.ItemName}, description={Quantity}, unit price={Price}. ";
        }
    }
}
