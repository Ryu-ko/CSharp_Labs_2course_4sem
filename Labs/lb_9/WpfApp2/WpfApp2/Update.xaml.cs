using Microsoft.Win32;
using Newtonsoft.Json.Linq;
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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Update.xaml
    /// </summary>
    public partial class Update : Window
    {
        private OpenFileDialog openFileDialog;
        private Uri fileUri;
        byte[] array;
        int[] idArray;
        public Update(object item)
        {
            InitializeComponent();
            try
            {
                if (item != null)
                {
                    nameTextBox.Text = item.GetType().GetProperty("name").GetValue(item).ToString();

                    ageTextBox.Text = item.GetType().GetProperty("age").GetValue(item).ToString();
                    countryTextBox.Text = item.GetType().GetProperty("country").GetValue(item).ToString();
                    NameTextBox.Text = item.GetType().GetProperty("city").GetValue(item).ToString();
                    streetTextBox.Text = item.GetType().GetProperty("street").GetValue(item).ToString();
                   
                    serialTextBox.Text = item.GetType().GetProperty("serial").GetValue(item).ToString();
                    idArray = new int[3] {(int)item.GetType().GetProperty("id_book").GetValue(item),
                    (int)item.GetType().GetProperty("id_publisher").GetValue(item),
                    (int)item.GetType().GetProperty("id_author").GetValue(item)};
                }
                
            }
            catch (Exception ex)
            {

            }
            
        }

        private byte[] B64Encode()
        {
            if (fileUri != null)
            {
                byte[] array = Encoding.ASCII.GetBytes(fileUri.ToString());
                return array;
            }
            else
            {
                return null;
            }
        }

        private void imgButton_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            if (int.TryParse(ageTextBox.Text, out i))
            {
                if (int.Parse(ageTextBox.Text) > 2)
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        using (var transaction = db.Database.BeginTransaction())
                        {
                            try
                            {
                                var book = db.Book.Where(p => p.id_book == idArray[0]).FirstOrDefault();
                                var publisher = db.PUBLISHER.Where(a => a.id_publisher == idArray[1]).FirstOrDefault();
                                var author = db.AUTHOR.Where(p => p.id_author == idArray[2]).FirstOrDefault();

                                book.name = nameTextBox.Text;
                                book.age = int.Parse(ageTextBox.Text);

                                publisher.country = countryTextBox.Text;
                                publisher.Name = NameTextBox.Text;

                                author.serial = serialTextBox.Text;
                                db.SaveChanges();
                                transaction.Commit();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("ERROR");
                                transaction.Rollback();
                            }
                        }
                    }
                }
            }
        }
    }
}
