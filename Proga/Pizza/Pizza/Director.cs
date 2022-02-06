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
    public partial class FormDirector : Form
    {
        enum ActionsAdmin { Insert, UpDate, Block }; 	//Возможные действия админа
        ActionsAdmin action;
        PizzaDataSet.MenuDataTable dataMenu;

        public FormDirector()
        {
            InitializeComponent();
        }
        private void FormDirector_Load(object sender, EventArgs e)
        {
            dataMenu = this.menuTableAdapter1.GetData();
            this.dataGridView1.DataSource = dataMenu;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //this.dataGridView1.Columns["Photo"].Visible = false;
            //this.dataGridView1.Columns["Id"].Visible = false;
            //this.dataGridView1.Columns["Composition"].Visible = false;
            this.groupBoxMenu.Enabled = false;		//заблокировать поля ввода
            buttonSave.Enabled = false;      //раззрешить кнопку внесения изменений
            textBoxIDMenu.Enabled = false;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numRow = e.RowIndex; //Получить номер выбранной строки
            this.textBoxIDMenu.Text = dataGridView1.Rows[numRow].Cells[0].Value.ToString();
            this.textBoxTitle.Text = dataGridView1.Rows[numRow].Cells[1].Value.ToString();
            this.textBoxComposition.Text = dataGridView1.Rows[numRow].Cells[2].Value.ToString();
            this.textBoxWeight.Text = dataGridView1.Rows[numRow].Cells[3].Value.ToString();
            this.textBoxCost.Text = dataGridView1.Rows[numRow].Cells[4].Value.ToString();
            this.comboBoxCategory.Text = dataGridView1.Rows[numRow].Cells[5].Value.ToString();
        }

        private void buttonNewPosition_Click(object sender, EventArgs e)
        {
            this.groupBoxMenu.Enabled = true;          //Активность контейнера
                                                        //Очистка всех элементов в контейнере
            foreach (var item in this.groupBoxMenu.Controls)
            {
                if (item is TextBox) (item as TextBox).Text = "";
                if (item is MaskedTextBox) (item as MaskedTextBox).Text = "";
                if (item is CheckBox) (item as CheckBox).Checked = true;
            }
            buttonSave.Enabled = true;
            action = ActionsAdmin.Insert;		//Зафиксировать выбранное дейсвтвие
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string Title, Composition, Category;
            int Weight, Cost;
            Title = this.textBoxTitle.Text;
            Composition = this.textBoxComposition.Text;
            Category = this.comboBoxCategory.Text;
            Weight = Convert.ToInt32(this.textBoxWeight.Text);
            Cost = Convert.ToInt32(this.textBoxCost.Text);
            switch (action)         //Операция с записью
            {
                case ActionsAdmin.Insert:   //Добавление новой записи - туроператора
                    try
                    {
                        //Добавление нового пользователя, активного
                        this.menuTableAdapter1.Insert(Title, Composition, Weight, Cost, Category, null, true);
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
                        int id = (int)this.dataGridView1.SelectedRows[0].Cells[0].Value;
                        //Создание строки той же структуры, что и строки в таблице
                        PizzaDataSet.MenuRow row;

                        //Получение (поиск) данных по номеру и запись их строку
                        row = dataMenu.FindByID(id);
                        //Менять только нужные поля, ID нельзя, IDRole не меняем
                        row.Title = Title;
                        row.Composition = Composition;
                        row.Caterogy = Category;
                        row.Cost = Cost;
                        row.Weight = Weight;
                        row.Active = true;
                        menuTableAdapter1.Update(row);
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
            dataMenu = this.menuTableAdapter1.GetData();   //Получить все данные таблицы
            this.dataGridView1.DataSource = dataMenu;

            buttonSave.Enabled = false;      //Запретить кнопку внесения изменений
            this.groupBoxMenu.Enabled = false;     //Заблокировать поля ввода
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //Проверка, что выделенных строк нет
            if (this.dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите в cотрудника, которого надо редактировать");
                return;
            }
            this.groupBoxMenu.Enabled = true;		//Разблокировать поля ввода
            buttonSave.Enabled = true; 		//Разрешить кнопку внесения изменений
            action = ActionsAdmin.UpDate; 		//Режим редактирования
        }
    }
}

