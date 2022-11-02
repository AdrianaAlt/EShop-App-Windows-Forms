using MAS_WinFormsApp.DTO;
using MAS_WinFormsApp.Helpers;
using MAS_WinFormsApp.Services;

namespace MAS_WinFormsApp.Forms
{
    public partial class ItemDetails : Form
    {
        private EShopDBRepository _database;
        private ItemDTO _selectedItem;
        private OrderDTO _order;

        private bool _isInCart = false;
        private int _quantity => (int)quantityField.Value;

        public ItemDetails()
        {
            InitializeComponent();
        }

        public ItemDetails(EShopDBRepository database, OrderDTO order, ItemDTO selectedItem) : this()
        {
            if (database == null) throw new Exception("[Error]: Database can not be null");
            if (selectedItem == null) throw new Exception("[Error]: Item can not be null");
            if (order == null) throw new Exception("[Error]: Order can not be null");

            _database = database;
            _order = order;
            _selectedItem = selectedItem;
            InitializeItemDetailsFields();
        }

        public void InitializeItemDetailsFields()
        {
            upcCodeField.Text = _selectedItem.UpcCode;
            itemNameField.Text = _selectedItem.ItemName;
            typeField.Text = _selectedItem.ItemType.ToString();
            unitPriceField.Text = $"{_selectedItem.UnitPrice}$";
            itemDescriptionField.Text = _selectedItem.Description;
            itemSpecDetailsField.Text = _selectedItem.SpecificInfo;
            quantityField.Maximum = _selectedItem.CommonQuantity;

            //check if item was already added
            var existingOrderLine = _order.OrderLines.SingleOrDefault(el => el.Item.UpcCode == _selectedItem.UpcCode);
            _isInCart = existingOrderLine != null;
            // if exiists set quantity from existing order line
            var quantityInOrder = existingOrderLine?.ItemQuantity;
            quantityField.Value = (decimal)(quantityInOrder == null ? 1 : quantityInOrder);
            // show message that item was already added
            infoMessage.Text = existingOrderLine == null ? "" : "item is already in your shopping cart";
            // unit price * selected quantity
            ShowTotalPrice();
        }

        private void quantityField_ValueChanged(object sender, EventArgs e)
        {
            ShowTotalPrice();
        }
        private void addItemToOrderButton_Click(object sender, EventArgs e)
        {
            if (!_database.AddItemToOrder(_order, _selectedItem, _quantity))
            {
                var message = $"Error occured during adding item to order. Please try again later.";
                var caption = "Adding item error";
                var buttons = MessageBoxButtons.OK;

                MessageBox.Show(message, caption, buttons);
                return;
            }
            else
            {
                string message = !_isInCart 
                    ? "Item successfully added to order"
                    : "Order line containing this item was successfully updated";
                var caption = "Item was added to order";
                var buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);

                Close();
            }
        }
        public void ShowTotalPrice()
        {
            totalPriceField.Text = Math.Round(_selectedItem.UnitPrice * _quantity, 2).ToString();
        }
        private void returnToItems_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ItemDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormsController.CloseWindow(this);
        }
    }
}
