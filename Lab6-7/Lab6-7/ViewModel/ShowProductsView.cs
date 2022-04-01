using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using Lab6_7.Model;

namespace Lab6_7.ViewModel
{
    internal class ShowProductsView:ViewModelBase
    {
        public ObservableCollection<ShowProductView> Products { get; set; }

        public ShowProductsView()
        {
            var shop = new Shop();
            List<Product> products = shop.Products; 
            Products = new ObservableCollection<ShowProductView>(products.Select(x=> new ShowProductView(x)));
        }
    }
}
