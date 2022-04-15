using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using DevExpress.Mvvm;
using Lab6_7.Model;
using Lab6_7.View;

namespace Lab6_7.ViewModel
{
    internal class ShowProductView:ViewModelBase
    {
        public Product Product;
        private Action _update;
        private Action<string> _find;

        public Window Window { get; set; }

        public ShowProductView(Product product,Action act)
        {
            Product = product;
            _update = act;
        }

        public ShowProductView(Product product, Action act,Action<string> find)
        {
            Product = product;
            _update = act;
            _find = find;
        }

        public int Id => Product.Id;

        public string Name
        {
            get => Product.Name;
            set
            {
                Product.Name = value;
                RaisePropertyChanged();
            }
        }

        public string Description
        {
            get => Product.Description;
            set
            {
                Product.Description = value;
                RaisePropertyChanged();
            }
        }

        public int Amount
        {
            get => Product.Amount;
            set
            {
                Product.Amount = value;
                RaisePropertyChanged();
            }
        }

        public int Price
        {
            get => Product.Price;
            set
            {
                Product.Price = value;
                RaisePropertyChanged();
            }
        }

        public string ImagePath
        {
            get => Product.ImagePath;
            set
            {
                Product.ImagePath = value;
                RaisePropertyChanged();
            }
        }

        public ICommand Remove
        {
            get => new DelegateCommand(() =>
            {
                Shop.Delete(Product);
                _update();
            });
        }

        public ICommand Edit => new DelegateCommand(() =>
        {
            var newWpf = new EditProduct(Product,_update);
            newWpf.Show();
        });

        public ICommand ConfirmEdit => new DelegateCommand(() =>
        {
            Shop.SaveEdit(Product,Id);
            _update();
        });
    }
}