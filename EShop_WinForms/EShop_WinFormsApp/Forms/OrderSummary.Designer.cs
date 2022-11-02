namespace MAS_WinFormsApp.Forms
{
    partial class OrderSummary
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.totalPriceField = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.deliveryAddressField = new System.Windows.Forms.Label();
            this.orderDateField = new System.Windows.Forms.Label();
            this.orderIdField = new System.Windows.Forms.Label();
            this.customerIdField = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.totalPriceField);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.tableLayoutPanel1);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox.Location = new System.Drawing.Point(12, 27);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(776, 305);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Order Summary";
            // 
            // totalPriceField
            // 
            this.totalPriceField.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalPriceField.Location = new System.Drawing.Point(627, 270);
            this.totalPriceField.Name = "totalPriceField";
            this.totalPriceField.Size = new System.Drawing.Size(105, 23);
            this.totalPriceField.TabIndex = 2;
            this.totalPriceField.Text = "400";
            this.totalPriceField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(515, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total Price:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.72052F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.27947F));
            this.tableLayoutPanel1.Controls.Add(this.deliveryAddressField, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.orderDateField, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.orderIdField, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.customerIdField, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(45, 36);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.90909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.09091F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(687, 219);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // deliveryAddressField
            // 
            this.deliveryAddressField.Location = new System.Drawing.Point(112, 163);
            this.deliveryAddressField.Name = "deliveryAddressField";
            this.deliveryAddressField.Size = new System.Drawing.Size(571, 53);
            this.deliveryAddressField.TabIndex = 7;
            this.deliveryAddressField.Text = "Customer ID";
            this.deliveryAddressField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderDateField
            // 
            this.orderDateField.Location = new System.Drawing.Point(112, 108);
            this.orderDateField.Name = "orderDateField";
            this.orderDateField.Size = new System.Drawing.Size(571, 53);
            this.orderDateField.TabIndex = 6;
            this.orderDateField.Text = "23/04/2022";
            this.orderDateField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderIdField
            // 
            this.orderIdField.Location = new System.Drawing.Point(112, 55);
            this.orderIdField.Name = "orderIdField";
            this.orderIdField.Size = new System.Drawing.Size(571, 52);
            this.orderIdField.TabIndex = 5;
            this.orderIdField.Text = "1234567890";
            this.orderIdField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customerIdField
            // 
            this.customerIdField.Location = new System.Drawing.Point(112, 1);
            this.customerIdField.Name = "customerIdField";
            this.customerIdField.Size = new System.Drawing.Size(571, 53);
            this.customerIdField.TabIndex = 4;
            this.customerIdField.Text = "Customer ID";
            this.customerIdField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 54);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 55);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnButton.Location = new System.Drawing.Point(505, 381);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(239, 42);
            this.returnButton.TabIndex = 1;
            this.returnButton.Text = "Return To Menu";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.return_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(611, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "$";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OrderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.groupBox);
            this.Name = "OrderSummary";
            this.Text = "OrderSummary";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderSummary_FormClosed);
            this.groupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Label customerIdField;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button returnButton;
        private Label deliveryAddressField;
        private Label orderDateField;
        private Label orderIdField;
        private Label totalPriceField;
        private Label label5;
        private Label label6;
    }
}