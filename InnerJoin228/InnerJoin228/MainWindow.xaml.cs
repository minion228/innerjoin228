using InnerJoin228.Interfaces;
using InnerJoin228.Logic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InnerJoin228
{

    public partial class MainWindow : Window
    {
        private IAuth _auth;
        public MainWindow()
        {
            InitializeComponent();
            _auth= new Auth();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login=tbxLogin.Text;
            string password=tbxPassword.Password;
            if (_auth.Check(login, password))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль","");
                tbxLogin.Clear();
                tbxPassword.Clear();
            }
        }
    }
}
