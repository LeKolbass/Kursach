
namespace Pizza
{
    partial class FormDirector
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.textBoxIDMenu = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxComposition = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonNewPosition = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTableAdapter1
            // 
            this.menuTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(716, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxMenu.Controls.Add(this.comboBoxCategory);
            this.groupBoxMenu.Controls.Add(this.label6);
            this.groupBoxMenu.Controls.Add(this.label5);
            this.groupBoxMenu.Controls.Add(this.label4);
            this.groupBoxMenu.Controls.Add(this.label3);
            this.groupBoxMenu.Controls.Add(this.label2);
            this.groupBoxMenu.Controls.Add(this.label1);
            this.groupBoxMenu.Controls.Add(this.textBoxCost);
            this.groupBoxMenu.Controls.Add(this.textBoxWeight);
            this.groupBoxMenu.Controls.Add(this.textBoxComposition);
            this.groupBoxMenu.Controls.Add(this.textBoxTitle);
            this.groupBoxMenu.Controls.Add(this.textBoxIDMenu);
            this.groupBoxMenu.Location = new System.Drawing.Point(750, 12);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(455, 426);
            this.groupBoxMenu.TabIndex = 1;
            this.groupBoxMenu.TabStop = false;
            // 
            // textBoxIDMenu
            // 
            this.textBoxIDMenu.Location = new System.Drawing.Point(134, 25);
            this.textBoxIDMenu.Name = "textBoxIDMenu";
            this.textBoxIDMenu.Size = new System.Drawing.Size(315, 26);
            this.textBoxIDMenu.TabIndex = 0;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(134, 57);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(315, 26);
            this.textBoxTitle.TabIndex = 1;
            // 
            // textBoxComposition
            // 
            this.textBoxComposition.Location = new System.Drawing.Point(6, 260);
            this.textBoxComposition.Multiline = true;
            this.textBoxComposition.Name = "textBoxComposition";
            this.textBoxComposition.Size = new System.Drawing.Size(443, 160);
            this.textBoxComposition.TabIndex = 2;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(134, 89);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(315, 26);
            this.textBoxWeight.TabIndex = 3;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(134, 121);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(315, 26);
            this.textBoxCost.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Номер заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Вес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Стоимость";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Категория";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Состав";
            // 
            // buttonNewPosition
            // 
            this.buttonNewPosition.Location = new System.Drawing.Point(750, 444);
            this.buttonNewPosition.Name = "buttonNewPosition";
            this.buttonNewPosition.Size = new System.Drawing.Size(223, 34);
            this.buttonNewPosition.TabIndex = 2;
            this.buttonNewPosition.Text = "Добавить позицию";
            this.buttonNewPosition.UseVisualStyleBackColor = true;
            this.buttonNewPosition.Click += new System.EventHandler(this.buttonNewPosition_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(884, 479);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(198, 34);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить изменения";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
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
            this.comboBoxCategory.Location = new System.Drawing.Point(134, 159);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(315, 28);
            this.comboBoxCategory.TabIndex = 12;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(979, 444);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(226, 34);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // FormDirector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 547);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonNewPosition);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDirector";
            this.Text = "Директор";
            this.Load += new System.EventHandler(this.FormDirector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxMenu.ResumeLayout(false);
            this.groupBoxMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PizzaDataSetTableAdapters.MenuTableAdapter menuTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxComposition;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxIDMenu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNewPosition;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button buttonEdit;
    }
}