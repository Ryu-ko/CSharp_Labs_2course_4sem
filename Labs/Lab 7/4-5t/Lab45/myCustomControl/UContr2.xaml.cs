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

namespace Lab45.myCustomControl
{
    /// <summary>
    /// Логика взаимодействия для UContr2.xaml
    /// </summary>
    public partial class UContr2 : UserControl
    {
        public UContr2()
        {
            InitializeComponent();
        }
        private void Back_Click( object sender, RoutedEventArgs e )
        {

           new MainWindow().Show();
        }
    }
}
