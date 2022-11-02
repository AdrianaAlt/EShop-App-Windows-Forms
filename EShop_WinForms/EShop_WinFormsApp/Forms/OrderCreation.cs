using MAS_WinFormsApp.DTO;
using MAS_WinFormsApp.Helpers;
using MAS_WinFormsApp.Services;
using System.Data;
using System.Windows.Forms;

namespace MAS_WinFormsApp.Forms
{
    public partial class OrderCreation : Form, IDataGridView
    {
        private EShopDBRepository _database;
        private OrderDTO _order;

        private BindingSource _source;

        public OrderCreation()
        {
            InitializeComponent();
        }
        public OrderCreation(EShopDBRepository database, OrderDTO order) : this()
        {
            if (database == null) throw new Exception("[Error]: Database can not be null");
            if (order == null) throw new Exception("[Error]: Order can not be null");

            _database = database;
            _order = order;
            _source = new BindingSource();
            _source.DataSource = _order.OrderLines;
            InitDataGridView(orderLinesTable, _source);

            fullNameLabel.Text = order.Customer.CustomerName;
            ReloadOrderPrice();
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            if (_order.OrderLines.Count() == 0)
            {
                MessageBox.Show(
                    "Order can not be placed, because there are no order lines added",
                    "No order lines were added",
                    MessageBoxButtons.OK);
                return;
            }
            if (!_database.PlaceOrder(_order))
            {
                MessageBox.Show(
                    "An error occured during order placement",
                    "Order didn't placed",
                    MessageBoxButtons.OK);
                return;
            }
            MessageBox.Show(
                    "Your order was successfully placed",
                    "Order placed",
                    MessageBoxButtons.OK);
            this.FormClosing -= OrderCreation_FormClosing;
            FormsController.SwitchWindowForm(new OrderSummary(_database, _order));
        }
        private void removeItemFromOrderButton_Click(object sender, EventArgs e)
        {
            if (orderLinesTable.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "No item was selected",
                    "To remove item, it should be selected",
                    MessageBoxButtons.OK);
                return;
            }
            var confirmation = MessageBox.Show(
                "Do you really want to remove this order line from your order?",
                "Removing order line confirmation",
                MessageBoxButtons.YesNo
            );
            if (confirmation != DialogResult.Yes) return;

            var selectedOrderLine = (OrderLineDTO)orderLinesTable.CurrentRow.DataBoundItem;
            if (!_database.RemoveItemFromOrder(_order, selectedOrderLine))
            {
                MessageBox.Show(
                    "Error occured during removing order line from order, please try again later.",
                    "Removing item error",
                     MessageBoxButtons.OK);
                return;
            }
            MessageBox.Show(
                    "Item was successfully removed from order",
                    "Order line was removed",
                    MessageBoxButtons.OK);
            RefreshDataGridView();
            ReloadOrderPrice();
        }
        private void showItemsListButton_Click(object sender, EventArgs e)
        {
            FormsController.SwitchWindowForm(new ItemsList(_database, _order));
        }


        private void ReloadOrderPrice()
        {
            totalOrderPriceField.Text = _order.TotalPrice.ToString();
        }
        public override void Refresh()
        {
            base.Refresh();
            ReloadOrderPrice();
            RefreshDataGridView();
        }

        public void InitDataGridView(DataGridView view, BindingSource source)
        {
            orderLinesTable.AutoGenerateColumns = false;
            orderLinesTable.Columns[0].HeaderText = "Nr.";
            orderLinesTable.Columns[0].Name = "RowId";
            orderLinesTable.Columns[1].HeaderText = "Item";
            orderLinesTable.Columns[1].DataPropertyName = "ItemPreview";
            orderLinesTable.Columns[2].HeaderText = "Unit Price";
            orderLinesTable.Columns[2].DataPropertyName = "ItemPrice";
            orderLinesTable.Columns[3].HeaderText = "Quantity";
            orderLinesTable.Columns[3].DataPropertyName = "ItemQuantity";
            orderLinesTable.Columns[4].HeaderText = "Price";
            orderLinesTable.Columns[4].DataPropertyName = "Price";
            orderLinesTable.DataSource = source;
        }

        public void EnumerateRows(DataGridView view, string keyRowName)
        {
            foreach (DataGridViewRow r in view.Rows)
            {
                r.Cells[keyRowName].Value = r.Index + 1;
            }
        }
        public void RefreshDataGridView()
        {
            _source.ResetBindings(false);
        }

        private void orderLinesTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            EnumerateRows(orderLinesTable, "RowId");
        }
        private void exitAction_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void OrderCreation_FormClosing(object sender, FormClosingEventArgs e)
        {
            var message = "Do you really want to cancel your order?";
            if (_order.OrderLines.Count != 0)
            {
                message = "There are order lines. After close this order will be cancelled." + message;
            }
            var res = MessageBox.Show(
                    message,
                    "Close confirmation",
                     MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes && _database.CancelOrder(_order))
            {
                FormsController.CloseWindow(this);
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
