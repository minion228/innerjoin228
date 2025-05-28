using InventoryAccounting.ModelDB;
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

    public partial class AddOrEdit : Window
    {
        SportAccountingEntities _db=new SportAccountingEntities();
        private AccountingInventory _ai;

        public AddOrEdit(AccountingInventory ai, SportAccountingEntities db)
        {
            InitializeComponent();
            _ai = ai;
            _db = db;

            cmxItem.ItemsSource = db.Items.Select(i => new {id=i.ItemID, name=i.ItemName}).ToList();
            cmxItem.DisplayMemberPath = "name";
            cmxItem.SelectedValuePath = "id";
            cmxWorker.ItemsSource = db.Workers.Select(w => new {id=w.WorkerID, name=w.WorkerSurname}).ToList();
            cmxWorker.DisplayMemberPath = "name";
            cmxWorker.SelectedValuePath = "id";


            if (_ai != null)
            {
                tbxAmount.Text = _ai.ItemQuanty.ToString();
                cmxItem.SelectedValue = _ai.ItemID;
                cmxWorker.SelectedValue= _ai.WorkerID;
                date.Text=_ai.Accounting.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(cmxItem.Text) || string.IsNullOrEmpty(cmxWorker.Text) 
                || string.IsNullOrEmpty(date.Text) || string.IsNullOrEmpty(tbxAmount.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка");
                return;
            }
            if (!int.TryParse(tbxAmount.Text,out int amount))
            {
                MessageBox.Show("Некорректный ввод", "Ошибка");
                return;
            }
            if (_ai == null)
            {
                _ai = new AccountingInventory
                {
                    ItemID = (int)cmxItem.SelectedValue,
                    WorkerID = (int)cmxWorker.SelectedValue,
                    Accounting=DateTime.Parse(date.Text),
                    ItemQuanty=amount,

                };
                _db.AccountingInventory.Add(_ai);
            }
            else
            {
                _ai.ItemID = (int)cmxItem.SelectedValue;
                _ai.WorkerID = (int)cmxWorker.SelectedValue;
                _ai.Accounting = DateTime.Parse(date.Text);
                _ai.ItemQuanty = amount;
            }
            _db.SaveChanges();
            DialogResult = true;
            Close();
        }
    }
}
