
namespace Pizza
{
    partial class FormOperator
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
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.buttonCreateNewOrder = new System.Windows.Forms.Button();
            this.dataGridViewReceipt = new System.Windows.Forms.DataGridView();
            this.groupBoxReceipt = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxID_Dish = new System.Windows.Forms.TextBox();
            this.textBoxID_Order = new System.Windows.Forms.TextBox();
            this.menuTableAdapter1 = new Pizza.PizzaDataSetTableAdapters.MenuTableAdapter();
            this.receiptTableAdapter1 = new Pizza.PizzaDataSetTableAdapters.ReceiptTableAdapter();
            this.ordersTableAdapter1 = new Pizza.PizzaDataSetTableAdapters.OrdersTableAdapter();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.buttonEditReceipt = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonDeleteDishReceipt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipt)).BeginInit();
            this.groupBoxReceipt.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(22, 40);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RowHeadersWidth = 62;
            this.dataGridViewOrders.RowTemplate.Height = 28;
            this.dataGridViewOrders.Size = new System.Drawing.Size(476, 216);
            this.dataGridViewOrders.TabIndex = 0;
            this.dataGridViewOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellContentClick);
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.AllowUserToAddRows = false;
            this.dataGridViewMenu.AllowUserToDeleteRows = false;
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Location = new System.Drawing.Point(511, 40);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.ReadOnly = true;
            this.dataGridViewMenu.RowHeadersWidth = 62;
            this.dataGridViewMenu.RowTemplate.Height = 28;
            this.dataGridViewMenu.Size = new System.Drawing.Size(954, 643);
            this.dataGridViewMenu.TabIndex = 1;
            this.dataGridViewMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenu_CellContentClick);
            // 
            // buttonCreateNewOrder
            // 
            this.buttonCreateNewOrder.Location = new System.Drawing.Point(22, 262);
            this.buttonCreateNewOrder.Name = "buttonCreateNewOrder";
            this.buttonCreateNewOrder.Size = new System.Drawing.Size(155, 32);
            this.buttonCreateNewOrder.TabIndex = 2;
            this.buttonCreateNewOrder.Text = "Создать заказ";
            this.buttonCreateNewOrder.UseVisualStyleBackColor = true;
            this.buttonCreateNewOrder.Click += new System.EventHandler(this.buttonCreateNewOrder_Click);
            // 
            // dataGridViewReceipt
            // 
            this.dataGridViewReceipt.AllowUserToAddRows = false;
            this.dataGridViewReceipt.AllowUserToDeleteRows = false;
            this.dataGridViewReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceipt.Location = new System.Drawing.Point(22, 317);
            this.dataGridViewReceipt.Name = "dataGridViewReceipt";
            this.dataGridViewReceipt.ReadOnly = true;
            this.dataGridViewReceipt.RowHeadersWidth = 62;
            this.dataGridViewReceipt.RowTemplate.Height = 28;
            this.dataGridViewReceipt.Size = new System.Drawing.Size(476, 270);
            this.dataGridViewReceipt.TabIndex = 3;
            this.dataGridViewReceipt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReceipt_CellContentClick);
            // 
            // groupBoxReceipt
            // 
            this.groupBoxReceipt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxReceipt.Controls.Add(this.label3);
            this.groupBoxReceipt.Controls.Add(this.label2);
            this.groupBoxReceipt.Controls.Add(this.label1);
            this.groupBoxReceipt.Controls.Add(this.textBoxCount);
            this.groupBoxReceipt.Controls.Add(this.textBoxID_Dish);
            this.groupBoxReceipt.Controls.Add(this.textBoxID_Order);
            this.groupBoxReceipt.Location = new System.Drawing.Point(22, 635);
            this.groupBoxReceipt.Name = "groupBoxReceipt";
            this.groupBoxReceipt.Size = new System.Drawing.Size(476, 48);
            this.groupBoxReceipt.TabIndex = 4;
            this.groupBoxReceipt.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Кол-во";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер блюда";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Номер заказа";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(418, 13);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(49, 26);
            this.textBoxCount.TabIndex = 2;
            // 
            // textBoxID_Dish
            // 
            this.textBoxID_Dish.Location = new System.Drawing.Point(301, 13);
            this.textBoxID_Dish.Name = "textBoxID_Dish";
            this.textBoxID_Dish.Size = new System.Drawing.Size(49, 26);
            this.textBoxID_Dish.TabIndex = 1;
            // 
            // textBoxID_Order
            // 
            this.textBoxID_Order.Location = new System.Drawing.Point(126, 13);
            this.textBoxID_Order.Name = "textBoxID_Order";
            this.textBoxID_Order.Size = new System.Drawing.Size(49, 26);
            this.textBoxID_Order.TabIndex = 0;
            // 
            // menuTableAdapter1
            // 
            this.menuTableAdapter1.ClearBeforeFill = true;
            // 
            // receiptTableAdapter1
            // 
            this.receiptTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(22, 593);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(155, 36);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить блюдо";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(972, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Меню";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Заказы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 8;
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
            this.comboBoxCategory.Location = new System.Drawing.Point(511, 6);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 28);
            this.comboBoxCategory.TabIndex = 9;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // buttonEditReceipt
            // 
            this.buttonEditReceipt.Location = new System.Drawing.Point(186, 593);
            this.buttonEditReceipt.Name = "buttonEditReceipt";
            this.buttonEditReceipt.Size = new System.Drawing.Size(149, 36);
            this.buttonEditReceipt.TabIndex = 10;
            this.buttonEditReceipt.Text = "Редактировать";
            this.buttonEditReceipt.UseVisualStyleBackColor = true;
            this.buttonEditReceipt.Click += new System.EventHandler(this.buttonEditReceipt_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(186, 262);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(131, 32);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Удалить заказ";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonDeleteDishReceipt
            // 
            this.buttonDeleteDishReceipt.Location = new System.Drawing.Point(341, 593);
            this.buttonDeleteDishReceipt.Name = "buttonDeleteDishReceipt";
            this.buttonDeleteDishReceipt.Size = new System.Drawing.Size(148, 36);
            this.buttonDeleteDishReceipt.TabIndex = 12;
            this.buttonDeleteDishReceipt.Text = "Удалить";
            this.buttonDeleteDishReceipt.UseVisualStyleBackColor = true;
            this.buttonDeleteDishReceipt.Click += new System.EventHandler(this.buttonDeleteDishReceipt_Click);
            // 
            // FormOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 695);
            this.Controls.Add(this.buttonDeleteDishReceipt);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEditReceipt);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxReceipt);
            this.Controls.Add(this.dataGridViewReceipt);
            this.Controls.Add(this.buttonCreateNewOrder);
            this.Controls.Add(this.dataGridViewMenu);
            this.Controls.Add(this.dataGridViewOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormOperator";
            this.Text = "Оператор";
            this.Load += new System.EventHandler(this.FormOperator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipt)).EndInit();
            this.groupBoxReceipt.ResumeLayout(false);
            this.groupBoxReceipt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private PizzaDataSetTableAdapters.MenuTableAdapter menuTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.Button buttonCreateNewOrder;
        private PizzaDataSetTableAdapters.ReceiptTableAdapter receiptTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridViewReceipt;
        private System.Windows.Forms.GroupBox groupBoxReceipt;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxID_Dish;
        private System.Windows.Forms.TextBox textBoxID_Order;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private PizzaDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button buttonEditReceipt;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonDeleteDishReceipt;
    }
}