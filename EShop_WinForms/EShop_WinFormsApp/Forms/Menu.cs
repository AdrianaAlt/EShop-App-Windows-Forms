using MAS_WinFormsApp.DTO;
using MAS_WinFormsApp.Helpers;
using MAS_WinFormsApp.Models.Persons.Customers;
using MAS_WinFormsApp.Services;
namespace MAS_WinFormsApp.Forms
{
    // Show order history
    public partial class Menu : Form, IDataGridView
    {
        private EShopDBRepository _database;
        private ICustomerDTO _customer;

        private BindingSource _source;
        private ICollection<OrderDTO> _customerOrders;


        public Menu()
        {
            InitializeComponent();
        }
        public Menu(EShopDBRepository database, ICustomerDTO customer) : this()
        {
            if (database == null) throw new Exception("[Error]: Database can not be null");
            if (customer == null) throw new Exception("[Error]: Customer can not be null");

            _database = database;
            _customer = customer;
            fullNameLabel.Text = _customer.CustomerName;

            // connect objects list with dataGridView
            _source = new BindingSource();
            _customerOrders = new List<OrderDTO>();
            _source.DataSource = _customerOrders;
            InitDataGridView(ordersTable, _source);

            // load data from db and fill dataGridView
            RefreshDataGridView();
        }


        // after adding new order, datagridview must be updated
        public void RefreshDataGridView()
        {
            _customerOrders.Clear();
            _database.GetOrders(_customer).ToList().ForEach(_customerOrders.Add);
            _source.ResetBindings(false);
        }

        // initilization of order history table
        public void InitDataGridView(DataGridView view, BindingSource source)
        {
            ordersTable.AutoGenerateColumns = false;
            ordersTable.Columns[0].HeaderText = "Nr.";
            ordersTable.Columns[0].Name = "RowId";
            ordersTable.Columns[0].DataPropertyName = "RowId";
            ordersTable.Columns[1].HeaderText = "Order ID";
            ordersTable.Columns[1].DataPropertyName = "Id";
            ordersTable.Columns[2].HeaderText = "Date";
            ordersTable.Columns[2].DataPropertyName = "OrderDate";
            ordersTable.Columns[3].HeaderText = "Status";
            ordersTable.Columns[3].DataPropertyName = "Status";
            ordersTable.DataSource = source;
        }
        // auto enumeration of rows in table
        public void EnumerateRows(DataGridView view, string keyRowName)
        {
            foreach (DataGridViewRow r in view.Rows)
            {
                r.Cells[keyRowName].Value = r.Index + 1;
            }
        }
        // after orders list update redraw table
        private void ordersTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            EnumerateRows(ordersTable, "RowId");
        }
        // flow to createOrder form
        private void CreateNewOrderAction_Click(object sender, EventArgs e)
        {
            if (_customer.Status == CustomerStatus.Blocked)
            {
                var message = "Blocked customers can't create orders";
                var caption = "Wrong operation";
                var buttons = MessageBoxButtons.OK;

                MessageBox.Show(message, caption, buttons);
                return;
            }

            var newOrder = _database.CreateOrder(_customer);
            FormsController.SwitchWindowForm(new OrderCreation(_database, newOrder));
        }
        private void exitAction_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show(
                    "Do you really want to exit?",
                    "Exit confirmation",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) FormsController.CloseWindow(this);
                else e.Cancel = true;
            }
        }

        // refresh full windows form
        public override void Refresh()
        {
            base.Refresh();
            RefreshDataGridView();
        }
    }
}
