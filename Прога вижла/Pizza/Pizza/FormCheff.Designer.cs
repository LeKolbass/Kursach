
namespace Pizza
{
    partial class FormCheff
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
            this.menuTableAdapter1 = new Pizza.PizzaDataSetTableAdapters.MenuTableAdapter();
            this.ordersTableAdapter1 = new Pizza.PizzaDataSetTableAdapters.OrdersTableAdapter();
            this.receiptTableAdapter1 = new Pizza.PizzaDataSetTableAdapters.ReceiptTableAdapter();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.dataGridViewReceipt = new System.Windows.Forms.DataGridView();
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.textBoxComposition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.buttonActiveDisable = new System.Windows.Forms.Button();
            this.buttonActiveActive = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // menuTableAdapter1
            // 
            this.menuTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // receiptTableAdapter1
            // 
            this.receiptTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(12, 32);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RowHeadersWidth = 62;
            this.dataGridViewOrders.RowTemplate.Height = 28;
            this.dataGridViewOrders.Size = new System.Drawing.Size(476, 196);
            this.dataGridViewOrders.TabIndex = 1;
            this.dataGridViewOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellContentClick);
            // 
            // dataGridViewReceipt
            // 
            this.dataGridViewReceipt.AllowUserToAddRows = false;
            this.dataGridViewReceipt.AllowUserToDeleteRows = false;
            this.dataGridViewReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceipt.Location = new System.Drawing.Point(12, 287);
            this.dataGridViewReceipt.Name = "dataGridViewReceipt";
            this.dataGridViewReceipt.ReadOnly = true;
            this.dataGridViewReceipt.RowHeadersWidth = 62;
            this.dataGridViewReceipt.RowTemplate.Height = 28;
            this.dataGridViewReceipt.Size = new System.Drawing.Size(476, 241);
            this.dataGridViewReceipt.TabIndex = 4;
            this.dataGridViewReceipt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReceipt_CellContentClick);
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.AllowUserToAddRows = false;
            this.dataGridViewMenu.AllowUserToDeleteRows = false;
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Location = new System.Drawing.Point(494, 32);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.ReadOnly = true;
            this.dataGridViewMenu.RowHeadersWidth = 62;
            this.dataGridViewMenu.RowTemplate.Height = 28;
            this.dataGridViewMenu.Size = new System.Drawing.Size(954, 665);
            this.dataGridViewMenu.TabIndex = 5;
            this.dataGridViewMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenu_CellContentClick);
            // 
            // textBoxComposition
            // 
            this.textBoxComposition.Enabled = false;
            this.textBoxComposition.Location = new System.Drawing.Point(12, 534);
            this.textBoxComposition.Multiline = true;
            this.textBoxComposition.Name = "textBoxComposition";
            this.textBoxComposition.Size = new System.Drawing.Size(475, 163);
            this.textBoxComposition.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(932, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Меню";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Заказы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Состав заказа";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Все",
            "Хит",
            "Вегетарианская",
            "Острая",
            "Мясная"});
            this.comboBoxCategory.Location = new System.Drawing.Point(494, 1);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 28);
            this.comboBoxCategory.TabIndex = 10;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // buttonActiveDisable
            // 
            this.buttonActiveDisable.Location = new System.Drawing.Point(165, 234);
            this.buttonActiveDisable.Name = "buttonActiveDisable";
            this.buttonActiveDisable.Size = new System.Drawing.Size(140, 30);
            this.buttonActiveDisable.TabIndex = 11;
            this.buttonActiveDisable.Text = "Не готово";
            this.buttonActiveDisable.UseVisualStyleBackColor = true;
            this.buttonActiveDisable.Click += new System.EventHandler(this.buttonActiveDisable_Click);
            // 
            // buttonActiveActive
            // 
            this.buttonActiveActive.Location = new System.Drawing.Point(12, 234);
            this.buttonActiveActive.Name = "buttonActiveActive";
            this.buttonActiveActive.Size = new System.Drawing.Size(132, 30);
            this.buttonActiveActive.TabIndex = 12;
            this.buttonActiveActive.Text = "Готово";
            this.buttonActiveActive.UseVisualStyleBackColor = true;
            this.buttonActiveActive.Click += new System.EventHandler(this.buttonActiveActive_Click);
            // 
            // FormCheff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 699);
            this.Controls.Add(this.buttonActiveActive);
            this.Controls.Add(this.buttonActiveDisable);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxComposition);
            this.Controls.Add(this.dataGridViewMenu);
            this.Controls.Add(this.dataGridViewReceipt);
            this.Controls.Add(this.dataGridViewOrders);
            this.Name = "FormCheff";
            this.Text = "Повар";
            this.Load += new System.EventHandler(this.FormCheff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PizzaDataSetTableAdapters.MenuTableAdapter menuTableAdapter1;
        private PizzaDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private PizzaDataSetTableAdapters.ReceiptTableAdapter receiptTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.DataGridView dataGridViewReceipt;
        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.TextBox textBoxComposition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button buttonActiveDisable;
        private System.Windows.Forms.Button buttonActiveActive;
    }
}