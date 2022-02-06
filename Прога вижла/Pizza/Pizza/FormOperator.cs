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
    public partial class FormOperator : Form
    {
        enum ActionsAdmin { Insert, UpDate, Block }; 	//Возможные действия админа
        ActionsAdmin action; 					//Выбранное действие
        PizzaDataSet.OrdersDataTable dataOrders;
        PizzaDataSet.MenuDataTable dataMenu;
        PizzaDataSet.ReceiptDataTable dataReceipt;
        int OrderCost;
        int IdOrderMeaning;
        int IdMenuMeaning;
        public FormOperator()
        {
            InitializeComponent();
        }

        private void FormOperator_Load(object sender, EventArgs e)
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
            this.textBoxID_Dish.Text = dataGridViewMenu.Rows[numRow].Cells[0].Value.ToString();
        }

        private void dataGridViewReceipt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int Count = 0;
            int numRow = e.RowIndex;
            this.textBoxID_Order.Text = dataGridViewReceipt.Rows[numRow].Cells[1].Value.ToString();
            this.textBoxID_Dish.Text = dataGridViewReceipt.Rows[numRow].Cells[2].Value.ToString();
            this.textBoxCount.Text = dataGridViewReceipt.Rows[numRow].Cells[3].Value.ToString();
            
            Count = Convert.ToInt32(dataGridViewReceipt.Rows[numRow].Cells[3].Value);
            
            


        }

        private void buttonCreateNewOrder_Click(object sender, EventArgs e)
        {
            foreach (var item in this.groupBoxReceipt.Controls)
            {
                if (item is TextBox) (item as TextBox).Text = "";
                if (item is MaskedTextBox) (item as MaskedTextBox).Text = "";
                if (item is CheckBox) (item as CheckBox).Checked = true;
            }

            
            action = ActionsAdmin.Insert;		//Зафиксировать выбранное дейсвтвие

            this.ordersTableAdapter1.Insert(0,null);
            //this.groupBoxReceipt.Enabled = true;
            dataOrders = this.ordersTableAdapter1.GetData();   //Получить все данные таблицы
            this.dataGridViewOrders.DataSource = dataOrders;  //Отобразить
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
                action = ActionsAdmin.Insert; //Зафиксировать выбранное дейсвтвие
                int ID_Order, ID_Dish, Count, Price, Cost;
                ID_Order = Convert.ToInt32(this.textBoxID_Order.Text);
                ID_Dish = Convert.ToInt32(this.textBoxID_Dish.Text);
                Count = Convert.ToInt32(this.textBoxCount.Text);
                switch (action) //Операция с записью
                {
                    case ActionsAdmin.Insert: //Добавление новой записи
                        try
                        {
                            //Добавление блюда
                            this.receiptTableAdapter1.Insert(ID_Order, ID_Dish, Count);
                            MessageBox.Show("Данные успешно добавлены");
                        }
                        catch (Exception er)
                        {
                            MessageBox.Show("Ошибка при добавлении новых данных" + er.Message);
                            return;
                        }
                        break;
                    case ActionsAdmin.UpDate: //Редактирование профиля записи - туроператора
                        try
                        {
                            //id изменяемого пользователя из выбранной строки в сетке
                            int id = (int)this.dataGridViewReceipt.SelectedRows[0].Cells[0].Value;
                            //Создание строки той же структуры, что и строки в таблице
                            PizzaDataSet.ReceiptRow rowReceipt;
                            //Получение (поиск) данных по номеру и запись их строку
                            rowReceipt = dataReceipt.FindByID(id);
                            //Менять только нужные поля, ID нельзя, IDRole не меняем
                            rowReceipt.ID_Order = ID_Order;
                            rowReceipt.ID_Dish = ID_Dish;
                            rowReceipt.Count = Count;
                            receiptTableAdapter1.Update(rowReceipt);
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
                dataReceipt = this.receiptTableAdapter1.GetData();   //Получить все данные таблицы
            this.dataGridViewReceipt.DataSource = dataReceipt;  //Отобразить
            //buttonAdd.Enabled = false;      //Запретить кнопку внесения изменений
            //this.groupBoxReceipt.Enabled = false;     //Заблокировать поля ввода
            for (int i = 0; i < dataGridViewOrders.Rows.Count - 1; i++)
            {
                if(dataGridViewOrders[0, i].Value.ToString() == textBoxID_Order.Text)
                {
                    OrderCost = Convert.ToInt32(dataGridViewOrders[1, i].Value);
                }
            }
                
            for (int i = 0; i < dataGridViewMenu.Rows.Count - 1; i++)
            {
                if (dataGridViewMenu[0, i].Value.ToString() == textBoxID_Dish.Text)
                {
                    OrderCost += Convert.ToInt32(dataGridViewMenu[4, i].Value ) * Count;
                }
            }
            PizzaDataSet.OrdersRow row;
            row = dataOrders.FindByID(ID_Order);
            row.Price = OrderCost;
            this.ordersTableAdapter1.Update(row);
            dataOrders = this.ordersTableAdapter1.GetData();   //Получить все данные таблицы
            this.dataGridViewOrders.DataSource = dataOrders;  //Отобразить

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

        private void buttonEditReceipt_Click(object sender, EventArgs e)
        {
            action = ActionsAdmin.UpDate; //Зафиксировать выбранное дейсвтвие
            int ID_Order, ID_Dish, Count, Price, Cost;
            int Old_Id_Dish;
            int Old_Count;
            ID_Order = Convert.ToInt32(this.textBoxID_Order.Text);
            ID_Dish = Convert.ToInt32(this.textBoxID_Dish.Text);
            Count = Convert.ToInt32(this.textBoxCount.Text);
            //id изменяемого пользователя из выбранной строки в сетке

            switch (action) //Операция с записью
            {
              /*  case ActionsAdmin.Insert: //Добавление новой записи
                    try
                    {
                        //Добавление блюда
                        this.receiptTableAdapter1.Insert(ID_Order, ID_Dish, Count);
                        MessageBox.Show("Данные успешно добавлены");
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Ошибка при добавлении новых данных" + er.Message);
                        return;
                    }
                    break; */
                case ActionsAdmin.UpDate: //Редактирование профиля записи - туроператора
                    try
                    {
                        //id изменяемого пользователя из выбранной строки в сетке
                        int id = (int)this.dataGridViewReceipt.SelectedRows[0].Cells[0].Value;
                        //Создание строки той же структуры, что и строки в таблице
                        PizzaDataSet.ReceiptRow rowReceipt;
                        //Получение (поиск) данных по номеру и запись их строку
                        rowReceipt = dataReceipt.FindByID(id);
                        Old_Id_Dish = rowReceipt.ID_Dish;
                        Old_Count = rowReceipt.Count;
                        //Менять только нужные поля, ID нельзя, IDRole не меняем
                        rowReceipt.ID_Order = ID_Order;
                        rowReceipt.ID_Dish = ID_Dish;
                        rowReceipt.Count = Count;
                        receiptTableAdapter1.Update(rowReceipt);
                        MessageBox.Show("Данные успешно отредактированы в БД");

                        //Обновить данные в таблице
                        dataReceipt = this.receiptTableAdapter1.GetData();   //Получить все данные таблицы
                        this.dataGridViewReceipt.DataSource = dataReceipt;  //Отобразить

                        for (int i = 0; i < dataGridViewOrders.Rows.Count - 1; i++)
                        {
                            if (dataGridViewOrders[0, i].Value.ToString() == textBoxID_Order.Text)
                            {
                                OrderCost = Convert.ToInt32(dataGridViewOrders[1, i].Value);
                            }
                        }
                        for (int i = 0; i < dataGridViewMenu.Rows.Count - 1; i++)
                        {
                            if (dataGridViewMenu[0, i].Value.ToString() == Old_Id_Dish.ToString())
                            {
                                OrderCost -= Convert.ToInt32(dataGridViewMenu[4, i].Value) * Old_Count;
                            }
                        }
                        
                        for (int i = 0; i < dataGridViewMenu.Rows.Count - 1; i++)
                        {
                            if (dataGridViewMenu[0, i].Value.ToString() == textBoxID_Dish.Text)
                            {
                                OrderCost += Convert.ToInt32(dataGridViewMenu[4, i].Value) * Count;
                            }
                        }
                        PizzaDataSet.OrdersRow row;
                        row = dataOrders.FindByID(ID_Order);
                        row.Price = OrderCost;
                        this.ordersTableAdapter1.Update(row);
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {



        }

        private void buttonDeleteDishReceipt_Click(object sender, EventArgs e)
        {
            //action = ActionsAdmin.Delete;
            //int id = (int)this.dataGridViewReceipt.SelectedRows[0].Cells[0].Value;
            //PizzaDataSet.ReceiptRow rowReceipt;
            ////Получение (поиск) данных по номеру и запись их строку
            //rowReceipt = dataReceipt.FindByID(id);

            //receiptTableAdapter1.Delete(id, rowReceipt.ID_Order,rowReceipt.ID_Dish,rowReceipt.Count);
            //dataReceipt = this.receiptTableAdapter1.GetData();   //Получить все данные таблицы
            //this.dataGridViewReceipt.DataSource = dataReceipt;  //Отобразить
        }
    }
}
