using InventoryAccounting.Interfaces;
using InventoryAccounting.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace InventoryAccounting
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private IAuth _auth;
        public Login()
        {
            InitializeComponent();
            _auth = new Auth();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login=tbxLogin.Text;
            string password = tbxPassword.Password;

            if(string.IsNullOrEmpty(tbxLogin.Text) || string.IsNullOrEmpty(tbxPassword.Password))
            {
                MessageBox.Show("Заполните все поля", "Ошибка");
            }
            if (_auth.Check(login, password))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка");
                tbxLogin.Clear();
                tbxPassword.Clear();
            }
            
        }
    }
}
