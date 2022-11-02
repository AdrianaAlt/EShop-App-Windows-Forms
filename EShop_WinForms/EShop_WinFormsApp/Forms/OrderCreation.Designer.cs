namespace MAS_WinFormsApp.Forms
{
    partial class OrderCreation
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
            this.components = new System.ComponentModel.Container();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.profileImage = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.exitAction = new System.Windows.Forms.ToolStripMenuItem();
            this.orderLinesGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.removeItemFromOrderButton = new System.Windows.Forms.Button();
            this.orderLinesTable = new System.Windows.Forms.DataGridView();
            this.Nr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPreview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commonPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showItemsListButton = new System.Windows.Forms.Button();
            this.placeOrderButton = new System.Windows.Forms.Button();
            this.totalOrderPriceLabel = new System.Windows.Forms.Label();
            this.totalOrderPriceField = new System.Windows.Forms.Label();
            this.orderLineDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.orderLinesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderLinesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderLineDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullNameLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fullNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fullNameLabel.Location = new System.Drawing.Point(3, 144);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(147, 23);
            this.fullNameLabel.TabIndex = 1;
            this.fullNameLabel.Text = "Adam Smith";
            this.fullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileImage
            // 
            this.profileImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileImage.BackgroundImage = global::MAS_WinFormsApp.Properties.Resources.profile_photo;
            this.profileImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profileImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileImage.Location = new System.Drawing.Point(37, 36);
            this.profileImage.Margin = new System.Windows.Forms.Padding(10);
            this.profileImage.Name = "profileImage";
            this.profileImage.Size = new System.Drawing.Size(75, 81);
            this.profileImage.TabIndex = 0;
            this.profileImage.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fullNameLabel);
            this.groupBox1.Controls.Add(this.profileImage);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 170);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitAction});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menu";
            // 
            // exitAction
            // 
            this.exitAction.Name = "exitAction";
            this.exitAction.Size = new System.Drawing.Size(103, 20);
            this.exitAction.Text = "Return To Menu";
            this.exitAction.Click += new System.EventHandler(this.exitAction_Click);
            // 
            // orderLinesGroupBox
            // 
            this.orderLinesGroupBox.Controls.Add(this.label2);
            this.orderLinesGroupBox.Controls.Add(this.removeItemFromOrderButton);
            this.orderLinesGroupBox.Controls.Add(this.orderLinesTable);
            this.orderLinesGroupBox.Location = new System.Drawing.Point(228, 27);
            this.orderLinesGroupBox.Name = "orderLinesGroupBox";
            this.orderLinesGroupBox.Size = new System.Drawing.Size(560, 292);
            this.orderLinesGroupBox.TabIndex = 4;
            this.orderLinesGroupBox.TabStop = false;
            this.orderLinesGroupBox.Text = "Order Creation";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(527, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Your Order Lines";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeItemFromOrderButton
            // 
            this.removeItemFromOrderButton.Location = new System.Drawing.Point(372, 249);
            this.removeItemFromOrderButton.Name = "removeItemFromOrderButton";
            this.removeItemFromOrderButton.Size = new System.Drawing.Size(171, 31);
            this.removeItemFromOrderButton.TabIndex = 6;
            this.removeItemFromOrderButton.Text = "Remove Selected Item";
            this.removeItemFromOrderButton.UseVisualStyleBackColor = true;
            this.removeItemFromOrderButton.Click += new System.EventHandler(this.removeItemFromOrderButton_Click);
            // 
            // orderLinesTable
            // 
            this.orderLinesTable.AllowUserToAddRows = false;
            this.orderLinesTable.AllowUserToDeleteRows = false;
            this.orderLinesTable.AllowUserToResizeColumns = false;
            this.orderLinesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderLinesTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.orderLinesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderLinesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nr,
            this.ItemPreview,
            this.UnitPrice,
            this.ItemQuantity,
            this.commonPrice});
            this.orderLinesTable.EnableHeadersVisualStyles = false;
            this.orderLinesTable.Location = new System.Drawing.Point(16, 55);
            this.orderLinesTable.MultiSelect = false;
            this.orderLinesTable.Name = "orderLinesTable";
            this.orderLinesTable.ReadOnly = true;
            this.orderLinesTable.RowHeadersVisible = false;
            this.orderLinesTable.RowTemplate.Height = 25;
            this.orderLinesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderLinesTable.Size = new System.Drawing.Size(527, 185);
            this.orderLinesTable.TabIndex = 5;
            this.orderLinesTable.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.orderLinesTable_DataBindingComplete);
            // 
            // Nr
            // 
            this.Nr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Nr.FillWeight = 50.6741F;
            this.Nr.HeaderText = "Nr.";
            this.Nr.MinimumWidth = 35;
            this.Nr.Name = "Nr";
            this.Nr.ReadOnly = true;
            this.Nr.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nr.Width = 48;
            // 
            // ItemPreview
            // 
            this.ItemPreview.FillWeight = 114.0167F;
            this.ItemPreview.HeaderText = "Item";
            this.ItemPreview.MinimumWidth = 150;
            this.ItemPreview.Name = "ItemPreview";
            this.ItemPreview.ReadOnly = true;
            this.ItemPreview.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemPreview.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.UnitPrice.FillWeight = 17.13545F;
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 83;
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ItemQuantity.FillWeight = 11.99482F;
            this.ItemQuantity.HeaderText = "Quantity";
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.ReadOnly = true;
            this.ItemQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ItemQuantity.Width = 59;
            // 
            // commonPrice
            // 
            this.commonPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.commonPrice.FillWeight = 25.64275F;
            this.commonPrice.HeaderText = "Total Price";
            this.commonPrice.Name = "commonPrice";
            this.commonPrice.ReadOnly = true;
            this.commonPrice.Width = 86;
            // 
            // showItemsListButton
            // 
            this.showItemsListButton.Location = new System.Drawing.Point(244, 325);
            this.showItemsListButton.Name = "showItemsListButton";
            this.showItemsListButton.Size = new System.Drawing.Size(527, 33);
            this.showItemsListButton.TabIndex = 5;
            this.showItemsListButton.Text = "Browse Available Items...";
            this.showItemsListButton.UseVisualStyleBackColor = true;
            this.showItemsListButton.Click += new System.EventHandler(this.showItemsListButton_Click);
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.Location = new System.Drawing.Point(600, 381);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Size = new System.Drawing.Size(171, 42);
            this.placeOrderButton.TabIndex = 6;
            this.placeOrderButton.Text = "Place Order";
            this.placeOrderButton.UseVisualStyleBackColor = true;
            this.placeOrderButton.Click += new System.EventHandler(this.placeOrderButton_Click);
            // 
            // totalOrderPriceLabel
            // 
            this.totalOrderPriceLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalOrderPriceLabel.Location = new System.Drawing.Point(228, 390);
            this.totalOrderPriceLabel.Name = "totalOrderPriceLabel";
            this.totalOrderPriceLabel.Size = new System.Drawing.Size(129, 23);
            this.totalOrderPriceLabel.TabIndex = 7;
            this.totalOrderPriceLabel.Text = "Total order price:";
            this.totalOrderPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalOrderPriceField
            // 
            this.totalOrderPriceField.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalOrderPriceField.Location = new System.Drawing.Point(379, 390);
            this.totalOrderPriceField.Name = "totalOrderPriceField";
            this.totalOrderPriceField.Size = new System.Drawing.Size(190, 23);
            this.totalOrderPriceField.TabIndex = 8;
            this.totalOrderPriceField.Text = "44411000000999";
            this.totalOrderPriceField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(362, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "$";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrderCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalOrderPriceField);
            this.Controls.Add(this.totalOrderPriceLabel);
            this.Controls.Add(this.placeOrderButton);
            this.Controls.Add(this.showItemsListButton);
            this.Controls.Add(this.orderLinesGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip);
            this.Name = "OrderCreation";
            this.Text = "New Order Creation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderCreation_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.orderLinesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderLinesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderLineDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label fullNameLabel;
        private PictureBox profileImage;
        private GroupBox groupBox1;
        private MenuStrip menuStrip;
        private ToolStripMenuItem exitAction;
        private GroupBox orderLinesGroupBox;
        private DataGridView orderLinesTable;
        private Button removeItemFromOrderButton;
        private Button showItemsListButton;
        private Button placeOrderButton;
        private Label totalOrderPriceLabel;
        private Label totalOrderPriceField;
        private BindingSource orderLineDTOBindingSource;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn Nr;
        private DataGridViewTextBoxColumn ItemPreview;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn ItemQuantity;
        private DataGridViewTextBoxColumn commonPrice;
    }
}