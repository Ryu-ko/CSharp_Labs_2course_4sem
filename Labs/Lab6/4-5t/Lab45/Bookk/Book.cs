using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Microsoft.Win32;


namespace Lab45.Models
{
    public class Book : INotifyPropertyChanged
    {
        private string title;
        private string autor;
        private int cost;
        private int pages;
        public ImageSource imgPath { get; set; }

        private string bindingtype;
        private string rating;

        public string Title
        {
            get { return title; }
            set
            {
                if (title == value)
                    return;
                title = value;
                OnPropertyChanged("Title");
            }
        }
        public string Autor
        {
            get { return autor; }
            set
            {
                if (autor == value)
                    return;
                autor = value;
                OnPropertyChanged("Autor");
            }
        }
        public int Cost
        {
            get { return cost; }
            set
            {
                if (cost == value)
                    return;
                cost = value;
                OnPropertyChanged("Cost");
            }
        }

        public int Pages
        {
            get { return pages; }
            set
            {
                if (pages == value)
                    return;
                pages = value;
                OnPropertyChanged("pages");
            }
        }


        public string Bindingtype
        {
            get { return bindingtype; }
            set
            {
                if (bindingtype == value)
                    return;
                bindingtype = value;
                OnPropertyChanged("Bindingtype");
            }
        }
        public string Rating
        {
            get { return rating; }
            set
            {
                if (rating == value)
                    return;
                rating = value;
                OnPropertyChanged("Rating");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}