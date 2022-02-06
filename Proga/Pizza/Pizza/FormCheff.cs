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
    public partial class FormCheff : Form
    {
        enum ActionsAdmin { Insert, UpDate, Block }; 	//Возможные действия админа
        ActionsAdmin action; 					//Выбранное действие
        PizzaDataSet.OrdersDataTable dataOrders;
        PizzaDataSet.MenuDataTable dataMenu;
        PizzaDataSet.ReceiptDataTable dataReceipt;
        int OrderCost;
        int IdOrderMeaning;
        int IdMenuMeaning;
        public FormCheff()
        {
            InitializeComponent();
        }

        private void FormCheff_Load(object sender, EventArgs e)
        {
            dataOrders = this.ordersTableAdapter1.GetData(); //Получить все данные таблицы Orders
            this.dataGridViewOrders.DataSource = dataOrders;
            dataGridViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataMenu = this.menuTableAdapter1.GetData();
            this.dataGridViewMenu.DataSource = dataMenu;
            dataGridViewMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMenu.Columns["Photo"].Visible = false;

            dataReceipt = this.receiptTableAdapter1.GetData();
            this.dataGridViewReceipt.DataSource = dataReceipt;
            dataGridViewReceipt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReceipt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReceipt.Select();

            //this.groupBoxReceipt.Enabled = false;
            this.Width = 1000;
            this.Height = 500;
        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numRow = e.RowIndex; //Получить номер выбранной строки
            IdOrderMeaning = Convert.ToInt32(dataGridViewOrders.Rows[numRow].Cells[0].Value);
            try
            {
                //Фильтр таблицы Receiptы
                dataReceipt = this.receiptTableAdapter1.GetData(); //Получить все данные таблицы
                var dataPol = dataReceipt.Where(rec => rec.ID_Order == IdOrderMeaning); // Получить только список операторов 
                this.dataGridViewReceipt.DataSource = dataPol.CopyToDataTable(); // Отображение
            }
            catch (Exception er)
            {
                MessageBox.Show("Ошибка при просмотре данных");
                return;
            }
            
        }

        private void dataGridViewMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numRow = e.RowIndex; //Получить номер выбранной строки
            IdMenuMeaning = Convert.ToInt32(dataGridViewMenu.Rows[numRow].Cells[0].Value);
            textBoxComposition.Text = dataGridViewMenu.Rows[numRow].Cells[2].Value.ToString();
        }

        private void dataGridViewReceipt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Count = 0;
            int numRow = e.RowIndex;
            Count = Convert.ToInt32(dataGridViewReceipt.Rows[numRow].Cells[3].Value);
            
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedIndex == 0)
            {
                dataMenu = this.menuTableAdapter1.GetData();
                this.dataGridViewMenu.DataSource = dataMenu;
            }

            if (comboBoxCategory.SelectedIndex == 1)
            {
                dataMenu = this.menuTableAdapter1.GetData(); //Получить все данные таблицы
                var dataPol = dataMenu.Where(rec => rec.Caterogy == "Хит"); // Получить только список операторов 
                this.dataGridViewMenu.DataSource = dataPol.CopyToDataTable(); // Отображение
            }

            if (comboBoxCategory.SelectedIndex == 2)
            {
                dataMenu = this.menuTableAdapter1.GetData(); //Получить все данные таблицы
                var dataPol = dataMenu.Where(rec => rec.Caterogy == "Вегетарианская"); // Получить только список операторов 
                this.dataGridViewMenu.DataSource = dataPol.CopyToDataTable(); // Отображение
            }

            if (comboBoxCategory.SelectedIndex == 3)
            {
                dataMenu = this.menuTableAdapter1.GetData(); //Получить все данные таблицы
                var dataPol = dataMenu.Where(rec => rec.Caterogy == "Острая"); // Получить только список операторов 
                this.dataGridViewMenu.DataSource = dataPol.CopyToDataTable(); // Отображение
            }

            if (comboBoxCategory.SelectedIndex == 4)
            {
                dataMenu = this.menuTableAdapter1.GetData(); //Получить все данные таблицы
                var dataPol = dataMenu.Where(rec => rec.Caterogy == "Мясная"); // Получить только список операторов 
                this.dataGridViewMenu.DataSource = dataPol.CopyToDataTable(); // Отображение
            }
        }

        private void buttonActiveDisable_Click(object sender, EventArgs e)
        {
            action = ActionsAdmin.UpDate; //Зафиксировать выбранное дейсвтвие
            bool Active = false;

            //id изменяемого пользователя из выбранной строки в сетке

            switch (action) //Операция с записью
            {

                case ActionsAdmin.UpDate: //Редактирование профиля записи - туроператора
                    try
                    {
                        //id изменяемого пользователя из выбранной строки в сетке
                        int id = (int)this.dataGridViewOrders.SelectedRows[0].Cells[0].Value;
                        //Создание строки той же структуры, что и строки в таблице
                        PizzaDataSet.OrdersRow rowOrders;
                        //Получение (поиск) данных по номеру и запись их строку
                        rowOrders = dataOrders.FindByID(id);
                        //Менять только нужные поля, ID нельзя, IDRole не меняем
                        rowOrders.Active = Active;

                        ordersTableAdapter1.Update(rowOrders);
                        

                        //Обновить данные в таблице
                        dataOrders = this.ordersTableAdapter1.GetData();   //Получить все данные таблицы
                        this.dataGridViewOrders.DataSource = dataOrders;  //Отобразить
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Ошибка при редактировании данных" + er.Message);
                        return;
                    }
                    break;
            }
        }

        private void buttonActiveActive_Click(object sender, EventArgs e)
        {
            action = ActionsAdmin.UpDate; //Зафиксировать выбранное дейсвтвие
            bool Active = true;

            //id изменяемого пользователя из выбранной строки в сетке

            switch (action) //Операция с записью
            {

                case ActionsAdmin.UpDate: //Редактирование профиля записи - туроператора
                    try
                    {
                        //id изменяемого пользователя из выбранной строки в сетке
                        int id = (int)this.dataGridViewOrders.SelectedRows[0].Cells[0].Value;
                        //Создание строки той же структуры, что и строки в таблице
                        PizzaDataSet.OrdersRow rowOrders;
                        //Получение (поиск) данных по номеру и запись их строку
                        rowOrders = dataOrders.FindByID(id);
                        //Менять только нужные поля, ID нельзя, IDRole не меняем
                        rowOrders.Active = Active;

                        ordersTableAdapter1.Update(rowOrders);
                        

                        //Обновить данные в таблице
                        dataOrders = this.ordersTableAdapter1.GetData();   //Получить все данные таблицы
                        this.dataGridViewOrders.DataSource = dataOrders;  //Отобразить
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Ошибка при редактировании данных" + er.Message);
                        return;
                    }
                    break;
            }
        }
    }
}
