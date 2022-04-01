using System.Windows;
using Lab6_7.ViewModel;

namespace Lab6_7
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ShopView();
        }
    }
}
