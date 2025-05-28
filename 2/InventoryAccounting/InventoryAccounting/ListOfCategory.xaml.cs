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
    /// <summary>
    /// Логика взаимодействия для ListOfCategory.xaml
    /// </summary>
    public partial class ListOfCategory : Window
    {
        SportAccountingEntities db=new SportAccountingEntities();
        public ListOfCategory()
        {
            InitializeComponent();
            dg.ItemsSource=db.Categories.ToList();
        }
    }
}
