using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IdentityModel.Metadata;
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
    /// Логика взаимодействия для Insert.xaml
    /// </summary>
    public partial class Insert : Window
    {

        private PUBLISHER publisher;
        private AUTHOR author;
        private Book book;
        public Insert()
        {
            InitializeComponent();
        }


        private void AsyncMethod()
        {
            System.Windows.Forms.MessageBox.Show("Data has been updated");
        }

        async private void insertButton_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            MessageBox.Show("Start");
            //if (int.TryParse(ageTextBox.Text, out i) && int.TryParse(nameTextBox.Text, out i) && int.TryParse(serialTextBox.Text, out i)
            //    && int.TryParse(NameTextBox.Text, out i) && int.TryParse(countryTextBox.Text, out i) )
            //{
            //    MessageBox.Show("IF 1");
            //    if (int.Parse(ageTextBox.Text) > 4  && int.Parse(ageTextBox.Text) < 100 && int.Parse(NameTextBox.Text) > 0)
            //    {

                    MessageBox.Show("IF 2");
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        using (var transaction = db.Database.BeginTransaction())
                        {
                            try
                            {
                                MessageBox.Show("try 1");
                                publisher = new PUBLISHER
                                {
                                    country = countryTextBox.Text,
                                    Name = NameTextBox.Text
                                };

                                MessageBox.Show("try 2");

                                author = new AUTHOR
                                {
                                    serial = serialTextBox.Text
                                };                                
                                db.AUTHOR.Add(author);
                                db.PUBLISHER.Add(publisher);
                                db.SaveChanges();
                                MessageBox.Show("try 3");
                                var id_publisher_db = (from publishData in db.PUBLISHER
                                                     where publishData.country == countryTextBox.Text &&
                                                     publishData.Name == NameTextBox.Text 
                                                     select publishData.id_publisher).FirstOrDefault<int>();

                                var id_author_db = (from authorData in db.AUTHOR
                                                      where authorData.serial == serialTextBox.Text
                                                      select authorData.id_author).FirstOrDefault<int>();
                                MessageBox.Show("try 4");
                                book = new Book
                                {
                                    name = nameTextBox.Text,
                                    age = int.Parse(ageTextBox.Text),
                                    id_publisher = id_publisher_db,
                                    id_author = id_author_db,
                                    PUBLISHER = publisher,
                                    AUTHOR = author
                                };
                                MessageBox.Show("try 5");
                                
                                db.Book.Add(book);
                                MessageBox.Show("try 5.1");
                                db.SaveChanges();
                                MessageBox.Show("try 5.2");
                                transaction.Commit();
                                MessageBox.Show("try 5.3");
                                AsyncMethod();
                                MessageBox.Show("try 6");
                                Show();
                                MessageBox.Show("try 7");
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                            }
                    //    }
                    //}

                }

            }
            
        }
    }
}
