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
    public partial class ListOfRoles : Window
    {
        InnerJoin228Entities db=new InnerJoin228Entities();
        public ListOfRoles()
        {
            InitializeComponent();
            dgRoles.ItemsSource=db.Roles.ToList();
        }
    }
}
