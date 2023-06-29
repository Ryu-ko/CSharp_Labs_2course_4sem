using System;
using System.Windows;
using Lab45.Models;
using System.ComponentModel;
using Lab45.Services;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace Lab45
{
    /// <summary>
    /// Логика взаимодействия для AddItem.xaml
    /// </summary>
    public partial class AddItem : Window
    {
        BindingList<Book> newBookList = new BindingList<Book>();
        Book newBook = new Book();
        
        OpenFileDialog openFileDialog = new OpenFileDialog();
        private readonly string PathForDate = $"{Environment.CurrentDirectory}\\alldata3.json";
        public AddItem(BindingList<Book> BookList)
        {
            InitializeComponent();
            openFileDialog.Filter = "Фотографии|*.jpg;*.png;*.jpeg;*.svg;";

            newBookList = BookList;
        }


        private void OpenExplorer(object sender, RoutedEventArgs e)
        {
            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    ProductsPhoto.Source = new BitmapImage(new Uri(openFileDialog.FileName, UriKind.Absolute));
                }
                catch
                {
                    MessageBox.Show("Выберите файл формата", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                
            }
        }


        private void AddItem_Loaded(object sender, RoutedEventArgs e)
        {
        }
        private void Power_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (!int.TryParse(powerInput.Text, out i))
            {
                powerInput.Text = "";
                MessageBox.Show("Plaese enter a valid Cost");
            }
            else if (Convert.ToInt32(powerInput.Text) <= 2 || Convert.ToInt32(powerInput.Text) > 5000)
            {
                powerInput.Text = "";
                MessageBox.Show("Plaese enter Cost between 2 and 5 000");
            }
            ////////////////////////////////////////////
            if (!int.TryParse(pagesInput.Text, out i))
            {
                pagesInput.Text = "";
                MessageBox.Show("Plaese enter a valid Pages number");
            }
            else if (Convert.ToInt32(pagesInput.Text) <= 10 || Convert.ToInt32(pagesInput.Text) > 2000)
            {
                pagesInput.Text = "";
                MessageBox.Show("Plaese enter Pages number between 10 and 2000");
            }
            //////////////////////////////////////////
            try
            {

                if (ProductsPhoto.Source == null)
                {
                    MessageBox.Show("Please enter image for the book!");
                }
            }
            catch
            {
                MessageBox.Show("Enter valid image folder");
            }
            if (titleInput.Text == "")
            {
                titleInput.Text = "";
                MessageBox.Show("Plaese enter a valid Title");
            }
            if (autorInput.Text == "")
            {
                autorInput.Text = "";
                MessageBox.Show("Plaese enter a valid Autor");
            }
            if (titleInput.Text != "" && autorInput.Text != "" && powerInput.Text != "" && pagesInput.Text != "" && ProductsPhoto.Source != null)
            {
                
                newBook.Title = titleInput.Text;
                newBook.Autor = autorInput.Text;
                newBook.Cost = Convert.ToInt32(powerInput.Text);
                newBook.Pages = Convert.ToInt32(pagesInput.Text);
                newBook.imgPath = ProductsPhoto.Source;

                ComboBoxItem typeItem = (ComboBoxItem)comboboxInput.SelectedItem;
                string value = typeItem.Content.ToString();
                newBook.Bindingtype = value;

                if ((bool)radiobtn1.IsChecked)
                    newBook.Rating = "1";
                if ((bool)radiobtn2.IsChecked)
                    newBook.Rating = "2";
                if ((bool)radiobtn3.IsChecked)
                    newBook.Rating = "3";
                if ((bool)radiobtn4.IsChecked)
                    newBook.Rating = "4";
                if ((bool)radiobtn5.IsChecked)
                    newBook.Rating = "5";

                newBookList.Add(newBook);


                

            }
        }

    }
}
