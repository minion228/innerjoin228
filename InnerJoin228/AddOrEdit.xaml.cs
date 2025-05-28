using InnerJoin228.ModelDB;
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

namespace InnerJoin228
{
    public partial class AddOrEdit : Window
    {
        private InnerJoin228Entities _db;
        private Users _user;
        public AddOrEdit(Users user, InnerJoin228Entities db)
        {
            InitializeComponent();
            _user = user;
            _db = db;
            cmxRole.ItemsSource = db.Roles
                .Select(r => new {ID=r.RoleID, Name=r.RoleName})
                .ToList();
            cmxRole.DisplayMemberPath = "Name";
            cmxRole.SelectedValuePath = "ID";


            if (_user!= null)
            {
                tbxLogin.Text = _user.UserLogin;
                tbxPassword.Text = _user.UserPassword;
                cmxRole.SelectedValue=_user.UserRole;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(tbxLogin.Text) || string.IsNullOrEmpty(tbxPassword.Text) || string.IsNullOrEmpty(cmxRole.Text))
            {
                MessageBox.Show("Заполните все поля","");
                return;
            }
            if (_user == null)
            {
                _user = new Users
                {
                    UserLogin = tbxLogin.Text,
                    UserPassword = tbxPassword.Text,
                    UserRole = (int)cmxRole.SelectedValue
                };
                _db.Users.Add(_user);
            }
            else
            {
                _user.UserLogin = tbxLogin.Text;
                _user.UserPassword = tbxPassword.Text;
                _user.UserRole = (int)cmxRole.SelectedValue;
            }
            _db.SaveChanges();
            DialogResult = true;
            Close();
        }
    }
}
