using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pizza
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }
        PizzaDataSet.UsersDataTable dataUsers;
        //Событие запуска приложения
        private void Form1_Load(object sender, EventArgs e)
        {
            
            //Строка подключения из файла конфигурации
            string connectionString = @"Data Source=DESKTOP-U0O3POV\SQLEXPRESS;Initial Catalog=Pizza;Integrated Security=True";
            //Создание и настройка объекта подключения к БД
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            //Контроль за удачным подключением
            try
            {
                connection.Open();			
            }
            catch (SqlException ex)			//Обработка сбоя при подключении
            {
                switch (ex.Number)			//Номер ошибки
                {
                    case 17: MessageBox.Show("Неверное имя сервера"); break;
                    case 4060: MessageBox.Show("Неверное имя БД"); break;
                    case 18456: MessageBox.Show("Неверное имя пользователя или пароль"); break;
                }
                MessageBox.Show(ex.Message + " Уровень ошибки " + ex.Class);
                Application.Exit();
            }
            catch (Exception ex)			//Общий сбой при подключении
            {
                MessageBox.Show("Ошибка подключения " + ex.Message);
                Application.Exit();
            }
            MessageBox.Show("Связь с сервером установлена");
            //Дальнейшие действия с подключенной БД
            //Получить все записи таблицы Users через адаптер usersTableAdapter
            dataUsers = this.usersTableAdapter1.GetData();
            //Отобразить полученные записи в компоненте
            this.dataGridViewUsers.DataSource = dataUsers;
            //Настроить компонент по ширине
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string log, pas;
            pas = this.textBoxPassword.Text;
            log = this.textBoxLogin.Text; //Исходные данные
            var filter = dataUsers.Where(p => p.Email == log && p.Password == pas);
            if (filter.Count() == 0) //Логин и пароль не совпали
                MessageBox.Show("Таких данных нет.");
            else //Данные в бд есть
            {
                //Получение данных о пользователе и запись их в общий
                //Первая и единственная запись с 0ым индексом
                Total.ID_User = filter.ElementAt(0).ID;
                Total.ID_Role = filter.ElementAt(0).ID_Role;
                switch (Total.ID_Role)
                {
                    case 2:
                        MessageBox.Show("Вы успешно авторизовались как администратор");
                        FormAdmin fa = new FormAdmin();
                        this.Hide();
                        fa.ShowDialog();
                        this.Show();
                        break;
                    case 1:
                        MessageBox.Show("Вы успешно авторизовались как директор");
                        FormDirectorChoose fd = new FormDirectorChoose();
                        this.Hide();
                        fd.ShowDialog();
                        this.Show();
                        break;
                    case 3:
                        MessageBox.Show("Вы успешно авторизовались как оператор");
                        FormOperator fo = new FormOperator();
                        this.Hide();
                        fo.ShowDialog();
                        this.Show();
                        break;
                    case 4:
                        MessageBox.Show("Вы успешно авторизовались как повар");
                        FormCheff fc = new FormCheff();
                        this.Hide();
                        fc.ShowDialog();
                        this.Show();
                        break;
                }
            }
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
