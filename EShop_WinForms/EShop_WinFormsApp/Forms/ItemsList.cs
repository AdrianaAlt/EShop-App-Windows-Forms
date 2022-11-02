using MAS_WinFormsApp.DTO;
using MAS_WinFormsApp.Helpers;
using MAS_WinFormsApp.Services;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Data;
using System.Windows.Forms;

namespace MAS_WinFormsApp.Forms
{
    public partial class ItemsList : Form, IDataGridView
    {
        private EShopDBRepository _database;
        private OrderDTO _order;

        private ICollection<ItemDTO> _allItems;
        private ICollection<ItemDTO> _filteredItems;
        private BindingSource _source;

        public ItemsList()
        {
            InitializeComponent();
        }
        public ItemsList(EShopDBRepository database, OrderDTO order) : this()
        {
            if (database == null) throw new Exception("[Error]: Database can not be null");
            if (order == null) throw new Exception("[Error]: Order can not be null");

            _source = new BindingSource();
            _database = database;
            _order = order;

            LoadAvailableItemsView();
        }

        private void LoadAvailableItemsView()
        {
            _allItems = _database.GetAvailableItems();
            _filteredItems = new List<ItemDTO>(_allItems);
            _source.DataSource = _filteredItems;

            InitDataGridView(itemsTable, _source);
        }
        public void InitDataGridView(DataGridView view, BindingSource source)
        {
            itemsTable.AutoGenerateColumns = false;
            itemsTable.Columns[0].HeaderText = "Nr.";
            itemsTable.Columns[0].Name = "RowId";
            itemsTable.Columns[0].DataPropertyName = "RowId";
            itemsTable.Columns[1].HeaderText = "UPC code";
            itemsTable.Columns[1].DataPropertyName = "UpcCode";
            itemsTable.Columns[2].HeaderText = "Item";
            itemsTable.Columns[2].DataPropertyName = "ItemPreview";
            itemsTable.Columns[3].HeaderText = "Price";
            itemsTable.Columns[3].DataPropertyName = "UnitPrice";
            itemsTable.DataSource = source;
        }
        public void EnumerateRows(DataGridView view, string keyRowName)
        {
            foreach (DataGridViewRow r in view.Rows)
            {
                r.Cells[keyRowName].Value = r.Index + 1;
            }
        }

        private void itemSearch_KeyUp(object sender, KeyEventArgs e)
        {
            RefreshDataGridView();
        }
        // updaet data grid after filtering by "search" 
        public void RefreshDataGridView()
        {
            var searchedItemName = searchItemTextBox.Text;

            _filteredItems.Clear();
            _allItems.Where(item => item.ItemPreview.Contains(searchedItemName, StringComparison.OrdinalIgnoreCase))
                .ToList()
                .ForEach(_filteredItems.Add);
            _source.ResetBindings(false);
        }
        // => item details form
        private void viewItemDetailsButton_Click(object sender, EventArgs e)
        {
            if (itemsTable.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "No item was selected",
                    "To view item details, it should be selected",
                     MessageBoxButtons.OK);
                return;
            }

            var selectedRow = (ItemDTO)itemsTable.CurrentRow.DataBoundItem;
            var selectedItem = _database.GetItem(selectedRow.UpcCode);
            if (selectedItem == null)
            {
                MessageBox.Show(
                    "Error, please try again later.",
                    "Loading item details error",
                    MessageBoxButtons.OK);
                return;
            }

            FormsController.SwitchWindowForm(new ItemDetails(_database, _order, selectedItem));
        }


        private void itemsTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            EnumerateRows(itemsTable, "RowId");
        }
        private void ItemsList_Load(object sender, EventArgs e)
        {
            searchItemTextBox.PlaceholderText = "Search in available items";
        }
        private void returnToOrder_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ItemsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormsController.CloseWindow(this);
        }
    }
}
