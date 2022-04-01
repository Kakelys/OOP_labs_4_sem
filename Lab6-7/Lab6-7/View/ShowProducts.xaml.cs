﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Lab6_7.ViewModel;

namespace Lab6_7.View
{
    /// <summary>
    /// Логика взаимодействия для ShowProducts.xaml
    /// </summary>
    public partial class ShowProducts : Window
    {
        public ShowProducts()
        {
            InitializeComponent();
            DataContext = new ShowProductsView();
        }
    }
}
