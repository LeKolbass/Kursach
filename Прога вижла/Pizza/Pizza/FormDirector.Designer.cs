
namespace Pizza
{
    partial class FormAdmin
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
            this.ButtonExit = new System.Windows.Forms.Button();
            this.dataGridViewOperators = new System.Windows.Forms.DataGridView();
            this.groupBoxUsers = new System.Windows.Forms.GroupBox();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonCheff = new System.Windows.Forms.RadioButton();
            this.radioButtonOperator = new System.Windows.Forms.RadioButton();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.buttonRegisterUser = new System.Windows.Forms.Button();
            this.buttonFixedDB = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.usersTableAdapter1 = new Pizza.PizzaDataSetTableAdapters.UsersTableAdapter();
            this.buttonEditProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperators)).BeginInit();
            this.groupBoxUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(1067, 12);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(75, 29);
            this.ButtonExit.TabIndex = 0;
            this.ButtonExit.Text = "Выход";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewOperators
            // 
            this.dataGridViewOperators.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOperators.Location = new System.Drawing.Point(12, 88);
            this.dataGridViewOperators.Name = "dataGridViewOperators";
            this.dataGridViewOperators.RowHeadersWidth = 62;
            this.dataGridViewOperators.RowTemplate.Height = 28;
            this.dataGridViewOperators.Size = new System.Drawing.Size(745, 461);
            this.dataGridViewOperators.TabIndex = 1;
            this.dataGridViewOperators.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOperators_CellContentClick);
            // 
            // groupBoxUsers
            // 
            this.groupBoxUsers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxUsers.Controls.Add(this.radioButtonAdmin);
            this.groupBoxUsers.Controls.Add(this.label4);
            this.groupBoxUsers.Controls.Add(this.label3);
            this.groupBoxUsers.Controls.Add(this.label2);
            this.groupBoxUsers.Controls.Add(this.label1);
            this.groupBoxUsers.Controls.Add(this.radioButtonCheff);
            this.groupBoxUsers.Controls.Add(this.radioButtonOperator);
            this.groupBoxUsers.Controls.Add(this.maskedTextBoxPhone);
            this.groupBoxUsers.Controls.Add(this.checkBoxActive);
            this.groupBoxUsers.Controls.Add(this.textBoxPassword);
            this.groupBoxUsers.Controls.Add(this.textBoxEmail);
            this.groupBoxUsers.Controls.Add(this.textBoxFullName);
            this.groupBoxUsers.Location = new System.Drawing.Point(763, 119);
            this.groupBoxUsers.Name = "groupBoxUsers";
            this.groupBoxUsers.Size = new System.Drawing.Size(452, 352);
            this.groupBoxUsers.TabIndex = 2;
            this.groupBoxUsers.TabStop = false;
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point(254, 287);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(156, 24);
            this.radioButtonAdmin.TabIndex = 12;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Администратор";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Номер телефона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "ФИО";
            // 
            // radioButtonCheff
            // 
            this.radioButtonCheff.AutoSize = true;
            this.radioButtonCheff.Location = new System.Drawing.Point(254, 256);
            this.radioButtonCheff.Name = "radioButtonCheff";
            this.radioButtonCheff.Size = new System.Drawing.Size(82, 24);
            this.radioButtonCheff.TabIndex = 7;
            this.radioButtonCheff.TabStop = true;
            this.radioButtonCheff.Text = "Повар";
            this.radioButtonCheff.UseVisualStyleBackColor = true;
            // 
            // radioButtonOperator
            // 
            this.radioButtonOperator.AutoSize = true;
            this.radioButtonOperator.Location = new System.Drawing.Point(254, 225);
            this.radioButtonOperator.Name = "radioButtonOperator";
            this.radioButtonOperator.Size = new System.Drawing.Size(109, 24);
            this.radioButtonOperator.TabIndex = 6;
            this.radioButtonOperator.TabStop = true;
            this.radioButtonOperator.Text = "Оператор";
            this.radioButtonOperator.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(150, 180);
            this.maskedTextBoxPhone.Mask = "9 (999) 000-0000";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(285, 26);
            this.maskedTextBoxPhone.TabIndex = 5;
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Location = new System.Drawing.Point(150, 225);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(89, 24);
            this.checkBoxActive.TabIndex = 4;
            this.checkBoxActive.Text = "Доступ";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(150, 132);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(285, 26);
            this.textBoxPassword.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(150, 84);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(285, 26);
            this.textBoxEmail.TabIndex = 1;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(150, 33);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(285, 26);
            this.textBoxFullName.TabIndex = 0;
            // 
            // buttonRegisterUser
            // 
            this.buttonRegisterUser.Location = new System.Drawing.Point(847, 477);
            this.buttonRegisterUser.Name = "buttonRegisterUser";
            this.buttonRegisterUser.Size = new System.Drawing.Size(127, 31);
            this.buttonRegisterUser.TabIndex = 3;
            this.buttonRegisterUser.Text = "Регистрация";
            this.buttonRegisterUser.UseVisualStyleBackColor = true;
            this.buttonRegisterUser.Click += new System.EventHandler(this.buttonRegisterUser_Click);
            // 
            // buttonFixedDB
            // 
            this.buttonFixedDB.Location = new System.Drawing.Point(847, 509);
            this.buttonFixedDB.Name = "buttonFixedDB";
            this.buttonFixedDB.Size = new System.Drawing.Size(303, 40);
            this.buttonFixedDB.TabIndex = 4;
            this.buttonFixedDB.Text = "Зафиксировать изменения в БД";
            this.buttonFixedDB.UseVisualStyleBackColor = true;
            this.buttonFixedDB.Click += new System.EventHandler(this.buttonFixedDB_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(12, 21);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(51, 20);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "label5";
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // buttonEditProfile
            // 
            this.buttonEditProfile.Location = new System.Drawing.Point(1002, 478);
            this.buttonEditProfile.Name = "buttonEditProfile";
            this.buttonEditProfile.Size = new System.Drawing.Size(148, 28);
            this.buttonEditProfile.TabIndex = 6;
            this.buttonEditProfile.Text = "Редактирование";
            this.buttonEditProfile.UseVisualStyleBackColor = true;
            this.buttonEditProfile.Click += new System.EventHandler(this.buttonEditProfile_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 578);
            this.Controls.Add(this.buttonEditProfile);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonFixedDB);
            this.Controls.Add(this.buttonRegisterUser);
            this.Controls.Add(this.groupBoxUsers);
            this.Controls.Add(this.dataGridViewOperators);
            this.Controls.Add(this.ButtonExit);
            this.Name = "FormAdmin";
            this.Text = "Администратор";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperators)).EndInit();
            this.groupBoxUsers.ResumeLayout(false);
            this.groupBoxUsers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.DataGridView dataGridViewOperators;
        private System.Windows.Forms.GroupBox groupBoxUsers;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.RadioButton radioButtonCheff;
        private System.Windows.Forms.RadioButton radioButtonOperator;
        private System.Windows.Forms.Button buttonRegisterUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFixedDB;
        private System.Windows.Forms.Label labelTotal;
        private PizzaDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.Button buttonEditProfile;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
    }
}