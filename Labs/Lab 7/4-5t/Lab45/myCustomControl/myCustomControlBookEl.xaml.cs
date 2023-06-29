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
    /// Логика взаимодействия для myCustomControlBookEl.xaml
    /// </summary>
    public partial class myCustomControlBookEl : UserControl
    {
        int rotateAngle = 60;
        public myCustomControlBookEl()
        {
            InitializeComponent();
        }
        private void Book_Click( object sender, RoutedEventArgs e )
        {

            RotateTransform rotateTransform = new RotateTransform(rotateAngle);
            BookImg.RenderTransform = rotateTransform;
            rotateAngle += 60;
        }

    }
}
