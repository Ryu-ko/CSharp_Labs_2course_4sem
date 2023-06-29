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
    /// Логика взаимодействия для UControl1.xaml
    /// </summary>
    public partial class UControl1 : UserControl
    {

        public static readonly DependencyProperty TitleProperty;
        public static readonly DependencyProperty MaxLengthProperty;
        public static readonly DependencyProperty PriceProperty;

        public UControl1()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        static UControl1()
        {
            TitleProperty = DependencyProperty.Register("TitleInput", typeof(string), typeof(UControl1));
            MaxLengthProperty = DependencyProperty.Register("MaxLength", typeof(int), typeof(UControl1));

            var metadataLenght = new FrameworkPropertyMetadata();
            metadataLenght.CoerceValueCallback = new CoerceValueCallback(CorrectValue);


            PriceProperty = DependencyProperty.Register("Price", typeof(int), typeof(UControl1), metadataLenght, new ValidateValueCallback(ValidateValueLenght));
        }


        private static bool ValidateValueLenght( object value )
        {
            var currentValue = (int)value;
            if (currentValue >= 0)
            {// если текущее значение от нуля и выше
                return true;
            }
            else { 
                MessageBox.Show("Цена должна быть не меньш 0 и не больше 500");
                return false; 
            }
           
        }

        private static object CorrectValue( DependencyObject d, object baseValue )
        {
            var currentValue = (int)baseValue;
            if (currentValue > 500)
            {
                return 500;
            }
            else
            {
                return currentValue;
            }
        }

        public string TitleInput
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public int MaxLength
        {
            get { return (int)GetValue(MaxLengthProperty); }
            set { SetValue(MaxLengthProperty, value); }
        }
        public int Price
        {
            get { return (int)GetValue(PriceProperty); }
            set { SetValue(PriceProperty, value); }
        }

        private void Submit_Click( object sender, RoutedEventArgs e )
        {

            MessageBox.Show("Ваша заявка на коллекцию книг в ценовом диапазоне  " + Price.ToString() + " Byn отправлена.");
        }
    }
}
