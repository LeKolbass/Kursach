using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class FormAdmin : Form
    {
        enum ActionsAdmin { Insert, UpDate, Block }; 	//Возможные действия админа
        ActionsAdmin action; 					//Выбранное действие
        PizzaDataSet.UsersDataTable dataUsers;
        int ID_Operator; //ID выбранного сотрудника

        

        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            dataUsers = this.usersTableAdapter1.GetData(); //Получить все данные таблицы
            var dataPol = dataUsers.Where(rec => rec.ID_Role == 3 || rec.ID_Role == 4 || rec.ID_Role == 2); // Получить только список операторов 
            this.dataGridViewOperators.DataSource = dataPol.CopyToDataTable(); // Отображение
            dataGridViewOperators.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // this.dataGridViewOperators.AutoSizeColumnsMode = 
            this.dataGridViewOperators.Columns["ID"].Visible = false;
            this.dataGridViewOperators.Columns["ID_Role"].Visible = false;
            this.dataGridViewOperators.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            buttonFixedDB.Enabled = false;
            this.groupBoxUsers.Enabled = false;
            this.labelTotal.Text = "Всего сотрудников в системе = " +
                                                                    dataPol.Count().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void dataGridViewOperators_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numRow = e.RowIndex; //Получить номер выбранной строки
            this.textBoxFullName.Text = dataGridViewOperators.Rows[numRow].Cells[2].Value.ToString();
            this.textBoxEmail.Text = dataGridViewOperators.Rows[numRow].Cells[3].Value.ToString();
            this.textBoxPassword.Text = dataGridViewOperators.Rows[numRow].Cells[4].Value.ToString();
            this.maskedTextBoxPhone.Text = dataGridViewOperators.Rows[numRow].Cells[5].Value.ToString();
            this.checkBoxActive.Checked = (bool)dataGridViewOperators.Rows[numRow].Cells[6].Value;
            ID_Operator = (int)dataGridViewOperators.Rows[numRow].Cells[0].Value;
            if((int)dataGridViewOperators.Rows[numRow].Cells[1].Value == 3)
            {
                this.radioButtonOperator.Checked = true;
            }
            else if ((int)dataGridViewOperators.Rows[numRow].Cells[1].Value == 4)
            {
                this.radioButtonCheff.Checked = true;
            }
            else if ((int)dataGridViewOperators.Rows[numRow].Cells[1].Value == 2)
            {
                this.radioButtonAdmin.Checked = true;
            }
        }

        private void buttonRegisterUser_Click(object sender, EventArgs e)
        {
            this.groupBoxUsers.Enabled = true;          //Активность контейнера
                                                        //Очистка всех элементов в контейнере
            foreach (var item in this.groupBoxUsers.Controls)
            {
                if (item is TextBox) (item as TextBox).Text = "";
                if (item is MaskedTextBox) (item as MaskedTextBox).Text = "";
                if (item is CheckBox) (item as CheckBox).Checked = true;
            }
            buttonFixedDB.Enabled = true;
            action = ActionsAdmin.Insert;		//Зафиксировать выбранное дейсвтвие


        }
        /// Фиксация в БД изменений с записью
        private void buttonFixedDB_Click(object sender, EventArgs e)
        {
            string Email, Password, FullName, Phone;
            int ID_Role = 3;
            Email = this.textBoxEmail.Text;
            Password = this.textBoxPassword.Text;
            FullName = this.textBoxFullName.Text;
            Phone = this.maskedTextBoxPhone.Text;
            if (radioButtonOperator.Checked == true)
            {
                ID_Role = 3;
            }
            else if (radioButtonCheff.Checked == true)
            {
                ID_Role = 4;
            }
            switch (action)         //Операция с записью
            {
                case ActionsAdmin.Insert:   //Добавление новой записи - туроператора
                    try
                    {
                        //Добавление нового пользователя, активного
                        this.usersTableAdapter1.Insert(ID_Role, FullName, Email, Password,Phone, true);
                        MessageBox.Show("Данные успешно добавлены в БД");
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Ошибка при добавлении новых данных" + er.Message);
                        return;
                    }
                    break;
                case ActionsAdmin.UpDate: 	//Редактирование профиля записи - туроператора
                    try
                    {
                        //id изменяемого пользователя из выбранной строки в сетке
                        int id = (int)this.dataGridViewOperators.SelectedRows[0].Cells[0].Value;
                        //Создание строки той же структуры, что и строки в таблице
                        PizzaDataSet.UsersRow row;

                        //Получение (поиск) данных по номеру и запись их строку
                        row = dataUsers.FindByID(id);
                        //Менять только нужные поля, ID нельзя, IDRole не меняем
                        row.Email = Email;
                        row.Password = Password;
                        row.Full_name = FullName;
                       
                        row.Phone = Phone;
                        row.Active = this.checkBoxActive.Checked;
                        usersTableAdapter1.Update(row);
                        MessageBox.Show("Данные успешно отредактированы в БД");
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Ошибка при редактировании данных" + er.Message);
                        return;
                    }
                    break;
            }

            //Обновить данные в таблице
            dataUsers = this.usersTableAdapter1.GetData();   //Получить все данные таблицы
            var dataPol = dataUsers.Where(rec => rec.ID_Role == 3 || rec.ID_Role == 4 || rec.ID_Role == 2);   //Только операторов
                                                                                          //Отобразить в таблице
            this.dataGridViewOperators.DataSource = dataPol.CopyToDataTable();
                    this.labelTotal.Text = "Всего сотрудников в системе = " +
                                                                    dataPol.Count().ToString();
                    buttonFixedDB.Enabled = false;      //Запретить кнопку внесения изменений
                    this.groupBoxUsers.Enabled = false;     //Заблокировать поля ввода
            }

        private void buttonEditProfile_Click(object sender, EventArgs e)
        {
      
            //Проверка, что выделенных строк нет
            if (this.dataGridViewOperators.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите в cотрудника, которого надо редактировать");
                return;
            }
            this.groupBoxUsers.Enabled = true;		//Разблокировать поля ввода
            buttonFixedDB.Enabled = true; 		//Разрешить кнопку внесения изменений
            action = ActionsAdmin.UpDate; 		//Режим редактирования

        }
    }
    }
    
