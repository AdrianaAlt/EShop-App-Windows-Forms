namespace MAS_WinFormsApp.Forms
{
    partial class Menu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.profileImage = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewOrderAction = new System.Windows.Forms.ToolStripMenuItem();
            this.exitAction = new System.Windows.Forms.ToolStripMenuItem();
            this.orderLinesGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createNewOrderButton = new System.Windows.Forms.Button();
            this.ordersTable = new System.Windows.Forms.DataGridView();
            this.RowId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.orderLinesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fullNameLabel);
            this.groupBox1.Controls.Add(this.profileImage);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
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
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem,
            this.exitAction});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menu";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewOrderAction});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // createNewOrderAction
            // 
            this.createNewOrderAction.Name = "createNewOrderAction";
            this.createNewOrderAction.Size = new System.Drawing.Size(168, 22);
            this.createNewOrderAction.Text = "Create New Order";
            this.createNewOrderAction.Click += new System.EventHandler(this.CreateNewOrderAction_Click);
            // 
            // exitAction
            // 
            this.exitAction.Name = "exitAction";
            this.exitAction.Size = new System.Drawing.Size(38, 20);
            this.exitAction.Text = "Exit";
            this.exitAction.Click += new System.EventHandler(this.exitAction_Click);
            // 
            // orderLinesGroupBox
            // 
            this.orderLinesGroupBox.Controls.Add(this.label1);
            this.orderLinesGroupBox.Controls.Add(this.createNewOrderButton);
            this.orderLinesGroupBox.Controls.Add(this.ordersTable);
            this.orderLinesGroupBox.Location = new System.Drawing.Point(191, 27);
            this.orderLinesGroupBox.Name = "orderLinesGroupBox";
            this.orderLinesGroupBox.Size = new System.Drawing.Size(560, 336);
            this.orderLinesGroupBox.TabIndex = 6;
            this.orderLinesGroupBox.TabStop = false;
            this.orderLinesGroupBox.Text = "Your Orders";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Orders History";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createNewOrderButton
            // 
            this.createNewOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createNewOrderButton.Location = new System.Drawing.Point(184, 274);
            this.createNewOrderButton.Name = "createNewOrderButton";
            this.createNewOrderButton.Size = new System.Drawing.Size(200, 42);
            this.createNewOrderButton.TabIndex = 6;
            this.createNewOrderButton.Text = "Create New Order";
            this.createNewOrderButton.UseVisualStyleBackColor = true;
            this.createNewOrderButton.Click += new System.EventHandler(this.CreateNewOrderAction_Click);
            // 
            // ordersTable
            // 
            this.ordersTable.AllowUserToAddRows = false;
            this.ordersTable.AllowUserToDeleteRows = false;
            this.ordersTable.AllowUserToResizeColumns = false;
            this.ordersTable.AllowUserToResizeRows = false;
            this.ordersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ordersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowId,
            this.orderID,
            this.OrderDate,
            this.Status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ordersTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.ordersTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ordersTable.Enabled = false;
            this.ordersTable.EnableHeadersVisualStyles = false;
            this.ordersTable.Location = new System.Drawing.Point(16, 62);
            this.ordersTable.MultiSelect = false;
            this.ordersTable.Name = "ordersTable";
            this.ordersTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ordersTable.RowHeadersVisible = false;
            this.ordersTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ordersTable.RowTemplate.Height = 25;
            this.ordersTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersTable.Size = new System.Drawing.Size(527, 196);
            this.ordersTable.TabIndex = 5;
            this.ordersTable.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ordersTable_DataBindingComplete);
            // 
            // RowId
            // 
            this.RowId.FillWeight = 21.69866F;
            this.RowId.HeaderText = "Nr.";
            this.RowId.Name = "RowId";
            this.RowId.ReadOnly = true;
            // 
            // orderID
            // 
            this.orderID.FillWeight = 65.91746F;
            this.orderID.HeaderText = "Order ID";
            this.orderID.MinimumWidth = 50;
            this.orderID.Name = "orderID";
            this.orderID.ReadOnly = true;
            this.orderID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.orderID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OrderDate
            // 
            this.OrderDate.FillWeight = 80.88826F;
            this.OrderDate.HeaderText = "Date";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            this.OrderDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Status
            // 
            this.Status.FillWeight = 45.22741F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orderLinesGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.orderLinesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label fullNameLabel;
        private PictureBox profileImage;
        private MenuStrip menuStrip;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private ToolStripMenuItem createNewOrderAction;
        private ToolStripMenuItem exitAction;
        private GroupBox orderLinesGroupBox;
        private DataGridView ordersTable;
        private Button createNewOrderButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private DataGridViewTextBoxColumn RowId;
        private DataGridViewTextBoxColumn orderID;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn Status;
    }
}