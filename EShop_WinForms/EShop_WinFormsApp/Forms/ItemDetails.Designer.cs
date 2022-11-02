namespace MAS_WinFormsApp.Forms
{
    partial class ItemDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.upcCodeRow = new System.Windows.Forms.Label();
            this.itemNameRow = new System.Windows.Forms.Label();
            this.itemTypeRow = new System.Windows.Forms.Label();
            this.itemPriceRow = new System.Windows.Forms.Label();
            this.upcCodeField = new System.Windows.Forms.Label();
            this.itemNameField = new System.Windows.Forms.Label();
            this.typeField = new System.Windows.Forms.Label();
            this.unitPriceField = new System.Windows.Forms.Label();
            this.itemDescriptionRow = new System.Windows.Forms.Label();
            this.itemSpecDetails = new System.Windows.Forms.Label();
            this.itemDescriptionField = new System.Windows.Forms.Label();
            this.itemSpecDetailsField = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityField = new System.Windows.Forms.NumericUpDown();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.totalPriceField = new System.Windows.Forms.Label();
            this.addItemToOrderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.returnToItems = new System.Windows.Forms.Button();
            this.infoMessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityField)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(41, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item details";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.93794F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.06206F));
            this.tableLayoutPanel1.Controls.Add(this.upcCodeRow, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.itemNameRow, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.itemTypeRow, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.itemPriceRow, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.upcCodeField, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.itemNameField, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.typeField, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.unitPriceField, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.itemDescriptionRow, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.itemSpecDetails, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.itemDescriptionField, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.itemSpecDetailsField, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.27586F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.72414F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(677, 216);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // upcCodeRow
            // 
            this.upcCodeRow.Location = new System.Drawing.Point(4, 1);
            this.upcCodeRow.Name = "upcCodeRow";
            this.upcCodeRow.Padding = new System.Windows.Forms.Padding(5);
            this.upcCodeRow.Size = new System.Drawing.Size(101, 26);
            this.upcCodeRow.TabIndex = 0;
            this.upcCodeRow.Text = "UPC-code";
            this.upcCodeRow.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // itemNameRow
            // 
            this.itemNameRow.Location = new System.Drawing.Point(4, 28);
            this.itemNameRow.Name = "itemNameRow";
            this.itemNameRow.Padding = new System.Windows.Forms.Padding(5);
            this.itemNameRow.Size = new System.Drawing.Size(101, 26);
            this.itemNameRow.TabIndex = 1;
            this.itemNameRow.Text = "Name";
            this.itemNameRow.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // itemTypeRow
            // 
            this.itemTypeRow.Location = new System.Drawing.Point(4, 57);
            this.itemTypeRow.Name = "itemTypeRow";
            this.itemTypeRow.Padding = new System.Windows.Forms.Padding(5);
            this.itemTypeRow.Size = new System.Drawing.Size(101, 24);
            this.itemTypeRow.TabIndex = 2;
            this.itemTypeRow.Text = "Type";
            this.itemTypeRow.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // itemPriceRow
            // 
            this.itemPriceRow.Location = new System.Drawing.Point(4, 86);
            this.itemPriceRow.Name = "itemPriceRow";
            this.itemPriceRow.Padding = new System.Windows.Forms.Padding(5);
            this.itemPriceRow.Size = new System.Drawing.Size(101, 27);
            this.itemPriceRow.TabIndex = 3;
            this.itemPriceRow.Text = "Unit price";
            this.itemPriceRow.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // upcCodeField
            // 
            this.upcCodeField.Location = new System.Drawing.Point(112, 1);
            this.upcCodeField.Name = "upcCodeField";
            this.upcCodeField.Padding = new System.Windows.Forms.Padding(5, 5, 4, 4);
            this.upcCodeField.Size = new System.Drawing.Size(561, 26);
            this.upcCodeField.TabIndex = 6;
            this.upcCodeField.Text = "123456789011";
            // 
            // itemNameField
            // 
            this.itemNameField.Location = new System.Drawing.Point(112, 28);
            this.itemNameField.Name = "itemNameField";
            this.itemNameField.Padding = new System.Windows.Forms.Padding(5, 5, 4, 4);
            this.itemNameField.Size = new System.Drawing.Size(561, 26);
            this.itemNameField.TabIndex = 7;
            this.itemNameField.Text = "Logitech K270";
            // 
            // typeField
            // 
            this.typeField.Location = new System.Drawing.Point(112, 57);
            this.typeField.Name = "typeField";
            this.typeField.Padding = new System.Windows.Forms.Padding(5, 5, 4, 4);
            this.typeField.Size = new System.Drawing.Size(561, 24);
            this.typeField.TabIndex = 8;
            this.typeField.Text = "Keyboard";
            // 
            // unitPriceField
            // 
            this.unitPriceField.Location = new System.Drawing.Point(112, 86);
            this.unitPriceField.Name = "unitPriceField";
            this.unitPriceField.Padding = new System.Windows.Forms.Padding(5, 5, 4, 4);
            this.unitPriceField.Size = new System.Drawing.Size(561, 27);
            this.unitPriceField.TabIndex = 10;
            this.unitPriceField.Text = "55$";
            // 
            // itemDescriptionRow
            // 
            this.itemDescriptionRow.Location = new System.Drawing.Point(4, 146);
            this.itemDescriptionRow.Name = "itemDescriptionRow";
            this.itemDescriptionRow.Padding = new System.Windows.Forms.Padding(5);
            this.itemDescriptionRow.Size = new System.Drawing.Size(101, 28);
            this.itemDescriptionRow.TabIndex = 4;
            this.itemDescriptionRow.Text = "Description";
            this.itemDescriptionRow.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // itemSpecDetails
            // 
            this.itemSpecDetails.Location = new System.Drawing.Point(4, 115);
            this.itemSpecDetails.Name = "itemSpecDetails";
            this.itemSpecDetails.Padding = new System.Windows.Forms.Padding(5);
            this.itemSpecDetails.Size = new System.Drawing.Size(101, 27);
            this.itemSpecDetails.TabIndex = 5;
            this.itemSpecDetails.Text = "Specific details";
            this.itemSpecDetails.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // itemDescriptionField
            // 
            this.itemDescriptionField.Location = new System.Drawing.Point(112, 146);
            this.itemDescriptionField.Name = "itemDescriptionField";
            this.itemDescriptionField.Padding = new System.Windows.Forms.Padding(5, 5, 4, 4);
            this.itemDescriptionField.Size = new System.Drawing.Size(561, 69);
            this.itemDescriptionField.TabIndex = 9;
            this.itemDescriptionField.Text = "K270 brings together familiar typing, wireless freedom, long battery life";
            // 
            // itemSpecDetailsField
            // 
            this.itemSpecDetailsField.Location = new System.Drawing.Point(112, 115);
            this.itemSpecDetailsField.Name = "itemSpecDetailsField";
            this.itemSpecDetailsField.Padding = new System.Windows.Forms.Padding(5, 5, 4, 4);
            this.itemSpecDetailsField.Size = new System.Drawing.Size(561, 30);
            this.itemSpecDetailsField.TabIndex = 11;
            this.itemSpecDetailsField.Text = "Connectivity technology: wireless";
            // 
            // quantityLabel
            // 
            this.quantityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantityLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityLabel.Location = new System.Drawing.Point(526, 304);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(71, 27);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "Quantity:";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // quantityField
            // 
            this.quantityField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantityField.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityField.Location = new System.Drawing.Point(616, 305);
            this.quantityField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityField.Name = "quantityField";
            this.quantityField.Size = new System.Drawing.Size(74, 27);
            this.quantityField.TabIndex = 3;
            this.quantityField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityField.ValueChanged += new System.EventHandler(this.quantityField_ValueChanged);
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalPriceLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalPriceLabel.Location = new System.Drawing.Point(526, 340);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(84, 27);
            this.totalPriceLabel.TabIndex = 5;
            this.totalPriceLabel.Text = "Total price:";
            this.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalPriceField
            // 
            this.totalPriceField.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalPriceField.Location = new System.Drawing.Point(632, 339);
            this.totalPriceField.Name = "totalPriceField";
            this.totalPriceField.Size = new System.Drawing.Size(119, 29);
            this.totalPriceField.TabIndex = 6;
            this.totalPriceField.Text = "110";
            this.totalPriceField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addItemToOrderButton
            // 
            this.addItemToOrderButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addItemToOrderButton.Location = new System.Drawing.Point(526, 381);
            this.addItemToOrderButton.Name = "addItemToOrderButton";
            this.addItemToOrderButton.Size = new System.Drawing.Size(233, 42);
            this.addItemToOrderButton.TabIndex = 7;
            this.addItemToOrderButton.Text = "Add item to order";
            this.addItemToOrderButton.UseVisualStyleBackColor = true;
            this.addItemToOrderButton.Click += new System.EventHandler(this.addItemToOrderButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(617, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "$";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // returnToItems
            // 
            this.returnToItems.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnToItems.Location = new System.Drawing.Point(49, 381);
            this.returnToItems.Name = "returnToItems";
            this.returnToItems.Size = new System.Drawing.Size(162, 40);
            this.returnToItems.TabIndex = 9;
            this.returnToItems.Text = "Return to items list";
            this.returnToItems.UseVisualStyleBackColor = true;
            this.returnToItems.Click += new System.EventHandler(this.returnToItems_Click);
            // 
            // infoMessage
            // 
            this.infoMessage.AutoSize = true;
            this.infoMessage.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoMessage.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.infoMessage.Location = new System.Drawing.Point(300, 396);
            this.infoMessage.Name = "infoMessage";
            this.infoMessage.Size = new System.Drawing.Size(194, 13);
            this.infoMessage.TabIndex = 10;
            this.infoMessage.Text = "item is already in your shopping cart";
            // 
            // ItemDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoMessage);
            this.Controls.Add(this.returnToItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addItemToOrderButton);
            this.Controls.Add(this.totalPriceField);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.quantityField);
            this.Controls.Add(this.groupBox1);
            this.Name = "ItemDetails";
            this.Text = "ItemDetails";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ItemDetails_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quantityField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label upcCodeRow;
        private Label itemNameRow;
        private Label itemTypeRow;
        private Label itemPriceRow;
        private Label itemDescriptionRow;
        private Label itemSpecDetails;
        private Label upcCodeField;
        private Label itemNameField;
        private Label typeField;
        private Label itemDescriptionField;
        private Label unitPriceField;
        private Label itemSpecDetailsField;
        private Label quantityLabel;
        private NumericUpDown quantityField;
        private Label totalPriceLabel;
        private Label totalPriceField;
        private Button addItemToOrderButton;
        private Label label1;
        private Button returnToItems;
        private Label infoMessage;
    }
}