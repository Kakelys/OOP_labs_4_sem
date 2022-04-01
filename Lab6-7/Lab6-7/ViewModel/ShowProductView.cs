using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DevExpress.Mvvm;
using Lab6_7.Model;

namespace Lab6_7.ViewModel
{
    internal class ShowProductView:ViewModelBase
    {
        public Product Product;
        private Action _update;

        public ShowProductView(Product product,Action act)
        {
            Product = product;
            _update = act;
        }


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
            
        });
    }
}

















