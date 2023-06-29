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

namespace Lab45
{
    /// <summary>
    /// Логика взаимодействия для Lab7.xaml
    /// </summary>
    public partial class Lab7 : Window
    {
        public Lab7()
        {
            InitializeComponent();
        }




        private void Button_Click( object sender, RoutedEventArgs e )
        {
            txt1.Text = "Сработало событие Button Click";
        }

        private void StackPanel_Click( object sender, RoutedEventArgs e )
        {
            txt2.Text = "Событие Click поднялось к Stack Panel";
        }

        private void Grid_Click( object sender, RoutedEventArgs e )
        {
            txt3.Text = "Событие Click поднялось к  Grid";
        }

        private void Control_MouseDown( object sender, MouseButtonEventArgs e )
        {
            textBlock1.Text = textBlock1.Text + "Событие отработало на элементне: " + sender.ToString() + "\n";
            textBlock1.Text = textBlock1.Text + "Элемент вызвавший событие: " + e.Source.ToString() + "\n\n";
        }

        private void CommandBinding_ExecutedUI( object sender, ExecutedRoutedEventArgs e )
        {
            Close();
        }
    }
}
