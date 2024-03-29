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
    /// Логика взаимодействия для PageAuthors.xaml
    /// </summary>
    public partial class PageAuthors : Page
    {
        private BookSystemEntities context = new BookSystemEntities();
        public PageAuthors()
        {
            InitializeComponent();
            dg_BD_authors.ItemsSource = context.Authors.ToList();
        }

    }
}
