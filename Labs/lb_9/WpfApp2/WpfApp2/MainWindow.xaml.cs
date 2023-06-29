using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IdentityModel.Metadata;
using System.Linq;
using System.Text;
using System.Windows;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Windows.Documents;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private OpenFileDialog openFileDialog;
        private Uri fileUri;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Show();
        }

        private void Show()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                        var currAllIdsQuery =
                        from book in db.Book
                        join publisher in db.PUBLISHER
                        on book.id_publisher equals publisher.id_publisher
                        join author in db.AUTHOR
                        on book.id_author equals author.id_author
                        select new
                        {
                            book.id_book,
                            book.id_author,
                            book.id_publisher
                        };
                    try
                    {
                        var query =
                        from book in db.Book
                        join publisher in db.PUBLISHER
                        on book.id_publisher equals publisher.id_publisher
                        join author in db.AUTHOR
                        on book.id_author equals author.id_author
                        select new
                        {
                            book.id_book,
                            book.name,
                            book.age,
                            book.id_author,
                            book.id_publisher,
                            publisher.country,
                            publisher.Name,
                            author.serial
                        };
                        table.ItemsSource = query.ToList();
                        var allIdsQueryContainer = currAllIdsQuery;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                    }
                }
            }
        }

        private byte[] B64Encode()
        {
            byte[] array = Encoding.ASCII.GetBytes(fileUri.ToString());
            return array;
        }

        private void insertButton_Click(object sender, RoutedEventArgs e)
        {
            Insert insert = new Insert();
            insert.ShowDialog();
            Show();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var book = db.Book.Where(p => p.id_book ==
                        (int)table.SelectedItem.GetType().GetProperty("id_book").GetValue(table.SelectedItem)).FirstOrDefault();
                        var publisher = db.PUBLISHER.Where(a => a.id_publisher ==
                        (int)table.SelectedItem.GetType().GetProperty("id_publisher").GetValue(table.SelectedItem)).FirstOrDefault();
                        var author = db.AUTHOR.Where(p => p.id_author ==
                        (int)table.SelectedItem.GetType().GetProperty("id_author").GetValue(table.SelectedItem)).FirstOrDefault();


                        db.Book.Remove(book);
                        db.PUBLISHER.Remove(publisher);
                        db.AUTHOR.Remove(author);

                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                    }
                }
            }
            Show();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            Update update = new Update(table.SelectedItem);
            update.ShowDialog();
            Show();
        }

        private void viewButton_Click(object sender, RoutedEventArgs e)
        {
            Show();
        }

        private void selectButton_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var listPerson = from p in db.Book
                                         join a in db.PUBLISHER on p.id_publisher equals a.id_publisher
                                         join ps in db.AUTHOR on p.id_author equals ps.id_author
                                         where p.age == int.Parse(ageTextBox.Text) &&
                                         a.country == countryTextBox.Text
                                         select new
                                         {
                                             p.id_book,
                                             p.name,
                                             p.age,
                                             p.id_author,
                                             p.id_publisher,
                                             a.country,
                                             a.Name,
                                             ps.serial
                                         };
                        table.ItemsSource = listPerson.ToList();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                    }
                }
            }
        }

        private void table_SelectionChanged( object sender, System.Windows.Controls.SelectionChangedEventArgs e )
        {

        }
    }
}
