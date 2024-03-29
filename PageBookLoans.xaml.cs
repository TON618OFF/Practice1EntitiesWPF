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

namespace practice_1_entities
{
    /// <summary>
    /// Логика взаимодействия для PageBookLoans.xaml
    /// </summary>
    public partial class PageBookLoans : Page
    {
        private BookSystemEntities context = new BookSystemEntities();
        public PageBookLoans()
        {
            InitializeComponent();
            dg_BD_bookloans.ItemsSource = context.BookLoans.ToList();
        }
    }
}
