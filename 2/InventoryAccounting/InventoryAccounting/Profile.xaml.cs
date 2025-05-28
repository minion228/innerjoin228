using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using InventoryAccounting.ModelDB;
using Microsoft.Win32;

namespace InventoryAccounting
{
    public partial class Profile : Window
    {
        SportAccountingEntities db=new SportAccountingEntities();
        private Users _currentUser;

        public Profile(Users user)
        {
            InitializeComponent();
            LoadData();
            _currentUser = user;
        }
        public void LoadData()
        {
            try
            {
                dg.ItemsSource = db.AccountingInventory.ToList();
                Stats();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText=search.Text.ToLower();
            var filter = db.AccountingInventory.Where(a=>
                a.Items.ItemName.ToLower().Contains(searchText) ||
                a.Items.ItemDescription.ToLower().Contains(searchText) ||
                a.Workers.WorkerName.ToLower().Contains(searchText) ||
                a.Workers.WorkerSurname.ToLower().Contains(searchText)
                );
            dg.ItemsSource=filter.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Login().Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new ListOfCategory().Show();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            var w = new AddOrEdit(null, db);
            if (w.ShowDialog() == true)
            {
                LoadData();
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if(dg.SelectedItem is AccountingInventory select)
            {
                var w = new AddOrEdit(select, db);
                if (w.ShowDialog() == true)
                {
                    LoadData();
                }
            }
        }

        private void Export_Click(object sender, RoutedEventArgs e)
        {
            
            SaveFileDialog sfd = new SaveFileDialog
            {
                FileName = "Export.csv",
                Filter = "File csv (*.csv) | *.csv",
                DefaultExt="*.csv",
            };
            if (sfd.ShowDialog() == true)
            {
                string path = sfd.FileName;
                var csv= new StringBuilder();
                csv.AppendLine("");
                foreach(var item in dg.ItemsSource.Cast<AccountingInventory>())
                {
                    csv.AppendLine($"{item.ItemID}");
                }
                File.WriteAllText(path, csv.ToString(),Encoding.UTF8);
                MessageBox.Show("Успешно!","");
            }

        }
        private void Stats()
        {
            int itemCount = db.AccountingInventory.Count(); 
            int totalQuantity = db.AccountingInventory.Sum(ai => ai.ItemQuanty); 
            int maxCount=db.AccountingInventory.Max(i=>i.ItemQuanty);

            tbStat.Text = $"Записей: {itemCount}, Всего товаров: {totalQuantity} Max: {maxCount}";
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (dg.SelectedItem is AccountingInventory select)
            {
                var res = MessageBox.Show("Удалить запись?", "", MessageBoxButton.YesNo);
                if (res == MessageBoxResult.Yes)
                {
                    db.AccountingInventory.Remove(select);
                    db.SaveChanges();
                    LoadData();
                }
            }
        }
    }
}
