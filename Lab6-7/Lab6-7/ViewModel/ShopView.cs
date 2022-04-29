using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
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
    internal class ShopView:ViewModelBase
    {
        public bool lightMode;

        public ICommand OpenAddingMenu
        {
            get => new DelegateCommand(() =>
            {
                var newWpf = new AddingProduct();
                newWpf.Show();
            });
        }

        public ICommand Show => new DelegateCommand(() =>
            {
                var newWpf = new ShowProducts();
                newWpf.Show();
            });

        public ICommand Undo => new DelegateCommand(UndoRedo.Undo);

        public ICommand Redo => new DelegateCommand(UndoRedo.Redo);

        public ICommand AddSectionConfirm => new DelegateCommand(() =>
        {
            lightMode = !lightMode;
            var theme = "";
            switch (lightMode)
            {
                case true: theme = "light";
                    break;
                case false: theme = "dark";
                    break;
            }
            var uri = new Uri($"Resources/{theme}.xaml", UriKind.Relative);
            // загружаем словарь ресурсов
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            // очищаем коллекцию ресурсов приложения
            Application.Current.Resources.Clear();
            // добавляем загруженный словарь ресурсов
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        });
    }
}
