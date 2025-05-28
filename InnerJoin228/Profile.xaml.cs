using InnerJoin228.Classes;
using InnerJoin228.ModelDB;
using System;
using System.IO;
using InnerJoin228.Logic;
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
using Microsoft.Win32;

namespace InnerJoin228
{
    public partial class Profile : Window
    {
        private Users _currentUser;
        private InnerJoin228Entities db=new InnerJoin228Entities();

        public Profile(Users user)
        {
            InitializeComponent();
            _currentUser = user;
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                dgUsers.ItemsSource = db.Users.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new AddOrEdit(null, db);
            if (window.ShowDialog() == true)
            {
                LoadData();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(dgUsers.SelectedItem is Users selected)
            {
                var window = new AddOrEdit(selected, db);
                if (window.ShowDialog() == true)
                {
                    LoadData();
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (dgUsers.SelectedItem is Users selected)
            {
                var res = MessageBox.Show("Удалить?","",MessageBoxButton.YesNo);
                if (res==MessageBoxResult.Yes)
                {
                    db.Users.Remove(selected);
                    db.SaveChanges();
                    LoadData();
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                FileName="Export.csv",
                Filter="file csv (*.csv) | *.csv",
                DefaultExt="*.csv"
            };
            if (sfd.ShowDialog() == true)
            {
                string path=sfd.FileName;
                var csv = new StringBuilder();
                csv.AppendLine("id,login,password,role");
                foreach(var item in dgUsers.ItemsSource.Cast<Users>())
                {
                    csv.AppendLine($"{item.UserID}, {item.UserLogin}, {item.UserPassword}, {item.UserRole}");
                }
                File.WriteAllText(path, csv.ToString(), Encoding.UTF8);
                MessageBox.Show("Экспортировано","");
            }


        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText=search.Text.ToLower();
            var filter=db.Users.Where(u=>
            u.UserID.ToString().Contains(searchText) ||
            u.UserLogin.ToLower().Contains(searchText) ||
            u.UserPassword.ToLower().Contains(searchText) ||
            u.Roles.RoleName.ToLower().Contains(searchText) 
            );
            dgUsers.ItemsSource = filter.ToList();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            new ListOfRoles().Show();

        }
    }
}
