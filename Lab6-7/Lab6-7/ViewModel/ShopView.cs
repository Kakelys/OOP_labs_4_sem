using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DevExpress.Mvvm;
using Lab6_7.View;

namespace Lab6_7.ViewModel
{
    internal class ShopView
    {
        public ICommand OpenAddingMenu
        {
            get => new DelegateCommand(() =>
            {
                var newWpf = new AddingProduct();
                newWpf.Show();
            });
        }

        public ICommand Show
        {
            get => new DelegateCommand(() =>
            {
                var newWpf = new ShowProducts();
                newWpf.Show();
            });
        }
    }
}
