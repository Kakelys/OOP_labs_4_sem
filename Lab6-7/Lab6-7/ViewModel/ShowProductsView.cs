using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DevExpress.Mvvm;
using Lab6_7.Model;

namespace Lab6_7.ViewModel
{
    internal class ShowProductsView:ViewModelBase
    {
        private ObservableCollection<ShowProductView> _products;

        public ObservableCollection<ShowProductView> Products
        {
            get => _products;
            set
            {
                _products = value;
                RaisePropertyChanged();
            }
        }


        public void Update()
        {
            var shop = new Shop();
            List<Product> products = shop.Products;
            Products = new ObservableCollection<ShowProductView>(products.Select(x => new ShowProductView(x,Update)));
        }


        public ShowProductsView()
        {
            var shop = new Shop();
            List<Product> products = shop.Products; 
            Products = new ObservableCollection<ShowProductView>(products.Select(x=> new ShowProductView(x,Update)));
        }
    }
}
