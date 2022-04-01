using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using DevExpress.Mvvm;
using DevExpress.Mvvm.UI;
using Lab6_7.Model;
using Microsoft.Win32;

namespace Lab6_7.ViewModel
{
    internal class ProductView:ViewModelBase
    {
        private Visibility _isImageChoosed = Visibility.Hidden;

        public Visibility IsImageChoosed { get; set; } = Visibility.Hidden;

        public string Name { get; set; }

        public string Description { get; set; }

        public int Amount { get; set; }

        public int Price { get; set; }

        public string ImagePath { get; set; }

        public ICommand AddProduct
        {
            get => new DelegateCommand(() =>
            {
                if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Description) || Amount< 0 || Price <= 0)
                {
                    MessageBox.Show("Nope");
                }
                else
                {
                    Shop.Add(new Product(Name, Description, Amount, 0, Price, ImagePath));
                }
            });
        }

        public ICommand ChooseImage
        {
            get => new DelegateCommand(() =>
            {
                var temp = new OpenFileDialog();

                if (temp.ShowDialog() == true)
                {
                    
                    ImagePath = temp.FileName;
                    IsImageChoosed = Visibility.Visible;
                }
            });
        }
    }
}
