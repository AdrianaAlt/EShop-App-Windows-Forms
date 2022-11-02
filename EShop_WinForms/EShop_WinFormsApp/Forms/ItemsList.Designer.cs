namespace MAS_WinFormsApp.Forms
{
    partial class ItemsList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.orderLinesGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.orderLinesGridTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itemsTable = new System.Windows.Forms.DataGridView();
            this.RowId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemUPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPreviewCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchItemTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.viewItemDetailsButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderLinesGridTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // orderLinesGroupBox
            // 
            this.orderLinesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.orderLinesGroupBox.Name = "orderLinesGroupBox";
            this.orderLinesGroupBox.Size = new System.Drawing.Size(200, 100);
            this.orderLinesGroupBox.TabIndex = 0;
            this.orderLinesGroupBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.orderLinesGridTable, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // orderLinesGridTable
            // 
            this.orderLinesGridTable.AllowUserToAddRows = false;
            this.orderLinesGridTable.AllowUserToDeleteRows = false;
            this.orderLinesGridTable.AllowUserToResizeColumns = false;
            this.orderLinesGridTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderLinesGridTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.orderLinesGridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderLinesGridTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Type,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.orderLinesGridTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderLinesGridTable.EnableHeadersVisualStyles = false;
            this.orderLinesGridTable.Location = new System.Drawing.Point(13, 13);
            this.orderLinesGridTable.MultiSelect = false;
            this.orderLinesGridTable.Name = "orderLinesGridTable";
            this.orderLinesGridTable.ReadOnly = true;
            this.orderLinesGridTable.RowHeadersVisible = false;
            this.orderLinesGridTable.RowTemplate.Height = 25;
            this.orderLinesGridTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderLinesGridTable.Size = new System.Drawing.Size(174, 14);
            this.orderLinesGridTable.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 30F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nr.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 80F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Unit Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 70F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(13, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add New Item";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.itemsTable);
            this.groupBox1.Controls.Add(this.searchItemTextBox);
            this.groupBox1.Controls.Add(this.searchLabel);
            this.groupBox1.Location = new System.Drawing.Point(40, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Available Items";
            // 
            // itemsTable
            // 
            this.itemsTable.AllowUserToAddRows = false;
            this.itemsTable.AllowUserToDeleteRows = false;
            this.itemsTable.AllowUserToResizeColumns = false;
            this.itemsTable.AllowUserToResizeRows = false;
            this.itemsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.itemsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowId,
            this.itemUPC,
            this.itemPreviewCol,
            this.unitPrice});
            this.itemsTable.EnableHeadersVisualStyles = false;
            this.itemsTable.Location = new System.Drawing.Point(27, 87);
            this.itemsTable.MultiSelect = false;
            this.itemsTable.Name = "itemsTable";
            this.itemsTable.ReadOnly = true;
            this.itemsTable.RowHeadersVisible = false;
            this.itemsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.itemsTable.RowTemplate.Height = 25;
            this.itemsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsTable.Size = new System.Drawing.Size(663, 191);
            this.itemsTable.TabIndex = 4;
            this.itemsTable.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.itemsTable_DataBindingComplete);
            // 
            // RowId
            // 
            this.RowId.DataPropertyName = "RowId";
            this.RowId.FillWeight = 20.7132F;
            this.RowId.HeaderText = "Nr.";
            this.RowId.MinimumWidth = 50;
            this.RowId.Name = "RowId";
            this.RowId.ReadOnly = true;
            this.RowId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RowId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // itemUPC
            // 
            this.itemUPC.DataPropertyName = "UpcCode";
            this.itemUPC.FillWeight = 44.72747F;
            this.itemUPC.HeaderText = "UPC";
            this.itemUPC.MaxInputLength = 12;
            this.itemUPC.Name = "itemUPC";
            this.itemUPC.ReadOnly = true;
            this.itemUPC.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.itemUPC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // itemPreviewCol
            // 
            this.itemPreviewCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemPreviewCol.DataPropertyName = "ItemPreview";
            this.itemPreviewCol.FillWeight = 105.6373F;
            this.itemPreviewCol.HeaderText = "Item";
            this.itemPreviewCol.MinimumWidth = 200;
            this.itemPreviewCol.Name = "itemPreviewCol";
            this.itemPreviewCol.ReadOnly = true;
            this.itemPreviewCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemPreviewCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // unitPrice
            // 
            this.unitPrice.DataPropertyName = "UnitPrice";
            this.unitPrice.FillWeight = 49.20482F;
            this.unitPrice.HeaderText = "Price";
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.ReadOnly = true;
            this.unitPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // searchItemTextBox
            // 
            this.searchItemTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchItemTextBox.Location = new System.Drawing.Point(160, 35);
            this.searchItemTextBox.Name = "searchItemTextBox";
            this.searchItemTextBox.Size = new System.Drawing.Size(319, 29);
            this.searchItemTextBox.TabIndex = 1;
            this.searchItemTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.itemSearch_KeyUp);
            // 
            // searchLabel
            // 
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchLabel.Location = new System.Drawing.Point(27, 32);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(118, 31);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Search item:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(45, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 42);
            this.button2.TabIndex = 6;
            this.button2.Text = "Return to order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.returnToOrder_Click);
            // 
            // viewItemDetailsButton
            // 
            this.viewItemDetailsButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewItemDetailsButton.Location = new System.Drawing.Point(475, 381);
            this.viewItemDetailsButton.Name = "viewItemDetailsButton";
            this.viewItemDetailsButton.Size = new System.Drawing.Size(255, 42);
            this.viewItemDetailsButton.TabIndex = 5;
            this.viewItemDetailsButton.Text = "Select item";
            this.viewItemDetailsButton.UseVisualStyleBackColor = true;
            this.viewItemDetailsButton.Click += new System.EventHandler(this.viewItemDetailsButton_Click);
            // 
            // ItemsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewItemDetailsButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ItemsList";
            this.Padding = new System.Windows.Forms.Padding(40, 30, 40, 15);
            this.Text = "ItemsList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ItemsList_FormClosed);
            this.Load += new System.EventHandler(this.ItemsList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderLinesGridTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox orderLinesGroupBox;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView orderLinesGridTable;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Button button1;
        private GroupBox groupBox1;
        private TextBox searchItemTextBox;
        private Label searchLabel;
        private DataGridView itemsTable;
        private Button viewItemDetailsButton;
        private Button button2;
        private DataGridViewTextBoxColumn RowId;
        private DataGridViewTextBoxColumn itemUPC;
        private DataGridViewTextBoxColumn itemPreviewCol;
        private DataGridViewTextBoxColumn unitPrice;
    }
}