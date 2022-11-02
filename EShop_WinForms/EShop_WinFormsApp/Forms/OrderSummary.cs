using MAS_WinFormsApp.DTO;
using MAS_WinFormsApp.Helpers;
using MAS_WinFormsApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAS_WinFormsApp.Forms
{
    public partial class OrderSummary : Form
    {
        private EShopDBRepository _database;
        private OrderDTO _order;

        public OrderSummary()
        {
            InitializeComponent();
        }

        public OrderSummary(EShopDBRepository database, OrderDTO order) : this()
        {
            if (database == null) throw new Exception("[Error]: Database can not be null");
            if (order == null) throw new Exception("[Error]: Order can not be null");

            _database = database;
            _order = order;
            InitializeOrderSummaryFields();
        }

        public void InitializeOrderSummaryFields()
        {
            customerIdField.Text = _order.Customer.CustomerId.ToString();
            orderIdField.Text = _order.Id.ToString();
            orderDateField.Text = _order.OrderDate.ToString();
            totalPriceField.Text = _order.TotalPrice.ToString();
            var address = _order.Customer.DeliveryAddress;
            deliveryAddressField.Text = $"{address.Country}, {address.City}, {address.Street} {address.StreetNumber}, {address.PostalCode}";
        }

        private void return_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OrderSummary_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormsController.CloseWindow(this);
            FormsController.ReturnToMenu();
        }
    }
}
