using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Linq;
using System.Windows.Input;
using Lab45.Models;
using Lab45.Services;
using Newtonsoft.Json;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Threading;

namespace Lab45
{
    public partial class MainWindow : Window
    {

        private static string PathForDate = $"{Environment.CurrentDirectory}\\alldata3.json";
        public FileIOService _fileOIService = new FileIOService(PathForDate);

        public BindingList<Book> BookList = new BindingList<Book>();

        Cursor Geom, Pix, Pony;



        Stack<string> undoAction = new Stack<string>();
        Stack<string> redoAction = new Stack<string>();
        public MainWindow()
        {
            InitializeComponent();
            string cursorDir = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\MyCursors";
            Geom = new Cursor($"{cursorDir}\\curs1.ani");
            Pix = new Cursor($"{cursorDir}\\curs2.cur");
            Pony = new Cursor($"{cursorDir}\\curs3.ani");

        }

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _fileOIService = new FileIOService(PathForDate);
            
            try
            {
                BookList = _fileOIService.LoadDate();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что-то не так с загрузкой данных из файла. Ошибка: {ex}");
                Close();
            }

            Books.ItemsSource = BookList;
            BookList.ListChanged += BookList_ListChanged1;


        }

        private void SearchBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (SearchBox.Text != string.Empty)
            {
                var SearchResult = BookList.Where(t => t.Title.ToLower().Contains(SearchBox.Text.ToLower()) || t.Autor.ToLower().Contains(SearchBox.Text.ToLower()) ).ToList() ;
               

                BindingList<Book> List = new BindingList<Book>(SearchResult);
                Books.ItemsSource = SearchResult;
             
            }
            else
            {
                Books.ItemsSource = BookList;
         
            }
        }

        private void Light_Selected(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("Resources/Light_mode.xaml", UriKind.Relative);                           // определяем путь к файлу ресурсов
            ResourceDictionary resourseDict = Application.LoadComponent(uri) as ResourceDictionary;     // загружаем словарь ресурсов
            Application.Current.Resources.Clear();                                                      // очищаем коллекцию ресурсов приложения
            Application.Current.Resources.MergedDictionaries.Add(resourseDict);                         // добавляем загруженный словарь ресурсов
        }

        private void Dark_Selected(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("Resources/DarkTheme.xaml", UriKind.Relative);
            ResourceDictionary resourseDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourseDict);
        }

        private void Green_Selected( object sender, RoutedEventArgs e )
        {
            var uri = new Uri("Resources/GreenTheme.xaml", UriKind.Relative);
            ResourceDictionary resourseDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourseDict);
        }


        private void BookList_ListChanged1(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.ItemChanged)
            {
                try
                {
                    _fileOIService.SaveData(sender);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Проблема с сохранением данных. Ошибка: {ex}");
                    Close();
                }
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void RusLocal_Selected(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("Resources/rusLang.xaml", UriKind.Relative);
            ResourceDictionary resourseDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourseDict);
        }

        private void EngLocal_Selected(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("Resources/engLang.xaml", UriKind.Relative);
            ResourceDictionary resourseDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourseDict);
        }

 


        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void btnCursor_Click( object sender, RoutedEventArgs e)
        {
            if (sender == btnGeometric)
            {
                this.Cursor = Geom;
            }
            else if (sender == btnPixel)
            {
                this.Cursor = Pix;
            }
            else if (sender == btnPony)
            {
                this.Cursor = Pony;
            }
        }

        public void AddItem_func(object sender, RoutedEventArgs e)
        {
            new AddItem(BookList).Show();
        }



        public void FilterWin_Open(object sender, RoutedEventArgs e)
        {
            new FilterItems(BookList, Books).Show();
        }
   


            private void Refresh_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                BookList = _fileOIService.LoadDate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что-то не так с загрузкой данных из файла. Ошибка: {ex}");
                Close();
            }
            Books.ItemsSource = BookList;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Image;
            if (button != null)
            {
                var deletedBook = button.DataContext as Book;

                BookList.Remove(deletedBook);
            }
            else
            {
                return;
            }

            try
            {
                _fileOIService.SaveData(BookList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Проблема с сохранением данных. Ошибка: {ex}");
                Close();
            }


        }
        // -------------------------------------------
        private void msUndo_Click( object sender, MouseButtonEventArgs e )
        {
            if (undoAction.Count < 1)
            {
                return;
            }

            if (redoAction.Count == 0 || SearchBox.Text != string.Empty)
            {
                redoAction.Push(SearchBox.Text);
            }

            SearchBox.Text = undoAction.Pop();
        }
        private void msRedo_Click( object sender, MouseButtonEventArgs e )
        {
            if (redoAction.Count < 1)
            {
                return;
            }


            if (undoAction.Count == 0 || SearchBox.Text != string.Empty)
            {
                undoAction.Push(SearchBox.Text);
            }

            SearchBox.Text = redoAction.Pop();
        }

        private void SearchBox_KeyDown( object sender, KeyEventArgs e )
        {
            undoAction.Push(SearchBox.Text);
        }

        // -------------------------------------------

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Image;
            if (button != null)
            {
                var editedBook = button.DataContext as Book;

                new EditItem(editedBook).Show();

                editedBook = EditItem.ShowEditedBook();

            }
            else
            {
                return;
            }

          
            try
            {
                _fileOIService.SaveData(BookList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Проблема с сохранением данных. Ошибка: {ex}");
                Close();
            }

            Books.ItemsSource = BookList;
        }

        private void Lab7_Page( object sender, RoutedEventArgs e )
        {
            new Lab7().Show();
        }

        private void ExitCommand_CanExecute( object sender, CanExecuteRoutedEventArgs e )
        {
            e.CanExecute = true;
        }

        private void ExitCommand_Executed( object sender, ExecutedRoutedEventArgs e )
        {
            Application.Current.Shutdown();
        }
    }
}
